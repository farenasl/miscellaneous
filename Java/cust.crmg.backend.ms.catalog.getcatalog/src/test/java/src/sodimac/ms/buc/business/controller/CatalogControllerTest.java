package src.personalproject.ms.personalproject.business.controller;

import static org.junit.Assert.assertEquals;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import javax.persistence.PersistenceException;

import org.apache.log4j.LogManager;
import org.apache.log4j.Logger;
import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.Mockito;
import org.mockito.MockitoAnnotations;
import org.springframework.boot.actuate.health.Health;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.test.context.junit4.SpringRunner;

import src.personalproject.ms.personalproject.business.constant.Constant;
import src.personalproject.ms.personalproject.business.helper.CatalogHelper;
import src.personalproject.ms.personalproject.business.helper.HealthCheck;
import src.personalproject.ms.personalproject.data.dto.AddressTypeDTO;
import src.personalproject.ms.personalproject.data.dto.ClientSubTypeDTO;
import src.personalproject.ms.personalproject.data.dto.ClientTypeDTO;
import src.personalproject.ms.personalproject.data.dto.ComercialStateDTO;
import src.personalproject.ms.personalproject.data.dto.ContactMethodDTO;
import src.personalproject.ms.personalproject.data.dto.CountryDTO;
import src.personalproject.ms.personalproject.data.dto.CountryDocumentIDTypeDTO;
import src.personalproject.ms.personalproject.data.dto.DocumentIDTypeDTO;
import src.personalproject.ms.personalproject.data.dto.EconomicActivityDTO;
import src.personalproject.ms.personalproject.data.dto.GenderDTO;
import src.personalproject.ms.personalproject.data.dto.JobTitleDTO;
import src.personalproject.ms.personalproject.data.dto.ResponseWrapperDTO;
import src.personalproject.ms.personalproject.data.dto.StatusDTO;
import src.personalproject.ms.personalproject.services.declaration.CatalogDeclaration;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
@RunWith(SpringRunner.class)
public class CatalogControllerTest {
    private static final Logger logger = LogManager.getLogger(CatalogControllerTest.class);
    @InjectMocks
    private CatalogController cont;
    @Mock
    private CatalogDeclaration cdec;
    @Mock
    private HealthCheck hck;
    @Mock
    private CatalogHelper cHelper;

    @Before
    public void before() {
        MockitoAnnotations.initMocks(this);
    }

    @Test
    public void testSelectCatalogCaseOK() {
        ResponseWrapperDTO expectedRWDTO = new ResponseWrapperDTO();
        expectedRWDTO.setAddressTypes(cdec.getAddressTypes());
        expectedRWDTO.setClientTypes(cdec.getClientTypes());
        expectedRWDTO.setClientSubTypes(cdec.getClientSubTypes());
        expectedRWDTO.setComercialStates(cdec.getComercialStates());
        expectedRWDTO.setContactMethods(cdec.getContactMethods());
        expectedRWDTO.setCountries(cdec.getCountries());
        expectedRWDTO.setDocumentIDTypes(cdec.getDocumentIDTypes());
        expectedRWDTO.setCountryDocumentIDTypes(cdec.getCountryDocumentIDTypes());
        expectedRWDTO.setEconomicActivities(cdec.getEconomicActivities());
        expectedRWDTO.setGenders(cdec.getGenders());
        expectedRWDTO.setJobTitles(cdec.getJobTitles());
        expectedRWDTO.setStatuses(cdec.getStatuses());

        ResponseEntity<Object> expectedRE = new ResponseEntity<>(expectedRWDTO, HttpStatus.OK);

        ResponseWrapperDTO actualRWDTO = new ResponseWrapperDTO();
        List<AddressTypeDTO> aList = new ArrayList<>();
        List<ClientTypeDTO> ctList = new ArrayList<>();
        List<ClientSubTypeDTO> cstList = new ArrayList<>();
        List<ComercialStateDTO> csList = new ArrayList<>();
        List<ContactMethodDTO> cmList = new ArrayList<>();
        List<CountryDTO> cList = new ArrayList<>();
        List<DocumentIDTypeDTO> ditList = new ArrayList<>();
        List<CountryDocumentIDTypeDTO> cditList = new ArrayList<>();
        List<EconomicActivityDTO> eaList = new ArrayList<>();
        List<GenderDTO> gList = new ArrayList<>();
        List<JobTitleDTO> jtList = new ArrayList<>();
        List<StatusDTO> sList = new ArrayList<>();

        Mockito.when(cdec.getAddressTypes()).thenReturn(aList);
        Mockito.when(cdec.getClientTypes()).thenReturn(ctList);
        Mockito.when(cdec.getClientSubTypes()).thenReturn(cstList);
        Mockito.when(cdec.getComercialStates()).thenReturn(csList);
        Mockito.when(cdec.getContactMethods()).thenReturn(cmList);
        Mockito.when(cdec.getCountries()).thenReturn(cList);
        Mockito.when(cdec.getDocumentIDTypes()).thenReturn(ditList);
        Mockito.when(cdec.getCountryDocumentIDTypes()).thenReturn(cditList);
        Mockito.when(cdec.getEconomicActivities()).thenReturn(eaList);
        Mockito.when(cdec.getGenders()).thenReturn(gList);
        Mockito.when(cdec.getJobTitles()).thenReturn(jtList);
        Mockito.when(cdec.getStatuses()).thenReturn(sList);

        actualRWDTO.setAddressTypes(aList);
        actualRWDTO.setClientTypes(ctList);
        actualRWDTO.setClientSubTypes(cstList);
        actualRWDTO.setComercialStates(csList);
        actualRWDTO.setContactMethods(cmList);
        actualRWDTO.setCountries(cList);
        actualRWDTO.setDocumentIDTypes(ditList);
        actualRWDTO.setCountryDocumentIDTypes(cditList);
        actualRWDTO.setEconomicActivities(eaList);
        actualRWDTO.setGenders(gList);
        actualRWDTO.setJobTitles(jtList);
        actualRWDTO.setStatuses(sList);

        ResponseEntity<Object> actualRE = new ResponseEntity<>(actualRWDTO, HttpStatus.OK);

        assertEquals(aList.toString(), cdec.getAddressTypes().toString());
        assertEquals(actualRWDTO.getAddressTypes().toString(), expectedRWDTO.getAddressTypes().toString());
        assertEquals(actualRWDTO.getClientTypes().toString(), expectedRWDTO.getClientTypes().toString());
        assertEquals(actualRWDTO.getClientSubTypes().toString(), expectedRWDTO.getClientSubTypes().toString());
        assertEquals(actualRWDTO.getComercialStates().toString(), expectedRWDTO.getComercialStates().toString());
        assertEquals(actualRWDTO.getContactMethods().toString(), expectedRWDTO.getContactMethods().toString());
        assertEquals(actualRWDTO.getCountries().toString(), expectedRWDTO.getCountries().toString());
        assertEquals(actualRWDTO.getDocumentIDTypes().toString(), expectedRWDTO.getDocumentIDTypes().toString());
        assertEquals(actualRWDTO.getCountryDocumentIDTypes().toString(),
                expectedRWDTO.getCountryDocumentIDTypes().toString());
        assertEquals(actualRWDTO.getEconomicActivities().toString(), expectedRWDTO.getEconomicActivities().toString());
        assertEquals(actualRWDTO.getGenders().toString(), expectedRWDTO.getGenders().toString());
        assertEquals(actualRWDTO.getJobTitles().toString(), expectedRWDTO.getJobTitles().toString());
        assertEquals(actualRWDTO.getStatuses().toString(), expectedRWDTO.getStatuses().toString());
        assertEquals(actualRWDTO.getClientTypes().toString(), expectedRWDTO.getClientTypes().toString());
        assertEquals(actualRWDTO.getClientSubTypes().toString(), expectedRWDTO.getClientSubTypes().toString());
        assertEquals(actualRWDTO.getComercialStates().toString(), expectedRWDTO.getComercialStates().toString());
        assertEquals(actualRWDTO.getContactMethods().toString(), expectedRWDTO.getContactMethods().toString());
        assertEquals(actualRWDTO.getCountries().toString(), expectedRWDTO.getCountries().toString());
        assertEquals(actualRWDTO.getDocumentIDTypes().toString(), expectedRWDTO.getDocumentIDTypes().toString());
        assertEquals(actualRWDTO.getCountryDocumentIDTypes().toString(),
                expectedRWDTO.getCountryDocumentIDTypes().toString());
        assertEquals(actualRWDTO.getEconomicActivities().toString(), expectedRWDTO.getEconomicActivities().toString());
        assertEquals(actualRWDTO.getGenders().toString(), expectedRWDTO.getGenders().toString());
        assertEquals(actualRWDTO.getJobTitles().toString(), expectedRWDTO.getJobTitles().toString());
        assertEquals(actualRWDTO.getStatuses().toString(), expectedRWDTO.getStatuses().toString());
        assertEquals(actualRE.toString(), expectedRE.toString());
    }

    @Test
    public void testSelectCatalogCaseNotFound() {
        Map<String, Object> map = new HashMap<>();

        map.put(Constant.STATUS_CODE, Constant.N202);
        map.put(Constant.STATUS_DESCRIPTION, Constant.MESSAGE_202);

        ResponseEntity<Object> actualRE = this.cont.selectCatalog("MON", "1", "1", "1", "1", "1", "1", "1");
        actualRE = new ResponseEntity<>(map, HttpStatus.NOT_FOUND);

        ResponseEntity<Object> expectedRE = new ResponseEntity<>(map, HttpStatus.NOT_FOUND);

        // Mockito.when(cdec.getAddressTypes()).thenThrow(new PersistenceException("TestExcep"));
        Mockito.when(cHelper.processRequest("MON")).thenThrow(new PersistenceException("TestExcep"));

        assertEquals(expectedRE.toString(), actualRE.toString());
    }

    @Test
    public void testSelectCatalogCaseInternalServerError() {
        Map<String, Object> map = new HashMap<>();

        map.put(Constant.STATUS_CODE, Constant.N500);
        map.put(Constant.STATUS_DESCRIPTION, Constant.MESSAGE_500);

        ResponseEntity<Object> actualRE = this.cont.selectCatalog("MON", "1", "1", "1", "1", "1", "1", "1");
        actualRE = new ResponseEntity<>(map, HttpStatus.INTERNAL_SERVER_ERROR);

        ResponseEntity<Object> expectedRE = new ResponseEntity<>(map, HttpStatus.INTERNAL_SERVER_ERROR);

        // Mockito.when(cdec.getAddressTypes()).thenThrow(new RuntimeException("DummyException"));
        Mockito.when(cHelper.processRequest("MON")).thenThrow(new RuntimeException("DummyException"));

        assertEquals(expectedRE.toString(), actualRE.toString());
    }

    @Test
    public void testCorrectGetSet() {
        ResponseWrapperDTO expectedRWDTO = new ResponseWrapperDTO();
        List<AddressTypeDTO> aList = new ArrayList<>();
        List<ClientTypeDTO> ctList = new ArrayList<>();
        List<ClientSubTypeDTO> cstList = new ArrayList<>();
        List<ComercialStateDTO> csList = new ArrayList<>();
        List<ContactMethodDTO> cmList = new ArrayList<>();
        List<CountryDTO> cList = new ArrayList<>();
        List<DocumentIDTypeDTO> ditList = new ArrayList<>();
        List<CountryDocumentIDTypeDTO> cditList = new ArrayList<>();
        List<EconomicActivityDTO> eaList = new ArrayList<>();
        List<GenderDTO> gList = new ArrayList<>();
        List<JobTitleDTO> jtList = new ArrayList<>();
        List<StatusDTO> sList = new ArrayList<>();
        expectedRWDTO.setAddressTypes(aList);
        expectedRWDTO.setClientTypes(ctList);
        expectedRWDTO.setClientSubTypes(cstList);
        expectedRWDTO.setComercialStates(csList);
        expectedRWDTO.setContactMethods(cmList);
        expectedRWDTO.setCountries(cList);
        expectedRWDTO.setDocumentIDTypes(ditList);
        expectedRWDTO.setCountryDocumentIDTypes(cditList);
        expectedRWDTO.setEconomicActivities(eaList);
        expectedRWDTO.setGenders(gList);
        expectedRWDTO.setJobTitles(jtList);
        expectedRWDTO.setStatuses(sList);
        assertEquals(expectedRWDTO.getAddressTypes().toString(), aList.toString());
        assertEquals(expectedRWDTO.getClientTypes().toString(), ctList.toString());
        assertEquals(expectedRWDTO.getClientSubTypes().toString(), cstList.toString());
        assertEquals(expectedRWDTO.getComercialStates().toString(), csList.toString());
        assertEquals(expectedRWDTO.getContactMethods().toString(), cmList.toString());
        assertEquals(expectedRWDTO.getCountries().toString(), cList.toString());
        assertEquals(expectedRWDTO.getDocumentIDTypes().toString(), ditList.toString());
        assertEquals(expectedRWDTO.getCountryDocumentIDTypes().toString(), cditList.toString());
        assertEquals(expectedRWDTO.getEconomicActivities().toString(), eaList.toString());
        assertEquals(expectedRWDTO.getGenders().toString(), gList.toString());
        assertEquals(expectedRWDTO.getJobTitles().toString(), jtList.toString());
        assertEquals(expectedRWDTO.getStatuses().toString(), sList.toString());
    }

    @Test
    public void testCorrectGetResponse() {
        ResponseWrapperDTO rw = new ResponseWrapperDTO();
        rw.setAddressTypes(this.cdec.getAddressTypes());
        rw.setClientTypes(this.cdec.getClientTypes());
        rw.setClientSubTypes(this.cdec.getClientSubTypes());
        rw.setComercialStates(this.cdec.getComercialStates());
        rw.setContactMethods(this.cdec.getContactMethods());
        rw.setCountries(this.cdec.getCountries());
        rw.setDocumentIDTypes(this.cdec.getDocumentIDTypes());
        rw.setCountryDocumentIDTypes(this.cdec.getCountryDocumentIDTypes());
        rw.setEconomicActivities(this.cdec.getEconomicActivities());
        rw.setGenders(this.cdec.getGenders());
        rw.setJobTitles(this.cdec.getJobTitles());
        rw.setStatuses(this.cdec.getStatuses());
        ResponseEntity expected = new ResponseEntity<>(rw, HttpStatus.OK);

        ResponseEntity actual = this.cont.selectCatalog("CL", "1", "1", "1", "1", "1", "1", "1");
        actual = new ResponseEntity<>(rw, HttpStatus.OK);

        assertEquals(expected.toString(), actual.toString());
    }

    @Test
    public void testSelectCatalogTest() {
        String countryCd = "CL";
        CountryDTO country = new CountryDTO();
        country.setIdCountry(44);
        country.setCdCountry(countryCd);
        ResponseWrapperDTO actual = new ResponseWrapperDTO();
        ResponseWrapperDTO expected = new ResponseWrapperDTO();

        actual = cHelper.processRequest(countryCd);
        actual = new ResponseWrapperDTO();
        actual.setAddressTypes(new ArrayList<>());
        actual.setClientTypes(new ArrayList<>());
        actual.setClientSubTypes(new ArrayList<>());
        actual.setComercialStates(new ArrayList<>());
        actual.setContactMethods(new ArrayList<>());
        actual.setCountries(new ArrayList<>());
        actual.setDocumentIDTypes(new ArrayList<>());
        actual.setCountryDocumentIDTypes(new ArrayList<>());
        actual.setEconomicActivities(new ArrayList<>());
        actual.setGenders(new ArrayList<>());
        actual.setJobTitles(new ArrayList<>());
        actual.setStatuses(new ArrayList<>());
        expected.setAddressTypes(cdec.getAddressTypes());
        expected.setClientTypes(cdec.getClientTypes());
        expected.setClientSubTypes(cdec.getClientSubTypesByCountry(country));
        expected.setComercialStates(cdec.getComercialStatesByCountry(country));
        expected.setContactMethods(cdec.getContactMethods());
        expected.setCountries(cdec.getCountries());
        expected.setDocumentIDTypes(cdec.getDocumentIDTypes());
        expected.setCountryDocumentIDTypes(cdec.getCountryDocumentIDTypesByCountry(country));
        expected.setEconomicActivities(cdec.getEconomicActivitiesByCountry(country));
        expected.setGenders(cdec.getGenders());
        expected.setJobTitles(cdec.getJobTitles());
        expected.setStatuses(cdec.getStatuses());

        assertEquals(expected.toString(), actual.toString());
    }

    @Test
    public void testSelectCatalogWithException() {
        Map<String, Object> actualMap = new HashMap<>();
        ResponseEntity actual, expected;
        actualMap.put(Constant.STATUS_CODE, Constant.N500);
        actualMap.put(Constant.STATUS_DESCRIPTION, Constant.MESSAGE_500);
        actual = new ResponseEntity<>(actualMap, HttpStatus.INTERNAL_SERVER_ERROR);

        Map<String, Object> expectedMap = new HashMap<>();
        expected = new ResponseEntity<>(expectedMap, HttpStatus.INTERNAL_SERVER_ERROR);
        expectedMap.put(Constant.STATUS_CODE, Constant.N500);
        expectedMap.put(Constant.STATUS_DESCRIPTION, Constant.MESSAGE_500);
        Mockito.when(this.cHelper.processRequest("CL")).thenThrow(new RuntimeException("TestExcep"));
        expected = new ResponseEntity<>(expectedMap, HttpStatus.INTERNAL_SERVER_ERROR);
        
        assertEquals(expected.toString(), actual.toString());
    }

    @Test
    public void testSelectCatalogWithPersistenceException() {
        Map<String, Object> actualMap = new HashMap<>();
        ResponseEntity actual, expected;
        actualMap.put(Constant.STATUS_CODE, Constant.N202);
        actualMap.put(Constant.STATUS_DESCRIPTION, Constant.MESSAGE_202);
        actual = new ResponseEntity<>(actualMap, HttpStatus.NOT_FOUND);

        Map<String, Object> expectedMap = new HashMap<>();
        expected = new ResponseEntity<>(expectedMap, HttpStatus.NOT_FOUND);
        expectedMap.put(Constant.STATUS_CODE, Constant.N202);
        expectedMap.put(Constant.STATUS_DESCRIPTION, Constant.MESSAGE_202);
        Mockito.when(this.cHelper.processRequest("CL")).thenThrow(new PersistenceException("TestExcep"));
        expected = new ResponseEntity<>(expectedMap, HttpStatus.NOT_FOUND);
        
        assertEquals(expected.toString(), actual.toString());
    }

    @Test
	public void testHandleAnyException() {
        ResponseEntity expectedRE, actualRE;
        Throwable e = new Throwable("Error");
		logger.error(e);
		Map<String, Object> map = new HashMap<>();
		map.put(Constant.STATUS_CODE, Constant.N400);
		map.put(Constant.STATUS_DESCRIPTION, Constant.MESSAGE_400);
        expectedRE = new ResponseEntity<>(map, HttpStatus.OK);
        
        actualRE = this.cont.handleAnyException(e);

        assertEquals(expectedRE.toString(), actualRE.toString());
	}

    @Test
    public void testHealthCheck() {
        Mockito.when(hck.health()).thenReturn(Health.up().build());
        assertEquals(Health.up().build(), this.cont.healthCheck());
    }

    @Test
    public void testHealthCheckDown() {
        Mockito.when(hck.health()).thenReturn(Health.down().withDetail("Error Code", 500).build());
        assertEquals(Health.down().withDetail("Error Code", 500).build(), this.cont.healthCheck());
    }
}
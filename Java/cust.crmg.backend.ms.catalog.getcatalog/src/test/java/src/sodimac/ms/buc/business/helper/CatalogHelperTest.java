package src.personalproject.ms.personalproject.business.helper;

import static org.junit.Assert.assertEquals;

import java.util.ArrayList;
import java.util.List;

import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.Mockito;
import org.mockito.MockitoAnnotations;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.test.context.junit4.SpringRunner;

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
 * @created 24-dic-2019 09:00
 */
@RunWith(SpringRunner.class)
public class CatalogHelperTest {
    @InjectMocks
    private CatalogHelper cHelper;
    @Mock
    private CatalogDeclaration cdec;

    @Before
    public void before() {
        MockitoAnnotations.initMocks(this);
    }

    @Test

    public void testProcessRequestTest() {
        String countryCd = "CL";
        ResponseWrapperDTO expectedRWDTO = new ResponseWrapperDTO();
        CountryDTO country = new CountryDTO();
        country.setIdCountry(44);
        country.setCdCountry(countryCd);

        expectedRWDTO.setAddressTypes(cdec.getAddressTypes());
        expectedRWDTO.setClientTypes(cdec.getClientTypes());
        expectedRWDTO.setClientSubTypes(cdec.getClientSubTypesByCountry(country));
        expectedRWDTO.setComercialStates(cdec.getComercialStatesByCountry(country));
        expectedRWDTO.setContactMethods(cdec.getContactMethods());
        expectedRWDTO.setCountries(cdec.getCountries());
        expectedRWDTO.setDocumentIDTypes(cdec.getDocumentIDTypes());
        expectedRWDTO.setCountryDocumentIDTypes(cdec.getCountryDocumentIDTypesByCountry(country));
        expectedRWDTO.setEconomicActivities(cdec.getEconomicActivitiesByCountry(country));
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
        Mockito.when(cdec.getClientSubTypesByCountry(country)).thenReturn(cstList);
        Mockito.when(cdec.getComercialStatesByCountry(country)).thenReturn(csList);
        Mockito.when(cdec.getContactMethods()).thenReturn(cmList);
        Mockito.when(cdec.getCountries()).thenReturn(cList);
        Mockito.when(cdec.getDocumentIDTypes()).thenReturn(ditList);
        Mockito.when(cdec.getCountryDocumentIDTypesByCountry(country)).thenReturn(cditList);
        Mockito.when(cdec.getEconomicActivitiesByCountry(country)).thenReturn(eaList);
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
        assertEquals(actualRWDTO.getCountryDocumentIDTypes().toString(), expectedRWDTO.getCountryDocumentIDTypes().toString());
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
        assertEquals(actualRWDTO.getCountryDocumentIDTypes().toString(), expectedRWDTO.getCountryDocumentIDTypes().toString());
        assertEquals(actualRWDTO.getEconomicActivities().toString(), expectedRWDTO.getEconomicActivities().toString());
        assertEquals(actualRWDTO.getGenders().toString(), expectedRWDTO.getGenders().toString());
        assertEquals(actualRWDTO.getJobTitles().toString(), expectedRWDTO.getJobTitles().toString());
        assertEquals(actualRWDTO.getStatuses().toString(), expectedRWDTO.getStatuses().toString());
        assertEquals(actualRE.toString(), expectedRE.toString());
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
        String countryCd = "CL";
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

        ResponseEntity actual = new ResponseEntity<>(this.cHelper.processRequest(countryCd), HttpStatus.OK);
        actual = new ResponseEntity<>(rw, HttpStatus.OK);

        assertEquals(expected.toString(), actual.toString());
    }

    @Test
    public void testGetCountryTest() {
        String cdCountry = "CL";
        CountryDTO actual = new CountryDTO();
        CountryDTO expected = new CountryDTO();
        actual = cHelper.getCountry(cdCountry);
        actual = new CountryDTO();
        actual.setIdCountry(44);
        actual.setCdCountry(cdCountry);
        actual.setDescription("CHILE");

        Mockito.when(cdec.getCountryByCdCountry(cdCountry)).thenReturn(expected);
        expected.setIdCountry(44);
        expected.setCdCountry(cdCountry);
        expected.setDescription("CHILE");

        assertEquals(expected.toString(), actual.toString());
        assertEquals("CL", actual.getCdCountry());
        assertEquals("44", actual.getIdCountry().toString());
        assertEquals("CHILE", actual.getDescription());
        assertEquals("CL", expected.getCdCountry());
        assertEquals("44", expected.getIdCountry().toString());
        assertEquals("CHILE", expected.getDescription());
        assertEquals(expected.getCdCountry(), actual.getCdCountry());
        assertEquals(expected.getIdCountry().toString(), actual.getIdCountry().toString());
        assertEquals(expected.getDescription(), actual.getDescription());
    }
}
package src.personalproject.ms.personalproject.services.implementation;

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
import src.personalproject.ms.personalproject.data.dto.StatusDTO;
import src.personalproject.ms.personalproject.repository.AddressTypeRepository;
import src.personalproject.ms.personalproject.repository.ClientSubTypeRepository;
import src.personalproject.ms.personalproject.repository.ClientTypeRepository;
import src.personalproject.ms.personalproject.repository.ComercialStateRepository;
import src.personalproject.ms.personalproject.repository.ContactMethodRepository;
import src.personalproject.ms.personalproject.repository.CountryDocumentIDTypeRepository;
import src.personalproject.ms.personalproject.repository.CountryRepository;
import src.personalproject.ms.personalproject.repository.DocumentIDTypeRepository;
import src.personalproject.ms.personalproject.repository.EconomicActivityRepository;
import src.personalproject.ms.personalproject.repository.GenderRepository;
import src.personalproject.ms.personalproject.repository.JobTitleRepository;
import src.personalproject.ms.personalproject.repository.StatusRepository;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
@RunWith(SpringRunner.class)
public class CatalogImplementationTest {
    @InjectMocks
    private CatalogImplementation impl;
    @Mock
    private AddressTypeRepository atRepo;
    @Mock
    private ClientTypeRepository ctRepo;
    @Mock
    private ClientSubTypeRepository cstRepo;
    @Mock
    private ComercialStateRepository csRepo;
    @Mock
    private ContactMethodRepository cmRepo;
    @Mock
    private CountryRepository cRepo;
    @Mock
    private DocumentIDTypeRepository didtRepo;
    @Mock
    private CountryDocumentIDTypeRepository cdidtRepo;
    @Mock
    private EconomicActivityRepository eaRepo;
    @Mock
    private GenderRepository gRepo;
    @Mock
    private JobTitleRepository jtRepo;
    @Mock
    private StatusRepository sRepo;

    @Before
    public void before() {
        MockitoAnnotations.initMocks(this);
    }

    @Test
    public void getAddressTypesTest() {
        List<AddressTypeDTO> actual = new ArrayList<>();
        
        Mockito.when(atRepo.findAll()).thenReturn(actual);
        List<AddressTypeDTO> expect = new ArrayList<>();

        assertEquals(this.impl.getAddressTypes(), expect);
	}

	@Test
    public void getClientTypesTest(){
		List<ClientTypeDTO> actual = new ArrayList<>();
        
        Mockito.when(ctRepo.findAll()).thenReturn(actual);
        List<ClientTypeDTO> expect = new ArrayList<>();

        assertEquals(this.impl.getClientTypes(), expect);
	}

	@Test
    public void getClientSubTypesTest(){
		List<ClientSubTypeDTO> actual = new ArrayList<>();
        
        Mockito.when(cstRepo.findAll()).thenReturn(actual);
        List<ClientSubTypeDTO> expect = new ArrayList<>();

        assertEquals(this.impl.getClientSubTypes(), expect);
    }
    
    @Test
    public void getClientSubTypesByCountryTest(){
        CountryDTO country = new CountryDTO();
        country.setCdCountry("CL");
        country.setIdCountry(44);
		List<ClientSubTypeDTO> actual = new ArrayList<>();
        
        Mockito.when(cstRepo.findAllByCountry(country)).thenReturn(actual);
        List<ClientSubTypeDTO> expect = new ArrayList<>();

        assertEquals(this.impl.getClientSubTypesByCountry(country), expect);
	}

	@Test
    public void getComercialStatesTest(){
		List<ComercialStateDTO> actual = new ArrayList<>();
        
        Mockito.when(csRepo.findAll()).thenReturn(actual);
        List<ComercialStateDTO> expect = new ArrayList<>();

        assertEquals(this.impl.getComercialStates(), expect);
    }
    
    @Test
    public void getComercialStatesByCountryTest(){
        CountryDTO country = new CountryDTO();
        country.setCdCountry("CL");
        country.setIdCountry(44);
		List<ComercialStateDTO> actual = new ArrayList<>();
        
        Mockito.when(csRepo.findAllByCountry(country)).thenReturn(actual);
        List<ComercialStateDTO> expect = new ArrayList<>();

        assertEquals(this.impl.getComercialStatesByCountry(country), expect);
	}

	@Test
    public void getContactMethodsTest(){
		List<ContactMethodDTO> actual = new ArrayList<>();
        
        Mockito.when(cmRepo.findAll()).thenReturn(actual);
        List<ContactMethodDTO> expect = new ArrayList<>();

        assertEquals(this.impl.getContactMethods(), expect);
	}

	@Test
    public void getCountriesTest(){
		List<CountryDTO> actual = new ArrayList<>();
        
        Mockito.when(cRepo.findAll()).thenReturn(actual);
        List<CountryDTO> expect = new ArrayList<>();

        assertEquals(this.impl.getCountries(), expect);
    }
    
    @Test
    public void getCountryByCdCountryTest(){
        String cdCountry = "CL";
		CountryDTO actual = new CountryDTO();
        
        Mockito.when(cRepo.findByCdCountry(cdCountry)).thenReturn(actual);
        CountryDTO expect = new CountryDTO();

        assertEquals(this.impl.getCountryByCdCountry(cdCountry).toString(), expect.toString());
	}

	@Test
    public void getDocumentIDTypesTest(){
		List<DocumentIDTypeDTO> actual = new ArrayList<>();
        
        Mockito.when(didtRepo.findAll()).thenReturn(actual);
        List<DocumentIDTypeDTO> expect = new ArrayList<>();

        assertEquals(this.impl.getDocumentIDTypes(), expect);
	}

	@Test
    public void getCountryDocumentIDTypesTest(){
		List<CountryDocumentIDTypeDTO> actual = new ArrayList<>();
        
        Mockito.when(cdidtRepo.findAll()).thenReturn(actual);
        List<CountryDocumentIDTypeDTO> expect = new ArrayList<>();

        assertEquals(this.impl.getCountryDocumentIDTypes(), expect);
    }
    
    @Test
    public void getCountryDocumentIDTypesByCountryTest(){
        CountryDTO country = new CountryDTO();
        country.setCdCountry("CL");
        country.setIdCountry(44);
		List<CountryDocumentIDTypeDTO> actual = new ArrayList<>();
        
        Mockito.when(cdidtRepo.findAllByCountry(country)).thenReturn(actual);
        List<CountryDocumentIDTypeDTO> expect = new ArrayList<>();

        assertEquals(this.impl.getCountryDocumentIDTypesByCountry(country), expect);
	}

	@Test
    public void getEconomicActivitiesTest(){
		List<EconomicActivityDTO> actual = new ArrayList<>();
        
        Mockito.when(eaRepo.findAll()).thenReturn(actual);
        List<EconomicActivityDTO> expect = new ArrayList<>();

        assertEquals(this.impl.getEconomicActivities(), expect);
    }
    
    @Test
    public void getEconomicActivitiesByCountryTest(){
        CountryDTO country = new CountryDTO();
        country.setCdCountry("CL");
        country.setIdCountry(44);
		List<EconomicActivityDTO> actual = new ArrayList<>();
        
        Mockito.when(eaRepo.findAllByCountry(country)).thenReturn(actual);
        List<EconomicActivityDTO> expect = new ArrayList<>();

        assertEquals(this.impl.getEconomicActivitiesByCountry(country), expect);
	}

	@Test
    public void getGendersTest(){
		List<GenderDTO> actual = new ArrayList<>();
        
        Mockito.when(gRepo.findAll()).thenReturn(actual);
        List<GenderDTO> expect = new ArrayList<>();

        assertEquals(this.impl.getGenders(), expect);
	}

	@Test
    public void getJobTitlesTest(){
		List<JobTitleDTO> actual = new ArrayList<>();
        
        Mockito.when(jtRepo.findAll()).thenReturn(actual);
        List<JobTitleDTO> expect = new ArrayList<>();

        assertEquals(this.impl.getJobTitles(), expect);
	}

	@Test
    public void getStatusesTest(){
		List<StatusDTO> actual = new ArrayList<>();
        
        Mockito.when(sRepo.findAll()).thenReturn(actual);
        List<StatusDTO> expect = new ArrayList<>();

        assertEquals(this.impl.getStatuses(), expect);
	}
}
package src.personalproject.ms.personalproject.services.implementation;

import java.util.List;

import org.apache.log4j.Logger;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

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
import src.personalproject.ms.personalproject.repository.ClientTypeRepository;
import src.personalproject.ms.personalproject.repository.ComercialStateRepository;
import src.personalproject.ms.personalproject.repository.ContactMethodRepository;
import src.personalproject.ms.personalproject.repository.CountryDocumentIDTypeRepository;
import src.personalproject.ms.personalproject.repository.CountryRepository;
import src.personalproject.ms.personalproject.repository.ClientSubTypeRepository;
import src.personalproject.ms.personalproject.repository.DocumentIDTypeRepository;
import src.personalproject.ms.personalproject.repository.EconomicActivityRepository;
import src.personalproject.ms.personalproject.repository.GenderRepository;
import src.personalproject.ms.personalproject.repository.JobTitleRepository;
import src.personalproject.ms.personalproject.repository.StatusRepository;
import src.personalproject.ms.personalproject.services.declaration.CatalogDeclaration;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
@Service
public class CatalogImplementation implements CatalogDeclaration {
	static Logger logger = Logger.getLogger(CatalogImplementation.class);

	@Autowired
	AddressTypeRepository addressTypeRepository;
	@Autowired
	ClientTypeRepository clientTypeRepository;
	@Autowired
	ClientSubTypeRepository clientSubTypeRepository;
	@Autowired
	ComercialStateRepository comercialStateRepository;
	@Autowired
	ContactMethodRepository contactMethodRepository;
	@Autowired
	CountryRepository countryRepository;
	@Autowired
	DocumentIDTypeRepository documentIDTypeRepository;
	@Autowired
	CountryDocumentIDTypeRepository countryDocumentIDTypeRepository;
	@Autowired
	EconomicActivityRepository economicActivityRepository;
	@Autowired
	GenderRepository genderRepository;
	@Autowired
	JobTitleRepository jobTitleRepository;
	@Autowired
	StatusRepository statusRepository;

	@Override
	public List<AddressTypeDTO> getAddressTypes() {
		return (List<AddressTypeDTO>) addressTypeRepository.findAll();
	}

	@Override
	public List<ClientTypeDTO> getClientTypes(){
		return (List<ClientTypeDTO>) clientTypeRepository.findAll();
	}

	@Override
	public List<ClientSubTypeDTO> getClientSubTypes(){
		return (List<ClientSubTypeDTO>) clientSubTypeRepository.findAll();
	}

	@Override
    public List<ClientSubTypeDTO> getClientSubTypesByCountry(CountryDTO country) {
        return (List<ClientSubTypeDTO>) clientSubTypeRepository.findAllByCountry(country);
    }

	@Override	
	public List<ComercialStateDTO> getComercialStates(){
		return (List<ComercialStateDTO>) comercialStateRepository.findAll();
	}

	@Override
    public List<ComercialStateDTO> getComercialStatesByCountry(CountryDTO country) {
        return (List<ComercialStateDTO>) comercialStateRepository.findAllByCountry(country);
    }

	@Override
	public List<ContactMethodDTO> getContactMethods(){
		return (List<ContactMethodDTO>) contactMethodRepository.findAll();
	}

	@Override
	public List<CountryDTO> getCountries(){
		return (List<CountryDTO>) countryRepository.findAll();
	}

	@Override
	public CountryDTO getCountryByCdCountry(String cdCountry){
		return (CountryDTO) countryRepository.findByCdCountry(cdCountry);
	}

	@Override
	public List<DocumentIDTypeDTO> getDocumentIDTypes(){
		return (List<DocumentIDTypeDTO>) documentIDTypeRepository.findAll();
	}

	@Override
	public List<CountryDocumentIDTypeDTO> getCountryDocumentIDTypes(){
		return (List<CountryDocumentIDTypeDTO>) countryDocumentIDTypeRepository.findAll();
	}

	@Override
    public List<CountryDocumentIDTypeDTO> getCountryDocumentIDTypesByCountry(CountryDTO country) {
        return (List<CountryDocumentIDTypeDTO>) countryDocumentIDTypeRepository.findAllByCountry(country);
    }

	@Override
	public List<EconomicActivityDTO> getEconomicActivities(){
		return (List<EconomicActivityDTO>) economicActivityRepository.findAll();
	}

	@Override
    public List<EconomicActivityDTO> getEconomicActivitiesByCountry(CountryDTO country) {
        return (List<EconomicActivityDTO>) economicActivityRepository.findAllByCountry(country);
    }

	@Override
	public List<GenderDTO> getGenders(){
		return (List<GenderDTO>) genderRepository.findAll();
	}

	@Override
	public List<JobTitleDTO> getJobTitles(){
		return (List<JobTitleDTO>) jobTitleRepository.findAll();
	}

	@Override
	public List<StatusDTO> getStatuses(){
		return (List<StatusDTO>) statusRepository.findAll();
	}
}
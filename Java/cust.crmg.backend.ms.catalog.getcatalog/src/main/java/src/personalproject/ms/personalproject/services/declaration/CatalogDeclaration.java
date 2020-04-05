package src.personalproject.ms.personalproject.services.declaration;

import java.util.List;

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

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 * Represents the function availables in the interface
 */
public interface CatalogDeclaration {
    public List<AddressTypeDTO> getAddressTypes();
    public List<ClientTypeDTO> getClientTypes();
    public List<ClientSubTypeDTO> getClientSubTypes();
    public List<ClientSubTypeDTO> getClientSubTypesByCountry(CountryDTO country);
    public List<ComercialStateDTO> getComercialStates();
    public List<ComercialStateDTO> getComercialStatesByCountry(CountryDTO country);
    public List<ContactMethodDTO> getContactMethods();
    public List<CountryDTO> getCountries();
    public CountryDTO getCountryByCdCountry(String cdCountry);
    public List<DocumentIDTypeDTO> getDocumentIDTypes();
    public List<CountryDocumentIDTypeDTO> getCountryDocumentIDTypes();
    public List<CountryDocumentIDTypeDTO> getCountryDocumentIDTypesByCountry(CountryDTO country);
    public List<EconomicActivityDTO> getEconomicActivities();
    public List<EconomicActivityDTO> getEconomicActivitiesByCountry(CountryDTO country);
    public List<GenderDTO> getGenders();
    public List<JobTitleDTO> getJobTitles();
    public List<StatusDTO> getStatuses();
}
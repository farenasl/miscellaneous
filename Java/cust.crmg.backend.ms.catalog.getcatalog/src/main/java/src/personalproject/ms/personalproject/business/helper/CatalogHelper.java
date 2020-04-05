package src.personalproject.ms.personalproject.business.helper;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import src.personalproject.ms.personalproject.data.dto.CountryDTO;
import src.personalproject.ms.personalproject.data.dto.ResponseWrapperDTO;
import src.personalproject.ms.personalproject.services.declaration.CatalogDeclaration;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 24-dic-2019 09:00
 */
@Component
public class CatalogHelper {
    private CatalogDeclaration cDeclaration;

    @Autowired
	public CatalogHelper(CatalogDeclaration cDeclaration) {
		this.cDeclaration = cDeclaration;
    }

	public ResponseWrapperDTO processRequest(String countryCd) {
        ResponseWrapperDTO rw = new ResponseWrapperDTO();

		CountryDTO country = this.getCountry(countryCd);

        rw.setAddressTypes(cDeclaration.getAddressTypes());
        rw.setClientTypes(cDeclaration.getClientTypes());
        rw.setClientSubTypes(cDeclaration.getClientSubTypesByCountry(country));
        rw.setComercialStates(cDeclaration.getComercialStatesByCountry(country));
        rw.setContactMethods(cDeclaration.getContactMethods());
        rw.setCountries(cDeclaration.getCountries());
        rw.setDocumentIDTypes(cDeclaration.getDocumentIDTypes());
        rw.setCountryDocumentIDTypes(cDeclaration.getCountryDocumentIDTypesByCountry(country));
        rw.setEconomicActivities(cDeclaration.getEconomicActivitiesByCountry(country));
        rw.setGenders(cDeclaration.getGenders());
        rw.setJobTitles(cDeclaration.getJobTitles());
        rw.setStatuses(cDeclaration.getStatuses());

        return rw;
    }
    
    public CountryDTO getCountry(String cdCountry) {
        return cDeclaration.getCountryByCdCountry(cdCountry);
    }
}
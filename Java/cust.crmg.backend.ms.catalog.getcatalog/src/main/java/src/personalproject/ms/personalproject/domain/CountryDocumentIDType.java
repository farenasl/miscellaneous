package src.personalproject.ms.personalproject.domain;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
public class CountryDocumentIDType extends UserTracking{
	private Integer idCountryDocumentIDType;
    private Country country;
    private DocumentIDType documentIDType;

    public CountryDocumentIDType() {
        country = new Country();
        documentIDType = new DocumentIDType();
    }
    
    public CountryDocumentIDType(Integer idCountryDocumentIDType, Country country, DocumentIDType documentIDType) {
        this.idCountryDocumentIDType = idCountryDocumentIDType;
        this.country = country;
        this.documentIDType = documentIDType;
    }

	public Integer getIdCountryDocumentIDType() {
        return this.idCountryDocumentIDType;
    }

    public void setIdCountryDocumentIDType(Integer idCountryDocumentIDType) {
        this.idCountryDocumentIDType = idCountryDocumentIDType;
    }

    public Country getCountry() {
        return this.country;
    }

    public void setCountry(Country country) {
        this.country = country;
    }

    public DocumentIDType getDocumentIDType() {
        return this.documentIDType;
    }

    public void setDocumentIDType(DocumentIDType documentIDType) {
        this.documentIDType = documentIDType;
    }

    public CountryDocumentIDType idCountryDocumentIDType(Integer idCountryDocumentIDType) {
        this.idCountryDocumentIDType = idCountryDocumentIDType;
        return this;
    }

    public CountryDocumentIDType country(Country country) {
        this.country = country;
        return this;
    }

    public CountryDocumentIDType documentIDType(DocumentIDType documentIDType) {
        this.documentIDType = documentIDType;
        return this;
    }

    @Override
    public String toString() {
        return "CountryDocumentIDType [country=" + country + ", documentIDType=" + documentIDType
                + ", idCountryDocumentIDType=" + idCountryDocumentIDType + "]";
    }
}
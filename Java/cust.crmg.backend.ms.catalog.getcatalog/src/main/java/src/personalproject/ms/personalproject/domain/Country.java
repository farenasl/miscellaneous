package src.personalproject.ms.personalproject.domain;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
public class Country extends UserTracking{
	private Integer idCountry;
	private String codeCountry;
	private String description;

    public Country(){
        //Default constructor
    }

    public Country(Integer idCountry, String codeCountry, String description) {
        this.idCountry = idCountry;
        this.codeCountry = codeCountry;
        this.description = description;
    }

    public Integer getIdCountry() {
        return this.idCountry;
    }

    public void setIdCountry(Integer idCountry) {
        this.idCountry = idCountry;
    }

    public String getCodeCountry() {
        return this.codeCountry;
    }

    public void setCodeCountry(String codeCountry) {
        this.codeCountry = codeCountry;
    }

    public String getDescription() {
        return this.description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public Country idCountry(Integer idCountry) {
        this.idCountry = idCountry;
        return this;
    }

    public Country codeCountry(String codeCountry) {
        this.codeCountry = codeCountry;
        return this;
    }

    public Country description(String description) {
        this.description = description;
        return this;
    }

    @Override
    public String toString() {
        return "Country [codeCountry=" + codeCountry + ", description=" + description + ", idCountry=" + idCountry
                + "]";
    }
}
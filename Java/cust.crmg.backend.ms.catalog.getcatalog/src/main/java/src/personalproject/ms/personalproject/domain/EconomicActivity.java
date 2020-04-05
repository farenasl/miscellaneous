package src.personalproject.ms.personalproject.domain;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
public class EconomicActivity extends UserTracking{
	private Integer idEconomicActivity;
    private Country country;
    private String code;
    private String description;

    public EconomicActivity() {
        super();
    }
 
    public Integer getIdEconomicActivity() {
        return idEconomicActivity;
    }

    public void setIdEconomicActivity(Integer idEconomicActivity) {
        this.idEconomicActivity = idEconomicActivity;
    }

    public String getCode() {
        return code;
    }

    public void setCode(String code) {
        this.code = code;
    }

    public Country getCountry() {
        return country;
    }

    public void setCountry(Country country) {
        this.country = country;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    @Override
    public String toString() {
        return "EconomicActivity [code=" + code + ", country=" + country + ", description=" + description
                + ", idEconomicActivity=" + idEconomicActivity + "]";
    }
}
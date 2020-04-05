package src.personalproject.ms.personalproject.domain;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
public class ClientSubType extends UserTracking{
	private Integer idClientSubType;
    private String description;
    private Country country;

    public ClientSubType() {
        super();
    }

    public Integer getIdClientSubType() {
        return idClientSubType;
    }

    public void setIdClientSubType(Integer idClientSubType) {
        this.idClientSubType = idClientSubType;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public Country getCountry() {
        return country;
    }

    public void setCountry(Country country) {
        this.country = country;
    }

    @Override
    public String toString() {
        return "ClientSubType [country=" + country + ", description=" + description + ", idClientSubType="
                + idClientSubType + "]";
    }
}
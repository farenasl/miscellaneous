package src.personalproject.ms.personalproject.domain;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
public class ComercialState extends UserTracking{
	private Integer idComercialState;
    private Country country;
    private String description;

    public ComercialState() {
        this.country = new Country();
    }
    
    public ComercialState(Integer idComercialState, String description) {
        this.idComercialState = idComercialState;
        this.country = new Country();
        this.description = description;
    }

    public Integer getIdComercialState() {
        return this.idComercialState;
    }

    public void setIdComercialState(Integer idComercialState) {
        this.idComercialState = idComercialState;
    }

    public Country getCountry() {
        return this.country;
    }

    public void setCountry(Country country) {
        this.country = country;
    }

    public String getDescription() {
        return this.description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public ComercialState idComercialState(Integer idComercialState) {
        this.idComercialState = idComercialState;
        return this;
    }

    public ComercialState country(Country country) {
        this.country = country;
        return this;
    }

    public ComercialState description(String description) {
        this.description = description;
        return this;
    }

    @Override
    public String toString() {
        return "ComercialState [country=" + country + ", description=" + description + ", idComercialState="
                + idComercialState + "]";
    }
}
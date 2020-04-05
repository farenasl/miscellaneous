package src.personalproject.ms.personalproject.domain;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
public class AddressType extends UserTracking{
	private Integer idAddressType;
    private String description;

    public AddressType() {
        super();
    }

    public Integer getIdAddressType() {
        return idAddressType;
    }

    public void setIdAddressType(Integer idAddressType) {
        this.idAddressType = idAddressType;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    @Override
    public String toString() {
        return "AddressType [description=" + description + ", idAddressType=" + idAddressType + "]";
    }
}
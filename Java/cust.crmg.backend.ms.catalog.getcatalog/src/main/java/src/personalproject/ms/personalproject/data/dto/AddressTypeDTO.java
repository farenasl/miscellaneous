package src.personalproject.ms.personalproject.data.dto;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonPropertyOrder;

import src.personalproject.ms.personalproject.domain.AddressType;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 10-dic-2019 09:00
 */
@Entity
@Table(name = "address_type")
@JsonPropertyOrder({"idAddressType", "description", "createdDate", "createdUser", "modifiedDate", "modifiedUser"})
public class AddressTypeDTO extends UserTrackingDTO {
    private AddressType addressType;

    public AddressTypeDTO() {
        super();
        addressType = new AddressType();
    }

    @Id
	@Column(name = "id_address_type")
    public Integer getIdAddressType() {
        return addressType.getIdAddressType();
    }

    public void setIdAddressType(Integer idAddressType) {
        addressType.setIdAddressType(idAddressType);
    }

    @Column(name = "description")
    public String getDescription() {
        return addressType.getDescription();
    }

    public void setDescription(String description) {
        addressType.setDescription(description);
    }
}
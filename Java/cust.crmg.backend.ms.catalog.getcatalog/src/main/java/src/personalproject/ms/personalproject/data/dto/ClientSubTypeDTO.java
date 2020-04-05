package src.personalproject.ms.personalproject.data.dto;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.OneToOne;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;

import src.personalproject.ms.personalproject.domain.ClientSubType;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 10-dic-2019 09:00
 */
@Entity
@Table(name = "client_sub_type")
@JsonPropertyOrder({"idClientSubType", "description", "createdDate", "createdUser", "modifiedDate", "modifiedUser"})
public class ClientSubTypeDTO extends UserTrackingDTO {
    private ClientSubType clientSubType;
    private CountryDTO country;

    public ClientSubTypeDTO() {
        super();
        clientSubType = new ClientSubType();
    }

    @Id
	@Column(name = "id_client_sub_type")
    public Integer getIdClientSubType() {
        return clientSubType.getIdClientSubType();
    }

    public void setIdClientSubType(Integer idClientSubType) {
        clientSubType.setIdClientSubType(idClientSubType);
    }

    @Column(name = "description")
    public String getDescription() {
        return clientSubType.getDescription();
    }

    public void setDescription(String description) {
        clientSubType.setDescription(description);
    }

    @JsonIgnore
    @OneToOne
    @JoinColumn(name = "id_country", referencedColumnName = "id_country")
    public CountryDTO getCountry() {
        return this.country;
    }

    public void setCountry(CountryDTO country) {
        this.country = country;
    }
}
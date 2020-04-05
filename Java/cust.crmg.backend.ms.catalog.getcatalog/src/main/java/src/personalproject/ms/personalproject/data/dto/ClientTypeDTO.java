package src.personalproject.ms.personalproject.data.dto;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonPropertyOrder;

import src.personalproject.ms.personalproject.domain.ClientType;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 10-dic-2019 09:00
 */
@Entity
@Table(name = "client_type")
@JsonPropertyOrder({"idClientType", "description", "createdDate", "createdUser", "modifiedDate", "modifiedUser"})
public class ClientTypeDTO extends UserTrackingDTO {
    private ClientType clientType;

    public ClientTypeDTO() {
        super();
        clientType = new ClientType();
    }

    @Id
	@Column(name = "id_client_type")
    public Integer getIdClientType() {
        return clientType.getIdClientType();
    }

    public void setIdClientType(Integer idClientType) {
        clientType.setIdClientType(idClientType);
    }

    @Column(name = "description")
    public String getDescription() {
        return clientType.getDescription();
    }

    public void setDescription(String description) {
        clientType.setDescription(description);
    }
}
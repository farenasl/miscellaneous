package src.personalproject.ms.personalproject.data.dto;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonPropertyOrder;

import src.personalproject.ms.personalproject.domain.Status;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 10-dic-2019 09:00
 */
@Entity
@Table(name = "status")
@JsonPropertyOrder({"idStatus", "description", "createdDate", "createdUser", "modifiedDate", "modifiedUser"})
public class StatusDTO extends UserTrackingDTO {
    private Status status;

    public StatusDTO() {
        super();
        status = new Status();
    }

    @Id
	@Column(name = "id_status")
    public Integer getIdStatus() {
        return status.getIdStatus();
    }

    public void setIdStatus(Integer idStatus) {
        status.setIdStatus(idStatus);
    }

    @Column(name = "description")
    public String getDescription() {
        return status.getDescription();
    }

    public void setDescription(String description) {
        status.setDescription(description);
    }
}
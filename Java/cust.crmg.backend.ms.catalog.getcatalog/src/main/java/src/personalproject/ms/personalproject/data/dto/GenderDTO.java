package src.personalproject.ms.personalproject.data.dto;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonPropertyOrder;

import src.personalproject.ms.personalproject.domain.Gender;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 10-dic-2019 09:00
 */
@Entity
@Table(name = "gender")
@JsonPropertyOrder({"idGender", "description", "createdDate", "createdUser", "modifiedDate", "modifiedUser"})
public class GenderDTO extends UserTrackingDTO {
    private Gender gender;

    public GenderDTO() {
        super();
        gender = new Gender();
    }

    @Id
	@Column(name = "id_gender")
    public Integer getIdGender() {
        return gender.getIdGender();
    }

    public void setIdGender(Integer idGender) {
        gender.setIdGender(idGender);
    }

    @Column(name = "description")
    public String getDescription() {
        return gender.getDescription();
    }

    public void setDescription(String description) {
        gender.setDescription(description);
    }
}
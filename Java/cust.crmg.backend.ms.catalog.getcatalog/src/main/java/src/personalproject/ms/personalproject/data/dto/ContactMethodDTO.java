package src.personalproject.ms.personalproject.data.dto;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonPropertyOrder;

import src.personalproject.ms.personalproject.domain.ContactMethod;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 10-dic-2019 09:00
 */
@Entity
@Table(name = "contact_method")
@JsonPropertyOrder({"idContactMethod", "description", "createdDate", "createdUser", "modifiedDate", "modifiedUser"})
public class ContactMethodDTO extends UserTrackingDTO {
    private ContactMethod contactMethod;

    public ContactMethodDTO() {
        super();
        contactMethod = new ContactMethod();
    }

    @Id
	@Column(name = "id_contact_method")
    public Integer getIdContactMethod() {
        return contactMethod.getIdContactMethod();
    }

    public void setIdContactMethod(Integer idContactMethod) {
        contactMethod.setIdContactMethod(idContactMethod);
    }

    @Column(name = "description")
    public String getDescription() {
        return contactMethod.getDescription();
    }

    public void setDescription(String description) {
        contactMethod.setDescription(description);
    }
}
package src.personalproject.ms.personalproject.domain;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
public class ContactMethod extends UserTracking{
	private Integer idContactMethod;
    private String description;

    public ContactMethod() {
        //default constructor
    }

    public ContactMethod(Integer idContactMethod, String description) {
        this.idContactMethod = idContactMethod;
        this.description = description;
    }

    public Integer getIdContactMethod() {
        return this.idContactMethod;
    }

    public void setIdContactMethod(Integer idContactMethod) {
        this.idContactMethod = idContactMethod;
    }

    public String getDescription() {
        return this.description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public ContactMethod idContactMethod(Integer idContactMethod) {
        this.idContactMethod = idContactMethod;
        return this;
    }

    public ContactMethod description(String description) {
        this.description = description;
        return this;
    }

    @Override
    public String toString() {
        return "ContactMethod [description=" + description + ", idContactMethod=" + idContactMethod + "]";
    }
}
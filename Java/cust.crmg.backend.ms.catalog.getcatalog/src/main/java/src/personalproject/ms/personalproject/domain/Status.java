package src.personalproject.ms.personalproject.domain;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
public class Status  extends UserTracking{
	private Integer idStatus;
	private String description;
    
    public Integer getIdStatus() {
        return this.idStatus;
    }

    public void setIdStatus(Integer idStatus) {
        this.idStatus = idStatus;
    }

    public String getDescription() {
        return this.description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public Status idStatus(Integer idStatus) {
        this.idStatus = idStatus;
        return this;
    }

    public Status description(String description) {
        this.description = description;
        return this;
    }

    @Override
    public String toString() {
        return "Status [description=" + description + ", idStatus=" + idStatus + "]";
    }
}
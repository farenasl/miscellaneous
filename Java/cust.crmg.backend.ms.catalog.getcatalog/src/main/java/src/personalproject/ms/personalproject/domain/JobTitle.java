package src.personalproject.ms.personalproject.domain;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
public class JobTitle extends UserTracking{
	private Integer idJobTitle;
    private String description;

    public JobTitle() {
        super();
    }

    public Integer getIdJobTitle() {
        return idJobTitle;
    }

    public void setIdJobTitle(Integer idJobTitle) {
        this.idJobTitle = idJobTitle;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    @Override
    public String toString() {
        return "JobTitle [description=" + description + ", idJobTitle=" + idJobTitle + "]";
    }
}
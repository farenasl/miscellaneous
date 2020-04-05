package src.personalproject.ms.personalproject.data.dto;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonPropertyOrder;

import src.personalproject.ms.personalproject.domain.JobTitle;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 10-dic-2019 09:00
 */
@Entity
@Table(name = "job_title")
@JsonPropertyOrder({"idJobTitle", "description", "createdDate", "createdUser", "modifiedDate", "modifiedUser"})
public class JobTitleDTO extends UserTrackingDTO {
    private JobTitle jobTitle;

    public JobTitleDTO() {
        super();
        jobTitle = new JobTitle();
    }

    @Id
	@Column(name = "id_job_title")
    public Integer getIdJobTitle() {
        return jobTitle.getIdJobTitle();
    }

    public void setIdJobTitle(Integer idJobTitle) {
        jobTitle.setIdJobTitle(idJobTitle);
    }

    @Column(name = "description")
    public String getDescription() {
        return jobTitle.getDescription();
    }

    public void setDescription(String description) {
        jobTitle.setDescription(description);
    }
}
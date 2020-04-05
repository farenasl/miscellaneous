package src.personalproject.ms.personalproject.data.dto;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.OneToOne;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;

import src.personalproject.ms.personalproject.domain.EconomicActivity;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 10-dic-2019 09:00
 */
@Entity
@Table(name = "economic_activity")
@JsonPropertyOrder({"idEconomicActivity", "code", "description", "createdDate", "createdUser", "modifiedDate", "modifiedUser"})
public class EconomicActivityDTO extends UserTrackingDTO {
    private EconomicActivity economicActivity;
    private CountryDTO country;

    public EconomicActivityDTO() {
        super();
        economicActivity = new EconomicActivity();
    }
    
    @Id
	@Column(name = "id_economic_activity")
    public Integer getIdEconomicActivity() {
        return economicActivity.getIdEconomicActivity();
    }

    public void setIdEconomicActivity(Integer idEconomicActivity) {
        economicActivity.setIdEconomicActivity(idEconomicActivity);
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

    @Column(name="code")
    public String getCode() {
        return economicActivity.getCode();
    }

    public void setCode(String code) {
        economicActivity.setCode(code);
    }

    @Column(name = "description")
    public String getDescription() {
        return economicActivity.getDescription();
    }

    public void setDescription(String description) {
        economicActivity.setDescription(description);
    }
}
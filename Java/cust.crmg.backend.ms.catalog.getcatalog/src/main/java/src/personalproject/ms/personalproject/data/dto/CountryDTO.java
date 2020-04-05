package src.personalproject.ms.personalproject.data.dto;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;

import src.personalproject.ms.personalproject.domain.Country;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 10-dic-2019 09:00
 */
@Entity
@Table(name = "country")
@JsonPropertyOrder({"idCountry", "code", "description", "createdDate", "createdUser", "modifiedDate", "modifiedUser"})
public class CountryDTO extends UserTrackingDTO {
    private Country country;

    public CountryDTO() {
        super();
        country = new Country();
    }

    @Id
	@Column(name = "id_country")
    public Integer getIdCountry() {
        return country.getIdCountry();
    }

    public void setIdCountry(Integer idCountry) {
        country.setIdCountry(idCountry);
    }

    @Column(name="cd_country")
    @JsonProperty(value = "code")
    public String getCdCountry() {
        return country.getCodeCountry();
    }

    public void setCdCountry(String cdCountry) {
        country.setCodeCountry(cdCountry);
    }

    @Column(name = "description")
    public String getDescription() {
        return country.getDescription();
    }

    public void setDescription(String description) {
        country.setDescription(description);
    }

    @Override
    public String toString() {
        return "CountryDTO [cdCountry=" + getCdCountry() + ", description=" + getDescription() + ", idCountry=" + getIdCountry() + "]";
    }
}
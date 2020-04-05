package src.personalproject.ms.personalproject.data.dto;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.OneToOne;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;

import src.personalproject.ms.personalproject.domain.ComercialState;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 10-dic-2019 09:00
 */
@Entity
@Table(name = "comercial_state")
@JsonPropertyOrder({"idComercialState", "description", "createdDate", "createdUser", "modifiedDate", "modifiedUser"})
public class ComercialStateDTO extends UserTrackingDTO {
    private ComercialState comercialState;
    private CountryDTO country;

    public ComercialStateDTO() {
        super();
        comercialState = new ComercialState();
    }

    @Id
	@Column(name = "id_comercial_state")
    public Integer getIdComercialState() {
        return comercialState.getIdComercialState();
    }

    public void setIdComercialState(Integer idComercialState) {
        comercialState.setIdComercialState(idComercialState);
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

    @Column(name = "description")
    public String getDescription() {
        return comercialState.getDescription();
    }

    public void setDescription(String description) {
        comercialState.setDescription(description);
    }
}
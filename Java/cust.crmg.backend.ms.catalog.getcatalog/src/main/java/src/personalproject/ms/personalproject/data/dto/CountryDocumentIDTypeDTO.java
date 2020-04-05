package src.personalproject.ms.personalproject.data.dto;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.OneToOne;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;

import src.personalproject.ms.personalproject.domain.CountryDocumentIDType;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 10-dic-2019 09:00
 */
@Entity
@Table(name = "country_document_id_type")
@JsonPropertyOrder({"idCountryDocumentIDType", "documentIDType", "createdDate", "createdUser", "modifiedDate", "modifiedUser"})
public class CountryDocumentIDTypeDTO extends UserTrackingDTO {
    private CountryDocumentIDType countryDocumentIDType;
    private CountryDTO country;
    private DocumentIDTypeDTO documentIDType;

    public CountryDocumentIDTypeDTO() {
        super();
        countryDocumentIDType = new CountryDocumentIDType();
    }
    
    @Id
	@Column(name = "id_country_doc_id_type")
    public Integer getIdCountryDocumentIDType() {
        return countryDocumentIDType.getIdCountryDocumentIDType();
    }

    public void setIdCountryDocumentIDType(Integer idCountryDocumentIDType) {
        countryDocumentIDType.setIdCountryDocumentIDType(idCountryDocumentIDType);
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

    @OneToOne
	@JoinColumn(name = "id_doc_id_type", referencedColumnName = "id_doc_id_type")
    public DocumentIDTypeDTO getDocumentIDType() {
        return this.documentIDType;
    }

    public void setDocumentIDType(DocumentIDTypeDTO documentIDType) {
        this.documentIDType = documentIDType;
    }
}
package src.personalproject.ms.personalproject.data.dto;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonPropertyOrder;

import src.personalproject.ms.personalproject.domain.DocumentIDType;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 10-dic-2019 09:00
 */
@Entity
@Table(name = "document_id_type")
@JsonPropertyOrder({"idDocumentIDType", "description", "createdDate", "createdUser", "modifiedDate", "modifiedUser"})
public class DocumentIDTypeDTO extends UserTrackingDTO {
    private DocumentIDType documentIDType;

    public DocumentIDTypeDTO() {
        super();
        documentIDType = new DocumentIDType();
    }

    @Id
	@Column(name = "id_doc_id_type")
    public Integer getIdDocumentIDType() {
        return documentIDType.getIdDocumentIDType();
    }

    public void setIdDocumentIDType(Integer idDocumentIDType) {
        documentIDType.setIdDocumentIDType(idDocumentIDType);
    }

    @Column(name = "description")
    public String getDescription() {
        return documentIDType.getDescription();
    }

    public void setDescription(String description) {
        documentIDType.setDescription(description);
    }
}
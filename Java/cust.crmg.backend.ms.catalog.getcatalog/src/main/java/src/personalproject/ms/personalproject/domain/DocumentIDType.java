package src.personalproject.ms.personalproject.domain;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
public class DocumentIDType extends UserTracking{
	private Integer idDocumentIDType;
    private String description;

    public DocumentIDType(){
        //Default constructor
    }

    public DocumentIDType(Integer idDocumentIDType, String codeDocumentIDType, String description) {
        this.idDocumentIDType = idDocumentIDType;
        this.description = description;
    }

    public Integer getIdDocumentIDType() {
        return this.idDocumentIDType;
    }

    public void setIdDocumentIDType(Integer idDocumentIDType) {
        this.idDocumentIDType = idDocumentIDType;
    }

    public String getDescription() {
        return this.description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public DocumentIDType idDocumentIDType(Integer idDocumentIDType) {
        this.idDocumentIDType = idDocumentIDType;
        return this;
    }

    public DocumentIDType description(String description) {
        this.description = description;
        return this;
    }

    @Override
    public String toString() {
        return "DocumentIDType [description=" + description
                + ", idDocumentIDType=" + idDocumentIDType + "]";
    }
}
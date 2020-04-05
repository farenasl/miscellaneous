package src.personalproject.ms.personalproject.domain;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
public class ClientType extends UserTracking{
    private Integer idClientType;
    private String description;

    public ClientType(){
        //default constructor
    }

    public ClientType(Integer idClientType, String description) {
        this.idClientType = idClientType;
        this.description = description;
    }

    public Integer getIdClientType() {
        return this.idClientType;
    }

    public void setIdClientType(Integer idClientType) {
        this.idClientType = idClientType;
    }

    public String getDescription() {
        return this.description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public ClientType idClientType(Integer idClientType) {
        this.idClientType = idClientType;
        return this;
    }

    public ClientType description(String description) {
        this.description = description;
        return this;
    }

    @Override
    public String toString() {
        return "ClientType [description=" + description + ", idClientType=" + idClientType + "]";
    }
}
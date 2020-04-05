package src.personalproject.ms.personalproject.data.dto;

import java.util.Date;

import javax.persistence.Column;
import javax.persistence.MappedSuperclass;

import com.fasterxml.jackson.annotation.JsonFormat;
import com.fasterxml.jackson.annotation.JsonIgnore;

import src.personalproject.ms.personalproject.domain.UserTracking;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
@MappedSuperclass
public class UserTrackingDTO extends UserTracking {
    private Date createdDate;
    private String createdUser;
    private Date modifiedDate;
    private String modifiedUser;
    private Date deletedDate;
    private String deletedUser;
    private Boolean validFlag;

    public UserTrackingDTO() {
        //default constructor
    }

    @Override
    @JsonFormat(shape = JsonFormat.Shape.STRING, pattern = "dd/MM/yyyy HH:mm:ss")
    public Date getCreatedDate() {
        return this.createdDate;
    }

    @Override
    public void setCreatedDate(Date createdDate) {
        this.createdDate = createdDate;
    }

    @Override
    @Column(name = "created_user")
    public String getCreatedUser() {
        return this.createdUser;
    }

    @Override
    public void setCreatedUser(String createdUser) {
        this.createdUser = createdUser;
    }

    @Override
    @JsonFormat(shape = JsonFormat.Shape.STRING, pattern = "dd/MM/yyyy HH:mm:ss")
    public Date getModifiedDate() {
        return this.modifiedDate;
    }

    @Override
    public void setModifiedDate(Date modifiedDate) {
        this.modifiedDate = modifiedDate;
    }

    @Override
    @Column(name = "modified_user")
    public String getModifiedUser() {
        return this.modifiedUser;
    }

    @Override
    public void setModifiedUser(String modifiedUser) {
        this.modifiedUser = modifiedUser;
    }

    @Override
    @JsonIgnore
    public Date getDeletedDate() {
        return this.deletedDate;
    }

    @Override
    public void setDeletedDate(Date deletedDate) {
        this.deletedDate = deletedDate;
    }

    @Override
    @JsonIgnore
    public String getDeletedUser() {
        return this.deletedUser;
    }

    @Override
    public void setDeletedUser(String deletedUser) {
        this.deletedUser = deletedUser;
    }

    @Override
    @JsonIgnore
    public Boolean getValidFlag() {
        return this.validFlag;
    }
}
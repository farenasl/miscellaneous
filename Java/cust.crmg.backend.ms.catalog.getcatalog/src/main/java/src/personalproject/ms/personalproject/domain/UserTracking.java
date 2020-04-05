package src.personalproject.ms.personalproject.domain;

import java.util.Date;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
public class UserTracking {
    private Date createdDate;
    private String createdUser;
    private Date modifiedDate;
    private String modifiedUser;
    private Date deletedDate;
    private String deletedUser;
    private Boolean validFlag;

    public Date getCreatedDate() {
        return this.createdDate;
    }

    public void setCreatedDate(Date createdDate) {
        this.createdDate = createdDate;
    }

    public String getCreatedUser() {
        return this.createdUser;
    }

    public void setCreatedUser(String createdUser) {
        this.createdUser = createdUser;
    }

    public Date getModifiedDate() {
        return this.modifiedDate;
    }

    public void setModifiedDate(Date modifiedDate) {
        this.modifiedDate = modifiedDate;
    }

    public String getModifiedUser() {
        return this.modifiedUser;
    }

    public void setModifiedUser(String modifiedUser) {
        this.modifiedUser = modifiedUser;
    }

    public Date getDeletedDate() {
        return this.deletedDate;
    }

    public void setDeletedDate(Date deletedDate) {
        this.deletedDate = deletedDate;
    }

    public String getDeletedUser() {
        return this.deletedUser;
    }

    public void setDeletedUser(String deletedUser) {
        this.deletedUser = deletedUser;
    }

    public Boolean getValidFlag() {
        return this.validFlag;
    }

    public void setValidFlag(Boolean validFlag) {
        this.validFlag = validFlag;
    }

    public UserTracking createdDate(Date createdDate) {
        this.createdDate = createdDate;
        return this;
    }

    public UserTracking createdUser(String createdUser) {
        this.createdUser = createdUser;
        return this;
    }

    public UserTracking modifiedDate(Date modifiedDate) {
        this.modifiedDate = modifiedDate;
        return this;
    }

    public UserTracking modifiedUser(String modifiedUser) {
        this.modifiedUser = modifiedUser;
        return this;
    }

    public UserTracking deletedDate(Date deletedDate) {
        this.deletedDate = deletedDate;
        return this;
    }

    public UserTracking deletedUser(String deletedUser) {
        this.deletedUser = deletedUser;
        return this;
    }

    public UserTracking validFlag(Boolean validFlag) {
        this.validFlag = validFlag;
        return this;
    }
}
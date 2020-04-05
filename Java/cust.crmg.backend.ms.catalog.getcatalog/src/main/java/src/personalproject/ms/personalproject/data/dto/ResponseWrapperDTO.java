package src.personalproject.ms.personalproject.data.dto;

import java.util.List;

import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
@JsonPropertyOrder({"AddressTypes", "ClientTypes", "ClientSubTypes"
                    ,"ComercialStates", "ContactMethods", "Countries"
                    ,"DocumentIDTypes", "CountryDocumentIdTypes", "EconomicActivities"
                    ,"Genders", "JobTitles", "Statuses"})
public class ResponseWrapperDTO {
    @JsonProperty(value = "AddressTypes")
    private List<AddressTypeDTO> addressTypes;
    @JsonProperty(value = "ClientTypes")
    private List<ClientTypeDTO> clientTypes;
    @JsonProperty(value = "ClientSubTypes")
    private List<ClientSubTypeDTO> clientSubTypes;
    @JsonProperty(value = "ComercialStates")
    private List<ComercialStateDTO> comercialStates;
    @JsonProperty(value = "ContactMethods")
    private List<ContactMethodDTO> contactMethods;
    @JsonProperty(value = "Countries")
    private List<CountryDTO> countries;
    @JsonProperty(value = "DocumentIDTypes")
    private List<DocumentIDTypeDTO> documentIDTypes;
    @JsonProperty(value = "CountryDocumentIdTypes")
    private List<CountryDocumentIDTypeDTO> countryDocumentIDTypes;
    @JsonProperty(value = "EconomicActivities")
    private List<EconomicActivityDTO> economicActivities;
    @JsonProperty(value = "Genders")
    private List<GenderDTO> genders;
    @JsonProperty(value = "JobTitles")
    private List<JobTitleDTO> jobTitles;
    @JsonProperty(value = "Statuses")
    private List<StatusDTO> statuses;

    public List<AddressTypeDTO> getAddressTypes() {
        return addressTypes;
    }

    public void setAddressTypes(List<AddressTypeDTO> addressTypes) {
        this.addressTypes = addressTypes;
    }

    public List<ClientTypeDTO> getClientTypes() {
        return this.clientTypes;
    }

    public void setClientTypes(List<ClientTypeDTO> clientTypes) {
        this.clientTypes = clientTypes;
    }

    public List<ClientSubTypeDTO> getClientSubTypes() {
        return this.clientSubTypes;
    }

    public void setClientSubTypes(List<ClientSubTypeDTO> clientSubTypes) {
        this.clientSubTypes = clientSubTypes;
    }

    public List<ComercialStateDTO> getComercialStates() {
        return this.comercialStates;
    }

    public void setComercialStates(List<ComercialStateDTO> comercialStates) {
        this.comercialStates = comercialStates;
    }

    public List<ContactMethodDTO> getContactMethods() {
        return this.contactMethods;
    }

    public void setContactMethods(List<ContactMethodDTO> contactMethods) {
        this.contactMethods = contactMethods;
    }

    public List<CountryDTO> getCountries() {
        return this.countries;
    }

    public void setCountries(List<CountryDTO> countries) {
        this.countries = countries;
    }

    public List<DocumentIDTypeDTO> getDocumentIDTypes() {
        return this.documentIDTypes;
    }

    public void setDocumentIDTypes(List<DocumentIDTypeDTO> documentIDTypes) {
        this.documentIDTypes = documentIDTypes;
    }

    public List<CountryDocumentIDTypeDTO> getCountryDocumentIDTypes() {
        return this.countryDocumentIDTypes;
    }

    public void setCountryDocumentIDTypes(List<CountryDocumentIDTypeDTO> countryDocumentIDTypes) {
        this.countryDocumentIDTypes = countryDocumentIDTypes;
    }

    public List<EconomicActivityDTO> getEconomicActivities() {
        return this.economicActivities;
    }

    public void setEconomicActivities(List<EconomicActivityDTO> economicActivities) {
        this.economicActivities = economicActivities;
    }

    public List<GenderDTO> getGenders() {
        return this.genders;
    }

    public void setGenders(List<GenderDTO> genders) {
        this.genders = genders;
    }

    public List<JobTitleDTO> getJobTitles() {
        return this.jobTitles;
    }

    public void setJobTitles(List<JobTitleDTO> jobTitles) {
        this.jobTitles = jobTitles;
    }

    public List<StatusDTO> getStatuses() {
        return this.statuses;
    }

    public void setStatuses(List<StatusDTO> statuses) {
        this.statuses = statuses;
    }

    public ResponseWrapperDTO addressTypes(List<AddressTypeDTO> addressTypes) {
        this.addressTypes = addressTypes;
        return this;
    }

    public ResponseWrapperDTO clientTypes(List<ClientTypeDTO> clientTypes) {
        this.clientTypes = clientTypes;
        return this;
    }

    public ResponseWrapperDTO clientSubTypes(List<ClientSubTypeDTO> clientSubTypes) {
        this.clientSubTypes = clientSubTypes;
        return this;
    }

    public ResponseWrapperDTO comercialStates(List<ComercialStateDTO> comercialStates) {
        this.comercialStates = comercialStates;
        return this;
    }

    public ResponseWrapperDTO contactMethods(List<ContactMethodDTO> contactMethods) {
        this.contactMethods = contactMethods;
        return this;
    }

    public ResponseWrapperDTO countries(List<CountryDTO> countries) {
        this.countries = countries;
        return this;
    }

    public ResponseWrapperDTO documentIDTypes(List<DocumentIDTypeDTO> documentIDTypes) {
        this.documentIDTypes = documentIDTypes;
        return this;
    }

    public ResponseWrapperDTO countryDocumentIDTypes(List<CountryDocumentIDTypeDTO> countryDocumentIDTypes) {
        this.countryDocumentIDTypes = countryDocumentIDTypes;
        return this;
    }

    public ResponseWrapperDTO economicActivities(List<EconomicActivityDTO> economicActivities) {
        this.economicActivities = economicActivities;
        return this;
    }

    public ResponseWrapperDTO genders(List<GenderDTO> genders) {
        this.genders = genders;
        return this;
    }

    public ResponseWrapperDTO jobTitles(List<JobTitleDTO> jobTitles) {
        this.jobTitles = jobTitles;
        return this;
    }

    public ResponseWrapperDTO statuses(List<StatusDTO> statuses) {
        this.statuses = statuses;
        return this;
    }

    @Override
    public String toString() {
        return "{" +
            " addressTypes='" + getAddressTypes() + "'" +
            ", clientTypes='" + getClientTypes() + "'" +
            ", clientSubTypes='" + getClientSubTypes() + "'" +
            ", comercialStates='" + getComercialStates() + "'" +
            ", contactMethods='" + getContactMethods() + "'" +
            ", countries='" + getCountries() + "'" +
            ", documentIDTypes='" + getDocumentIDTypes() + "'" +
            ", countryDocumentIDTypes='" + getCountryDocumentIDTypes() + "'" +
            ", economicActivities='" + getEconomicActivities() + "'" +
            ", genders='" + getGenders() + "'" +
            ", jobTitles='" + getJobTitles() + "'" +
            ", statuses='" + getStatuses() + "'" +
            "}";
    }
}
package com.example.demo.dto;

import java.util.Objects;

import com.fasterxml.jackson.annotation.JsonProperty;

public class RequestDTO {
    @JsonProperty("85")
    private Declaration art85;
    @JsonProperty("57")
    private Declaration circ57;

    public RequestDTO() {
    }

    public RequestDTO(Declaration art85, Declaration circ57) {
        this.art85 = art85;
        this.circ57 = circ57;
    }

    public Declaration getArt85() {
        return this.art85;
    }

    public void setArt85(Declaration art85) {
        this.art85 = art85;
    }

    public Declaration getCirc57() {
        return this.circ57;
    }

    public void setCirc57(Declaration circ57) {
        this.circ57 = circ57;
    }

    public RequestDTO art85(Declaration art85) {
        this.art85 = art85;
        return this;
    }

    public RequestDTO circ57(Declaration circ57) {
        this.circ57 = circ57;
        return this;
    }

    @Override
    public boolean equals(Object o) {
        if (o == this)
            return true;
        if (!(o instanceof RequestDTO)) {
            return false;
        }
        RequestDTO requestDTO = (RequestDTO) o;
        return Objects.equals(art85, requestDTO.art85) && Objects.equals(circ57, requestDTO.circ57);
    }

    @Override
    public int hashCode() {
        return Objects.hash(art85, circ57);
    }

    @Override
    public String toString() {
        return "{" +
            " art85='" + getArt85() + "'" +
            ", circ57='" + getCirc57() + "'" +
            "}";
    }

}
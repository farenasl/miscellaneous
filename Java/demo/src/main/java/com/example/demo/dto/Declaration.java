package com.example.demo.dto;

import java.util.Objects;

import com.fasterxml.jackson.annotation.JsonProperty;

public class Declaration {
    @JsonProperty("DC")
    private RelationSet DC;
    @JsonProperty("CD")
    private RelationSet CD;
    @JsonProperty("SP")
    private RelationSet SP;

    public Declaration() {
    }

    public Declaration(RelationSet DC, RelationSet CD, RelationSet SP) {
        this.DC = DC;
        this.CD = CD;
        this.SP = SP;
    }

    public RelationSet getDC() {
        return this.DC;
    }

    public void setDC(RelationSet DC) {
        this.DC = DC;
    }

    public RelationSet getCD() {
        return this.CD;
    }

    public void setCD(RelationSet CD) {
        this.CD = CD;
    }

    public RelationSet getSP() {
        return this.SP;
    }

    public void setSP(RelationSet SP) {
        this.SP = SP;
    }

    public Declaration DC(RelationSet DC) {
        this.DC = DC;
        return this;
    }

    public Declaration CD(RelationSet CD) {
        this.CD = CD;
        return this;
    }

    public Declaration SP(RelationSet SP) {
        this.SP = SP;
        return this;
    }

    @Override
    public boolean equals(Object o) {
        if (o == this)
            return true;
        if (!(o instanceof Declaration)) {
            return false;
        }
        Declaration declaration = (Declaration) o;
        return Objects.equals(DC, declaration.DC) && Objects.equals(CD, declaration.CD) && Objects.equals(SP, declaration.SP);
    }

    @Override
    public int hashCode() {
        return Objects.hash(DC, CD, SP);
    }

    @Override
    public String toString() {
        return "{" +
            " DC='" + getDC() + "'" +
            ", CD='" + getCD() + "'" +
            ", SP='" + getSP() + "'" +
            "}";
    }
}
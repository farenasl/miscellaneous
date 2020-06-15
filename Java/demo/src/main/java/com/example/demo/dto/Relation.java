package com.example.demo.dto;

import java.util.Objects;

public class Relation {
    private Empresa empresa;
    private String razonSocial;
    private String porcentaje;
    private String action;

    public Relation() {
    }

    public Relation(Empresa empresa, String razonSocial, String porcentaje, String action) {
        this.empresa = empresa;
        this.razonSocial = razonSocial;
        this.porcentaje = porcentaje;
        this.action = action;
    }

    public Empresa getEmpresa() {
        return this.empresa;
    }

    public void setEmpresa(Empresa empresa) {
        this.empresa = empresa;
    }

    public String getRazonSocial() {
        return this.razonSocial;
    }

    public void setRazonSocial(String razonSocial) {
        this.razonSocial = razonSocial;
    }

    public String getPorcentaje() {
        return this.porcentaje;
    }

    public void setPorcentaje(String porcentaje) {
        this.porcentaje = porcentaje;
    }

    public String getAction() {
        return this.action;
    }

    public void setAction(String action) {
        this.action = action;
    }

    public Relation empresa(Empresa empresa) {
        this.empresa = empresa;
        return this;
    }

    public Relation razonSocial(String razonSocial) {
        this.razonSocial = razonSocial;
        return this;
    }

    public Relation porcentaje(String porcentaje) {
        this.porcentaje = porcentaje;
        return this;
    }

    public Relation action(String action) {
        this.action = action;
        return this;
    }

    @Override
    public boolean equals(Object o) {
        if (o == this)
            return true;
        if (!(o instanceof Relation)) {
            return false;
        }
        Relation relation = (Relation) o;
        return Objects.equals(empresa, relation.empresa) && Objects.equals(razonSocial, relation.razonSocial) && Objects.equals(porcentaje, relation.porcentaje) && Objects.equals(action, relation.action);
    }

    @Override
    public int hashCode() {
        return Objects.hash(empresa, razonSocial, porcentaje, action);
    }

    @Override
    public String toString() {
        return "{" +
            " empresa='" + getEmpresa() + "'" +
            ", razonSocial='" + getRazonSocial() + "'" +
            ", porcentaje='" + getPorcentaje() + "'" +
            ", action='" + getAction() + "'" +
            "}";
    }
}
package com.example.demo.dto;

import java.util.Objects;

public class Empresa {
    private String rut;
    private String digitoVerificador;

    public Empresa() {
    }

    public Empresa(String rut, String digitoVerificador) {
        this.rut = rut;
        this.digitoVerificador = digitoVerificador;
    }

    public String getRut() {
        return this.rut;
    }

    public void setRut(String rut) {
        this.rut = rut;
    }

    public String getDigitoVerificador() {
        return this.digitoVerificador;
    }

    public void setDigitoVerificador(String digitoVerificador) {
        this.digitoVerificador = digitoVerificador;
    }

    public Empresa rut(String rut) {
        this.rut = rut;
        return this;
    }

    public Empresa digitoVerificador(String digitoVerificador) {
        this.digitoVerificador = digitoVerificador;
        return this;
    }

    @Override
    public boolean equals(Object o) {
        if (o == this)
            return true;
        if (!(o instanceof Empresa)) {
            return false;
        }
        Empresa empresa = (Empresa) o;
        return Objects.equals(rut, empresa.rut) && Objects.equals(digitoVerificador, empresa.digitoVerificador);
    }

    @Override
    public int hashCode() {
        return Objects.hash(rut, digitoVerificador);
    }

    @Override
    public String toString() {
        return "{" +
            " rut='" + getRut() + "'" +
            ", digitoVerificador='" + getDigitoVerificador() + "'" +
            "}";
    }
}
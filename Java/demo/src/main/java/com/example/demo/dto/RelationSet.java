package com.example.demo.dto;

import java.util.List;
import java.util.Objects;

public class RelationSet {
    private List<Relation> change;
    private List<Relation> delete;

    public RelationSet() {
    }

    public RelationSet(List<Relation> change, List<Relation> delete) {
        this.change = change;
        this.delete = delete;
    }

    public List<Relation> getChange() {
        return this.change;
    }

    public void setChange(List<Relation> change) {
        this.change = change;
    }

    public List<Relation> getDelete() {
        return this.delete;
    }

    public void setDelete(List<Relation> delete) {
        this.delete = delete;
    }

    public RelationSet change(List<Relation> change) {
        this.change = change;
        return this;
    }

    public RelationSet delete(List<Relation> delete) {
        this.delete = delete;
        return this;
    }

    @Override
    public boolean equals(Object o) {
        if (o == this)
            return true;
        if (!(o instanceof RelationSet)) {
            return false;
        }
        RelationSet relationSet = (RelationSet) o;
        return Objects.equals(change, relationSet.change) && Objects.equals(delete, relationSet.delete);
    }

    @Override
    public int hashCode() {
        return Objects.hash(change, delete);
    }

    @Override
    public String toString() {
        return "{" +
            " change='" + getChange() + "'" +
            ", delete='" + getDelete() + "'" +
            "}";
    }
}
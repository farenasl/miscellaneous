package src.personalproject.ms.personalproject.repository;

import org.springframework.data.repository.CrudRepository;
import org.springframework.data.rest.core.annotation.RepositoryRestResource;

import src.personalproject.ms.personalproject.data.dto.CountryDTO;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
@RepositoryRestResource
public interface CountryRepository extends CrudRepository<CountryDTO, Integer> {
    public CountryDTO findByCdCountry(String cdCountry);
}
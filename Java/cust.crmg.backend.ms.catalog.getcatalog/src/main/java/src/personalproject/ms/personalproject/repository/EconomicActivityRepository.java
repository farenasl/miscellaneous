package src.personalproject.ms.personalproject.repository;

import java.util.List;

import org.springframework.data.repository.CrudRepository;
import org.springframework.data.rest.core.annotation.RepositoryRestResource;

import src.personalproject.ms.personalproject.data.dto.CountryDTO;
import src.personalproject.ms.personalproject.data.dto.EconomicActivityDTO;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
@RepositoryRestResource
public interface EconomicActivityRepository extends CrudRepository<EconomicActivityDTO, Integer> {
    List<EconomicActivityDTO> findAllByCountry(CountryDTO country);
}
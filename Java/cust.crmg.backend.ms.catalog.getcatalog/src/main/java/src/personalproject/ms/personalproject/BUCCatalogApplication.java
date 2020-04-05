package src.personalproject.ms.personalproject;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import springfox.documentation.swagger2.annotations.EnableSwagger2;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 * App start point
 */
@SpringBootApplication
@EnableSwagger2
public class personalprojectCatalogApplication {
	public static void main(String[] args) {
		SpringApplication.run(personalprojectCatalogApplication.class);
	}
}
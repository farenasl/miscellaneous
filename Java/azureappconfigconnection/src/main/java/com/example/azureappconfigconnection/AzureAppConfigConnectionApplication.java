package com.example.azureappconfigconnection;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.context.properties.EnableConfigurationProperties;

@SpringBootApplication
@EnableConfigurationProperties(MessageProperties.class)
public class AzureAppConfigConnectionApplication {

	public static void main(String[] args) {
		SpringApplication.run(AzureAppConfigConnectionApplication.class, args);
	}

}

package src.personalproject.ms.personalproject.business.controller;

import java.util.HashMap;
import java.util.Map;

import javax.persistence.PersistenceException;

import org.apache.log4j.LogManager;
import org.apache.log4j.Logger;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.actuate.health.Health;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.ExceptionHandler;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestHeader;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import src.personalproject.ms.personalproject.business.constant.Constant;
import src.personalproject.ms.personalproject.business.helper.CatalogHelper;
import src.personalproject.ms.personalproject.business.helper.HealthCheck;
import src.personalproject.ms.personalproject.data.dto.ResponseWrapperDTO;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
@RestController
@RequestMapping("/catalog")
public class CatalogController {
	@Autowired
	HealthCheck healthCheck;
	@Autowired
	CatalogHelper cHelper;

	private static final Logger logger = LogManager.getLogger(CatalogController.class);

	@GetMapping("/")
	public ResponseEntity<Object> selectCatalog(
		@RequestHeader(value= "X-country", required = true) String countryCd
		, @RequestHeader(value = "X-commerce", required = true) String commerce
		, @RequestHeader(value = "X-chRef", required = true) String chRef
		, @RequestHeader(value = "X-rhsRef", required = true) String rhsRef
		, @RequestHeader(value = "X-cmRef", required = true) String cmRef
		, @RequestHeader(value = "X-txRef", required = true) String txRef
		, @RequestHeader(value = "X-prRef", defaultValue = "") String prRef
		, @RequestHeader(value = "X-usrTx", defaultValue = "") String usrTx) {
		Map<String, Object> map = new HashMap<>();
		ResponseWrapperDTO rw = new ResponseWrapperDTO();
		try {
			logger.info("***** Start of Get Service *****");

			rw = cHelper.processRequest(countryCd);
		} catch (PersistenceException e) {
			logger.error(e);
			map.put(Constant.STATUS_CODE, Constant.N202);
			map.put(Constant.STATUS_DESCRIPTION, Constant.MESSAGE_202);
			return new ResponseEntity<>(map, HttpStatus.NOT_FOUND);
		} catch (Exception e) {
			logger.error(e);
			map.put(Constant.STATUS_CODE, Constant.N500);
			map.put(Constant.STATUS_DESCRIPTION, Constant.MESSAGE_500);
			return new ResponseEntity<>(map, HttpStatus.INTERNAL_SERVER_ERROR);
		} finally {
			logger.info("***** End of Get Service *****");
		}
		return new ResponseEntity<>(rw, HttpStatus.OK);
	}

	@ExceptionHandler(Throwable.class)
	public ResponseEntity<Object> handleAnyException(Throwable e) {
		logger.error(e);
		Map<String, Object> map = new HashMap<>();
		map.put(Constant.STATUS_CODE, Constant.N400);
		map.put(Constant.STATUS_DESCRIPTION, Constant.MESSAGE_400);
		return new ResponseEntity<>(map, HttpStatus.OK);
	}

	@GetMapping("/healthCheck")
	public Health healthCheck() {
		return healthCheck.health();
	}
}
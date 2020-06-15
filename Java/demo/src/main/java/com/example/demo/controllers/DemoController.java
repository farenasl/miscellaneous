package com.example.demo.controllers;

import java.util.concurrent.ExecutionException;

import javax.validation.Valid;

import com.example.demo.dto.RequestDTO;
import com.example.demo.helpers.RelationHelper;

import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class DemoController {
    @RequestMapping("/")
    public String index() {
        return "Hello world from Spring Boot!";
    }

    @PostMapping("/")
    public ResponseEntity insertRelations(@Valid @RequestBody RequestDTO request)
            throws InterruptedException, ExecutionException {
        HttpStatus salida = RelationHelper.validateRelations(request) ? HttpStatus.OK : HttpStatus.INTERNAL_SERVER_ERROR;
        return new ResponseEntity<>(salida);
    }
}
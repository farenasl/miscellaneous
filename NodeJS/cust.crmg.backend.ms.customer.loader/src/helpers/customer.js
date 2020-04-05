/**
 * Util functions to work with API PERSONAL_PROJECT
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 24-ene-2020 09:00
 */
const logger = 'helpers-customer';
const utils = require('./utils');
const catalogUtils = require('./catalog');
const moment = require('moment');
const fileUtils = require('./file');
const cache = require("../helpers/cacheService");
const {JWT_CACHED} = process.env;

exports.setAPIPERSONAL_PROJECTGETUniqueHeaders = (params,token) => {
  let obj = this.setAPIPERSONAL_PROJECTHeaders(params,token);

  obj.headers.idDocIDType = params.idDocIDType;
  obj.headers.docIDValue = params.docIDValue;
  obj.headers.idDocIDCountry = params.idDocIDCountry;

  return obj;
}

exports.setAPIPERSONAL_PROJECTHeaders = (params,token) => {
  return {
    headers: {
      "Authorization": `Bearer ${token}`,
      'X-country': params.country
      , 'X-chRef': "1"
      , 'X-commerce': "1"
      , 'X-rhsRef': "1"
      , 'X-cmRef': "1"
      , 'X-txRef': "1"
      , 'X-prRef': "1"
      , 'X-usrTx': "MassiveLoader"
    }
  }
}

exports.handleAxiosError = (err) => {
  utils.logInfoMessage(logger, 'Handle Axios Error method');

  let obj = {};
  if (err.response) {  // * SI REALIZA REQUEST Y SERVER RESPONDE 
    obj = { status: err.response.status, data: err.response.data };
  } else if (err.request) { // * SI REZALIZA REQUEST PERO SIN RESPUESTA DEL SERVER
    obj = { status: 400, data: "Bad Request, check logger to see full error request" };
  } else { // * SI ALGO SUCEDE AL MOMENTO DE REALIZAR EL REQUEST Y SE DISPARA ALGUN ERROR
    obj = { status: 500, data: err.message };
  }

  utils.logErrorMessage(logger, 'Axios error: ' + err);

  return obj;
}

exports.createUpdateRequest = (catalog, client, PERSONAL_PROJECTClient, addresses, contacts, contactMethods, economicActivities) => {
  let updateJson = this.setClientNodeForUpdate(catalog, client, PERSONAL_PROJECTClient);
  updateJson.KEY = this.setKEYNode(catalog, client)
  updateJson.Addresses = this.setAddressesNode(catalog, addresses)
  updateJson.Contacts = this.setContactsNode(catalog, contacts)
  updateJson.ContactMethods = this.setContactMethodsNode(catalog, contactMethods, true)
  updateJson.EconomicActivities = this.setEconomicActivitiesNode(economicActivities, true)
  updateJson.Registration = this.setRegistrationNode();
  return updateJson;
}

exports.createInsertRequest = (catalog, client, addresses, contacts, contactMethods, economicActivities) => {
  return {
    KEY: this.setKEYNode(catalog, client)
    , Client: this.setClientNode(catalog, client)
    , Addresses: this.setAddressesNode(catalog, addresses)
    , Contacts: this.setContactsNode(catalog, contacts)
    , ContactMethods: this.setContactMethodsNode(catalog, contactMethods, false)
    , EconomicActivities: this.setEconomicActivitiesNode(economicActivities, false)
    , Registration: this.setRegistrationNode()
  };
}

exports.setKEYNode = (catalog, obj) => {
  return {
    "cdCountry": utils.returnValidString(obj["cdCountry"])
    , "idDocIDType": catalogUtils.objectExist(catalog.DocumentIDTypes, obj["docIDType"]) ? (catalogUtils.returnObj(catalog.DocumentIDTypes, obj["docIDType"])).idDocumentIDType : null
    , "docIDValue": utils.returnValidString(obj["docIDValue"])
    , "idDocIDCountry": catalogUtils.countryObjectExist(catalog.Countries, obj["docIDCountry"]) ? (catalogUtils.returnCountryObj(catalog.Countries, obj["docIDCountry"])).idCountry : null
  };
}

exports.setClientNode = (catalog, obj) => {
  return {
    "names": utils.returnValidString(obj["names"])
    , "lastnames": utils.returnValidString(obj["lastnames"])
    , "idGender": catalogUtils.objectExist(catalog.Genders, obj["gender"]) ? (catalogUtils.returnObj(catalog.Genders, obj["gender"])).idGender : null
    , "idClientType": catalogUtils.objectExist(catalog.ClientTypes, obj["clientType"]) ? (catalogUtils.returnObj(catalog.ClientTypes, obj["clientType"])).idClientType : null
    , "idComercialState": catalogUtils.objectExist(catalog.ComercialStates, obj["comercialState"]) ? (catalogUtils.returnObj(catalog.ComercialStates, obj["comercialState"])).idComercialState : null
    , "fantasyName": utils.returnValidString(obj["fantasyName"])
    , "idStatus": catalogUtils.objectExist(catalog.Statuses, obj["status"]) ? (catalogUtils.returnObj(catalog.Statuses, obj["status"])).idStatus : null
    , "idClientSubType": catalogUtils.objectExist(catalog.ClientSubTypes, obj["clientSubType"]) ? (catalogUtils.returnObj(catalog.ClientSubTypes, obj["clientSubType"])).idClientSubType : null
    , "occupation": utils.returnValidString(obj["occupation"])
    , "birthday": moment(utils.returnValidString(obj["birthday"])).format("DD/MM/YYYY")
    , "isSubscribed": utils.returnValidBoolean(obj["subscribed"])
    , "isEmployee": utils.returnValidBoolean(obj["isEmployee"])
  };
}

exports.setClientNodeForUpdate = (catalog, obj, PERSONAL_PROJECTClient) => {
  return Object.assign(this.setClientNode(catalog, obj), { 'idClient': PERSONAL_PROJECTClient.Client.idClient });
}

exports.setAddressesNode = (catalog, lst) => {
  var addresses = [];

  for (let address of lst) {
    addresses.push({
      "idAddressType": catalogUtils.objectExist(catalog.AddressTypes, address["addressType"]) ? (catalogUtils.returnObj(catalog.AddressTypes, address["addressType"])).idAddressType : null
      , "address": utils.returnValidString(address["address"])
      , "references": utils.returnValidString(address["references"])
      , "idGeo": utils.returnValidString(address["idGeoParent"])
      , "geoDesc": utils.returnValidString(address["geoDesc"])
      , "isMain": utils.returnValidBoolean(address["isMain"])
    });
  }

  return addresses;
}

exports.setContactsNode = (catalog, lst) => {
  var contacts = [];

  for (let contact of lst) {
    contacts.push({
      "names": utils.returnValidString(contact["names"])
      , "lastnames": utils.returnValidString(contact["lastnames"])
      , "idJobTitle": catalogUtils.objectExist(catalog.JobTitles, contact["jobTitle"]) ? (catalogUtils.returnObj(catalog.JobTitles, contact["jobTitle"])).idJobTitle : null
      , "phone": utils.returnValidString(contact["phone"])
      , "mail": utils.returnValidString(contact["mail"])
    });
  }

  return contacts;
}

exports.setContactMethodsNode = (catalog, lst, isUpdate) => {
  var contactMethods = [];
  let key = (isUpdate ? "idContactMethod" : "idContactMethodType");

  for (let contactMethod of lst) {
    contactMethods.push({
      [key]: catalogUtils.objectExist(catalog.ContactMethods, contactMethod["contactMethodType"]) ? (catalogUtils.returnObj(catalog.ContactMethods, contactMethod["contactMethodType"])).idContactMethod : null
      , "value": utils.returnValidString(contactMethod["value"])
      , "acceptOffers": utils.returnValidBoolean(contactMethod["acceptOffers"])
      , "isMain": utils.returnValidBoolean(contactMethod["isMain"])
    });
  }

  return contactMethods;
}

exports.setEconomicActivitiesNode = (lst, isUpdate) => {
  var economicActivities = [];
  let key = (isUpdate ? "idClientEconomicActivity" : "idEconomicActivity");

  for (let economicActivity of lst) {
    economicActivities.push({
      [key]: utils.returnValidString(economicActivity["idEconomicActivity"])
      , "isMain": utils.returnValidBoolean(economicActivity["isMain"])
    });
  }

  return economicActivities;
}

exports.setRegistrationNode = () => {
  return {
    "requestingDate": moment().format("DD/MM/YYYY H:mm:ss"),
    "requestingUser": "MassiveLoader"
  }
}

exports.createInsertOrUpdateRequestBody = async (xCountry, apiCustomer, json, catalog, toUpdate, toInsert) => {
  for (let client of json.Clientes) {
    let tokenRequest = cache.getKey(JWT_CACHED).generateToken();
    utils.logInfoMessage(logger, "Processing client: idDocIDType = " + client["docIDType"] + ", docIDValue = " + client["docIDValue"] + ", idDocIDCountry = " + client["docIDCountry"] + ", country = " + xCountry);
    let getResult = await apiCustomer.get({ idDocIDType: catalog.DocumentIDTypes.filter(dit => dit.description === client["docIDType"])[0].idDocumentIDType, docIDValue: client["docIDValue"], idDocIDCountry: catalog.Countries.filter(c => c.code === client["docIDCountry"])[0].idCountry, country: xCountry },tokenRequest)
      .then(r => r)
      .catch(err => { utils.logErrorMessage(logger, 'Error trying to do a GET request to API PERSONAL_PROJECT: ' + err); });
    if (getResult.data.Client !== undefined) {
      // update
      utils.logInfoMessage(logger, "Processing IdClient selected: " + getResult.data.Client.idClient);
      let jsonToUpdate = this.createUpdateRequest(catalog, client, getResult.data, fileUtils.returnFilteredList(json.Direcciones, client), fileUtils.returnFilteredList(json.Contactos, client), fileUtils.returnFilteredList(json.MetodosDeContacto, client), fileUtils.returnFilteredList(json.ActividadesEconomicas, client));
      utils.logInfoMessage(logger, 'API PERSONAL_PROJECT - Update request generated successfully for client: ' + getResult.data.Client.idClient);
      toUpdate.push(jsonToUpdate);
    }
    else {
      // insert
      let jsonToInsert = this.createInsertRequest(catalog, client, fileUtils.returnFilteredList(json.Direcciones, client), fileUtils.returnFilteredList(json.Contactos, client), fileUtils.returnFilteredList(json.MetodosDeContacto, client), fileUtils.returnFilteredList(json.ActividadesEconomicas, client));
      utils.logInfoMessage(logger, 'API PERSONAL_PROJECT - Insert request generated successfully');
      toInsert.push(jsonToInsert);
    }
  }

  utils.logInfoMessage(logger, 'All excel data were transformed in API PERSONAL_PROJECT requests: ' + toInsert.length + ' clients to insert, and ' + toUpdate.length + ' to update');
}

exports.sendInsertOrUpdateRequestToAPI = async (xCountry, apiCustomer, toInsert, inserted, toUpdate, updated) => {
  let response;
  for (let cti of toInsert) {
    let tokenPost = cache.getKey(JWT_CACHED).generateToken();
    response = await apiCustomer.post({ country: xCountry, body: cti },tokenPost)
      .then(r => r)
      .catch(err => { utils.logErrorMessage(logger, 'Error trying to do a POST request to API PERSONAL_PROJECT: ' + err); });

    inserted += this.setRequestResult(response.data);
  }

  utils.logInfoMessage(logger, 'Finished insertion process with ' + inserted + ' clientes inserted successfully and ' + (toInsert.length - inserted) + ' with errors');

  for (let ctu of toUpdate) {
    let tokenPut = cache.getKey(JWT_CACHED).generateToken();
    response = await apiCustomer.put({ country: xCountry, body: ctu },tokenPut)
      .then(r => r)
      .catch(err => { utils.logErrorMessage(logger, 'Error trying to do a PUT request to API PERSONAL_PROJECT: ' + err); });

    updated += this.setRequestResult(response.data);
  }

  utils.logInfoMessage(logger, 'Finished updating process with ' + updated + ' clientes updated successfully and ' + (toUpdate.length - updated) + ' with errors');

  return { inserted, updated };
}

exports.setRequestResult = (response) => {
  let qty = 0;
  response.statusCode !== 200 ? utils.logInfoMessage(logger, 'Request was not processed by API PERSONAL_PROJECT: ' + response.statusCode) : qty++;
  return qty;
}
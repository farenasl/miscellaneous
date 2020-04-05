const file = require('../../src/helpers/file');
const jsonExcel = setJsonFromExcelForTesting();
const clientJsonExcel = setClientFromExcelForTesting();

describe('Testing helpers layer - file', () => {
    it("File helper module is defined!", () => {
        expect(file).toBeDefined();
    });

    let expectedList = [{"cdCountry":"CL","docIDType":"RUT","docIDValue":"10000504-2","docIDCountry":"CL","addressType":"DESPACHO","address":"Mi casita 123","references":"por ahí","idGeoParent":323,"geoDesc":"CL/RM/SANTIAGO/SCL","isMain":"TRUE"}
    ,{"cdCountry":"CL","docIDType":"RUT","docIDValue":"10000504-2","docIDCountry":"CL","addressType":"Facturacion","address":"La peguita","references":"en tobalaba","idGeoParent":32333,"geoDesc":"CL/RM/SANTIAGO/PROvi","isMain":"false"}];
    it('Checking returnFilteredList function', () => {
        expect(file.returnFilteredList(jsonExcel.Direcciones, clientJsonExcel)).toEqual(expectedList);
    });
});

function setJsonFromExcelForTesting() {
    return {"Clientes":[{"cdCountry":"CL","docIDType":"RUT","docIDValue":"22227782-5","docIDCountry":"CL","names":"German","lastnames":"Ochoa Palominos","gender":"M","clientType":"Persona","status":"Activo","birthday":"1980-09-18T03:00:46.000Z","isEmployee":"TRUE"},{"cdCountry":"CL","docIDType":"RUT","docIDValue":"70227782-5","docIDCountry":"CL","names":"Wework S.A.","clientType":"Empresa","fantasyName":"WEWORK","status":"Activo"},{"cdCountry":"CL","docIDType":"RUT","docIDValue":"10000504-2","docIDCountry":"CL","names":"Fabian","lastnames":"Arenas","gender":"M","clientType":"Persona","status":"Activo","birthday":"1988-02-26T03:00:46.000Z","isEmployee":"false"}],"Contactos":[{"cdCountry":"CL","docIDType":"RUT","docIDValue":"70227782-5","docIDCountry":"CL","names":"THIAGO","lastnames":"GONZALEZ","jobTitle":"Administrador","phone":12345,"mail":"thiago@ww.com"},{"cdCountry":"CL","docIDType":"RUT","docIDValue":"10000504-2","docIDCountry":"CL","names":"Julio","lastnames":"Arenas","jobTitle":"Papa","phone":323,"mail":"flo@fla.com"},{"cdCountry":"CL","docIDType":"RUT","docIDValue":"10000504-2","docIDCountry":"CL","names":"Sofia","lastnames":"Loyola","jobTitle":"Mama","phone":232,"mail":"fla@flo.com"}],"Direcciones":[{"cdCountry":"CL","docIDType":"RUT","docIDValue":"22227782-5","docIDCountry":"CL","addressType":"Facturacion","address":"Calle 123 depto 01","references":"al lado de la bencinera","geoDesc":"CL/RM/SANTIAGO/MACUL","isMain":"TRUE"},{"cdCountry":"CL","docIDType":"RUT","docIDValue":"70227782-5","docIDCountry":"CL","addressType":"Facturacion","address":"Sanchez Fontesilla 123","idGeoParent":2,"geoDesc":"CL/RM/SANTIAGO/PROVIDENCIA","isMain":"TRUE"},{"cdCountry":"CL","docIDType":"RUT","docIDValue":"10000504-2","docIDCountry":"CL","addressType":"DESPACHO","address":"Mi casita 123","references":"por ahí","idGeoParent":323,"geoDesc":"CL/RM/SANTIAGO/SCL","isMain":"TRUE"},{"cdCountry":"CL","docIDType":"RUT","docIDValue":"10000504-2","docIDCountry":"CL","addressType":"Facturacion","address":"La peguita","references":"en tobalaba","idGeoParent":32333,"geoDesc":"CL/RM/SANTIAGO/PROvi","isMain":"false"}],"MetodosDeContacto":[{"cdCountry":"CL","docIDType":"RUT","docIDValue":"22227782-5","docIDCountry":"CL","contactMethodType":"EMAIL","value":"german.8a@gmail.com","acceptOffers":"FALSE","isMain":"TRUE"},{"cdCountry":"CL","docIDType":"RUT","docIDValue":"22227782-5","docIDCountry":"CL","contactMethodType":"CELULAR","value":84038969,"acceptOffers":"FALSE","isMain":"FALSE"},{"cdCountry":"CL","docIDType":"RUT","docIDValue":"10000504-2","docIDCountry":"CL","contactMethodType":"EMAIL","value":"lordjerhyn@gmail.com","acceptOffers":"true","isMain":"FALSE"},{"cdCountry":"CL","docIDType":"RUT","docIDValue":"10000504-2","docIDCountry":"CL","contactMethodType":"CELULAR","value":985744171,"acceptOffers":"true","isMain":"TRUE"}],"ActividadesEconomicas":[{"cdCountry":"CL","docIDType":"RUT","docIDValue":"70227782-5","docIDCountry":"CL","idEconomicActivity":11114,"isMain":"TRUE"},{"cdCountry":"CL","docIDType":"RUT","docIDValue":"10000504-2","docIDCountry":"CL","idEconomicActivity":2,"isMain":"TRUE"},{"cdCountry":"CL","docIDType":"RUT","docIDValue":"10000504-2","docIDCountry":"CL","idEconomicActivity":11114,"isMain":"false"}]};
}

function setClientFromExcelForTesting() {
    return { cdCountry: 'CL', docIDType: "RUT", docIDValue: '10000504-2', docIDCountry: 'CL'};
}
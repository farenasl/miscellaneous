/**
 * Excel reading config file
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 04-feb-2020 09:00
 */
'use strict';
const log = require('log4js').getLogger("config-excel");
const excelToJson = require('convert-excel-to-json');

exports.readExcelFile = (file) => {
    log.info('Starting Excel reading process');

    return excelToJson({
        //ToDo: move configuration to config folder
        source: file.buffer
        , sheets: 
        [
            {
                name: 'Clientes'
                , header:{
                    rows: 1
                }
                , columnToKey: {
                    A: 'cdCountry'
                    , B: 'docIDType'
                    , C: 'docIDValue'
                    , D: 'docIDCountry'
                    , E: 'names'
                    , F: 'lastnames'
                    , G: 'gender'
                    , H: 'clientType'
                    , I: 'comercialState'
                    , J: 'fantasyName'
                    , K: 'status'
                    , L: 'clientSubType'
                    , M: 'occupation'
                    , N: 'birthday'
                    , O: 'subscribed'
                    , P: 'isEmployee'
                }
            }
            , {
                name: 'Contactos'
                , header:{
                    rows: 1
                }
                , columnToKey: {
                    A: 'cdCountry'
                    , B: 'docIDType'
                    , C: 'docIDValue'
                    , D: 'docIDCountry'
                    , E: 'names'
                    , F: 'lastnames'
                    , G: 'jobTitle'
                    , H: 'phone'
                    , I: 'mail'
                }
            }
            , {
                name: 'Direcciones'
                , header:{
                    rows: 1
                }
                , columnToKey: {
                    A: 'cdCountry'
                    , B: 'docIDType'
                    , C: 'docIDValue'
                    , D: 'docIDCountry'
                    , E: 'addressType'
                    , F: 'address'
                    , G: 'references'
                    , H: 'idGeoParent'
                    , I: 'geoDesc'
                    , J: 'isMain'
                }
            }
            , {
                name: 'MetodosDeContacto'
                , header:{
                    rows: 1
                }
                , columnToKey: {
                    A: 'cdCountry'
                    , B: 'docIDType'
                    , C: 'docIDValue'
                    , D: 'docIDCountry'
                    , E: 'contactMethodType'
                    , F: 'value'
                    , G: 'acceptOffers'
                    , H: 'isMain'
                }
            }
            , {
                name: 'ActividadesEconomicas'
                , header:{
                    rows: 1
                }
                , columnToKey: {
                    A: 'cdCountry'
                    , B: 'docIDType'
                    , C: 'docIDValue'
                    , D: 'docIDCountry'
                    , E: 'idEconomicActivity'
                    , F: 'isMain'
                }
            }
        ]
    });
};
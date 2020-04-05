/**
 * *AUTHOR : DEVELOPER
 * *CREATED : 28/11/2019
 * *EMAIL : contacto@silca8.cl
 */
// ! IMPORTAMOS LIBRERIAS
const axios = require('axios');
const log = require('log4js').getLogger("helpers-requestService");
const https = require('https');
const axiosConfig = require('../config/global/axios');
const setOptions = axiosConfig({https}, log);

// ! IMPORTAMOS PROPERTIES .ENV NECESIARAS
const {API_CATALOG} = global.gConfig;

/**
 * EXPONE FUNCION PARA CONSUMIR API EXTERNA
 * ! getRequest -> Obtiene la lista del catalog
 */
module.exports = {
  getRequest: async (token) => {
    log.info(`#### INICIAMOS PETICION AL SERVICIO GET CATALOGO: ${API_CATALOG}`);
    const rstGet = await axios.get(API_CATALOG, await setOptions.setOptionsAxios(token))
                              .then(r => r)
                              .catch(err => setOptions.handleErrors(err));
    log.info(`####FIN DE LLAMADO #####`);
    return rstGet;
  }
}
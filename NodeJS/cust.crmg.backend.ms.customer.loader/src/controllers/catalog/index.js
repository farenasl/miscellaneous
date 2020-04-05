/**
 * *AUTHOR : DEVELOPER
 * *CREATED : 09/12/2019
 * *EMAIL : contacto@silca8.cl
 */
// ! INICIAMOS LOGGER
const logger = require('log4js');
const log = logger.getLogger("controller-catalog-index");

// ! IMPORTAMOS PROPERTIES
const {CATALOG_DATA,JWT_CACHED} = process.env;


// ! IMPORTAMOS HELPERS
const cacheService = require('../../helpers/cacheService');
const requestService = require('../../helpers/requestService');

/**
 * * getCatalogList
 * RELIZA LA PETICION A LA API CATALOG Y ALMACENA LOS DATOS DENTRO DEL CACHE SERVICES
 */
exports.getCatalogList = async (fnToken) => {
    var rsStatus = false;
    await requestService.getRequest(fnToken.generateToken())
        .then((res) => { if (res.status == 200) rsStatus = cacheService.setKey(CATALOG_DATA, res.data); cacheService.setKey(JWT_CACHED,fnToken)})
        .catch(function (resError) { log.error(resError); });
    return rsStatus;
};
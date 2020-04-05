/**
 * Config file for Axios requests
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-ene-2020 09:00
 */
// ! IMPORTAMOS PROPERTIES .ENV NECESIARAS
const {SSL_AXIOS, AXIOS_TIMEOUT, AGENT_KEEP_ALIVE, AGENT_KEEP_ALIVE_MSECS, X_country, X_chRef} = process.env;

/**
 * * HTTP AGENT
 * NECESARIO PARA SETEAR CONFIGURACION EXTRA AL MOMENTO DE COMUNICAR CON LA API PERSONAL_PROJECT
 * @param SSL_AXIOS habilita o deshabilita SSL 
 * @param AGENT_KEEP_ALIVE determinar si mantiene abierta la conexcion en caso de un request tarda mas de lo esperado
 * @param AGENT_KEEP_ALIVE_MSECS determinar el tiempo que debera esperar para cerrar el request, este es requerido si el AGENT_KEEP_ALIVE es TRUE
 */
const agentSSL = (https) => new https.Agent({
    rejectUnauthorized: SSL_AXIOS == 0 ? false : true,
    keepAlive: AGENT_KEEP_ALIVE == 0 ? false : true,
    keepAliveMsecs: Number(AGENT_KEEP_ALIVE_MSECS)
});

/**
 * * OPTION REQUEST
 * NECESARIO PARA SETEAR CONFIGURACION EXTRA AL MOMENTO DE COMUNICAR A LA API PERSONAL_PROJECT, SETEA EL AGENT Y HEADERS ENTRE OTROS
 */
module.exports = ({https}, log) => {
    return {
        setOptionsAxios: async (token) => {
            return {
                httpsAgent: agentSSL(https),
                timeout: Number(AXIOS_TIMEOUT),
                headers: {
                    "Authorization": `Bearer ${token}`,
                    'X-country': X_country,
                    'X-chRef': X_chRef,
                    'X-commerce': "1",
                    'X-rhsRef': "1",
                    'X-cmRef': "1",
                    'X-txRef': "1",
                    'X-prRef': "1",
                    'X-usrTx': "1"
                }
            }
        },
        handleErrors: (err) => {
            log.error(err);
            return err;
        }
    }
}
/**
 * HealthCheck method to verify if server is running
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 23-ene-2020 09:00
 */
const logger = 'controller-healthcheck-index';
const utils = require('../../helpers/utils');

const endpoints = {
    get: function(req, res, next) {
        utils.logInfoMessage(logger, 'Starting health check!');
        utils.sendCustomizedResponse(res, 200, 'Service is UP and runnig :-P')
        utils.logInfoMessage(logger, 'Ending health check!');
    }
};

module.exports = endpoints;
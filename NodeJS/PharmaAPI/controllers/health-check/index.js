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
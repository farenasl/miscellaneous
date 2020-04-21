const logger = 'controller-core-index';
const utils = require('../../helpers/utils');

const endpoints = {
    get: function(req, res, next) {
        utils.logInfoMessage(logger, 'Starting core!');
        utils.sendCustomizedResponse(res, 200, 'Service is UP and runnig :-P')
        utils.logInfoMessage(logger, 'Ending core!');
    }
};

module.exports = endpoints;
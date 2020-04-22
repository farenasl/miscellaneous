const logger = 'controller-minsal-index';
const utils = require('../../helpers/utils');
const cacheService = require('../../helpers/cacheService');
const requestService = require('../../helpers/requestService');

/**
 * * getRegionDetails
 * Make the request to the Minsal API and store data in cache services
 */
exports.getRegionDetails = async () => {
    var rsStatus = false;
    await requestService.getRequest()
        .then((res) => {
            if (res.status == 200)
                rsStatus = cacheService.setKey('CATALOG_DATA', res.data);
        })
        .catch(function (resError) { utils.logErrorMessage(logger, resError); });
    return rsStatus;
};
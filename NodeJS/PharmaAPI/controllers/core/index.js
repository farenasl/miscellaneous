const logger = 'controller-core-index';
const utils = require('../../helpers/utils');
const cache = require('../../helpers/cacheService');

const endpoints = {
    get: function(req, res, next) {
        utils.logInfoMessage(logger, 'Starting core!');

        let location = req.query.location;
        let company = req.query.company;

        utils.logInfoMessage(logger, 'Requested filters: Comuna: ' + location + ', Nombre de local: ' + company)

        // Getting cached data
        const catalog = cache.getKey('CATALOG_DATA');

        // Filtering by user-params
        var result =  catalog.filter(function(pharma) {
            return pharma.comuna_nombre === (location === undefined ? pharma.comuna_nombre : location.toUpperCase())
                && pharma.local_nombre === (company === undefined ? pharma.local_nombre : company.toUpperCase());
        });

        res.status(200).json(utils.filterResponse(result));
        utils.logInfoMessage(logger, 'Ending core!');
    }
};

module.exports = endpoints;
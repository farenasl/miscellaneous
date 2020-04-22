const logger = 'helpers-requestService';
const utils = require('./utils');
const axios = require('axios');

/**
 * Expose the function to make the request to the external API
 * getRequest -> Get the list
 */
module.exports = {
  getRequest: async () => {
    utils.logInfoMessage(logger, 'Starting catalog request')
    const rstGet = await axios.get('https://farmanet.minsal.cl/maps/index.php/ws/getLocalesRegion?id_region=7')
                              .then(r => r)
                              .catch(err => utils.logErrorMessage(logger, err));
    utils.logInfoMessage(logger, 'Ending catalog request')
    return rstGet;
  }
}
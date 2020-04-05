/**
 * Action VERBS for API PERSONAL_PROJECT interaction
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 24-ene-2020 09:00
 */
const log = require('log4js').getLogger("controller-customer-index");
const utils = require('../../helpers/customer');


const {API_CUSTOMER} = global.gConfig;

module.exports = (axios) => {
    return {
      get: async (params,token) => {
        log.info("API PERSONAL_PROJECT GetCustomerByUnique over: " + API_CUSTOMER + ", with params: " + JSON.stringify(params));
        return await axios.get(API_CUSTOMER, utils.setAPIPERSONAL_PROJECTGETUniqueHeaders(params,token))
            .then(r => { return {status, data} = r })
            .catch(err => utils.handleAxiosError(err));
      },
      post: async (params,token) => {
        log.info("API PERSONAL_PROJECT AddCustomer over: " + API_CUSTOMER + ", with params: " + JSON.stringify(params));
        return await axios.post(API_CUSTOMER, params.body, utils.setAPIPERSONAL_PROJECTHeaders(params,token))
          .then(r => { return {status, data} = r })
          .catch(err => utils.handleAxiosError(err));
      },
      put: async (params,token) => {
        log.info("API PERSONAL_PROJECT UpdateCustomer over: " + API_CUSTOMER + ", with params: " + JSON.stringify(params));
        return await axios.put(API_CUSTOMER, params.body, utils.setAPIPERSONAL_PROJECTHeaders(params,token))
          .then(r => { return {status, data} = r })
          .catch(err => utils.handleAxiosError(err));
      }
    }
};
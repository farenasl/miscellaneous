const requestService = require('../../src/helpers/requestService');
const axios = require('axios');
const log = require('log4js').getLogger("helpers-requestService");
const https = require('https');
const axiosConfig = require('../../src/config/global/axios');
const setOptions = axiosConfig({https}, log);

describe('Testing helpers layer', () => {
    it("Modules are defined!", () => {
        expect(requestService).toBeDefined();
        expect(axios).toBeDefined();
        expect(log).toBeDefined();
        expect(https).toBeDefined();
        expect(axiosConfig).toBeDefined();
        expect(setOptions).toBeDefined();
    });

    it('Checking getRequest function', async () => {
        let respGet = await requestService.getRequest();
        expect.objectContaining(respGet);
        expect(typeof respGet.status).toBe('number');
    })

    // it("Checking getRequest function with exception", async () => {
    //     const handlers = await setOptions.handleErrors("[ERROR] REQUEST_API_PERSONAL_PROJECT - Error: Request failed with status code 400");

    //     expect.objectContaining(setOptions.setOptionsAxios());
    //     expect.objectContaining(handlers);
    // })
});
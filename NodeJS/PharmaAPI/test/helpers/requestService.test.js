const requestService = require('../../helpers/requestService');
const axios = require('axios');
const https = require('https');

describe('Testing helpers layer', () => {
    it("Modules are defined!", () => {
        expect(requestService).toBeDefined();
        expect(axios).toBeDefined();
    });

    it('Checking getRequest function', async () => {
        let respGet = await requestService.getRequest();
        expect.objectContaining(respGet);
        expect(respGet).toBe(undefined);
    })

    // it("Checking getRequest function with exception", async () => {
    //     const handlers = await setOptions.handleErrors("[ERROR] REQUEST_API_BUC - Error: Request failed with status code 400");

    //     expect.objectContaining(setOptions.setOptionsAxios());
    //     expect.objectContaining(handlers);
    // })
});
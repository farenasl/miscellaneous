/**
 * @jest-environment node
 */

const requestService = require('../../helpers/requestService');
const axios = require('axios');

describe('Testing helpers layer', () => {
    it("Modules are defined!", () => {
        expect(requestService).toBeDefined();
        expect(axios).toBeDefined();
    });

    it('Checking getRequest function', async () => {
        let respGet = await requestService.getRequest();
        expect.objectContaining(respGet);
        expect(typeof respGet.status).toBe('number');
    })
});
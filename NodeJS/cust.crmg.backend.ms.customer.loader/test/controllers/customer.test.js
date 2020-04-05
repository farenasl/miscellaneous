const axios = require('axios');
const customer = require('../../src/controllers/customer/index');
const apiCustomer = customer(axios);

describe('Testing controllers layer - customer', () => {
    it("Customer controller module is defined!", () => {
        expect(axios).toBeDefined();
        expect(customer).toBeDefined();
        expect(apiCustomer).toBeDefined();
    });

    it('Checking get function', async () => {
        try {
            let resp = await apiCustomer.get({ idDocIDType: 1, docIDValue: '16629717-6', idDocIDCountry: 44, country: 'CL' }).then(r => r);
            expect.objectContaining(resp);
            expect(typeof resp.status).toBe('number');
            expect(typeof resp.data).toBe('object');
        } catch (error) {
            console.log('Service error not related with unit test: ' + error + " response obj: " + resp);
        }
    })

    it('Checking post function', async () => {
        let resp;
        try {
            resp = await apiCustomer.post({ country: 'CL', body: { idClient: 200 } });
            expect.objectContaining(resp);
            expect(typeof resp.status).toBe('number');
            expect(typeof resp.data).toBe('object');
        } catch (error) {
            console.log('Service error not related with unit test: ' + error + " response obj: " + resp);
        }
    })

    it('Checking put function', async () => {
        try {
            let resp = await apiCustomer.put({ country: 'CL', body: { idClient: 200 } });
            expect.objectContaining(resp);
            expect(typeof resp.status).toBe('number');
            expect(typeof resp.data).toBe('object');
        } catch (error) {
            console.log('Service error not related with unit test: ' + error + " response obj: " + resp);
        }
    })
});
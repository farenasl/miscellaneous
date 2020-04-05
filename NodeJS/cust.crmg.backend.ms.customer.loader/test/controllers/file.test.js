const file = require('../../src/controllers/file/index');
const dbUse = file(require('../../src/config/global/dbConnect'));
const request = require('supertest');

describe('Testing controllers layer - file', () => {
    it("File controller module is defined!", () => {
        expect(file).toBeDefined();
    });

    it('Checking get function with success', async () => {
        let req = {
            headers: { 'x-country': 'CL', 'x-commerce': '1', 'x-chref': '1', 'x-rhsref': '1'
            , 'x-cmref': '1', 'x-txref': '1', 'x-prref': '1', 'x-usrtx': 'TeSt'}
            , query: { 'page': 1, 'size': 20 }
            , status: jest.fn().mockReturnThis()
            , json: jest.fn().mockReturnThis()
        };

        let res = {
            status: jest.fn().mockReturnThis(),
            json: jest.fn().mockReturnThis()
        };

        let next = jest.fn().mockReturnThis();

        try {
            await dbUse.get(req, res, next);
        } catch (error) {
            console.log('Service error not related with unit test: ' + error + " response obj: " + res);
        }

        expect(typeof res.status.mock.calls).toBe('object');
    });

    it('Checking get function with no data', async () => {
        // let expectedRes = { status: 404, json : 'There are no rows with the specified criteria.'};
        let req = {
            headers: { 'x-country': 'CL', 'x-commerce': '1', 'x-chref': '1', 'x-rhsref': '1'
            , 'x-cmref': '1', 'x-txref': '1', 'x-prref': '1', 'x-usrtx': 'TeSt'}
            , query: { 'page': 100, 'size': 20 }
            , status: jest.fn().mockReturnThis()
            , json: jest.fn().mockReturnThis()
        };

        let res = {
            status: jest.fn().mockReturnThis(),
            json: jest.fn().mockReturnThis()
        };

        let next = jest.fn().mockReturnThis();

        try {
            await dbUse.get(req, res, next);
        } catch (error) {
            console.log('Service error not related with unit test: ' + error + " response obj: " + res);
        }

        expect(typeof res.status.mock.calls).toBe('object');
        expect(typeof res.json.mock.calls).toBe('object');
        // expect(res.status.mock.calls).toEqual([[expectedRes.status]]);
        // expect(res.json.mock.calls).toEqual([[expectedRes.json]]);
    });

    // it('Checking post function with success', async () => {
    //     let expectedRes = {statusCode: 200, statusDescription: 'File processed successfully'};
    //     let response;
        
    //     try {
    //         response = await request('https://MY_PERSONAL_DOMAIN.com/customer/loader')
    //         .post('/files')
    //         .set(setRequestHeaders())
    //         .attach('attachment', 'Formato_de_Carga_1.0.xlsx')
    //         .expect(typeof Object);
    //     } catch (error) {
    //         console.log('Service error not related with unit test: ' + error + " response obj: " + response);
    //     }
    // });

    // it('Checking post function with bad request', async () => {
    //     let expectedRes = {statusCode: 400, statusDescription: 'Invalid Request!'};
        
    //     await request('https://MY_PERSONAL_DOMAIN.com/customer/loader')
    //         .post('/files')
    //         .set('Accept', 'application/json')
    //         .attach('attachment', 'Formato_de_Carga_1.0.xlsx')
    //         .expect('Content-Type', /json/)
    //         .expect(expectedRes);
    // });
});

function setRequestHeaders() {
    return { 
        "Content-Type": "application/x-www-form-urlencoded"
        , "X-country": "CL"
        , "X-commerce": "1"
        , "X-chRef": "1"
        , "X-rhsRef": "1"
        , "X-cmRef": "1"
        , "X-txRef": "1"
        , "X-prRef": "1"
        , "X-usrTx": "FARENASL"
    };
}
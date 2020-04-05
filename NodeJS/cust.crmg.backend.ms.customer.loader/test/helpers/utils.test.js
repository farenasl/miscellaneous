const utils = require('../../src/helpers/utils');

describe('Testing helpers layer', () => {
    it("Utils helper module is defined!", () => {
        expect(utils).toBeDefined();
    });

    it('Checking returnValidBoolean function', () => {
        expect(utils.returnValidBoolean(undefined)).toEqual(false);
        expect(utils.returnValidBoolean('true')).toEqual(true);
        expect(utils.returnValidBoolean('fal')).toEqual(false);
    });

    it('Checking returnValidString function', () => {
        expect(utils.returnValidString(undefined)).toEqual('');
        expect(utils.returnValidString('')).toEqual('');
        expect(utils.returnValidString('fal')).toEqual('fal');
    });

    it('Checking returnIsEmptyString function', () => {
        expect(utils.returnIsEmptyString('')).toEqual(false);
        expect(utils.returnIsEmptyString('fal')).toEqual(true);
    });

    it('Checking setServiceStatus function', () => {
        expect(utils.setServiceStatus(500, 'holanda', 'error')).toEqual({ status: 500, message: 'error'});
        expect(utils.setServiceStatus(200, 'holanda', 'success')).toEqual({ status: 200, message: 'success'});
    });

    it('Checking validatedomainHeaders function true case', () => {
        let next = jest.fn().mockReturnThis();

        let req = {
            headers: { 'x-country': 'CL', 'x-commerce': '1', 'x-chref': '1', 'x-rhsref': '1'
            , 'x-cmref': '1', 'x-txref': '1', 'x-prref': '1', 'x-usrtx': 'TeSt'}
            , status: jest.fn().mockReturnThis()
            , json: jest.fn().mockReturnThis()
        };

        let res = {
            status: jest.fn().mockReturnThis(),
            json: jest.fn().mockReturnThis()
        };

        utils.validatedomainHeaders().request(req, res, next);

        expect(next()).toEqual(undefined);
    });

    it('Checking validatedomainHeaders function false case', () => {
        let expectedRes = { status: 400, json: {statusCode: 400, statusDescription: 'Invalid Request!'}};
        let req = {
            headers: { 'holanda': 'CL'}
            , status: jest.fn().mockReturnThis()
            , json: jest.fn().mockReturnThis()
        };

        let res = {
            status: jest.fn().mockReturnThis(),
            json: jest.fn().mockReturnThis()
        };

        let next = jest.fn().mockReturnThis();

        utils.validatedomainHeaders().request(req, res, next);

        expect(res.status.mock.calls).toEqual([[expectedRes.status]]);
        expect(res.json.mock.calls).toEqual([[expectedRes.json]]);
    });

    it('Checking validateGetHeaders function true case', () => {
        let next = jest.fn().mockReturnThis();

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

        utils.validateGetHeaders().request(req, res, next);

        expect(next()).toEqual(undefined);
    });

    it('Checking validateGetHeaders function false case', () => {
        let expectedRes = { status: 400, json: {statusCode: 400, statusDescription: 'Invalid Request!'}};
        let next = jest.fn().mockReturnThis();

        let req = {
            headers: { 'holanda': 'CL'}
            , query: { 'pagoe': 1, 'sieze': 20 }
            , status: jest.fn().mockReturnThis()
            , json: jest.fn().mockReturnThis()
        };

        let res = {
            status: jest.fn().mockReturnThis(),
            json: jest.fn().mockReturnThis()
        };

        utils.validateGetHeaders().request(req, res, next);

        expect(res.status.mock.calls).toEqual([[expectedRes.status]]);
        expect(res.json.mock.calls).toEqual([[expectedRes.json]]);
    });

    it('Checking sendCustomizedResponse function', () => {
        let expectedRes = { status: 500, json: {statusCode: 500, statusDescription: 'holanda'}};

        let res = {
            status: jest.fn().mockReturnThis()
            , json: jest.fn().mockReturnThis()
        };

        utils.sendCustomizedResponse(res, 500, 'holanda');

        expect(res.status.mock.calls).toEqual([[expectedRes.status]]);
        expect(res.json.mock.calls).toEqual([[expectedRes.json]]);
    });
});
const utils = require('../../helpers/utils');

describe('Testing helpers layer', () => {
    it("Utils helper module is defined!", () => {
        expect(utils).toBeDefined();
    });

    it('Checking validateGetHeaders function true case', () => {
        let next = jest.fn().mockReturnThis();

        let req = {
            query: { 'location': 'Recoleta', 'company': 'Cruz Verde' }
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
            query: { }
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
});
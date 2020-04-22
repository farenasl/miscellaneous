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

    it('Checking filterResponse function', () => {
        let array = [{"fecha": "22-04-2020","local_id": "534","local_nombre": "TORRES MPD","comuna_nombre": "RECOLETA",
            "localidad_nombre": "RECOLETA","local_direccion": "AVENIDA EL SALTO 2972","funcionamiento_hora_apertura": "10:30 hrs.",
            "funcionamiento_hora_cierre": "19:30 hrs.","local_telefono": "+560225053570","local_lat": "-33.3996351",
            "local_lng": "-70.62894990000001","funcionamiento_dia": "miercoles","fk_region": "7","fk_comuna": "122"}];
        let expectedRes = [{"local_nombre": "TORRES MPD","comuna_nombre": "RECOLETA","localidad_nombre": "RECOLETA",
        "local_direccion": "AVENIDA EL SALTO 2972","local_telefono": "+560225053570","local_lat": "-33.3996351",
        "local_lng": "-70.62894990000001"}];

        utils.filterResponse(array);

        expect(array).toEqual(expectedRes);
    });
});
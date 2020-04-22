const hc = require('../../controllers/health-check/index');

describe('Testing controllers layer - healthcheck', () => {
    it("HealthCheck controller module is defined!", () => {
        expect(hc).toBeDefined();
    });

    it('Checking get function', async () => {
        let res = {
            status: jest.fn().mockReturnThis(),
            json: jest.fn().mockReturnThis()
        };
        let resp = hc.get({}, res, {});
        expect.objectContaining(resp);
    })
});
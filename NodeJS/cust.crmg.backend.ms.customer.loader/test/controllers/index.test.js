const controllers = require('../../src/controllers/index');

describe('Testing controllers layer - index', () => {
    it("Index controller module is defined!", () => {
        expect(controllers).toBeDefined();
    });
});
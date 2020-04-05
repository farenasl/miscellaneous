const catalog = require('../../src/controllers/catalog/index');

const jwtFn = {
    generateToken: () => Math.random().toString(36).substring(7)
}

describe('Testing controllers layer - catalog', () => {
    it("Catalog controller module is defined!", () => {
        expect(catalog).toBeDefined();
    });

    it('Checking getCatalogList function - true', async () => {
        expect(await catalog.getCatalogList(jwtFn)).toBe(true);
    })

    it('Checking getCatalogList function - type', () => {
        expect(typeof catalog.getCatalogList(jwtFn)).toBe('object');
    })
});
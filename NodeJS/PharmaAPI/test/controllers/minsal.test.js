const minsal = require('../../controllers/minsal/index');

describe('Testing controllers layer - minsal', () => {
    it("Minsal controller module is defined!", () => {
        expect(minsal).toBeDefined();
    });

    it('Checking getRegionDetails function - false', async () => {
        expect(await minsal.getRegionDetails()).toBe(false);
    })

    it('Checking getRegionDetails function - type', () => {
        expect(typeof minsal.getRegionDetails()).toBe('object');
    })
});
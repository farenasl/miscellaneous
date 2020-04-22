
/**
 * @jest-environment node
 */

 const minsal = require('../../controllers/minsal/index');

describe('Testing controllers layer - minsal', () => {
    it("Minsal controller module is defined!", () => {
        expect(minsal).toBeDefined();
    });

    it('Checking getRegionDetails function - true', async () => {
        expect(await minsal.getRegionDetails()).toBe(true);
    })

    it('Checking getRegionDetails function - type', async () => {
        expect(typeof minsal.getRegionDetails()).toBe('object');
    })
});
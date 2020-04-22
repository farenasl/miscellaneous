const cacheService = require('../../helpers/cacheService');
const NodeCache = require("node-cache");
const serviceCache = new NodeCache({
    stdTTL: 0,
    checkperiod: 0
  });

describe('Testing helpers layer - cacheService', () => {
    it('Modules are defined!', () => {
        expect(cacheService).toBeDefined();
        expect(NodeCache).toBeDefined();
        expect(serviceCache).toBeDefined();
    });

    let key = 'demo', value = null;
    it('Checking setKey function', () => {
        expect(cacheService.setKey(key, value)).toEqual(true);
    });

    it('Checking setKey function', () => {
        var result = cacheService.getKey(key);
        expect(result).toBe(value);
    });
});
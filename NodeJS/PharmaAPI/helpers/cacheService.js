const NodeCache = require("node-cache");

// Setting default values
const serviceCache = new NodeCache({
  stdTTL: 0,
  checkperiod: 0
});

module.exports = {
  setKey: (key, value) => {
    serviceCache.set(key, value);
    return serviceCache.has(key);
  },
  getKey: (key) => serviceCache.get(key)
};
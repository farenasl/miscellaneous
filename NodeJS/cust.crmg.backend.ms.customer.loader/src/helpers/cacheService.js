/**
 * *AUTHOR : DEVELOPER
 * *CREATED : 09/12/2019
 * *EMAIL : contacto@silca8.cl
 */
// ! IMPORTAMOS LIB.
const NodeCache = require("node-cache");
//! SETEAMOS VALORS DEFAULT AL CACHE
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
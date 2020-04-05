/**
 * Util functions to work with catalog
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 31-ene-2020 09:00
 */
exports.objectExist = (catalogList, str) => {
    return catalogList.filter(cl => str && cl.description.toUpperCase() === str.toUpperCase()).length === 1 ? true : false;
}

exports.countryObjectExist = (catalogList, str) => {
    return catalogList.filter(cl => str && cl.code.toUpperCase() === str.toUpperCase()).length === 1 ? true : false;
}

exports.returnObj = (catalogList, str) => {
    return catalogList.filter(cl => str && cl.description.toUpperCase() === str.toUpperCase())[0];
}

exports.returnCountryObj = (catalogList, str) => {
    return catalogList.filter(cl => str && cl.code.toUpperCase() === str.toUpperCase())[0];
}
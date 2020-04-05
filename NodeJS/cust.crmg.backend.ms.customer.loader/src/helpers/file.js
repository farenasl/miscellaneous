/**
 * Util functions to work with files
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 24-ene-2020 09:00
 */
exports.returnFilteredList = (lst, obj) => {
    return lst.filter(e => e.cdCountry === obj["cdCountry"]
                        && e.docIDType === obj["docIDType"]
                        && e.docIDValue === obj["docIDValue"]
                        && e.docIDCountry === obj["docIDCountry"]);
}
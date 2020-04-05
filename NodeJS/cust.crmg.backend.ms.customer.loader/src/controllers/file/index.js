/**
 * Action VERBS for files API interaction
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 23-ene-2020 09:00
 */
const logger = 'controller-file-index';
const fileConfig = require('../../config/global/excel');
const dbUtils = require('../../helpers/database');
const cache = require('../../helpers/cacheService');
const utils = require('../../helpers/utils');
const cUtils = require('../../helpers/customer');
const axios = require('axios');
const customer = require('../customer');
const apiCustomer = customer(axios);
const CATALOG_DATA = process.env.CATALOG_DATA;

var multer = require('multer');
var storage = multer.memoryStorage();
var upload = multer({ storage: storage }).single('attachment');

module.exports = (pool) => {
    return {
        get: async function (req, res, next) {
            utils.logInfoMessage(logger, 'Starting get method with params: ' + JSON.stringify(req.query));
            let service = utils.setServiceStatus(200, logger, 'Success :-)');

            utils.logInfoMessage(logger, 'Starting query execution');

            await pool.query(dbUtils.generateSelectQuery(req.query))
                .then(r => {
                    service = utils.setServiceStatus(r.rowCount > 0 ? 200 : 404, logger, r.rowCount > 0 ? 'Clients found!' : 'There are no rows with the specified criteria.');
                    service.message = r.rowCount > 0 ? r.rows : service.message;
                })
                .catch(err => { service = utils.setServiceStatus(err.code === '22003' ? 400 : 500, logger, err.code === '22003' ? 'Invalid Request!' : 'Error in query execution: ' + err); });

            res.status(service.status).json(service.message);
        }
        , post: async function (req, res) {
            let toUpdate = [], toInsert = [], json;
            let service = utils.setServiceStatus(200, logger, 'File processed successfully');
            let idClientLoader = 0, inserted = 0, updated = 0;

            return await upload(req, res, async function (fileEx) {
                utils.logInfoMessage(logger, 'Starting post method for file');

                if (fileEx instanceof multer.MulterError || fileEx) {
                    // A Multer or unknown error occurred when uploading.
                    service = utils.setServiceStatus(500, logger, 'Error uploading excel file: ' + fileEx);
                }
                else {
                    try {

                        if(req.file){
                            utils.logInfoMessage(logger, 'Starting post method for file' + req.file.originalname);
                            json = fileConfig.readExcelFile(req.file);
                            utils.logInfoMessage(logger, 'A total of ' + json.Clientes.length + ' clients will be processed');
                        }else{
                           service = utils.setServiceStatus(500, logger, 'File Required');
                        }

                    } catch (error) {
                        service = utils.setServiceStatus(500, logger, 'Error parsing excel to json: ' + error);

                        await pool.query(dbUtils.generateInsertForFileExceptionQuery({ exception: error }))
                            .then(r => { idClientLoader = r.rows[0].idClientLoader; })
                            .catch(err => { service = utils.setServiceStatus(500, logger, 'Error in query execution InsertForFileException: ' + err); });
                    }

                    if (service.status === 200) {
                        await pool.query(dbUtils.generateInsertQuery({ clients: json.Clientes.length }))
                            .then(r => { idClientLoader = r.rows[0].idClientLoader; })
                            .catch(err => { service = utils.setServiceStatus(500, logger, 'Error in query execution Insert: ' + err); });

                        if (service.status === 200) {
                            const catalog = cache.getKey(CATALOG_DATA);

                            await cUtils.createInsertOrUpdateRequestBody(req.headers['x-country'], apiCustomer, json, catalog, toUpdate, toInsert);

                            ({ inserted, updated } = await cUtils.sendInsertOrUpdateRequestToAPI(req.headers['x-country'], apiCustomer, toInsert, inserted, toUpdate, updated));
                        }
                    }
                }

                if(json){
                await pool.query(dbUtils.generateUpdateQuery({idClientLoader: idClientLoader, lRows: (inserted + updated), eRows: (json.Clientes.length - (inserted + updated))}))
                    .then(r => r)
                    .catch(err => { service = utils.setServiceStatus(500, logger, 'Error in query execution UpdateForFileProcessing: ' + err); });
                }

                utils.logInfoMessage(logger, service.message);

                return utils.sendCustomizedResponse(res, service.status, service.message);
            });
        }
    }
};
/**
 * Main rounting file for different API requests
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 17-ene-2020 09:00
 */
const log = require('log4js').getLogger("routes-index");
const express = require('express');
const endpoints = require('../controllers');
const utils = require('../helpers/utils');
const router = express.Router();
const dbUse = endpoints.file(require('../config/global/dbConnect'));

log.info('Setting endpoints');

router.get('/', utils.validatedomainHeaders().request, endpoints.healthCheck.get);
router.get('/files', utils.validateGetHeaders().request, dbUse.get);
router.post('/files', utils.validatedomainHeaders().request, dbUse.post);

log.info('All endpoints were set successfully');

module.exports = router;
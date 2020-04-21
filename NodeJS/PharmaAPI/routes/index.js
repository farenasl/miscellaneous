const log = require('log4js').getLogger("routes-index");
const express = require('express');
const endpoints = require('../controllers');
const utils = require('../helpers/utils');
const router = express.Router();

log.info('Setting endpoints');

router.get('/healthcheck', endpoints.healthCheck.get);
router.get('/listBy', utils.validateGetHeaders().request, endpoints.core.get);

log.info('All endpoints were set successfully');

module.exports = router;

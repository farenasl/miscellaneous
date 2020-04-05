/**
 * Util functions with no specific use
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 31-ene-2020 09:00
 */
const log = require('log4js');

exports.returnValidBoolean = (str) => {
    return str && str.toUpperCase() === "TRUE" ? true : false;
}

exports.returnValidString = (str) => {
    return str && this.returnIsEmptyString(str) ? str : '';
}

exports.returnIsEmptyString = (str) => {
  return str !== '' ? true : false;
}

exports.setServiceStatus = (status, logger, data) => {
    status === 500 ? this.logErrorMessage(logger, data) : this.logInfoMessage(logger, data);
    return { status: status, message: data };
}

exports.logInfoMessage = (logger, msg) => {
    log.getLogger(logger).info(msg);
}

exports.logErrorMessage = (logger, msg) => {
    log.getLogger(logger).error(msg);
}

exports.validatedomainHeaders = () => {
  return {
    request: (req, res, next) => {
      if (this.hasRequireddomainHeaders(req)) {
        next();
      }
      else this.sendCustomizedResponse(res, 400, 'Invalid Request!');
    }
  }
}

exports.validateGetHeaders = () => {
  return {
    request: (req, res, next) => {
      if (this.hasRequireddomainHeaders(req)
          && req.query['page'] && !isNaN(req.query.page) && req.query.page > 0
          && req.query['size'] && !isNaN(req.query.size) && req.query.size > 0) {
        next();
      }
      else this.sendCustomizedResponse(res, 400, 'Invalid Request!');
    }
  }
}

exports.sendCustomizedResponse = (res, code, message) => {
  return res.status(code).json({ statusCode: code, statusDescription: message });
}

exports.hasRequireddomainHeaders = (req) => {
  return req.headers['x-country'] && req.headers['x-commerce'] && req.headers['x-chref'] && req.headers['x-rhsref']
    && req.headers['x-cmref'] && req.headers['x-txref'] && req.headers['x-prref'] && req.headers['x-usrtx'];
}
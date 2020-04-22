const log = require('log4js');

exports.logInfoMessage = (logger, msg) => {
    log.getLogger(logger).info(msg);
}

exports.logErrorMessage = (logger, msg) => {
    log.getLogger(logger).error(msg);
}

exports.sendCustomizedResponse = (res, code, message) => {
    return res.status(code).json({ statusCode: code, statusDescription: message });
}

exports.validateGetHeaders = () => {
    return {
        request: (req, res, next) => {
            if ((req.query['location'] && req.query.location.length > 0)
                ||  (req.query['company'] && req.query.company.length > 0)) {
            next();
            }
            else this.sendCustomizedResponse(res, 400, 'Invalid Request!');
        }
    }
}
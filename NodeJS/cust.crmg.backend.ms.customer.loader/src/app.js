/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 17-ene-2020 09:00
 */
var createError = require('http-errors');
const express = require('express');
const bodyParser = require('body-parser');
const log4js = require('log4js');
const logger = log4js.getLogger("startup");
const utils = require('./helpers/utils');

const routes = require('./routes/index');

const app = express();

app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());
app.use(log4js.connectLogger(log4js.getLogger("http"), { level: 'auto' }));

app.use('/customer/loader', routes);

// catch 404 and forward to error handler
app.use(function(req, res, next) {
  next(createError(404));
});


// error handler
app.use(function(err, req, res, next) {
  // set locals, only providing error in development
  res.locals.message = err.message;
  res.locals.error = req.app.get('env') === 'development' ? err : {};

  // render the error page
  res.status(err.status || 500);
  logger.error(err);
  utils.sendCustomizedResponse(res, res.status, 'Internal Server Error')
});

module.exports = app;
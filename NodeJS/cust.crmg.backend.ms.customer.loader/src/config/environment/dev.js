/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 23-ene-2020 09:00
 */
/**
 * Module dependencies.
 */
require('dotenv').config();

// config variables
const config = require('../global/config');

//! LOGICA JWT
const fs = require('fs')
const jwt = require('jsonwebtoken');
const jwtService= require("../global/jwt.services")
//! EXTRAEMOS SECRET JWT
//let jsonJwt =  JSON.parse(fs.readFileSync(`${__dirname}/secret.json`, 'utf8'));global.gConfig
let jsonJwt =  JSON.parse(fs.readFileSync(global.gConfig.JWT_CONFIG, 'utf8'));
const generarToken = jwtService(jwt,jsonJwt);

const {PORT, Allow_Origin} = process.env;
const app = require('../../app'); 
const http = require('http');
const catalogData = require('../../controllers/catalog/index');

/**
 * Initialise log4js config
 */
const log4js = require('log4js');
log4js.configure('./src/config/global/log4js.json');
const log = log4js.getLogger("startup");

/**
 * Get port from environment and store in Express.
 */
const port = normalizePort(PORT|| '3000');
app.set('port', port);

/**
 * Create HTTP server.
 */
const server = http.createServer(app);

/**
 * Listen on provided port, on all network interfaces.
 */
server.listen(port);
server.on('error', onError);
server.on('listening', onListening);

console.log("Starting to load API PERSONAL_PROJECT Catalog ... please wait until receive confirmation")
catalogData.getCatalogList(generarToken).then(x => {
  if (x) {
      log.info("Catalog in cache!")
      console.log("Catalog loaded. App ready to be used! :-)")
  } else {
      throw new Error("Catalog was not loaded")
      //ToDo: Load catalog from file inside of server
  }
}).catch(err => log.error(err));

/**
 * Normalize a port into a number, string, or false.
 */
function normalizePort(val) {
  let usedPort = parseInt(val, 10);

  if (isNaN(usedPort)) {
    // named pipe
    return val;
  }

  if (usedPort >= 0) {
    // port number
    return usedPort;
  }

  return false;
}

/**
 * Event listener for HTTP server "error" event.
 */
function onError(error) {
  if (error.syscall !== 'listen') {
    throw error;
  }

  const bind = typeof port === 'string'
    ? 'Pipe ' + port
    : 'Port ' + port;

  // handle specific listen errors with friendly messages
  switch (error.code) {
    case 'EACCES':
      console.error(bind + ' requires elevated privileges');
      process.exit(1);
      break;
    case 'EADDRINUSE':
      console.error(bind + ' is already in use');
      process.exit(1);
      break;
    default:
      throw error;
  }
}

/**
 * Event listener for HTTP server "listening" event.
 */
function onListening() {
  const addr = server.address();
  const bind = typeof addr === 'string'
    ? 'pipe ' + addr
    : 'port ' + addr.port;
  log.info('Listening on ' + bind);
}
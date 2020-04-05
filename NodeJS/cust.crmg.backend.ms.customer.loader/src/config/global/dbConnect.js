/**
 * DB connection config file
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 06-feb-2020 09:00
 */
const Pool = require('pg').Pool;
const pool = new Pool({
    host: process.env.DS_HOST,
    database: process.env.DS_DB,
    user: process.env.SYSTEM_DATASOURCE_USER,
    password: process.env.SYSTEM_DATASOURCE_PASSWORD,
    port: process.env.DS_PORT
});

module.exports = pool;
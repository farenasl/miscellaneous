/**
 * Util functions to work with PERSONAL_PROJECT database
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 30-ene-2020 09:00
 */
const log = require('log4js').getLogger("helpers-database");

exports.generateSelectQuery = (params) => {
    log.info('Constructing SELECT query');
    return 'SELECT '
        + 'id_client_loader as "idClientLoader", filename, status'
        + ', total_rows AS "totalRows", loaded_rows AS "loadedRows"'
        + ', error_rows AS "errorRows", exception'
        + ', created_date AS "createdDate", created_user AS "createdUser"'
        + ', modified_date AS "modifiedDate", modified_user AS "modifiedUser"'
        + ' FROM client_loader'
        + ' ORDER BY modified_date DESC'
        + ' LIMIT ' + params.size 
        + ' OFFSET ' + ((params.page - 1)*params.size);
};

exports.generateInsertQuery = (params) => {
    log.info('Constructing INSERT query');
    return 'INSERT INTO client_loader '
        + '(filename, status, total_rows, loaded_rows, error_rows, exception'
        + ', created_date, created_user, modified_date, modified_user, valid_flag) '
        + 'VALUES '
        + '(TO_CHAR(NOW(), \'yyyy_mm_dd_HH24_MI_SS\')||\'.xlsx\', \'PROCESSING\', ' + params.clients + ', 0, 0, NULL'
        + ', NOW()::TIMESTAMP, \'MASSIVE LOADER\', NOW()::TIMESTAMP, \'MASSIVE LOADER\', true) '
        + 'RETURNING id_client_loader as "idClientLoader"';
};

exports.generateInsertForFileExceptionQuery = (params) => {
    log.info('Constructing INSERT for file exception query');
    return 'INSERT INTO client_loader '
        + '(filename, status, total_rows, loaded_rows, error_rows, exception'
        + ', created_date, created_user, modified_date, modified_user, valid_flag) '
        + 'VALUES '
        + '(TO_CHAR(NOW(), \'yyyy_mm_dd_HH24_MI_SS\')||\'.xlsx\', \'ERROR\', 0, 0, 0, \'' + params.exception + '\''
        + ', NOW()::TIMESTAMP, \'MASSIVE LOADER\', NOW()::TIMESTAMP, \'MASSIVE LOADER\', true) '
        + 'RETURNING id_client_loader as "idClientLoader"';
};

exports.generateUpdateQuery = (params) => {
    log.info('Constructing UPDATE query');
    return 'UPDATE client_loader SET '
        + 'status = \'LOADED\', loaded_rows = ' + params.lRows + ', error_rows = ' + params.eRows
        + ', modified_date = NOW()::TIMESTAMP, modified_user = \'MASSIVE LOADER\' '
        + 'WHERE id_client_loader = ' + params.idClientLoader;
};
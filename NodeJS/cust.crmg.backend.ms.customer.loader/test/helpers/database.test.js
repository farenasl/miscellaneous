const db = require('../../src/helpers/database');

describe('Testing helpers layer - database', () => {
    it("Database helper module is defined!", () => {
        expect(db).toBeDefined();
    });

    let expectedQuery = setExpectedSelectQuery();
    it('Checking generateSelectQuery function', () => {
        expect(db.generateSelectQuery({ page: 1, size: 10 })).toEqual(expectedQuery);
    });

    let expectedInsertQuery = setExpectedInsertQuery();
    it('Checking generateInsertQuery function', () => {
        expect(db.generateInsertQuery({ clients: 50 })).toEqual(expectedInsertQuery);
    });

    let expectedInsertExceptionQuery = setExpectedInsertForFileExceptionQuery();
    it('Checking generateInsertForFileExceptionQuery function', () => {
        expect(db.generateInsertForFileExceptionQuery({ exception: 'TeSt' })).toEqual(expectedInsertExceptionQuery);
    });

    let expectedUpdateQuery = setExpectedUpdateQuery();
    it('Checking generateUpdateQuery function', () => {
        expect(db.generateUpdateQuery({ lRows: 10, eRows: 20, idClientLoader: 10203040 })).toEqual(expectedUpdateQuery);
    });
});

function setExpectedSelectQuery() {
    return 'SELECT '
    + 'id_client_loader as "idClientLoader", filename, status'
    + ', total_rows AS "totalRows", loaded_rows AS "loadedRows"'
    + ', error_rows AS "errorRows", exception'
    + ', created_date AS "createdDate", created_user AS "createdUser"'
    + ', modified_date AS "modifiedDate", modified_user AS "modifiedUser"'
    + ' FROM client_loader'
    + ' ORDER BY modified_date DESC'
    + ' LIMIT ' + 10 
    + ' OFFSET ' + ((1 - 1)*10);
}

function setExpectedInsertQuery() {
    return 'INSERT INTO client_loader '
        + '(filename, status, total_rows, loaded_rows, error_rows, exception'
        + ', created_date, created_user, modified_date, modified_user, valid_flag) '
        + 'VALUES '
        + '(TO_CHAR(NOW(), \'yyyy_mm_dd_HH24_MI_SS\')||\'.xlsx\', \'PROCESSING\', ' + 50 + ', 0, 0, NULL'
        + ', NOW()::TIMESTAMP, \'MASSIVE LOADER\', NOW()::TIMESTAMP, \'MASSIVE LOADER\', true) '
        + 'RETURNING id_client_loader as "idClientLoader"';
}

function setExpectedInsertForFileExceptionQuery() {
    return 'INSERT INTO client_loader '
        + '(filename, status, total_rows, loaded_rows, error_rows, exception'
        + ', created_date, created_user, modified_date, modified_user, valid_flag) '
        + 'VALUES '
        + '(TO_CHAR(NOW(), \'yyyy_mm_dd_HH24_MI_SS\')||\'.xlsx\', \'ERROR\', 0, 0, 0, \'' + 'TeSt' + '\''
        + ', NOW()::TIMESTAMP, \'MASSIVE LOADER\', NOW()::TIMESTAMP, \'MASSIVE LOADER\', true) '
        + 'RETURNING id_client_loader as "idClientLoader"';
}

function setExpectedUpdateQuery() {
    return 'UPDATE client_loader SET '
    + 'status = \'LOADED\', loaded_rows = ' + 10 + ', error_rows = ' + 20
    + ', modified_date = NOW()::TIMESTAMP, modified_user = \'MASSIVE LOADER\' '
    + 'WHERE id_client_loader = ' + 10203040;
}
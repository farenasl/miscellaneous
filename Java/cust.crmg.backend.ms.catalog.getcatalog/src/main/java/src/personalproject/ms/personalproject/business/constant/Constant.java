package src.personalproject.ms.personalproject.business.constant;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
public class Constant {
    public static final String STATUS_CODE = "statusCode";
    public static final String STATUS_DESCRIPTION = "statusDescription";
    public static final int N400 = 400;
    public static final String MESSAGE_400 = "Request not completed because request is not valid";
    public static final int N200 = 200;
    public static final String MESSAGE_200 = "Completed successfully";
    public static final int N202 = 202;
    public static final String MESSAGE_500 = "Internal Server Error";
    public static final int N500 = 500;
    public static final String MESSAGE_202 = "Request not completed because country was not found";
    public static final String START_UPDATE_SERVICE = "***** Start of Update Service *****";
    public static final String END_UPDATE_SERVICE = "***** End of Update Service *****";

    private Constant() {
        //default constructor
    }
}
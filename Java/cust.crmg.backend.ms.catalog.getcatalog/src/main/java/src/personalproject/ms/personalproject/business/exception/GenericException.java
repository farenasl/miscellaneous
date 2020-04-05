package src.personalproject.ms.personalproject.business.exception;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 28-nov-2019 09:00
 */
public class GenericException extends Exception{
    private static final long serialVersionUID = 6016642833009371710L;

    public GenericException(String message){
        super(message);
    }
}
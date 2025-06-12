namespace Trans_system.Exception;
public class ErrorOnValidationException : Trans_SystemException
{
    List<string> Error { get; set; }
    public ErrorOnValidationException(List<string> errorMessages)
    {
        Error = errorMessages;
    }
}

using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc.Filters;
using Swashbuckle.AspNetCore.Swagger;

namespace Trans_system.API.Exceptions;

public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        HandlerProjectException(context);
        ThrowUnknownError(context);
    }

    private void ThrowUnknownError(ExceptionContext context)
    {
        throw new NotImplementedException();
    }

    private void HandlerProjectException(ExceptionContext context)
    {
        throw new NotImplementedException();
    }
}

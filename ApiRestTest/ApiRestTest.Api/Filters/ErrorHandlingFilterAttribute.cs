using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ApiRestTest.Api.Filters;

public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var exception = context.Exception;

        var problemDetails = new ProblemDetails{
            Type = "https://tools.ietf.org/html/rfc7231#section-6.6.1",
            Title = "Se ha producido un error al procesar su solicitud",
            Status = (int) HttpStatusCode.InternalServerError,
            Instance = context.HttpContext.Request.Path,
            Detail = exception.Message
        };


        context.Result = new ObjectResult(problemDetails)
        {
            StatusCode = 500
        };
        context.ExceptionHandled = true;

    }
}
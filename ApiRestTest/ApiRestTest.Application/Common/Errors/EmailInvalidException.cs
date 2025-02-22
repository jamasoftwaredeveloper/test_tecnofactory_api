using System.Net;

namespace ApiRestTest.Application.Common.Errors;

public class EmailInvalidException : Exception, IServiceException
{
    public HttpStatusCode StatusCode => HttpStatusCode.Conflict;

    public string ErrorMessage => "Contraseña invalida";
}
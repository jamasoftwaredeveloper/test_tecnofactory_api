using System.Net;

namespace ApiRestTest.Application.Common.Errors;

public class DuplicateEmailException : Exception, IServiceException
{
    public HttpStatusCode StatusCode => HttpStatusCode.Conflict;

    public string ErrorMessage => "El correo no está asociado a ningún usuario registrarse";
}
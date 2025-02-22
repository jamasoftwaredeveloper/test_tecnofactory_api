using System.Net;

namespace ApiRestTest.Application.Common.Errors;

public interface IServiceException{

    public HttpStatusCode StatusCode {get;}
    public string ErrorMessage {get;}

}
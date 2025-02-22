using System.Text.Json;

namespace ApiRestTest.Api.Middleware;

public class ErrorHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }

    }

    private async Task HandleExceptionAsync(HttpContext context, Exception ex)
    {
        var code = context.Response.StatusCode = StatusCodes.Status500InternalServerError;
        var result = JsonSerializer.Serialize(new { error = "Se ha producido un error al procesar su solicitud", code });
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)code;

        await context.Response.WriteAsJsonAsync(result);
    }
}
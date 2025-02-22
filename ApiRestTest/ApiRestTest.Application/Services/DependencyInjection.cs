using ApiRestTest.Application.Services.Authentication;
using ApiRestTest.Application.Services.Authentication.Commands;
using ApiRestTest.Application.Services.Authentication.Queries;
using ApiRestTest.Application.Services.LikeComicS.Commads;
using ApiRestTest.Application.Services.LikeComicS.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace ApiRestTest.Application;

public static class DependencyInjection
{

    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthCommadService, AuthCommadService>();
        services.AddScoped<IAuthQueryService, AuthQueryService>();
        services.AddScoped<ILikeComicCommadService, LikeComicCommadService>();
        services.AddScoped<ILikeComicQueryService, LikeComicQueryService>();
        return services;
    }

}
using ApiRestTest.Api.Filters;
using ApiRestTest.Api.Middleware;
using ApiRestTest.Application;
using ApiRestTest.Infrastructure;
using Microsoft.EntityFrameworkCore;
using MyApp.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
    .AddApplication()
    .AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SqliteDatabase")))
    .AddInfrastructure(builder.Configuration);
    builder.Services.AddControllers(
       // options => options.Filters.Add<ErrorHandlingFilterAttribute>()
    );

    builder.Services.AddCors(o => o.AddPolicy("corsapp", builder =>
    {
        builder.WithOrigins("*").AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    }));

}



var app = builder.Build();
{
    // app.UseHttpsRedirection();
    // app.UseMiddleware<ErrorHandlingMiddleware>();
    app.UseExceptionHandler("/error");
    app.UseAuthentication();
    app.UseAuthorization();
    app.MapControllers();
    // Cors
    app.UseCors("corsapp");
    app.Run();
}


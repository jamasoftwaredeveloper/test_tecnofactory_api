using ApiRestTest.Application.Common.Interfaces.Services;

namespace ApiRestTest.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
using Microsoft.EntityFrameworkCore;

namespace Accounting.Api.Infrastructure;

public sealed class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
}

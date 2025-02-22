using ApiRestTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;



namespace MyApp.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<LikeComic> LikeComics { get; set; }

    /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=app.db");
            }
        }
    */
}

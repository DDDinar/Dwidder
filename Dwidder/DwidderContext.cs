using Dwidder.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dwidder;

public class DwidderContext : DbContext
{
    public DwidderContext(DbContextOptions<DwidderContext> options)
        : base(options)
    {
        Database.EnsureCreated();   // создаем базу данных при первом обращении
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
    
    public DbSet<User> Users { get; set; }
    
    public DbSet<Tweet> Tweets { get; set; }
}
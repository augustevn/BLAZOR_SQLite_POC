using Microsoft.EntityFrameworkCore;

namespace EpicPoC.Spa.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Token> Tokens { get; set; }
    public DbSet<Shopper> Shoppers { get; set; }
    
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        return await base.SaveChangesAsync(cancellationToken);
    }
}
using EpicPoC.Spa.Data.Shoppers;
using EpicPoC.Spa.Data.Tokens;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EpicPoC.Spa.Data;

public static class Extensions
{
    public static void AddSpaDataContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));
    }
    
    public static void AddSpaDataProviders(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ITokensProvider, TokensProvider>();
        services.AddScoped<IShoppersProvider, ShoppersProvider>();
    }
    
    public static void AddSpaNoOpProviders(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ITokensProvider, NoOpTokensProvider>();
        services.AddScoped<IShoppersProvider, NoOpShoppersProvider>();
    }
}
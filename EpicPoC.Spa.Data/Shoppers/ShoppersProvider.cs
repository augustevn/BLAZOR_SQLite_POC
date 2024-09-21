using Microsoft.EntityFrameworkCore;
using SqliteWasmHelper;

namespace EpicPoC.Spa.Data.Shoppers;

public record ShopperResponse(int Id, string Name, int AccountId);

public record UpsertShopperRequest
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public int AccountId { get; set; }
}

public class ShoppersProvider : IShoppersProvider
{
    private readonly ISqliteWasmDbContextFactory<ApplicationDbContext> _dbContext;
    public ShoppersProvider(ISqliteWasmDbContextFactory<ApplicationDbContext> dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<ShopperResponse>> GetShoppers()
    {
        using var ctx = await _dbContext.CreateDbContextAsync();
        
        return await ctx.Shoppers
            .Select(shopper => new ShopperResponse(shopper.Id ?? -1, shopper.Name, shopper.AccountId))
            .ToListAsync();
    }

    public async Task<bool> UpsertShopper(UpsertShopperRequest request)
    {
        var mappedShopper = new Shopper {Id = request.Id, Name = request.Name, AccountId = request.AccountId};
     
        using var ctx = await _dbContext.CreateDbContextAsync();
        
        ctx.Shoppers.Update(mappedShopper);
        await ctx.SaveChangesAsync();

        return mappedShopper.Id > 0;
    }
}
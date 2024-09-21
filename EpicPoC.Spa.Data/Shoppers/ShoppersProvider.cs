using Microsoft.EntityFrameworkCore;

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
    private readonly ApplicationDbContext _dbContext;
    public ShoppersProvider(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbContext.Database.Migrate();
    }

    public async Task<List<ShopperResponse>> GetShoppers()
    {
        return await _dbContext.Shoppers
            .Select(shopper => new ShopperResponse(shopper.Id ?? -1, shopper.Name, shopper.AccountId))
            .ToListAsync();
    }

    public async Task<bool> UpsertShopper(UpsertShopperRequest request)
    {
        var mappedShopper = new Shopper {Id = request.Id, Name = request.Name, AccountId = request.AccountId};
        
        _dbContext.Shoppers.Update(mappedShopper);
        await _dbContext.SaveChangesAsync();

        return mappedShopper.Id > 0;
    }
}
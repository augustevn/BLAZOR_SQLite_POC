namespace EpicPoC.Spa.Data.Shoppers;

public class NoOpShoppersProvider : IShoppersProvider
{
    public Task<List<ShopperResponse>> GetShoppers()
    {
        return Task.FromResult(new List<ShopperResponse>());
    }

    public Task<bool> UpsertShopper(UpsertShopperRequest request)
    {
        return Task.FromResult(false);
    }
}
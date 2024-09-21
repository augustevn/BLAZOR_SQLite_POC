namespace EpicPoC.Spa.Data.Shoppers;

public interface IShoppersProvider
{
    Task<List<ShopperResponse>> GetShoppers();
    Task<bool> UpsertShopper(UpsertShopperRequest request);
}
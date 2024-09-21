namespace EpicPoC.Spa.Data;

public record Shopper
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public int AccountId { get; set; }
}
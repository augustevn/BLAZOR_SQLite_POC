namespace EpicPoC.Spa.Data.Tokens;

public class TokensProvider : ITokensProvider
{
    private readonly ApplicationDbContext _dbContext;
    public TokensProvider(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
}
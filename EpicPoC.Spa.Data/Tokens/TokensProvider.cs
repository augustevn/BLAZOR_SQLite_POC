using SqliteWasmHelper;

namespace EpicPoC.Spa.Data.Tokens;

public class TokensProvider : ITokensProvider
{
    private readonly ISqliteWasmDbContextFactory<ApplicationDbContext> _dbContext;
    public TokensProvider(ISqliteWasmDbContextFactory<ApplicationDbContext> dbContext)
    {
        _dbContext = dbContext;
    }
    
}
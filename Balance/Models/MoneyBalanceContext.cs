using Microsoft.EntityFrameworkCore;
namespace Balance.Models
{
    public class MoneyBalanceContext : DbContext
    {
        public MoneyBalanceContext(DbContextOptions<MoneyBalanceContext> options)
            : base(options)
        { }

        
        public DbSet<MoneyBalance> MoneyBalances { get; set; } = null!;
    }


    
}

using Microsoft.EntityFrameworkCore;

namespace PersonalBuy.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> Options) : base(Options)
        {
        }
    }
}

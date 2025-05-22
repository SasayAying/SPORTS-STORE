using System.Linq;
using SPORTS_STORE.Data;

namespace SPORTS_STORE.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private SportsStoreDbContext context;

        public EFStoreRepository(SportsStoreDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
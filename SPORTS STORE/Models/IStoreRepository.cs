using System.Linq;

namespace SPORTS_STORE.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
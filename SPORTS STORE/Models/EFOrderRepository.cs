using System.Linq;
using SPORTS_STORE.Data;

namespace SPORTS_STORE.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private SportsStoreDbContext context;

        public EFOrderRepository(SportsStoreDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Order> Orders => context.Orders;

        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.Product));
            if (order.OrderID == 0)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }
    }
}
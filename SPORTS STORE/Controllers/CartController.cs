using Microsoft.AspNetCore.Mvc;
using SPORTS_STORE.Data;
using SPORTS_STORE.Models;

namespace SPORTS_STORE.Controllers
{
    public class CartController : Controller
    {
        private readonly SportsStoreDbContext _context;
        public CartController(SportsStoreDbContext context) => _context = context;

        public IActionResult Index()
        {
            var sessionId = HttpContext.Session.Id;
            var items = _context.CartItems.Include(c => c.Product).Where(c => c.SessionId == sessionId).ToList();
            return View(items);
        }

        [HttpPost]
        public IActionResult AddToCart(int productId)
        {
            var sessionId = HttpContext.Session.Id;
            var item = _context.CartItems.FirstOrDefault(c => c.ProductId == productId && c.SessionId == sessionId);
            if (item == null)
            {
                item = new CartItem { ProductId = productId, Quantity = 1, SessionId = sessionId };
                _context.CartItems.Add(item);
            }
            else
            {
                item.Quantity++;
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

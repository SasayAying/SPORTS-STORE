using Microsoft.AspNetCore.Mvc;
using SPORTS_STORE.Data;
using SPORTS_STORE.Models;

public class CheckoutController : Controller
{
    private readonly SportsStoreDbContext _context;
    public CheckoutController(SportsStoreDbContext context) => _context = context;

    public IActionResult Index() => View();

    [HttpPost]
    public IActionResult Index(Order order)
    {
        if (!ModelState.IsValid) return View(order);
        order.OrderDate = DateTime.Now;
        order.Items = _context.CartItems.Where(c => c.SessionId == HttpContext.Session.Id).ToList();
        _context.Orders.Add(order);
        _context.SaveChanges();
        return RedirectToAction("Complete");
    }

    public IActionResult Complete() => View();
}
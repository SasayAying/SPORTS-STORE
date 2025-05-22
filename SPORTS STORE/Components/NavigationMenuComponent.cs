using Microsoft.AspNetCore.Mvc;
using SPORTS_STORE.Models;

namespace SPORTS_STORE.Components
{
    public class NavigationMenuComponent : ViewComponent
    {
        private IStoreRepository repository;

        public NavigationMenuComponent(IStoreRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
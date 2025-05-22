using System.Collections.Generic;
using SPORTS_STORE.Models;

namespace SPORTS_STORE.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; } = Enumerable.Empty<Product>();
        public PagingInfo PagingInfo { get; set; } = new PagingInfo();
        public string? CurrentCategory { get; set; }
    }

    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}
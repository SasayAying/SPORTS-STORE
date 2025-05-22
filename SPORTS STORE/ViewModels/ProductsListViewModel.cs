using SPORTS_STORE.Models;

namespace SPORTS_STORE.Models.ViewModels
{
	public class ProductsListViewModel
	{
		public IEnumerable<Product> Products { get; set; }
			= Enumerable.Empty<Product>();

		public PagingInfo PagingInfo { get; set; } = new();
		public string? CurrentCategory { get; set; }
	}
}

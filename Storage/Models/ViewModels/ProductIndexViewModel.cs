using Microsoft.AspNetCore.Mvc.Rendering;

namespace Storage.Models.ViewModels
{
    public class ProductIndexViewModel
    {
        public IEnumerable<Product> Products { get; set; } = new List<Product>();
        public IEnumerable<SelectListItem> Categories { get; set; } = new List<SelectListItem>();
        public string? Name { get; set; }
        public Classification? Category { get; set; }
    }
}

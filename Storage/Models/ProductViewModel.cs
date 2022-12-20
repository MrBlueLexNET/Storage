using System.ComponentModel.DataAnnotations;
namespace Storage.Models
{
//string Name
//int Price
//int Count
//int InventoryValue
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public int Count { get; set; }
        public int InventoryValue { get; set; }

    }
}

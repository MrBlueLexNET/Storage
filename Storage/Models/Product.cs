using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    //int Id
    //string Name
    //int Price
    //DateTime Orderdate
    //string Category
    //string Shelf
    //int Count
    //string Description

    //Validation attributes
    public class Product
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [Range(0, 999)]
        public int Price { get; set; }
        [DataType(DataType.Date)]
        [Display(Name="Order date")]
        public DateTime OrderDate { get; set; }
        [Required]
        public Classification Category { get; set; }

        [StringLength(100)]
        public string Shelf { get; set; } = string.Empty;

        public int Count { get; set; }
        [StringLength(1000)] public string Description { get; set; } = string.Empty;    
       
    }
}

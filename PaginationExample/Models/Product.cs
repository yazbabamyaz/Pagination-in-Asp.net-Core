using System.ComponentModel.DataAnnotations;

namespace PaginationExample.Models
{
    public class Product
    {
        [Display(Name ="Number")]
        public int Id { get; set; }
        [Display(Name ="Product Name")]
        public string? Name { get; set; }
        [Display(Name ="Product Price")]
        public decimal Price { get; set; }
    }
}

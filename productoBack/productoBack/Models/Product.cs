namespace productoBack.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [Display(Name ="Product Name")]
        public string Name { get; set; }

        public double Price { get; set; }
    }
}
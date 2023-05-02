using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotNETCoreEFCore.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productID { get; set; }
        public string productName { get; set; }
        public string description{ get; set; }

        public float price { get; set; } 
        
        public Category Category { get; set;}
    }
}

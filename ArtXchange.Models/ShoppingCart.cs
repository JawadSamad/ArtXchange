using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ArtXchange.Models
{
    public class ShoppingCart
{
    //Setting count always to 1 that equals 1 month
    public ShoppingCart()
    {
        Count = 1;
    }
    [Key]
    public int Id { get; set; }

    public string ApplicationUserId { get; set; }
    [ForeignKey("ApplicationUserId")]
    public ApplicationUser ApplicationUser { get; set; }

    public int ProductId { get; set; }
    [ForeignKey("ProductId")]
    public Product Product { get; set; }

    [Range(1, 12, ErrorMessage = "Please enter a value between 1 and 12 months")]
    public int Count { get; set; }

    [NotMapped]
    public double Price { get; set; }
    }
}

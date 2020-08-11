using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ArtXchange.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string Artist { get; set; }
        [Required]
        [Range(1, 100000)]
        public double Price { get; set; }
        [Required]
        [Range(1, 100000)]
        public double Price3 { get; set; }
        [Required]
        [Range(1, 100000)]
        public double Price6 { get; set; }
        public string ImageUrl { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
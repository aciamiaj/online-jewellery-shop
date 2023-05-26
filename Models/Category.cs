﻿using System.ComponentModel.DataAnnotations;

namespace OnlineJewelleryShop.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Required]
        //[StringLength(4)]
        public string CategoryId { get; set; } = null!;
        //[Required]
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

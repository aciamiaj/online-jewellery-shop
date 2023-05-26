﻿using System.ComponentModel.DataAnnotations;

namespace OnlineJewelleryShop.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductDetails = new HashSet<ProductDetail>();
            ProductOrders = new HashSet<ProductOrder>();
        }

        [Required]
        [StringLength(4)]
        public string ProductId { get; set; } = null!;

        [Required]
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }

        [Required]
        //[StringLength(4)]
        public string? CategoryId { get; set; }

        [Required]
        [Range(0.1, 1000000.0, ErrorMessage = "Price must be more than 0.")]
        public decimal? Price { get; set; }

        [Required]
        //[StringLength(4)]
        public string? ProdTypeId { get; set; }

        [Required]
        public string? ImagePath { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ProductType? ProdType { get; set; }
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }

    }
}

﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CheeseAndThankYou.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        [DisplayName("Stink Rating")]
        [Range(1, 5)]
        public int StinkRating { get; set; }

        public string Description { get; set; }

        [Range(0.01, 1000.00)]
        public decimal Price { get; set; }

        public string? Image { get; set; }
        
        public string Size { get; set; }
    }
}

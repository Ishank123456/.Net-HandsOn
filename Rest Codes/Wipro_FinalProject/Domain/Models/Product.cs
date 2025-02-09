﻿using System.Text.Json.Serialization;

namespace Wipro_FinalProject.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductPrice { get; set; }
        public int CategoryId { get; set; }
        [JsonIgnore]
        public Category Category { get; set; }
    }
}

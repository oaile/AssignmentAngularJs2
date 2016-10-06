﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News.API.Models
{
    public class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string productCode { get; set; }
        public string releaseDate { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public double starRating { get; set; }
        public string imageUrl { get; set; }
        
    }
}
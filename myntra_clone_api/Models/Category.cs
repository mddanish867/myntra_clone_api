﻿using System.ComponentModel.DataAnnotations;

namespace myntra_clone_api.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string MainCategory { get; set; }
    }
}

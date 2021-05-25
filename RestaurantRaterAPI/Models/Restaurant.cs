﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantRaterAPI.Models
{
    public class Restaurant
    {
        [Key]

        public int Id { get; set; }
        
        [Required] //annotations
        public string Name { get; set; }
        
        [Required]
        public string Address { get; set; }
        
        [Required]
        public double Rating { get; set; }
        

        public bool IsRecommended => Rating > 3.5; //like opening get and putting set values //bool isRecommended = Rating > 3.5;//return isRecommended; 
    }
}
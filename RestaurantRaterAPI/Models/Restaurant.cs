using System;
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

        public virtual List<Rating> Ratings { get; set; } = new List<Rating>(); //instantiate list or new up list 
        
        public double Rating 
        {
            get
            {
                double totalAverageRating = 0;
                foreach (Rating rating in Ratings)
                {
                    totalAverageRating += rating.AverageRating;
                }
                return totalAverageRating / Ratings.Count;
            }
        }
        
        public bool IsRecommended => Rating > 8.5; //like opening get and putting set values //bool isRecommended = Rating > 3.5;//return isRecommended; 
    }
}
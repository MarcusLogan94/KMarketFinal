﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMarket.Data
{
    //defines the order class for tracking orders of a specific type of meal
    public class OrderMeal
    {

        [Key]
        public int OrderID { get; set; }

        [Required]
        public Guid OwnerID { get; set; }

        public Guid LastModifiedID { get; set; }

        [ForeignKey("Meal")]
        [Required]
        public int MealID { get; set; }
        [Required]

        public KCafeMeal Meal { get; set; }

        [Required]
        public int Quantity { get; set; }

        public double TotalPrice { get; set; }

        [Required]
        public DateTimeOffset AddedUTC { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}

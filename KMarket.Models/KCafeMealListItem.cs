﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMarket.Models
{
    public class KCafeMealListItem
    {
        public int MealID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }

        [Display(Name = "Added")]
        public DateTimeOffset AddedUTC { get; set; }

    }
}

﻿using System;
namespace OdeToFood.Data.Models
{
    public class Restaurant
    {
        public Restaurant()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using OdeToFood.Data.Models;

namespace OdeToFood.Data.Services
{
  
        public class InMemoryRestaurantData : IRestaurantData
        {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Valeria's pizza ", Cuisine = CuisineType.Italian},
                new Restaurant { Id = 2, Name = "Macciano's ", Cuisine = CuisineType.French},
                 new Restaurant { Id = 3, Name = "Patty's corner ", Cuisine = CuisineType.Indian}
            };
        }


        IEnumerable<Restaurant> IRestaurantData.GetAll()
        {
            return restaurants.OrderBy(restaurants => restaurants.Name);
        }
    }
    
}

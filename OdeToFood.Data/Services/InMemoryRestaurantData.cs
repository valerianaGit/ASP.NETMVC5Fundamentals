﻿using System;
using System.Collections.Generic;
using OdeToFood.Data.Models;

namespace OdeToFood.Data.Services
{
  
        public class InMemoryRestaurantData : IRestaurantData
        {
            public IEnumerable<Restaurant> GetAll()
            {
                throw new NotImplementedException();
            }

        IEnumerable<Restaurant> IRestaurantData.GetAll()
        {
            throw new NotImplementedException();
        }
    }
    
}

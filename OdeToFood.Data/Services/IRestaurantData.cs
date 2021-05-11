using System;
using System.Collections.Generic;
using OdeToFood.Data.Models;

namespace OdeToFood.Data.Services
{
    public interface IRestaurantData
    {
        // list of all restaurants in my data source

        IEnumerable<Restaurant> GetAll();


    }

    
}

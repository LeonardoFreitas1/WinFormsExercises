﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toDoApp
{
    class Restaurant
    {
        public long id { get; set; }
        public string restaurantName { get; set; }
        public string sloganRestaurant { get; set; }

        public Restaurant()
        {
                
        }

        public Restaurant(long id, string restaurantName, string sloganRestaurant)
        {
            this.id = id;
            this.restaurantName = restaurantName;
            this.sloganRestaurant = sloganRestaurant;
        }
    }
}

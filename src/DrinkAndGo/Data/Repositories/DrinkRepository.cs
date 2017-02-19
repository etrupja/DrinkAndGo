using DrinkAndGo.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.Data.Models;

namespace DrinkAndGo.Data.Repositories
{
    public class DrinkRepository : IDrinkRepository
    {
        public IEnumerable<Drink> Drinks
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<Drink> PreferredDrinks
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Drink GetDrinkById(int drinkId)
        {
            throw new NotImplementedException();
        }
    }
}

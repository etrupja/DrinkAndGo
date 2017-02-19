using DrinkAndGo.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.Data.Models;

namespace DrinkAndGo.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}

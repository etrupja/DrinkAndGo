using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;
using DrinkAndGo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Controllers
{
    [Route("api/[controller]")]
    public class DrinkDataController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;

        public DrinkDataController(IDrinkRepository drinkRepository)
        {
            _drinkRepository = drinkRepository;
        }

        [HttpGet]
        public IEnumerable<DrinkViewModel> LoadMoreDrinks()
        {
            IEnumerable<Drink> dbDrinks = null;

            dbDrinks = _drinkRepository.Drinks.OrderBy(p => p.DrinkId).Take(10);

            List<DrinkViewModel> drinks = new List<DrinkViewModel>();

            foreach (var dbDrink in dbDrinks)
            {
                drinks.Add(MapDbDrinkToDrinkViewModel(dbDrink));
            }
            return drinks;
        }

        private DrinkViewModel MapDbDrinkToDrinkViewModel(Drink dbDrink) => new DrinkViewModel()
        {
            DrinkId = dbDrink.DrinkId,
            Name = dbDrink.Name,
            Price = dbDrink.Price,
            ShortDescription = dbDrink.ShortDescription,
            ImageThumbnailUrl = dbDrink.ImageThumbnailUrl
        };

    }
}

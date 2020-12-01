using asp_net___car_shop.Data.Models;
using System.Collections.Generic;

namespace asp_net___car_shop.ViewModels
{
    public class CarListViewModel
    {
        public IEnumerable<Car> AllCars { get; set; }
        public string currCategory { get; set; }
    }
}
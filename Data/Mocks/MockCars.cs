using asp_net___car_shop.Data.Interface;
using asp_net___car_shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace asp_net___car_shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory carsCategory = new MockCategory();

        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car {
                        name = "Tesla Motors X",
                        shortDesc = "Экологичный и стильный",
                        longDesc = "Красивый",
                        img = "/img/electrocar.png",
                        price = 45000,
                        isFavourite = true,
                        isAvailable = true,
                        category = carsCategory.AllCategories.First() }
                };
            }
        }
        public IEnumerable<Car> FavouriteCars { get; set; }

        public Car GetObjectCar(int carId)
        {
            throw new System.NotImplementedException();
        }
    }
}
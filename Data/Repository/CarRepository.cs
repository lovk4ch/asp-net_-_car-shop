using asp_net___car_shop.Data.Interface;
using asp_net___car_shop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace asp_net___car_shop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.category);

        public IEnumerable<Car> FavouriteCars => appDBContent.Car.Where(p => p.isFavourite).Include(c => c.category);

        public Car GetObjectCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.id == carId);
    }
}
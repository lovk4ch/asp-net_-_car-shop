using asp_net___car_shop.Data.Models;
using System.Collections.Generic;

namespace asp_net___car_shop.Data.Interface
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> FavouriteCars { get; }
        Car GetObjectCar(int carId);
    }
}
using asp_net___car_shop.Data.Interface;
using asp_net___car_shop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace asp_net___car_shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars allCars, ICarsCategory allCategories)
        {
            this._allCars = allCars;
            this._allCategories = allCategories;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";

            CarListViewModel obj = new CarListViewModel();
            obj.AllCars = _allCars.Cars;
            obj.currCategory = "Автомобили";

            return View(obj);
        }
    }
}
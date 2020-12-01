using asp_net___car_shop.Data.Interface;
using asp_net___car_shop.Data.Models;
using System.Collections.Generic;

namespace asp_net___car_shop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Электромобили", desc = "Современный вид транспорта" },
                    new Category { categoryName = "Автомобили", desc = "Машины с двигателем внутреннего сгорания" }
                };
            }
        }
    }
}
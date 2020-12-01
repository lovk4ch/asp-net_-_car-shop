using asp_net___car_shop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace asp_net___car_shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Motors X",
                        shortDesc = "Экологичный и стильный",
                        longDesc = "Красивый",
                        img = "/img/electrocar.png",
                        price = 45000,
                        isFavourite = true,
                        isAvailable = true,
                        category = Categories["Электромобили"]
                    }
                );

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Электромобили", desc = "Современный вид транспорта" },
                        new Category { categoryName = "Автомобили", desc = "Машины с двигателем внутреннего сгорания" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category _category in list)
                    {
                        category.Add(_category.categoryName, _category);
                    }
                }
                return category;
            }
        }
    }
}
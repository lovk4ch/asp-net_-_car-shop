using asp_net___car_shop.Data.Interface;
using asp_net___car_shop.Data.Models;
using System.Collections.Generic;

namespace asp_net___car_shop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
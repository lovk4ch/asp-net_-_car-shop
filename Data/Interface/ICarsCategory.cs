using asp_net___car_shop.Data.Models;
using System.Collections.Generic;

namespace asp_net___car_shop.Data.Interface
{
    public interface ICarsCategory
    {
        public IEnumerable<Category> AllCategories { get; }
    }
}
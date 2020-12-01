using asp_net___car_shop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace asp_net___car_shop.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
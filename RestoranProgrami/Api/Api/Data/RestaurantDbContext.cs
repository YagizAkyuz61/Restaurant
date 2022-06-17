using Api.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Data
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
        {

        }
        public DbSet<FoodClass> FoodTable { get; set; }
        public DbSet<CategoryClass> CategoryTable { get; set; }
        public DbSet<TableClass> Tables { get; set; }
        public DbSet<OrderClass> OrderTable { get; set; }
        public DbSet<ReservationsClass> ReservationsTable { get; set; }
        public DbSet<TimeClass> TimeTable { get; set; }
        public DbSet<WaiterClass> WaiterTable { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Crud;
using Crud.Models;
namespace Crud.Data
{
    public class EntityDbContext:DbContext
    {
        public EntityDbContext(DbContextOptions<EntityDbContext> options) : base(options)
        { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=Curds;TrustServerCertificate=True;MultipleActiveResultSets=true;");
        //    base.OnConfiguring(optionsBuilder);
        //}

        public DbSet<Category> Categories { get; set; }
        public DbSet<products> Products { get; set; }
        public DbSet<stoks> Stoks { get; set; }
        public DbSet<brands> Brands { get; set; }
        public DbSet<staffs> Staffs { get; set; }
        public DbSet<stores> Stores { get; set; }
        public DbSet<order_items> Order_Items { get; set; }
        public DbSet<customers> Customers { get; set; }
        public DbSet<orders> Orders { get; set; }

    }
    

}

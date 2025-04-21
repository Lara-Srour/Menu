using Menu.Models;
using Microsoft.EntityFrameworkCore;


namespace Menu.Data
{
    public class MenuDBContext : DbContext
    {
        public MenuDBContext(DbContextOptions <MenuDBContext> options) : base(options)  
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishIngredient>().HasKey(di => new
            {
                di.DishId,
                di.IngredientId
            });

            modelBuilder.Entity<DishIngredient>().HasOne(d => d.Dish).WithMany(di => di.DishIngredients).HasForeignKey(d => d.DishId);
            modelBuilder.Entity<DishIngredient>().HasOne(i => i.Ingredient).WithMany(di => di.DishIngredients).HasForeignKey(i => i.IngredientId);

            modelBuilder.Entity<Dish>().HasData(
                new Dish { Id = 1, Name = "Marghritta", Price = 7.5, ImageUrl = "https://png.pngtree.com/png-vector/20240727/ourmid/pngtree-traditional-margherita-pizza-from-campania-png-image_13235087.png" }
             );

            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { Id = 1, Name ="Tomato Sauce"},
                new Ingredient { Id = 2, Name = "Mozarella" }
            );
            modelBuilder.Entity<DishIngredient>().HasData(
                new DishIngredient { DishId = 1, IngredientId = 1},
                new DishIngredient { DishId = 1, IngredientId = 2 }
            );


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<DishIngredient> DishIngredients { get; set; }



    }
}
    
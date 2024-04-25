using Microsoft.EntityFrameworkCore;

namespace To_do_App.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<ToDo> ToDoSet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ToDo>().HasData(
                new ToDo
                {
                    Id=1,
                    Category="Work",
                    Task = "Assignment",
                    Description = "Colledge Math  Assignment ",
                    DueDate = new DateTime(2024, 4, 15),
                    Status = "Open"

                },
                new ToDo
                {
                    Id=2,
                    Category="Shopping",
                    Task = "Buying T-Shirt",
                    Description = "Go to Shopping Next Week ",
                    DueDate = new DateTime(2024, 4, 15),
                    Status = "Open"

                },
                new ToDo
                {
                    Id=3,
                    Category="Training",
                    Task = "Exercise ",
                    Description = "Go to GYM For exercise ",
                    DueDate = new DateTime(2024, 4, 15),
                    Status = "Open"

                }
                );
        }



    }
}

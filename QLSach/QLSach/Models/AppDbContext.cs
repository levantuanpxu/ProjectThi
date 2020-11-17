using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSach.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Books> Books { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Hóa" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Toán" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Sinh" });

            modelBuilder.Entity<Books>().HasData(new Books
            {
                Id = 1, 
                Name = "Bảo Vệ Động Vật",
                NameAuthor="Le Van Luyen",
                Short_content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                Year = 2000,
                Count = 50,              
                CategoryId=1
            });
            modelBuilder.Entity<Books>().HasData(new Books
            {
                Id = 2,
                Name = "Bảo Vệ thực vật",
                NameAuthor = "Le Van A",
                Short_content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                Year = 2000,
                Count = 20,
                CategoryId =2
            });
            modelBuilder.Entity<Books>().HasData(new Books
            {
                Id = 3,
                Name = "Bảo Vệ Môi trường",
                NameAuthor = "Le Van B",
                Short_content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                Year = 2000,
                Count = 200,
                CategoryId = 3
            });


        }
    }
}

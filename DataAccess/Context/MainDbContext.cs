using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class MainDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=..\\database.db");

        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminUser>().HasData(
                new AdminUser
                {
                    UserName = "Ebruly",
                    HashedPassword =  BCrypt.Net.BCrypt.HashPassword("123"),
                }
            );

        }

    }
}

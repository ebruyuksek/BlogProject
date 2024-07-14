using Core.Entities;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace DataAccess.Context
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "database.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region CommentPostIdCascadeDeleteRestrict

            modelBuilder.Entity<Comment>()
                .HasOne(comment => comment.Post)
                .WithOne()
                .HasForeignKey<Comment>(comment => comment.PostId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Post>()
                .HasOne(post => post.PostCategory)
                .WithOne()
                .HasForeignKey<Post>(post => post.PostCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            #endregion
        }


        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
    }
}

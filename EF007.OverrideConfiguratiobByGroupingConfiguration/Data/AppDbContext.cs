using EF007.OverrideConfiguratiobByGroupingConfiguration.Data.Config;
using EF007.OverrideConfiguratiobByGroupingConfiguration.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF007.OverrideConfiguratiobByGroupingConfiguration.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Tweet> Tweets { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // individual call
            new UserConfiguration().Configure(modelBuilder.Entity<User>());
            new TweetConfiguration().Configure(modelBuilder.Entity<Tweet>());
            new CommentConfiguration().Configure(modelBuilder.Entity<Comment>());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = config.GetSection("constr").Value;

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
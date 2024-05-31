using Microsoft.EntityFrameworkCore;
using UstamYolda.Core.Aggregates.Entities;
using UstamYolda.Infastructure.Configurations;

namespace UstamYolda.Infastructure.Datas
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(){}

        public AppDbContext(DbContextOptions<AppDbContext> options){}


        public DbSet<User> Users => Set<User>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            modelBuilder.ApplyConfiguration<User>(new UserConfiguration());
        }

    }
}

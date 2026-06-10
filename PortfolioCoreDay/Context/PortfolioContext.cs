using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Context
{
    public class PortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JQG1QG1\\SQLEXPRESS;Initial Catalog=PortfolioDayDb;integrated security=true;trust server certificate=True;");
        }

        public DbSet<Education> Educations { get; set; }
        public DbSet<Experince> Experinces { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
    }
}

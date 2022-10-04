using Investex.Domain.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Investex.Infastructure.Context
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //todo: Stock prices, currencies etc will be pulled from an api!

        public DbSet<NewsArticle> NewsArticles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Video> Videos { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using WebApiDotNetCore.Models;

namespace WebApiDotNetCore.Context
{
    public class CmsContext : DbContext
    {
        public CmsContext(DbContextOptions<CmsContext> options) : base(options){}        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Noticia>().HasKey(c => c.Id);
        }

        public DbSet<Noticia> Noticias { get; set; }
    }
}
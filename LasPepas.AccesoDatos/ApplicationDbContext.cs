using LasPepas.Entidades;
using Microsoft.EntityFrameworkCore;

namespace LasPepas.AccesoDatos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Prenda> Prendas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Prenda>()
        .Property(p => p.Id)
        .ValueGeneratedNever();
        }
    }
}

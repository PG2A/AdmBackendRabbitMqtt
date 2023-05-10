using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace MicroRabbit.Transfer.Data.Context
{
    public class Nivel1DbContext : DbContext
    {
        public DbSet<Nivel1Tabla> INV_NIVEL_1 { get; set; }
        
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<NIvel1Model>().HasNoKey(); // Indica que es un tipo de entidad sin clave
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=192.168.0.70;Initial Catalog=BDADMEP;user id=BIROBID;password=IROBID20");
        }
    }
}

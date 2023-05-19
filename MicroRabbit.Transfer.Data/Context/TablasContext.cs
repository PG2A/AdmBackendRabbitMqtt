﻿using MicroRabbit.Transfer.Domain.Models.CuentasPorCobrar;
using Microsoft.EntityFrameworkCore;
using MicroRabbit.Transfer.Domain.Models;
using MicroRabbit.Transfer.Domain.Models.Inventario;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TablasContext : DbContext
    {
        public TablasContext(DbContextOptions<TablasContext> options) : base(options)
        {
        }
        public DbSet<Nivel1Tabla> INV_NIVEL_1 { get; set; }
        public DbSet<ClientesTabla> CXC_CLIENTE { get; set; }
        public DbSet<ProductosTabla> INV_PRODUCTO { get; set; }
        public DbSet<Nivel2Tabla> INV_NIVEL_2 { get; set; }
        public DbSet<Nivel3Tabla> INV_NIVEL_3 { get; set;}
        public DbSet<VenCabEgresoTabla> VEN_CABEGRESO { get; set; }
        public DbSet<VenDetEgresoTabla> VEN_DETEGRESO { get; set; }
        public DbSet<VenCabEgresoBodTabla> VEN_CABEGRESO_BOD { get; set; }


            //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //{
            //    optionsBuilder.UseSqlServer("Data Source=192.168.0.70;Initial Catalog=BDADMEP;user id=BIROBID;password=IROBID20");

        //}
        }
}

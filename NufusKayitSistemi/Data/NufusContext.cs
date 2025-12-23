using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NufusKayitSistemi.Models;

namespace NufusKayitSistemi.Data
{
    public class NufusContext : DbContext
    {
        public DbSet<Kisi> Kisiler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-TSKC1DF4\\SQLEXPRESS;Database=NufusDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}

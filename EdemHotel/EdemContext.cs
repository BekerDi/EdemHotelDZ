using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;


namespace EdemHotel
{
    internal class EdemContext:DbContext
    {
        public DbSet<Gosti> Gosti { get; set; } = null!;
        public DbSet<StatusNomera> StatusNomera { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../../../edem.db");
        }
    }
}

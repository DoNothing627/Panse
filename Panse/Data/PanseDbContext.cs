using Microsoft.EntityFrameworkCore;
using Panse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Panse.Data
{
    public class PanseDbContext: DbContext
    {
        public PanseDbContext(DbContextOptions<PanseDbContext> options) : base(options)
        {

        }

        public DbSet<Ring> Rings { get; set; }
        public DbSet<Necklace> Necklaces { get; set; }
        public DbSet<Password> Passs { get; set; }
        public DbSet<RePassword> RePasswords { get; set; }
    }
}

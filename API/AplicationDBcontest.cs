using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public class AplicationDBcontest:DbContext
    {
        public DbSet<TarjetaCredito> TarjetaCreditos { get; set; }

        public AplicationDBcontest(DbContextOptions<AplicationDBcontest> options) : base(options) {
        }
    }
}

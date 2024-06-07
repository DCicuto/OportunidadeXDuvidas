using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace APIDuvidasXOportunidades.Data
{
    public class APIDuvidasXOportunidadesContext : DbContext
    {
        public APIDuvidasXOportunidadesContext (DbContextOptions<APIDuvidasXOportunidadesContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Oportunidade> Oportunidade { get; set; } = default!;
    }
}

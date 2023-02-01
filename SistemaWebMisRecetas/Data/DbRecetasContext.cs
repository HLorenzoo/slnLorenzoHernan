using Microsoft.EntityFrameworkCore;
using SistemaWebMisRecetas.Models;
using System.Collections.Generic;

namespace SistemaWebMisRecetas.Data
{
    public class DbRecetasContext : DbContext
    {
        public DbRecetasContext(DbContextOptions<DbRecetasContext> options) : base(options) { }

        public DbSet<Receta> Recetas { get; set; }
    }
}
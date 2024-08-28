using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Data
{
    public class TiendaContext : DbContext
    {
        public TiendaContext(DbContextOptions options) : base(options)
        {
           
        }

        public DbSet<Producto> Productos { get; set; }
    }
}

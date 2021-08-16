using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotin.Data
{
    public class DotinContext : DbContext
    {
        public DotinContext(DbContextOptions<DotinContext> context):base(context)
        {

        }

        public DbSet<URL> URLs { get; set; }
    }
}

using Dotin.Core.Interfaces;
using Dotin.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotin.Core.Services
{
    public class Repository<T> : IRepository<T> where T:class
    {
        public DotinContext context;
        public DbSet<T> Entity { get; }
        public virtual IQueryable<T> Table => Entity;
        //-------------------------------
        public Repository(DotinContext context )
        {
            this.context = context;
            Entity = context.Set<T>();
        }
    }
}

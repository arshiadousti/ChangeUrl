using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotin.Core.Interfaces
{
    public interface IRepository<T> where T:class
    {
        public DbSet<T> Entity { get; }
        public IQueryable<T> Table { get;}
    }
}
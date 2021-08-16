using Dotin.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotin.Core.Interfaces
{
    public interface IRepository
    {
        Task<int> GetURL(URL url);
        Task<string> GetId(int id);
    }
}
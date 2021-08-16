using Dotin.Core.Interfaces;
using Dotin.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotin.Core.Services
{
    public class Repository : IRepository
    {
        public DotinContext context;
        //-------------------------------
        public Repository(DotinContext context)
        {
            this.context = context;
        }

        public async Task<string> GetId(int id)
        {
            URL url = await context.URLs.FindAsync(id);

            if (url is null)
            {
                return "Not Found";
            }
            else
            {
                return url.Url;
            }

        }

        public async Task<int> GetURL(URL url)
        {
            //URL uRL = new URL()
            //{
            //    Url = url.Url
            //};
            await context.AddAsync(url);
            await context.SaveChangesAsync();


            return url.Id;

        }
    }
}

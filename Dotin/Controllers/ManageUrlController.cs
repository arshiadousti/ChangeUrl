using Dotin.Core.Interfaces;
using Dotin.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotin.Controllers
{
    [Route("api/url")]
    [ApiController]
    public class ManageUrlController : ControllerBase
    {

        private IRepository repository;
        public ManageUrlController(IRepository repository)
        {
            this.repository = repository;
        }



        [HttpGet("{id:int}")]
        public async Task<IActionResult> GoTo(int id)
        {
            string url = await repository.GetId(id);

            return Redirect(url);
        }

        [HttpPost]
        public async Task<string> SendUrl(URL urls)
        {
            int id = await repository.GetURL(urls);
            return id.ToString();

        }
    }
}

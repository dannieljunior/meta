using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTwo.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiTwo.Controllers
{
    [ApiController]
    [Route("api2/Showmethecode")]
    public class ShowmethecodeController : ControllerBase
    {
        /// <summary>Retorna a url do repositório do GitHub</summary>
        /// <returns>"url do repositório no github"</returns>
        [HttpGet]
        public async Task<string> ObterUrl()
        {
            return await Task.FromResult("https://github.com/dannieljunior/meta");
        }
    }
}

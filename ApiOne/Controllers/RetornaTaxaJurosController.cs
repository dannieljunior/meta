using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiOne.Controllers
{
    [ApiController]
    [Route("api1/taxajuros")]
    public class RetornaTaxaJurosController : ControllerBase
    {
        /// <summary>
        /// obtem a taxa de juros
        /// </summary>
        [HttpGet()]
        public async Task<decimal> GetTaxaJuros()
        {
            return await Task.FromResult(0.01M);
        }
    }
}

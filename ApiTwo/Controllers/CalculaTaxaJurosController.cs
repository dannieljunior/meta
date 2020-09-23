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
    [Route("api2/calculajuros")]
    public class CalculaTaxaJurosController : ControllerBase
    {

        private readonly ICalculaTaxaJurosService _serviceCalculaTaxaJuros;
        public CalculaTaxaJurosController(ICalculaTaxaJurosService service)
        {
            _serviceCalculaTaxaJuros = service;
        }

        /// <summary>Calcula juros</summary>
        /// <param name="valorinicial">valor inicial</param>
        /// <param name="tempo">tempo, em meses"</param>
        /// <returns>"valor do juros calculado"</returns>
        [HttpGet]
        public async Task<decimal> CalculaJuros(decimal valorinicial, int tempo)
        {
            return await _serviceCalculaTaxaJuros.CalcularTaxaDeJuros(valorinicial, tempo);
        }
    }
}

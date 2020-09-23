using System;
using System.Threading.Tasks;
using ApiTwo.Contracts;

namespace ApiTwo.Services
{
    public class CalculaTaxaJurosService : ICalculaTaxaJurosService
    {
        private readonly ITaxaJuros _taxaJurosService;
        public CalculaTaxaJurosService(ITaxaJuros taxaJurosService)
        {
            _taxaJurosService = taxaJurosService;
        }
        public async Task<decimal> CalcularTaxaDeJuros(decimal valorInicial, int tempo)
        {
            var taxaJuros = await _taxaJurosService.ObterTaxaJuros();
            var jurosComposto = 1 + (double)taxaJuros;
            return (decimal)Math.Round((Math.Pow(jurosComposto, tempo) * (double)valorInicial), 2);
        }
    }
}
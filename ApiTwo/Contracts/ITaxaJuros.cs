using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTwo.Contracts
{
    public interface ITaxaJuros
    {
        [Get("/api1/taxajuros")]
        Task<decimal> ObterTaxaJuros();
    }
}

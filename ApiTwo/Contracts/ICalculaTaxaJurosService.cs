using System.Threading.Tasks;

namespace ApiTwo.Contracts
{
    public interface ICalculaTaxaJurosService
    {
        Task<decimal> CalcularTaxaDeJuros(decimal valorInicial, int tempo);
    }
}
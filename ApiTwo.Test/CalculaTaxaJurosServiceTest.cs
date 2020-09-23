using System.Threading.Tasks;
using Xunit;
using ApiTwo.Contracts;
using Moq;
using ApiTwo.Services;

namespace ApiTwo.Test
{
    public class CalculaTaxaJurosServiceTest
    {
        private readonly Mock<ITaxaJuros> _mockTaxaJuros;
        private readonly ICalculaTaxaJurosService _service;
        
        public CalculaTaxaJurosServiceTest()
        {
            _mockTaxaJuros = new Mock<ITaxaJuros>();
            _mockTaxaJuros.Setup(x => x.ObterTaxaJuros()).Returns(Task.FromResult<decimal>(0.01M));
            _service = new CalculaTaxaJurosService(_mockTaxaJuros.Object);
        }

        [Theory]
        [InlineData(100.00, 5)]
        public async Task CalculaJurosTest(decimal valorinicial, int tempo)
        {
            var resultado = await _service.CalcularTaxaDeJuros(valorinicial, tempo);
            Assert.Equal(105.10M, resultado);
        }
    }
}

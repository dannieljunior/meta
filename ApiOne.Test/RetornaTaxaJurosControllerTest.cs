using System.Reflection;
using System;
using Xunit;
using ApiOne.Controllers;

namespace ApiOne.Test
{
    public class RetornaTaxaJurosControllerTest
    {
        private readonly RetornaTaxaJurosController _controller;

        public RetornaTaxaJurosControllerTest()
        {
            _controller = new RetornaTaxaJurosController();
        }

        [Fact]
        public void GetTaxaJurosTest()
        {
            //como o requisito é fixo, vou testar o valor fixo
            var resultado = _controller.GetTaxaJuros().Result;
            Assert.Equal(0.01M, resultado);
        }
    }
}

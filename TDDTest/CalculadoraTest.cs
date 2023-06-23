using Xunit;
using TDD;
using System;

namespace TDDTest
{
    public class CalculadoraTest
    {
        [Theory]
        [InlineData(10, 2, 12)]
        [InlineData(4, 5, 9)]
        public void SomarTest(int x, int y, int result)
        {
            Calculadora calculadora = new Calculadora();
            Assert.Equal(result, calculadora.Somar(x, y));
        }

        [Fact]
        public void SubtrairTest()
        {
            Calculadora calculadora = new Calculadora();
            Assert.Equal(5, calculadora.Subtrair(7, 2));
        }

        [Fact]
        public void DividirTest()
        {
            Calculadora calculadora = new Calculadora();
            Assert.Equal(0.5, calculadora.Dividir(3, 2));
        }

        [Fact]
        public void DividirPorZeroTest()
        {
            Calculadora calculadora = new Calculadora();
            Assert.Throws<DivideByZeroException>(
                () => calculadora.Dividir(3, 0)
            );
        }

        [Fact]
        public void MultiplicarTest()
        {
            Calculadora calculadora = new Calculadora();
            Assert.Equal(10, calculadora.Multiplicar(5, 2));
        }

        [Fact]
        public void HistoricoTest()
        {
            Calculadora calculadora = new Calculadora();
            var lista = calculadora.Historico(4,6);
            Assert.NotEmpty(lista);
            Assert.Equal(4, lista.Count);
        }

    }

}

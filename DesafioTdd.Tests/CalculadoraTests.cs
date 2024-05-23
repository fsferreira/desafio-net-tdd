namespace DesafioTdd.Tests
{
    public class CalculadoraTests
    {
        Calculadora _calculadora;

        public CalculadoraTests()
        {
            _calculadora = new Calculadora();
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 2, 4)]
        [InlineData(5, 7, 12)]
        public void DeveEfetuarSoma(int valor1, int valor2, int resultadoEsperado)
        {
            // Arrange, Act
            var result = _calculadora.Somar(valor1, valor2);

            // Assert
            Assert.Equal(resultadoEsperado, result);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(2, 2, 0)]
        [InlineData(10, 7, 3)]
        public void DeveEfetuarSubtracao(int valor1, int valor2, int resultadoEsperado)
        {
            // Arrange, Act
            var result = _calculadora.Subtrair(valor1, valor2);

            // Assert
            Assert.Equal(resultadoEsperado, result);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(10, 7, 70)]
        [InlineData(2, 0, 0)]
        public void DeveEfetuarMultiplicacao(int valor1, int valor2, int resultadoEsperado)
        {
            // Arrange, Act
            var result = _calculadora.Multiplicar(valor1, valor2);

            // Assert
            Assert.Equal(resultadoEsperado, result);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(4, 2, 2)]
        [InlineData(10, 1, 10)]
        public void DeveEfetuarDivisao(int valor1, int valor2, int resultadoEsperado)
        {
            // Arrange, Act
            var resultado = _calculadora.Dividir(valor1, valor2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveEfetuarErroDivisaoPorZero()
        {
            // Arrange
            int valor1 = 2;
            int valor2 = 0;

            // Act, Assert
            Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(valor1, valor2));
        }
    }
}
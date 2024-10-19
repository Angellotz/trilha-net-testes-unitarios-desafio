using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //DONE: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
         var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);
       
        // Assert
        Assert.False(resultado);
    }

    //TODO: Corrigir a anotação [Fact]
    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        //DONE: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        
        // Act
        var listaMultiplicada = lista.Select(x => x * 2).ToList();
        // Assert
        Assert.Equal(resultadoEsperado, listaMultiplicada);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        //DONE: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var maiorNumero = 9;

        // Act
       var maiorNumeroObtido = lista.Max();
        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(maiorNumero, maiorNumeroObtido);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
         // Arrange
    var lista = new List<int> { 5, -1, -8, 9 };
    var menorNumeroEsperado = -8;

    // Act
    var resultado = _validacoes.RetornarMenorNumeroLista(lista); 

    // Assert
    Assert.Equal(menorNumeroEsperado, resultado); 
    }
}

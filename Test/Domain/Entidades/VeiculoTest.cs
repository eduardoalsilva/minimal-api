using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;



[TestClass]
public class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        // Arrange
        var veiculo = new Veiculo();

        // Act
        veiculo.Id = 1;
        veiculo.Nome = "teste";
        veiculo.Marca = "teste";
        veiculo.Ano = 1990;

        // Assert
        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("teste", veiculo.Nome);
        Assert.AreEqual("teste", veiculo.Marca);
        Assert.AreEqual(1990, veiculo.Ano);
    }
}
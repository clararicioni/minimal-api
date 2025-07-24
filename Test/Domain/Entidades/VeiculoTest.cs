using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades
{
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
            veiculo.Nome = "Passat";
            veiculo.Marca = "Volkswagen";
            veiculo.Ano = 2014;

            // Assert   
            Assert.AreEqual(1, veiculo.Id);
            Assert.AreEqual("Passat", veiculo.Nome);
            Assert.AreEqual("Volkswagen", veiculo.Marca);
            Assert.AreEqual(2014, veiculo.Ano);
        }
    }
}

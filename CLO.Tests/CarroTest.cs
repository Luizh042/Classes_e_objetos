namespace CLO.Tests;
using CLO;
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestCarro()
    {
        Carro carro = new Carro();
        carro.Marca = "Volkswagen";
        carro.Modelo = "Parati";
        carro.Ano = 2001;

        Assert.AreEqual("Volkswagen", carro.Marca);
        Assert.AreEqual("Parati",carro.Modelo);
        Assert.AreEqual(2001, carro.Ano);
    }
}
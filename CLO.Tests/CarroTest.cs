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




    [TestFixture]
    public class TestCarro1
    {
        [Test]
        public void CarroEletrico_AutonomiaBateria_Correta()
        {
            var carroEletrico = new CarroEletrico
            {
                Marca = "Tesla",
                Modelo = "Model S",
                Ano = 2020,
                AutonomiaBateria = 600
            };
            var autonomia = carroEletrico.AutonomiaBateria;
            Assert.AreEqual(600, autonomia);
        }
        [Test]
        public void CarroEsportivo_Aceleracao_Correta()
        {
            var carroEsportivo = new CarroEsportivo
            {
                Marca = "Ferrari",
                Modelo = "488 GTB",
                Ano = 2020,
            };
           carroEsportivo.AcelerarRapidamente();
           double velocidade = carroEsportivo.Velocidade;

            Assert.IsTrue(velocidade > 50);
        }
    }
}
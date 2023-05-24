namespace CLO
{
    public class Carro

    {
        public string Marca {get; set;}
        public string Modelo {get; set;}
        public int Ano {get; set;}
    }
    public class CarroEletrico : Carro
    {
        public double AutonomiaBateria {get; set; }
        public string Marca {get; set;}
        public string Modelo {get; set;}
        public int Ano {get; set;}
    }
    public class CarroEsportivo : Carro
    {
        public void AcelerarRapidamente()
        {
            Velocidade += 100;
        }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Velocidade { get; set; }
    }
}
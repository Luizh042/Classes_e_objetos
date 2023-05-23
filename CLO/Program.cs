namespace CLO
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            carro1.Marca = "Volkswagen";
            carro1.Modelo = "Parati";
            carro1.Ano = 2001;

            Carro carro2 = new Carro();
            carro2.Marca = "Fiat";
            carro2.Modelo = "Argo";
            carro2.Ano = 2017;

            Console.WriteLine($"Marca:{carro1.Marca}, Modelo: {carro1.Modelo}, Ano: {carro1.Ano}");
            Console.WriteLine($"Marca:{carro2.Marca}, Modelo: {carro2.Modelo}, Ano: {carro2.Ano}");
        }
    }
}    
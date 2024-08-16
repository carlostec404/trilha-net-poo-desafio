namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }
        

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

         // Método para exibir informações do smartphone
        public void InfoCell()
        {
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"IMEI: {Imei}");
            Console.WriteLine($"Memória: {Memoria}GB");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
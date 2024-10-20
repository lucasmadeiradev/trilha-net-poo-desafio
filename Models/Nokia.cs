namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string nome, string modelo, string imei, int memoria):base(nome, modelo, imei, memoria)
         {}
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo no dispositivo {nomeApp} no dispositivo Nokia");
        }
    }
}
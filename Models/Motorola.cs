namespace DesafioPOO.Models
{
    public class Motorola : Smartphone
    {
            public Motorola(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
            {
            }

        public override void InstalarAplicativo(string nomeApp)
            {
                Console.WriteLine($"Instalando aplicativo: {nomeApp} via PlayStore no Motorola");
            }
    }
}
public class Nokia : Smartphone
{
    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero)
    {
        Modelo = modelo;
        Imei = imei;
        Memoria = memoria;
    }

    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia");
    }
}
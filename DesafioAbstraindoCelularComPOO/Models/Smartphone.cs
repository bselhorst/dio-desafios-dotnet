public abstract class Smartphone
{
    public string Numero {get; set;}
    protected string? Modelo {get; set;}
    protected string? Imei {get; set;}
    protected int Memoria {get; set;}

    public Smartphone (string numero) 
    {
        Numero = numero;
    }

    public void Ligar ()
    {
        Console.WriteLine ("Ligando...");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine ("Recebendo ligação...");
    }

    public abstract void InstalarAplicativo(string nomeApp);

}
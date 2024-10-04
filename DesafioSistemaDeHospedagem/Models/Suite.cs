public class Suite
{
    public string TipoSuite { get; set; }
    public int Capacidade { get; set; }
    public decimal ValorDiaria { get; set; }

    public Suite(string TipoSuite, int capacidade, decimal ValorDiaria)
    {
        this.TipoSuite = TipoSuite;
        this.Capacidade = capacidade;
        this.ValorDiaria = ValorDiaria;
    }
    
}
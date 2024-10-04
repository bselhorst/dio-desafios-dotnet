public class Reserva
{
    List<Pessoa> PessoaList;
    Suite Suite;
    public int DiasReservados;

    public Reserva(int diasReservados)
    {
        this.DiasReservados = diasReservados;
        this.PessoaList = new List<Pessoa>();
        // this.Suite = new Suite("", 0, 0);
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if(hospedes.Count > Suite.Capacidade){
            throw new Exception("A suíte não comporta a capacidade de hospedes");
        }
        PessoaList.AddRange(hospedes);
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return PessoaList.Count;
    }

    public decimal CalcularValorDiaria()
    {
        
        return Suite.ValorDiaria*DiasReservados;
    }
}
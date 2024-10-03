public class Estacionamento 
{
    private decimal precoInicial = 0;
    private decimal precoHora = 0;
    private List<string> veiculos = new List<string>();

    public Estacionamento(decimal precoInicial, decimal precoHora)
    {
        this.precoInicial = precoInicial;
        this.precoHora = precoHora;
    }

    public void AdicionarVeiculo()
    {
        Console.WriteLine("\nDigite a placa do veículo para adicionar: ");
        string? placa = Console.ReadLine();
        this.veiculos.Add(placa.ToUpper());
        Console.WriteLine($"\nVeículo com a placa {placa} adicionado!");
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("\nDigite a placa do veículo para remover: ");
        string? placa = Console.ReadLine();
        Console.WriteLine("Digite a quantidade de horas que ficou estacionado: ");
        int? horas = Convert.ToInt32(Console.ReadLine());
        if (this.veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
        {
            this.veiculos.Remove(placa.ToUpper());
            Console.WriteLine($"\nVeículo com a placa {placa} removido, valor total: {this.precoInicial + (this.precoHora * (horas-1))}");
        }
        else
        {
            Console.WriteLine($"Não existe veículo com a placa {placa}");
        }
        this.veiculos.Remove(placa);
    }

    public void ListarVeiculos()
    {
        if (veiculos.Any())
        {
            Console.WriteLine("\nListando Veículos: ");
            foreach (string veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }
        else
        {
            Console.WriteLine("Não existem veículos");
        }
    }
}
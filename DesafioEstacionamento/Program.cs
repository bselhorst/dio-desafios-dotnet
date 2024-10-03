
Console.WriteLine("Qual o valor inicial?");
int valorInicial = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o valor da hora?");
int valorHora = int.Parse(Console.ReadLine());
Estacionamento estacionamento = new Estacionamento(valorInicial, valorHora);

bool flag = true;

do
{
    Console.Clear();
    Console.WriteLine("MENU: ");
    Console.WriteLine("1 - Adicionar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Encerrar");
    Console.Write("\nDIGITE UMA OPÇÃO: ");
    int opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            estacionamento.AdicionarVeiculo();
            break;
        case 2:
            estacionamento.RemoverVeiculo();
            break;
        case 3:
            estacionamento.ListarVeiculos();
            break;
        case 4:
            Console.WriteLine("Encerrando");
            flag = false;
            break;
        default:
            Console.WriteLine("Opção inexistente");
            break;
    }
    Console.WriteLine("\nAperte 'Enter' para continuar");
    Console.ReadLine();
} while (flag);

// estacionamento.AdicionarVeiculo();
// estacionamento.AdicionarVeiculo();
// estacionamento.RemoverVeiculo();
// estacionamento.ListarVeiculos();
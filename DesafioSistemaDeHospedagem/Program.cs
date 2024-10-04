List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("João", "Oliveira");
Pessoa p2 = new Pessoa("Paulo", "Pereira");

hospedes.Add(p1);   
hospedes.Add(p2);

Suite suite = new Suite("Premium", 2, 30);

Reserva reserva = new Reserva(10);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"\nHóspedes: {reserva.ObterQuantidadeHospedes()}\n");
foreach (var item in hospedes)
{
    Console.WriteLine($"{item.Nome} {item.Sobrenome}");
}
Console.WriteLine($"\nValor diária: {reserva.CalcularValorDiaria()}\n");

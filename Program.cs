using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

static void RunTest(int opcao)
{
    int numeroDeHospedes = opcao == 3 ? 4 : 2;
    int capacidade = 3;
    int diasReservados = opcao == 2 ? 10 : 5;
    
    // Cria os modelos de hóspedes e cadastra na lista de hóspedes
    List<Pessoa> hospedes = new();

    for (int i = 0; i < numeroDeHospedes; i++)
    {
        hospedes.Add(new(nome: $"Hóspede {i + 1}"));
    }

    // Cria a suíte
    Suite suite = new(tipoSuite: "Premium", capacidade, valorDiaria: 30);

    // Cria uma nova reserva, passando a suíte e os hóspedes
    Reserva reserva = new(diasReservados);
    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);

    // Exibe a quantidade de hóspedes e o valor da diária
    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
}

while (true)
{
    Console.Clear();

    Console.WriteLine("Olá. Escolha uma da opções de teste:");
    Console.WriteLine("1 - Teste de sucesso");
    Console.WriteLine("2 - Teste de sucesso (desconto)");
    Console.WriteLine("3 - Teste de falha (mais hóspedes que possível)");
    Console.WriteLine("4 - Sair");
    Console.WriteLine("Digite um dos números e aperte Enter para escolher uma opção.");

    int opcao = 0;

    while (true)
    {
        bool valido = int.TryParse(Console.ReadLine(), out opcao) && opcao >= 1 && opcao <= 4;

        if (valido) break;

        Console.WriteLine("Opção inválida! Tente novamente.");
    }

    if (opcao == 4) break;

    Console.Clear();
    
    try
    {
        RunTest(opcao);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
    }

    Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
    Console.ReadKey();
}

Console.WriteLine("Até mais.");

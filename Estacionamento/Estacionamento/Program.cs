using Estacionamento;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");

Console.WriteLine("Informe o preço inicial: ");
decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora informe o preço por hora: ");
decimal precoHora = Convert.ToDecimal(Console.ReadLine());

Controle cr = new Controle(precoInicial, precoHora);



bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();

    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            cr.AdicionarVeiculo();
            break;

        case "2":
            cr.RemoverVeiculo();
            break;

        case "3":
            cr.ListarVeiculo();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}



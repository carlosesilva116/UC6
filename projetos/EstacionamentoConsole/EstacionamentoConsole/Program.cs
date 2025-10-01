using EstacionamentoConsole.Controllers;
using EstacionamentoConsole.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddDbContext<EstacionamentoDbContext>(opt =>
            opt.UseSqlServer("Scaffold-DbContext \"Server=(localdb)\\MSSQLLocalDB;Database=EstacionamentoDB;Trusted_Connection=True;TrustServerCertificate=True;\" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models"));
    
      services.AddTransient<ClienteController>();
    })

    .Build();

var clienteController = host.Services.GetRequiredService<ClienteController>();
bool sair = false;


   

while (!sair)
{

  Console.Clear();
  Console.WriteLine("=== sistema de estacionamento ===");
  Console.WriteLine("1. Listar Clientes");
  Console.WriteLine("2. Adicionar Cliente");
  Console.WriteLine("3. (A Fazer) Gerenciar Veículos");
  Console.WriteLine("4. (A Fazer) Gerenciar Vagas");
  Console.WriteLine("5. Ver Detalhes do cliente");
  Console.WriteLine("0. Sair");

 String opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            clienteController.ListarClientes();
            break;
        case "2":
            clienteController.AdicionarCliente();
            break;
        case "3":
            Console.WriteLine(" Chamou o Gerenciar Veículos.");
            break;
        case "4":
            Console.WriteLine(" Chamou o Gerenciar Vagas.");
            break;
        case "5":
            clienteController.VerDetalhesCliente();
            break;
        case "0":
            sair = true;
            break;
        default:
            Console.WriteLine(" Opção inválida. Tente novamente.");
            Console.ReadKey(); 
            break;
    }
}

Console.WriteLine("Encerrando o sistema . Até logo!");

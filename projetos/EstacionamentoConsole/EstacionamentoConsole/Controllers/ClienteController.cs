using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstacionamentoConsole.Models;

namespace EstacionamentoConsole.Controllers
{
    internal class ClienteController
    {
        EstacionamentoDbContext _context;

        public ClienteController(EstacionamentoDbContext context)
        {
            _context = context;
        }

        public void ListarClientes()
        {
            Console.Clear();
            var clientes = _context.Clientes.ToList();

            foreach (var cliente in clientes)
            {
                Console.WriteLine($"ID: {cliente.Id}, Nome: {cliente.Nome}");
            }
            Console.WriteLine("\nPressine qualquer tecla para retornar.");
            Console.ReadKey();
        }

        public void AdicionarCliente()
        {
            Console.Clear();
            Console.WriteLine("=== Adicionar Novo Cliente ===");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("CPF: ");
            string cpf = Console.ReadLine();

            Console.WriteLine("Telefone (Opicional): ");
            string telefone = Console.ReadLine();



            Cliente c1 = new Cliente(nome, cpf, telefone);
            _context.Clientes.Add(c1);
            _context.SaveChanges();

        }

        public void VerDetalhesCliente()
        {
            Console.Clear();
            Console.WriteLine("=== Ver Detalhes do Cliente ===");
            Console.WriteLine("Dgigte o Id do cliente : ");
            var clienteId = int.Parse(Console.ReadLine());

            var cliente = _context.Clientes.FirstOrDefault(cliente => cliente.Id == clienteId);

            if (cliente == null)
                Console.WriteLine("Cliente não encontrado.");
            else
            {
                Console.WriteLine($"ID: {cliente.Id}");
                Console.WriteLine($"Nome: {cliente.Nome}");
                Console.WriteLine($"CPF: {cliente.Cpf}");
                Console.WriteLine($"Telefone: {cliente.Telefone}");
            }
            Console.WriteLine("\nPressine qualquer tecla para retornar.");
            Console.ReadKey();
        }

    }

}

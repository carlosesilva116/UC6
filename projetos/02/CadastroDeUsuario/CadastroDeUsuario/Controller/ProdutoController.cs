using CadastroDeUsuario.Data;
using CadastroDeUsuario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario.Controller
{
    internal class ProdutoController
    {
        private AppDbContext _context;
        public ProdutoController(AppDbContext context)
        {
            _context = context;
        }

        public void AdicionarProduto()
        {

            Console.Clear();
            #region Pedir_Dados
            Console.Write("Nome do Produto: ");
            string NomeProduto = Console.ReadLine();

            Console.Write("Preço do Produto: ");
            decimal PrecoProduto = decimal.Parse(Console.ReadLine());

            Console.Write("Data de Vencimento: ");
            DateOnly VencimentoProduto = DateOnly.Parse(Console.ReadLine());

            var novoProduto = new Models.Produto()
            {
                Nome = NomeProduto,
                Preco = PrecoProduto,
                Vencimento = VencimentoProduto
            };

            _context.Produtos.Add(novoProduto);
            _context.SaveChanges();
        }

    }
}

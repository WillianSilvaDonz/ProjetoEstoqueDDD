using System.Collections.Generic;
using System.Linq;
using ProjetoEstoqueDDD.Domain.Entidades;
using ProjetoEstoqueDDD.Domain.Interfaces;

namespace ProjetoEstoqueDDD.Infra.Data.Repositorios
{
    public class EstoqueRepositorio : RepositorioBase<Estoque>, IEstoqueRepositorio
    {
        public int QuantidadeEstoque(int produto)
        {
            var dataEstoque = Db.Estoque.Where(p => p.ProdutoId == produto);
            int totalestoque = 0;
            foreach (var dataest in dataEstoque)
            {
                if (dataest.Type == "+")
                {
                    totalestoque = totalestoque + dataest.Quantidade;
                }
                if (dataest.Type == "-")
                {
                    totalestoque = totalestoque - dataest.Quantidade;
                }
            }
            return totalestoque;
        }
    }
}

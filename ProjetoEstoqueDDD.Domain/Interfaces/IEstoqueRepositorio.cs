using ProjetoEstoqueDDD.Domain.Entidades;
using System.Collections.Generic;

namespace ProjetoEstoqueDDD.Domain.Interfaces
{
    public interface IEstoqueRepositorio : IRepositorioBase<Estoque>
    {
        int QuantidadeEstoque(int produto);
    }
}

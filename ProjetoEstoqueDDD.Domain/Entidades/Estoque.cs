using System;

namespace ProjetoEstoqueDDD.Domain.Entidades
{
    public class Estoque
    {
        public int EstoqueId    { get; set; }
        public int Quantidade   { get; set; }
        public string Type        { get; set; }
        public DateTime Date_Criado { get; set; }
        public int ProdutoId { get; set; }

        public virtual Produto Produto { get; set; }
    }
}

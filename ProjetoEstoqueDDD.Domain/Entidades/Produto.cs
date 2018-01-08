
using System;
using System.Collections.Generic;

namespace ProjetoEstoqueDDD.Domain.Entidades
{
    public class Produto
    {
        public int ProdutoId    { get; set; }
        public string Nome      { get; set; }
        public double Valor     { get; set; }
        public DateTime Date_Criado { get; set; }
        public DateTime Date_Alterado { get; set; }
        public bool Ativo       { get; set; }
        public int Quantidade { get; set; }

        public IEnumerable<Estoque> Estoque { get; set; }

    }   
}

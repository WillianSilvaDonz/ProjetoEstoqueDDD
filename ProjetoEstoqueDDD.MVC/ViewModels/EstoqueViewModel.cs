using System;

namespace ProjetoEstoqueDDD.MVC.ViewModels
{
    public class EstoqueViewModel
    {
        public int EstoqueId { get; set; }
        public int Quantidade { get; set; }
        public string Type { get; set; }
        public DateTime Date_Criado { get; set; }
        public int ProdutoId { get; set; }

        public virtual ProdutoViewModel Produto { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoEstoqueDDD.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }
        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Preencha o campo valor")]
        [Range(typeof(decimal),"0","999999999999")]
        public double Valor { get; set; }
        [ScaffoldColumn(false)]
        public DateTime Date_Criado { get; set; }
        [ScaffoldColumn(false)]
        public DateTime Date_Alterado { get; set; }
        public bool Ativo { get; set; }
        public int Quantidade { get; set; }

        public IEnumerable<EstoqueViewModel> Estoque { get; set; }
    }
}
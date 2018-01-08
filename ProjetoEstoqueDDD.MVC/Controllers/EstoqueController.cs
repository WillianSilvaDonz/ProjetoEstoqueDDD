using AutoMapper;
using ProjetoEstoqueDDD.Domain.Entidades;
using ProjetoEstoqueDDD.Infra.Data.Repositorios;
using ProjetoEstoqueDDD.MVC.ViewModels;
using System.Web.Mvc;

namespace ProjetoEstoqueDDD.MVC.Controllers
{
    public class EstoqueController : Controller
    {
        private readonly EstoqueRepositorio _estoqueRepositorio = new EstoqueRepositorio();

        // GET: Produto/Details/5
        public string ModificarEstoque(string type, int produtoid)
        {
            EstoqueViewModel estoqueGravar = new EstoqueViewModel();
            estoqueGravar.ProdutoId = produtoid;
            estoqueGravar.Quantidade = 1;
            estoqueGravar.Type = type;
            var estoqueDomain = Mapper.Map<EstoqueViewModel, Estoque>(estoqueGravar);
            _estoqueRepositorio.Add(estoqueDomain);

            //Poderia usa metodo do repositorio no Infra.data do estoque para pega as informações de estoque.

            return "Atualizado com Sucesso"; //poderia retorna em formato json.
        }
    }
}

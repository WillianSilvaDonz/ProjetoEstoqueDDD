using AutoMapper;
using ProjetoEstoqueDDD.Domain.Entidades;
using ProjetoEstoqueDDD.MVC.ViewModels;

namespace ProjetoEstoqueDDD.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.CreateMap<ProdutoViewModel, Produto>();
                //x.CreateMap<EstoqueViewModel, Estoque>();
                //x.CreateMap<Estoque, EstoqueViewModel>();
                x.CreateMap<Produto, ProdutoViewModel>();
            });
        }
    }
}
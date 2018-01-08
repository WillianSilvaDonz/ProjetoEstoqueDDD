namespace ProjetoEstoqueDDD.Infra.Data.Migrations
{
    using ProjetoEstoqueDDD.Domain.Entidades;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Contexto.ProjetoEstoqueContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Contexto.ProjetoEstoqueContexto context)
        {
            IList<Produto> produtodata = new List<Produto>();
            produtodata.Add(new Produto() { Nome = "Willian na Questor", Date_Criado = DateTime.Now, Date_Alterado = DateTime.Now, Ativo = true, Valor = 1000, Quantidade = 0 });
            produtodata.Add(new Produto() { Nome = "Willian na Questor 2018", Date_Criado = DateTime.Now, Date_Alterado = DateTime.Now, Ativo = true, Valor = 1000, Quantidade = 0 });
            produtodata.Add(new Produto() { Nome = "Questor Contrata Williar", Date_Criado = DateTime.Now, Date_Alterado = DateTime.Now, Ativo = true, Valor = 1000, Quantidade = 0 });

            foreach(Produto ptd in produtodata)
                context.Produtos.Add(ptd);

            base.Seed(context);
        }
    }
}


using ProjetoEstoqueDDD.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoEstoqueDDD.Infra.Data.EntityConfig
{
    public class ProdutoConfiguracao : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguracao()
        {
            HasKey(c => c.ProdutoId);

            Property(c => c.Nome).IsRequired().HasMaxLength(100);
        }
    }
}

using ProjetoEstoqueDDD.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoEstoqueDDD.Infra.Data.EntityConfig
{
    public class EstoqueConfiguracao : EntityTypeConfiguration<Estoque>
    {
        public EstoqueConfiguracao()
        {
            HasKey(p => p.EstoqueId);

            Property(p => p.Type).IsRequired().HasMaxLength(1);

            HasRequired(p => p.Produto).WithMany().HasForeignKey(p => p.ProdutoId);
        }
    }
}

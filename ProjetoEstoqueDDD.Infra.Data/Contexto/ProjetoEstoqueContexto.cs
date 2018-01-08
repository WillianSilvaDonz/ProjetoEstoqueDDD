using ProjetoEstoqueDDD.Domain.Entidades;
using ProjetoEstoqueDDD.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace ProjetoEstoqueDDD.Infra.Data.Contexto
{
    public class ProjetoEstoqueContexto : DbContext {
        public ProjetoEstoqueContexto() : base("ProjetoEstoqueDDD"){}

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public object Produto { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(255));

            modelBuilder.Configurations.Add(new ProdutoConfiguracao());
            modelBuilder.Configurations.Add(new EstoqueConfiguracao());
        }

        public override int SaveChanges()
        {
            foreach(var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Date_Criado") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("Date_Criado").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("Date_Alterado").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}

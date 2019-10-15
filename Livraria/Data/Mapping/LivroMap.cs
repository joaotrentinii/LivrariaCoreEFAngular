using Livraria.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livraria.Data.Mapping
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builderLivro)
        {
            builderLivro.Property(l => l.LivroId)
                .HasColumnName("LivroId")
                .UseSqlServerIdentityColumn();
            builderLivro.Property(l => l.Titulo)
                .HasColumnType("varchar(80)")
                .HasMaxLength(80)
                .IsRequired();
            builderLivro.Property(l => l.NomeDoAutor)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();
            builderLivro.Property(l => l.DataDaPublicacao)
                .IsRequired();
            builderLivro.Property(l => l.QuantidadePaginas)
                .IsRequired();            
        }
    }
}

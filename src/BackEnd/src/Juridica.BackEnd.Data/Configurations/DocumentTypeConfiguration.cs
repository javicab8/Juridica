using Juridica.BackEnd.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Juridica.BackEnd.Data.Configurations
{
    public class DocumentTypeConfiguration : IEntityTypeConfiguration<DocumentType>
    {
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {
            builder
                .HasKey(dt => dt.Id);
            builder
                .Property(dt => dt.Id)
                .UseIdentityColumn();
            builder
                .Property(dt => dt.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(dt => dt.Process)
                .IsRequired()
                .HasMaxLength(45);
            builder
                .Property(dt => dt.Subdocument);
            builder
                .Property(dt => dt.ControlMedium);
            builder
                .ToTable("document_types");
        }
    }
}
using Juridica.BackEnd.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Juridica.BackEnd.Data.Configurations
{
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder
                .HasKey(d => d.Id);
            builder
                .Property(d => d.Id)
                .UseIdentityColumn();
            builder
                .Property(d => d.Settlement)
                .IsRequired()
                .HasMaxLength(10);
            builder
                .Property(d => d.Date)
                .IsRequired();
            builder
                .Property(d => d.Applicant);
            builder
                .HasOne(d => d.DocumentType)
                .WithMany(dt => dt.Documents)
                .HasForeignKey(d => d.DocumentTypeId);
            builder
                .ToTable("documents");
        }
    }
}
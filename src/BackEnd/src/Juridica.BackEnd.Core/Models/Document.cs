using System;

namespace Juridica.BackEnd.Core.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Settlement { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Applicant { get; set; }
        public int DocumentTypeId { get; set; }
        public DocumentType DocumentType { get; set; }
    }
}
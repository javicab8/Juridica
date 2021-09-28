using System;

namespace Juridica.BackEnd.Core.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Settlement { get; set; }
        public DateTime Date { get; set; }
        public string Applicant { get; set; }
        public DocumentType DocumentType { get; set; }
    }
}
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Juridica.BackEnd.Core.Models
{
    public class DocumentType
    {
        public DocumentType()
        {
            Documents = new Collection<Document>();
        }
        public int Id { get; set; }
        public string Process { get; set; }
        public string Name { get; set; }
        public string Subdocument { get; set; }
        public string ControlMedium { get; set; }
        public ICollection<Document> Documents { get; set; }
    }
}
namespace Juridica.BackEnd.Core.Models
{
    public class DocumentType
    {
        public int Id { get; set; }
        public string Process { get; set; }
        public string Name { get; set; }
        public string Subdocument { get; set; }
        public string ControlMedium { get; set; }
    }
}
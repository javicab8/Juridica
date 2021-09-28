namespace Juridica.BackEnd.Core.Models
{
    public class ExtrajudicialDefense
    {
        public int Id { get; set; }
        public string Issue { get; set; }
        public string Amount { get; set; }
        public string Representative { get; set; }
        public string Convene { get; set; }
        public Document Document {get; set; }
        public Dependency Dependency { get; set; }
        public string Attendant { get; set; }
    }
}
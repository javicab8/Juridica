namespace Juridica.BackEnd.Core.Models
{
    public class CommitteMinutes
    {
        public int Id { get; set; }
        public string Issue { get; set; }
        public Document Document { get; set; }        
    }
}
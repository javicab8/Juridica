namespace Juridica.BackEnd.Core.Models
{
    public class JudicialDefense
    {
        public int Id { get; set; }
        public string Issue { get; set; }
        public string Amount { get; set; }
        public string Representative { get; set; }
        public string Convene { get; set; }
        public string RiskLevel { get; set; }
        public string Attendant { get; set; }
        public string OfficeKnowledge { get; set; }
        public Document Document { get; set; }
        
    }
}
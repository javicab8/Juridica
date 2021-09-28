namespace Juridica.BackEnd.Core.Models
{
    public class Attach
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public LegalAdviceAndSupport LegalAdviceAndSupport { get; set; }
    }
}
using System;

namespace Juridica.BackEnd.Core.Models
{
    public class Action
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Observations { get; set; }
        public ActionType ActionType { get; set; }
        public Document Document { get; set;}
    }

}
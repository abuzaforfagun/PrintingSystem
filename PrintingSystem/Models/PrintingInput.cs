using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrintingSystem.Models
{
    public class PrintingInput
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public int PrinterQuantity { get; set; }
        public int PhotocopyQuantity { get; set; }
        public string Purpose { get; set; }
        public DateTime Date { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppDesign
{
    public class Expense
    {
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
    }
}

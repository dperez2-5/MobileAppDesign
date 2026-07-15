using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppDesign
{
    public static class AppData
    {
        // These static variables live for the entire lifecycle of the app
        public static string Username { get; set; } = "User";
        public static double TotalAllowance { get; set; } = 0;
        public static double TotalExpenses { get; set; } = 0;
        public static double CurrentBalance { get; set; } = 0;
    }
}

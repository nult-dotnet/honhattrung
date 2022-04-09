using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsilbilityPrinciple
{
    internal class ErrorManagemnet
    {
        //This is where to manage error
        public void logError(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

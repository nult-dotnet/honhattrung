using System;

namespace OpenClosedPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle[] rec;
            AreaCalculator areaCal=new AreaCalculator();
            rec =new Rectangle[1];
            
            
           
            Console.WriteLine("The total of area is {0}", areaCal.TotalArea(rec));
            Console.ReadKey();
        
        }
    }
}

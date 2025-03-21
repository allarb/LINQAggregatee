using System;
using System.Linq;

namespace LINQAggregate
{
    public class Program
    {
        public static void Main()
        
        {
            string commaSeparatedCarBrands = AutoList.auto
                .Select(auto => auto.Name)
                .Aggregate("Auto margid: ", (str, name) => str + name + ", "); 

            Console.WriteLine(commaSeparatedCarBrands);
        }
    }
}

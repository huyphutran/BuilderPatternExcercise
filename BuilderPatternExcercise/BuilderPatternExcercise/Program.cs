using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExcercise
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var pc = new PCBuilder()
                            .GetCpu("Intel Core i9-12900KS ( Turbo 5.50 GHz, 16C/24T)\r\n\r\n")
                            .GetRam("32GB/DDR5/5200\r\n\r\n")
                            .GetVga("RTX 4060 Ti 8G Dual Fan DDR6\r\n\r\n")
                            .GetMain("MSI Z790 LGA 1700 Wifi DDR5\r\n\r\n")
                            .Build();
            Console.WriteLine(pc);

        }
    }
}

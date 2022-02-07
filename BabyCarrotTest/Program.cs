using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BabyCarrot.Tools;

namespace BabyCarrotTest
{
   class Program
    {
        static void Main(string[] args)
        {
            LogManager log = new LogManager();
            log.Write("Processing...");
            log.WriteLine("Begin Processing....");

            Console.WriteLine(Application.Root);
            Console.ReadLine();
        }
    }
}
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
            LogManager log = new LogManager(null, "_BabyCarrotText");

            log.WriteLine("[Begin Processing]-----");

            for(int index = 0; index < 10; index++)
            {
                log.WriteLine("Processing: " + index);

                System.Threading.Thread.Sleep(500);

                log.WriteLine("Done: " + index);

            }


            log.WriteLine("[End Processing]-----");
        }
    }
}

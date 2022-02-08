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
                log.WriteConsole("testExtension");

                System.Threading.Thread.Sleep(500);

                log.WriteLine("Done: " + index);
                
            }


            log.WriteLine("[End Processing]-----");
        }
    }

    //확장 클래스 static 이어야 한다.
    public static class ExtensionTest
    {
        //확장 메소드 역시 static, 확장 메소드의 첫번째 매개변수는 this와 확장 키워드를 줘야함(두번 째부터는 상관없다.)
        public static void WriteConsole(this LogManager log, string data)
        {
            log.Write(data);
            Console.Write(data);
        }
    }
}

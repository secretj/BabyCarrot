using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BabyCarrot.Tools;
using BabyCarrot.Extensions;
namespace BabyCarrotTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = "12/08/2015 10:10";

            Console.WriteLine("IsNumeric? : " + temp.IsNumeric());
            Console.WriteLine("IsDateTime : " + temp.IsDateTime());
        }
    }
}



/*    //확장 클래스 static 이어야 한다.
    public static class ExtensionTest
    {
        //확장 메소드 역시 static, 확장 메소드의 첫번째 매개변수는 this와 확장 키워드를 줘야함(두번 째부터는 상관없다.)
        public static void WriteConsole(this LogManager log, string data)
        {
            log.Write(data);
            Console.Write(data);
        }
    }*/


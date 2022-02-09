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
            string contents = "Hello there, <br> This is SecretJ";

            EmailManager email = new EmailManager("smtp.com", 25, "id", "password");
            email.From = "sender@test.com";
            email.To.Add("receiver@test.com");
            email.Subject = "Subject";
            email.Body = contents;
            email.Send();

            email.To.Clear();
            email.To.Add("receiver2@test.com");
            email.Subject = "Hi Derek";
            email.Send();
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


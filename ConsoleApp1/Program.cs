using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int Date { get; private set; }

        static void Main(string[] args)
        {
            var now = new DateTime(2018, 6, 18, 18, 00, 32);
            Message message = new Message(now, 8, 12, 19);
            

            Console.WriteLine(message.GetHelloMessage() + " " + Environment.UserName);
            Console.ReadKey();





        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Message
    {
        public void AfficherBonWeekEnd()

        {

            Console.WriteLine("Bon week-end " + Environment.UserName);
            Console.ReadKey();

        }


        public void AfficherBonjour()

        {

            Console.WriteLine("Bonjour " + Environment.UserName);
            Console.ReadKey();

        }


        public void AfficherBonneApresMidi()

        {

            Console.WriteLine("Bonne après-midi " + Environment.UserName);
            Console.ReadKey();

        }

        public void AfficherBonsoir()

        {

            Console.WriteLine("Bonsoir " + Environment.UserName);
            Console.ReadKey();
        }
    }
}

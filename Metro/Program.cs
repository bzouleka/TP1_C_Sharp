using Newtonsoft.Json;
using System;
using System.Collections.Generic;
//using System.Collections.Generic;
using System.IO;
using System.Linq;
//using System.Linq;
using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web;
//using Newtonsoft.Json;
using LibMetro;


namespace Metro
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Lines> listSansDoublon = MetroLib.BusStopProxity(lo);



            foreach (Lines line in listSansDoublon) // iteration ligne par ligne 
            {
                Console.WriteLine($"Nom de la ligne {line.name}");

            }
            Console.ReadLine();

        }
    }
}

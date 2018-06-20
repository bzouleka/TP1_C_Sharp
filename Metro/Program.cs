using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using static System.Console;
using Newtonsoft.Json;

namespace Metro
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a request for the URL.   
            WebRequest request = WebRequest.Create(
              "https://data.metromobilite.fr/api/linesNear/json?x=5.709360123&y=45.176494599999984&dist=400&details=true");           
            // Get the response.  
            WebResponse response = request.GetResponse();
            // Display the status.  
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.  
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();
            // Display the content. 

            List<Lines> lines = JsonConvert.DeserializeObject<List<Lines>>(responseFromServer);
            List<Lines> listSansDoublon = lines.GroupBy(i => i.name).Select(g => g.First()).ToList();
            

            foreach (Lines line in listSansDoublon) // iteration ligne par ligne 
            {
            Console.WriteLine($"Nom de la ligne {line.name}");
                
            }

            // Clean up the streams and the response.  
            
            reader.Close();
            response.Close();
            ReadLine(); // sinon le programme sors sans afficher de resultats

        }
    }
}

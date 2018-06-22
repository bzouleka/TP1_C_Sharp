using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;



namespace LibMetro
{
    public class MetroLib
    {

        public static List<Lines> BusStopProxity()
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


            // Clean up the streams and the response.  

            reader.Close();
            response.Close();
            return listSansDoublon;
            
        }
    }
}

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

        public MetroLib()
        {

        }

        public List<Lines> BusStopProxity(string longitude, string latitude, string rayon )
        {
            // Create a request for the URL.   
            WebRequest request = WebRequest.Create(
              "https://data.metromobilite.fr/api/linesNear/json?x=" + longitude + "&y=" + latitude + "&dist=" + rayon + "&details=true");
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

        public List<Lines> lignes { get; set; }



      

       
    }
}

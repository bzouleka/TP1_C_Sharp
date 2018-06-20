using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro
{
    class Lines
    {
        // fonctions generer par jsontocsharp a partir du json de metromobilité
        public string id { get; set; }
        public object ID { get; internal set; }
        public string name { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }
        public List<string> lines { get; set; }
    }
}

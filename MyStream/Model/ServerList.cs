using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStream.Model
{
    public class ServerList
    {
        public Server[] Property1 { get; set; }
    }

    public class Server
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}

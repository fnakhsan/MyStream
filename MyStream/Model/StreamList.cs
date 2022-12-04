using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStream.Model
{
    internal class StreamList
    {
        public Headers headers { get; set; }

        public class Headers
        {
            public string Referer { get; set; }
        }

        public Source[] sources { get; set; }

        public class Source
        {
            public string url { get; set; }
            public bool isM3U8 { get; set; }
            public string quality { get; set; }
        }
    }
}

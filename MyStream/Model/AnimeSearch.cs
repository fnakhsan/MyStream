﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStream.Model
{
    internal class AnimeSearch
    {
        public int currentPage { get; set; }
        public bool hasNextPage { get; set; }
        public Result[] results { get; set; }
        public class Result
        {
            public string id { get; set; }
            public string title { get; set; }
            public string url { get; set; }
            public string image { get; set; }
            public string releaseDate { get; set; }
            public string subOrDub { get; set; }
        }
    }
}

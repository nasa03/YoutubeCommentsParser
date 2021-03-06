﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeCommentsParser.Models
{
    [Serializable]
    public class SearchProject
    {
        public string Name { get; set; }
        public string Query { get; set; }
        public Dictionary<string, VideoInfo> Videos { get; set; }
    }
}

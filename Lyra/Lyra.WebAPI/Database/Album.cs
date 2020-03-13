﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public class Album
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public ICollection<Track> Tracks { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public class TrackArtist
    {
        public int TrackID { get; set; }
        public Track Track { get; set; }
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public class UserFavouriteTrack
    {
        public int UserID { get; set; }
        public User User { get; set; }
        public int TrackID { get; set; }
        public Track Track { get; set; }
    }
}

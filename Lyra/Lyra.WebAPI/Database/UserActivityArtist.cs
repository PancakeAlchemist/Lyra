﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public class UserActivityArtist
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }
        public DateTime InteractedAt { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model
{
    public class Playlist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CreatedAt { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model.Requests
{
    public class AlbumSearchRequest
    {
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
    }
}
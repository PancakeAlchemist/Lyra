﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lyra.Model.Requests
{
    public class TrackUpsertRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Length { get; set; }
        public int MainArtist { get; set; }
        public List<int> FeaturedArtists { get; set; }
        public List<int> ArtistToDelete { get; set; }
        public List<int> Genres { get; set; }
        public List<int> GenresToDelete { get; set; }
    }
}

﻿using Lyra.Mobile.Helpers;
using Lyra.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Lyra.Mobile.ViewModels
{
    public class YourMusicArtistsViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("");
        public ObservableCollection<Model.Artist> ArtistsList { get; set; } = new ObservableCollection<Model.Artist>();
        private bool IsLoaded = false;
        public YourMusicArtistsViewModel()
        {
        }

        public async Task Init()
        {
            try
            {
                if (!IsLoaded)
                {
                    int ID = SignedInUserHelper.User.ID;

                    var artists = await _service.GetFavouriteArtists(ID);
                    foreach (var artist in artists)
                    {
                        ArtistsList.Add(artist);
                    }

                    IsLoaded = true;
                }
            }
            catch
            {

            }
        }
    }
}
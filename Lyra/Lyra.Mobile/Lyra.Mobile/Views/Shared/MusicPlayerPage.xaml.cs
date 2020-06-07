﻿using Lyra.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lyra.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MusicPlayerPage : ContentPage
    {
        private MusicPlayerViewModel model = null;
        public MusicPlayerPage(Model.Track track, IEnumerable<Model.Track> tracks)
        {
            InitializeComponent();
            ObservableCollection<Model.Track> queue = null;
            if(tracks != null)
            {
                queue = new ObservableCollection<Model.Track>(tracks);
            }
            BindingContext = model = new MusicPlayerViewModel(track, queue);
        }
    }
}
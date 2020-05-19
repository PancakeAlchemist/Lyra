﻿using Lyra.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lyra.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class YourMusicAlbumsPage : ContentPage
    {
        private YourMusicAlbumsViewModel model = null;

        public YourMusicAlbumsPage()
        {
            InitializeComponent();
            BindingContext = model = new YourMusicAlbumsViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}
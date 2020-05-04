﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lyra.WinUI.Helpers;

namespace Lyra.WinUI.UserControls.Administrator.Album
{
    public partial class ucAlbumList : UserControl
    {
        private readonly APIService _apiService = new APIService("Album");
        
        public ucAlbumList()
        {
            InitializeComponent();
        }

        private async void ucAlbumList_Load(object sender, EventArgs e)
        {
            var list = await _apiService.Get<List<Model.Album>>(null);
            var props = new List<string> { "ID", "Name", "ReleaseYear"};
            DataGridViewHelper.PopulateWithList(dgvAlbums, list, props);
        }

        private async void btnDeleteAlbum_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvAlbums.CurrentRow.Cells["ID"].Value);
            await _apiService.Delete<dynamic>(id);
            PanelHelper.SwapPanels(this.Parent, this, new ucAlbumList());
        }

        private void btnEditAlbum_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgvAlbums.CurrentRow.Cells["ID"].Value);
            PanelHelper.SwapPanels(this.Parent, this, new ucAlbumUpsert(ID));
        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new ucAlbumUpsert());
        }

        
    }
}

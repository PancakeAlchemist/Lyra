﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lyra.WinUI.UserControls.Administrator.Album;
using Lyra.WinUI.UserControls.Administrator.Track;
using Lyra.WinUI.Helpers;
using Lyra.WinUI.Validators;
using Lyra.Model.Requests;

namespace Lyra.WinUI.UserControls.Administrator.Artist
{
    public partial class ucArtistUpsert : UserControl
    {
        private readonly APIService _apiService = new APIService("Artist");
        private List<string> albumProps = new List<string> { "ID", "Name", "ReleaseYear" };
        private List<string> trackProps = new List<string> { "ID", "Name", "Length" };
        private int _albumsPage;
        private int _tracksPage;
        private int _itemsPerPage;
        private readonly int? _ID;
        public ucArtistUpsert(int? ID = null)
        {
            _ID = ID;
            _albumsPage = 1;
            _tracksPage = 1;
            _itemsPerPage = 10;
            InitializeComponent();
            AutoScroll = true;
        }

        #region Setup
        private async void ucArtistUpsert_Load(object sender, EventArgs e)
        {
            if (_ID.HasValue)
            {
                var artist = await _apiService.GetById<Model.Artist>(_ID.Value);
                txtName.Text = artist.Name;

                if (artist.Image.Length != 0)
                {
                    pbArtistImage.Image = ImageHelper.ByteArrayToSystemDrawing(artist.Image);
                    pbArtistImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                gbAlbums.Visible = true;
                gbTracks.Visible = true;


                BuildAlbumsList();
                var albumRequest = new AlbumSearchRequest()
                {
                    Page = _albumsPage,
                    ItemsPerPage = _itemsPerPage
                };
                await LoadListAlbums(albumRequest);

                BuildTracksList();
                var trackRequest = new TrackSearchRequest()
                {
                    Page = _tracksPage,
                    ItemsPerPage = _itemsPerPage
                };
                await LoadListTracks(trackRequest);

                gbTracks.Location = new Point(gbAlbums.Location.X, gbAlbums.Location.Y + gbAlbums.Height);


                SetButtonSavePosition();
            }
        }

        private void BuildAlbumsList()
        {
            SetDataGridViewSize(dgvAlbums);
            gbAlbums.Height = dgvAlbums.Height + 60;
            SetButtonSavePosition();
            pnlAlbumsPageButtons.Location = new Point(pnlAlbumsPageButtons.Location.X, dgvAlbums.Height + 70);
        }
        private void BuildTracksList()
        {
            SetDataGridViewSize(dgvTracks);
            gbTracks.Height = dgvTracks.Height + 110;
            SetButtonSavePosition();
            pnlTracksPageButtons.Location = new Point(pnlTracksPageButtons.Location.X, dgvTracks.Height + 65);
        }

        private void SetButtonSavePosition()
        {
            btnSave.Location = new Point(gbTracks.Location.X, gbTracks.Location.Y + gbTracks.Height + 10);
        }

        private void SetDataGridViewSize(DataGridView dgv)
        {
            var rowHeight = 25;
            dgv.Height = rowHeight * _itemsPerPage;
        }

        #endregion

        private async Task LoadListAlbums(AlbumSearchRequest request)
        {
            var list = await _apiService.GetAlbums<List<Model.Album>>(_ID.Value, request);

            if (list.Count > 0)
            {
                dgvAlbums.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvAlbums, list, albumProps);

                _albumsPage = request.Page;
            }
            else if (!string.IsNullOrEmpty(Convert.ToString(txtSearchAlbums.Text)) && request.Page == 1)
            {
                dgvAlbums.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvAlbums, list, albumProps);

                _albumsPage = 1;
            }

            btnPageNumberAlbums.Text = Convert.ToString(_albumsPage);
        }

        private async Task LoadListTracks(TrackSearchRequest request)
        {
            var list = await _apiService.GetTracks<List<Model.Track>>(_ID.Value, request);

            if (list.Count > 0)
            {
                dgvTracks.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvTracks, list, trackProps);

                _tracksPage = request.Page;
                
            }
            else if (!string.IsNullOrEmpty(Convert.ToString(txtSearchTracks.Text)) && request.Page == 1)
            {
                dgvTracks.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvTracks, list, trackProps);

                _tracksPage = 1;
            }

            btnPageNumberTracks.Text = Convert.ToString(_tracksPage);
        }

        

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbArtistImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbArtistImage.Image = new Bitmap(opnfd.FileName);
            }
        }

        #region Validation

        private void Name_Validating(object sender, CancelEventArgs e)
        {
            var validator = new ArtistValidator();
            var result = validator.NameCheck(txtName.Text);
            errorProviderName.SetError(txtName, result.Message);
            e.Cancel = !result.IsValid;
        }

        #endregion

        #region Pagination
        private async void btnPreviousAlbums_Click(object sender, EventArgs e)
        {
            if (_albumsPage > 1)
            {
                var search = Convert.ToString(txtSearchAlbums.Text);

                var request = new AlbumSearchRequest()
                {
                    Page = _albumsPage - 1,
                    ItemsPerPage = _itemsPerPage,
                    Name = search
                };

                await LoadListAlbums(request);
            }
        }

        private async void btnNextAlbums_Click(object sender, EventArgs e)
        {
            var search = Convert.ToString(txtSearchAlbums.Text);

            var request = new AlbumSearchRequest()
            {
                Page = _albumsPage + 1,
                ItemsPerPage = _itemsPerPage,
                Name = search
            };

            await LoadListAlbums(request);
        }

        private async void btnPreviousTracks_Click(object sender, EventArgs e)
        {
            if (_tracksPage > 1)
            {
                var search = Convert.ToString(txtSearchTracks.Text);

                var request = new TrackSearchRequest()
                {
                    Page = _tracksPage - 1,
                    ItemsPerPage = _itemsPerPage,
                    Name = search
                };

                await LoadListTracks(request);
            }
        }

        private async void btnNextTracks_Click(object sender, EventArgs e)
        {
            var search = Convert.ToString(txtSearchTracks.Text);

            var request = new TrackSearchRequest()
            {
                Page = _tracksPage + 1,
                ItemsPerPage = _itemsPerPage,
                Name = search
            };

            await LoadListTracks(request);
        }

        #endregion

        #region Search
        private async void btnSearchAlbums_Click(object sender, EventArgs e)
        {
            var search = Convert.ToString(txtSearchAlbums.Text);

            var request = new AlbumSearchRequest()
            {
                Page = 1,
                ItemsPerPage = _itemsPerPage,
                Name = search
            };

            await LoadListAlbums(request);
        }

        private async void btnSearchTracks_Click(object sender, EventArgs e)
        {
            var search = Convert.ToString(txtSearchTracks.Text);

            var request = new TrackSearchRequest()
            {
                Page = 1,
                ItemsPerPage = _itemsPerPage,
                Name = search
            };

            await LoadListTracks(request);
        }

        #endregion

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = new Model.Requests.ArtistUpsertRequest
                {
                    Name = Convert.ToString(txtName.Text),
                    Image = ImageHelper.SystemDrawingToByteArray(pbArtistImage.Image)
                };

                if (_ID.HasValue)
                {
                    await _apiService.Update<Model.Artist>(_ID.Value, request);
                }
                else
                {
                    await _apiService.Insert<Model.Artist>(request);
                    PanelHelper.SwapPanels(this.Parent, this, new ucArtistUpsert());
                }

                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

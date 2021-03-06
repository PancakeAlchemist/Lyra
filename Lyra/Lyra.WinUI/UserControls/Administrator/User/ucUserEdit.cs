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
using Lyra.WinUI.Validators;

namespace Lyra.WinUI.UserControls.Administrator.User
{
    public partial class ucUserEdit : UserControl
    {
        private readonly APIService _apiService = new APIService("User");
        private readonly APIService _roleApiService = new APIService("Role");
        private readonly int _ID;

        public ucUserEdit(int ID)
        {
            _ID = ID;
            InitializeComponent();
        }

        private async void ucUserEdit_Load(object sender, EventArgs e)
        {
            //Load user info
            var user = await _apiService.GetById<Model.User>(_ID);

            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtUsername.Text = user.Username;
            txtEmail.Text = user.Email;
            txtPhoneNumber.Text = user.PhoneNumber;

            if (user.Image.Length != 0)
            {
                pbUserImage.Image = ImageHelper.ByteArrayToSystemDrawing(user.Image);
                pbUserImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            //List all roles
            var roles = await _roleApiService.Get<List<Model.Role>>(null);
            clbRoles.DataSource = roles;
            clbRoles.ValueMember = "ID";
            clbRoles.DisplayMember = "Name";

            //Check users roles
            var rolesList = clbRoles.Items.Cast<Model.Role>().Select(i => i.ID).ToList();
            foreach(var userRole in user.UserRoles)
            {
                for (int i = 0; i < clbRoles.Items.Count; i++)
                {
                    if (rolesList[i] == userRole.RoleID)
                    {
                        clbRoles.SetItemChecked(i, true);
                    }
                }
            }
        }
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbUserImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbUserImage.Image = new Bitmap(opnfd.FileName);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                try
                {
                    var checkedRoles = clbRoles.CheckedItems.Cast<Model.Role>().Select(i => i.ID).ToList();

                    List<int> uncheckedRoles = new List<int>();
                    for (int i = 0; i < clbRoles.Items.Count; i++)
                    {
                        if (!clbRoles.GetItemChecked(i))
                        {
                            int RoleID = clbRoles.Items.Cast<Model.Role>().ToList()[i].ID;
                            uncheckedRoles.Add(RoleID);
                        }
                    }

                    var request = new Model.Requests.UserUpdateRequest
                    {
                        FirstName = Convert.ToString(txtFirstName.Text),
                        LastName = Convert.ToString(txtLastName.Text),
                        Username = Convert.ToString(txtUsername.Text),
                        Email = Convert.ToString(txtEmail.Text),
                        PhoneNumber = Convert.ToString(txtPhoneNumber.Text),
                        Image = pbUserImage.Image != null ? ImageHelper.SystemDrawingToByteArray(pbUserImage.Image) : null,
                        Roles = checkedRoles,
                        RolesToDelete = uncheckedRoles
                    };

                    await _apiService.Update<Model.User>(_ID, request);

                    MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void FirstName_Validating(object sender, CancelEventArgs e)
        {
            var validator = new UserValidator();
            var result = validator.FirstNameCheck(txtFirstName.Text);
            errorProviderFirstName.SetError(txtFirstName, result.Message);
            e.Cancel = !result.IsValid;
        }

        private void LastName_Validating(object sender, CancelEventArgs e)
        {
            var validator = new UserValidator();
            var result = validator.FirstNameCheck(txtLastName.Text);
            errorProviderLastName.SetError(txtLastName, result.Message);
            e.Cancel = !result.IsValid;
        }

        private void Username_Validating(object sender, CancelEventArgs e)
        {
            var validator = new UserValidator();
            var result = validator.UsernameCheck(txtUsername.Text);
            errorProviderUsername.SetError(txtUsername, result.Message);
            e.Cancel = !result.IsValid;
        }

        private void Email_Validating(object sender, CancelEventArgs e)
        {
            var validator = new UserValidator();
            var result = validator.EmailCheck(txtEmail.Text);
            errorProviderEmail.SetError(txtEmail, result.Message);
            e.Cancel = !result.IsValid;
        }

        private void PhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            var validator = new UserValidator();
            var result = validator.EmailCheck(txtPhoneNumber.Text);
            errorProviderPhoneNumber.SetError(txtPhoneNumber, result.Message);
            e.Cancel = !result.IsValid;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyra.WinUI.User
{
    public partial class frmUserPanel : Form
    {
        private static Model.User _user;
        public frmUserPanel(Model.User user)
        {
            _user = user;
            InitializeComponent();
        }
    }
}

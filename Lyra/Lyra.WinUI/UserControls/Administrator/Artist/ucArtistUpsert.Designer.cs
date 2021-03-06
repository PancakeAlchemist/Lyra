﻿namespace Lyra.WinUI.UserControls.Administrator.Artist
{
    partial class ucArtistUpsert
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.pbArtistImage = new System.Windows.Forms.PictureBox();
            this.gbAlbums = new System.Windows.Forms.GroupBox();
            this.pnlAlbumsPageButtons = new System.Windows.Forms.Panel();
            this.btnNextAlbums = new System.Windows.Forms.Button();
            this.btnPreviousAlbums = new System.Windows.Forms.Button();
            this.btnPageNumberAlbums = new System.Windows.Forms.Button();
            this.dgvAlbums = new System.Windows.Forms.DataGridView();
            this.gbTracks = new System.Windows.Forms.GroupBox();
            this.pnlTracksPageButtons = new System.Windows.Forms.Panel();
            this.btnNextTracks = new System.Windows.Forms.Button();
            this.btnPreviousTracks = new System.Windows.Forms.Button();
            this.btnPageNumberTracks = new System.Windows.Forms.Button();
            this.dgvTracks = new System.Windows.Forms.DataGridView();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSearchAlbums = new System.Windows.Forms.Button();
            this.txtSearchAlbums = new System.Windows.Forms.TextBox();
            this.btnSearchTracks = new System.Windows.Forms.Button();
            this.txtSearchTracks = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbArtistImage)).BeginInit();
            this.gbAlbums.SuspendLayout();
            this.pnlAlbumsPageButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).BeginInit();
            this.gbTracks.SuspendLayout();
            this.pnlTracksPageButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).BeginInit();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(51, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(188, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(245, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 16);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(248, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 22);
            this.txtName.TabIndex = 10;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.Name_Validating);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.Location = new System.Drawing.Point(13, 229);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(188, 24);
            this.btnUploadImage.TabIndex = 21;
            this.btnUploadImage.Text = "Upload image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // pbArtistImage
            // 
            this.pbArtistImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbArtistImage.Location = new System.Drawing.Point(13, 30);
            this.pbArtistImage.Name = "pbArtistImage";
            this.pbArtistImage.Size = new System.Drawing.Size(188, 184);
            this.pbArtistImage.TabIndex = 20;
            this.pbArtistImage.TabStop = false;
            // 
            // gbAlbums
            // 
            this.gbAlbums.AutoSize = true;
            this.gbAlbums.Controls.Add(this.btnSearchAlbums);
            this.gbAlbums.Controls.Add(this.txtSearchAlbums);
            this.gbAlbums.Controls.Add(this.pnlAlbumsPageButtons);
            this.gbAlbums.Controls.Add(this.dgvAlbums);
            this.gbAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlbums.Location = new System.Drawing.Point(38, 327);
            this.gbAlbums.Name = "gbAlbums";
            this.gbAlbums.Size = new System.Drawing.Size(712, 238);
            this.gbAlbums.TabIndex = 75;
            this.gbAlbums.TabStop = false;
            this.gbAlbums.Text = "Albums";
            this.gbAlbums.Visible = false;
            // 
            // pnlAlbumsPageButtons
            // 
            this.pnlAlbumsPageButtons.Controls.Add(this.btnNextAlbums);
            this.pnlAlbumsPageButtons.Controls.Add(this.btnPreviousAlbums);
            this.pnlAlbumsPageButtons.Controls.Add(this.btnPageNumberAlbums);
            this.pnlAlbumsPageButtons.Location = new System.Drawing.Point(569, 171);
            this.pnlAlbumsPageButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAlbumsPageButtons.Name = "pnlAlbumsPageButtons";
            this.pnlAlbumsPageButtons.Size = new System.Drawing.Size(127, 40);
            this.pnlAlbumsPageButtons.TabIndex = 28;
            // 
            // btnNextAlbums
            // 
            this.btnNextAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextAlbums.Location = new System.Drawing.Point(85, 6);
            this.btnNextAlbums.Name = "btnNextAlbums";
            this.btnNextAlbums.Size = new System.Drawing.Size(33, 30);
            this.btnNextAlbums.TabIndex = 27;
            this.btnNextAlbums.Text = ">";
            this.btnNextAlbums.UseVisualStyleBackColor = true;
            this.btnNextAlbums.Click += new System.EventHandler(this.btnNextAlbums_Click);
            // 
            // btnPreviousAlbums
            // 
            this.btnPreviousAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousAlbums.Location = new System.Drawing.Point(7, 6);
            this.btnPreviousAlbums.Name = "btnPreviousAlbums";
            this.btnPreviousAlbums.Size = new System.Drawing.Size(33, 30);
            this.btnPreviousAlbums.TabIndex = 25;
            this.btnPreviousAlbums.Text = "<";
            this.btnPreviousAlbums.UseVisualStyleBackColor = true;
            this.btnPreviousAlbums.Click += new System.EventHandler(this.btnPreviousAlbums_Click);
            // 
            // btnPageNumberAlbums
            // 
            this.btnPageNumberAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPageNumberAlbums.Location = new System.Drawing.Point(46, 6);
            this.btnPageNumberAlbums.Name = "btnPageNumberAlbums";
            this.btnPageNumberAlbums.Size = new System.Drawing.Size(33, 30);
            this.btnPageNumberAlbums.TabIndex = 26;
            this.btnPageNumberAlbums.Text = "1";
            this.btnPageNumberAlbums.UseVisualStyleBackColor = true;
            // 
            // dgvAlbums
            // 
            this.dgvAlbums.AllowUserToAddRows = false;
            this.dgvAlbums.AllowUserToDeleteRows = false;
            this.dgvAlbums.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlbums.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlbums.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvAlbums.Location = new System.Drawing.Point(13, 69);
            this.dgvAlbums.Name = "dgvAlbums";
            this.dgvAlbums.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlbums.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvAlbums.Size = new System.Drawing.Size(683, 96);
            this.dgvAlbums.TabIndex = 0;
            // 
            // gbTracks
            // 
            this.gbTracks.Controls.Add(this.btnSearchTracks);
            this.gbTracks.Controls.Add(this.pnlTracksPageButtons);
            this.gbTracks.Controls.Add(this.txtSearchTracks);
            this.gbTracks.Controls.Add(this.dgvTracks);
            this.gbTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTracks.Location = new System.Drawing.Point(38, 576);
            this.gbTracks.Name = "gbTracks";
            this.gbTracks.Size = new System.Drawing.Size(712, 212);
            this.gbTracks.TabIndex = 76;
            this.gbTracks.TabStop = false;
            this.gbTracks.Text = "Tracks";
            this.gbTracks.Visible = false;
            // 
            // pnlTracksPageButtons
            // 
            this.pnlTracksPageButtons.Controls.Add(this.btnNextTracks);
            this.pnlTracksPageButtons.Controls.Add(this.btnPreviousTracks);
            this.pnlTracksPageButtons.Controls.Add(this.btnPageNumberTracks);
            this.pnlTracksPageButtons.Location = new System.Drawing.Point(569, 163);
            this.pnlTracksPageButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTracksPageButtons.Name = "pnlTracksPageButtons";
            this.pnlTracksPageButtons.Size = new System.Drawing.Size(127, 40);
            this.pnlTracksPageButtons.TabIndex = 29;
            // 
            // btnNextTracks
            // 
            this.btnNextTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextTracks.Location = new System.Drawing.Point(85, 6);
            this.btnNextTracks.Name = "btnNextTracks";
            this.btnNextTracks.Size = new System.Drawing.Size(33, 30);
            this.btnNextTracks.TabIndex = 27;
            this.btnNextTracks.Text = ">";
            this.btnNextTracks.UseVisualStyleBackColor = true;
            this.btnNextTracks.Click += new System.EventHandler(this.btnNextTracks_Click);
            // 
            // btnPreviousTracks
            // 
            this.btnPreviousTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousTracks.Location = new System.Drawing.Point(7, 6);
            this.btnPreviousTracks.Name = "btnPreviousTracks";
            this.btnPreviousTracks.Size = new System.Drawing.Size(33, 30);
            this.btnPreviousTracks.TabIndex = 25;
            this.btnPreviousTracks.Text = "<";
            this.btnPreviousTracks.UseVisualStyleBackColor = true;
            this.btnPreviousTracks.Click += new System.EventHandler(this.btnPreviousTracks_Click);
            // 
            // btnPageNumberTracks
            // 
            this.btnPageNumberTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPageNumberTracks.Location = new System.Drawing.Point(46, 6);
            this.btnPageNumberTracks.Name = "btnPageNumberTracks";
            this.btnPageNumberTracks.Size = new System.Drawing.Size(33, 30);
            this.btnPageNumberTracks.TabIndex = 26;
            this.btnPageNumberTracks.Text = "1";
            this.btnPageNumberTracks.UseVisualStyleBackColor = true;
            // 
            // dgvTracks
            // 
            this.dgvTracks.AllowUserToAddRows = false;
            this.dgvTracks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTracks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTracks.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvTracks.Location = new System.Drawing.Point(13, 61);
            this.dgvTracks.Name = "dgvTracks";
            this.dgvTracks.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTracks.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvTracks.Size = new System.Drawing.Size(683, 96);
            this.dgvTracks.TabIndex = 0;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.pbArtistImage);
            this.gbInfo.Controls.Add(this.lblName);
            this.gbInfo.Controls.Add(this.txtName);
            this.gbInfo.Controls.Add(this.btnUploadImage);
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.Location = new System.Drawing.Point(38, 25);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(712, 264);
            this.gbInfo.TabIndex = 77;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // btnSearchAlbums
            // 
            this.btnSearchAlbums.BackgroundImage = global::Lyra.WinUI.Properties.Resources.search;
            this.btnSearchAlbums.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchAlbums.FlatAppearance.BorderSize = 0;
            this.btnSearchAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAlbums.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchAlbums.Location = new System.Drawing.Point(188, 41);
            this.btnSearchAlbums.Name = "btnSearchAlbums";
            this.btnSearchAlbums.Size = new System.Drawing.Size(28, 23);
            this.btnSearchAlbums.TabIndex = 30;
            this.btnSearchAlbums.UseVisualStyleBackColor = true;
            this.btnSearchAlbums.Click += new System.EventHandler(this.btnSearchAlbums_Click);
            // 
            // txtSearchAlbums
            // 
            this.txtSearchAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAlbums.Location = new System.Drawing.Point(13, 41);
            this.txtSearchAlbums.Name = "txtSearchAlbums";
            this.txtSearchAlbums.Size = new System.Drawing.Size(167, 22);
            this.txtSearchAlbums.TabIndex = 29;
            // 
            // btnSearchTracks
            // 
            this.btnSearchTracks.BackgroundImage = global::Lyra.WinUI.Properties.Resources.search;
            this.btnSearchTracks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchTracks.FlatAppearance.BorderSize = 0;
            this.btnSearchTracks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTracks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchTracks.Location = new System.Drawing.Point(188, 33);
            this.btnSearchTracks.Name = "btnSearchTracks";
            this.btnSearchTracks.Size = new System.Drawing.Size(28, 23);
            this.btnSearchTracks.TabIndex = 32;
            this.btnSearchTracks.UseVisualStyleBackColor = true;
            this.btnSearchTracks.Click += new System.EventHandler(this.btnSearchTracks_Click);
            // 
            // txtSearchTracks
            // 
            this.txtSearchTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTracks.Location = new System.Drawing.Point(13, 33);
            this.txtSearchTracks.Name = "txtSearchTracks";
            this.txtSearchTracks.Size = new System.Drawing.Size(167, 22);
            this.txtSearchTracks.TabIndex = 31;
            // 
            // ucArtistUpsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbTracks);
            this.Controls.Add(this.gbAlbums);
            this.Name = "ucArtistUpsert";
            this.Size = new System.Drawing.Size(796, 814);
            this.Load += new System.EventHandler(this.ucArtistUpsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbArtistImage)).EndInit();
            this.gbAlbums.ResumeLayout(false);
            this.gbAlbums.PerformLayout();
            this.pnlAlbumsPageButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).EndInit();
            this.gbTracks.ResumeLayout(false);
            this.gbTracks.PerformLayout();
            this.pnlTracksPageButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.PictureBox pbArtistImage;
        private System.Windows.Forms.GroupBox gbAlbums;
        private System.Windows.Forms.GroupBox gbTracks;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.DataGridView dgvAlbums;
        private System.Windows.Forms.DataGridView dgvTracks;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.Button btnNextAlbums;
        private System.Windows.Forms.Button btnPageNumberAlbums;
        private System.Windows.Forms.Button btnPreviousAlbums;
        private System.Windows.Forms.Panel pnlAlbumsPageButtons;
        private System.Windows.Forms.Panel pnlTracksPageButtons;
        private System.Windows.Forms.Button btnNextTracks;
        private System.Windows.Forms.Button btnPreviousTracks;
        private System.Windows.Forms.Button btnPageNumberTracks;
        private System.Windows.Forms.Button btnSearchAlbums;
        private System.Windows.Forms.TextBox txtSearchAlbums;
        private System.Windows.Forms.Button btnSearchTracks;
        private System.Windows.Forms.TextBox txtSearchTracks;
    }
}

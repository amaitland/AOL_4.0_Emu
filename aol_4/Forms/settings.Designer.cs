﻿namespace aol.Forms
{
    partial class settings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fullscreenCheckbox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainTitle = new System.Windows.Forms.Label();
            this.miniBtn = new System.Windows.Forms.Button();
            this.maxBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.homePageBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fullnameBox = new System.Windows.Forms.TextBox();
            this.updateFNBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.searchProvider = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.browseHistoryList = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteAllBrowsingHistory = new System.Windows.Forms.Button();
            this.deleteBrowserHistoryBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullscreenCheckbox
            // 
            this.fullscreenCheckbox.AutoSize = true;
            this.fullscreenCheckbox.Location = new System.Drawing.Point(15, 69);
            this.fullscreenCheckbox.Margin = new System.Windows.Forms.Padding(6);
            this.fullscreenCheckbox.Name = "fullscreenCheckbox";
            this.fullscreenCheckbox.Size = new System.Drawing.Size(173, 29);
            this.fullscreenCheckbox.TabIndex = 0;
            this.fullscreenCheckbox.Text = "Start Full Screen";
            this.fullscreenCheckbox.UseVisualStyleBackColor = true;
            this.fullscreenCheckbox.CheckedChanged += new System.EventHandler(this.fullscreenCheckbox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::aol.Properties.Resources.top_bar;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.mainTitle);
            this.panel1.Controls.Add(this.miniBtn);
            this.panel1.Controls.Add(this.maxBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 35);
            this.panel1.TabIndex = 3;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainTitle.Location = new System.Drawing.Point(6, 4);
            this.mainTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(150, 25);
            this.mainTitle.TabIndex = 11;
            this.mainTitle.Text = "General Settings";
            // 
            // miniBtn
            // 
            this.miniBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.miniBtn.BackColor = System.Drawing.SystemColors.Control;
            this.miniBtn.BackgroundImage = global::aol.Properties.Resources.minimize_btn;
            this.miniBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.miniBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.miniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.miniBtn.ForeColor = System.Drawing.Color.Black;
            this.miniBtn.Location = new System.Drawing.Point(484, 2);
            this.miniBtn.Margin = new System.Windows.Forms.Padding(6);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.Size = new System.Drawing.Size(33, 31);
            this.miniBtn.TabIndex = 2;
            this.miniBtn.UseVisualStyleBackColor = false;
            this.miniBtn.Click += new System.EventHandler(this.MiniBtn_Click);
            // 
            // maxBtn
            // 
            this.maxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxBtn.BackColor = System.Drawing.SystemColors.Control;
            this.maxBtn.BackgroundImage = global::aol.Properties.Resources.maximize_disabled_btn;
            this.maxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maxBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.maxBtn.Enabled = false;
            this.maxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxBtn.ForeColor = System.Drawing.Color.Black;
            this.maxBtn.Location = new System.Drawing.Point(517, 2);
            this.maxBtn.Margin = new System.Windows.Forms.Padding(0);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maxBtn.Size = new System.Drawing.Size(33, 31);
            this.maxBtn.TabIndex = 1;
            this.maxBtn.UseVisualStyleBackColor = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.closeBtn.BackgroundImage = global::aol.Properties.Resources.close_btn;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.ForeColor = System.Drawing.Color.Black;
            this.closeBtn.Location = new System.Drawing.Point(554, 2);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closeBtn.Size = new System.Drawing.Size(33, 31);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(471, 721);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // homePageBox
            // 
            this.homePageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homePageBox.Location = new System.Drawing.Point(148, 129);
            this.homePageBox.Margin = new System.Windows.Forms.Padding(6);
            this.homePageBox.Name = "homePageBox";
            this.homePageBox.Size = new System.Drawing.Size(428, 33);
            this.homePageBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Home Page:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Full Name:";
            // 
            // fullnameBox
            // 
            this.fullnameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullnameBox.Location = new System.Drawing.Point(148, 179);
            this.fullnameBox.Margin = new System.Windows.Forms.Padding(6);
            this.fullnameBox.Name = "fullnameBox";
            this.fullnameBox.Size = new System.Drawing.Size(314, 33);
            this.fullnameBox.TabIndex = 2;
            // 
            // updateFNBtn
            // 
            this.updateFNBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateFNBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.updateFNBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateFNBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.updateFNBtn.Location = new System.Drawing.Point(477, 177);
            this.updateFNBtn.Margin = new System.Windows.Forms.Padding(6);
            this.updateFNBtn.Name = "updateFNBtn";
            this.updateFNBtn.Size = new System.Drawing.Size(103, 42);
            this.updateFNBtn.TabIndex = 3;
            this.updateFNBtn.Text = "Update";
            this.updateFNBtn.UseVisualStyleBackColor = false;
            this.updateFNBtn.Click += new System.EventHandler(this.updateFNBtn_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 738);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(282, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Settings are saved automatically";
            // 
            // searchProvider
            // 
            this.searchProvider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchProvider.FormattingEnabled = true;
            this.searchProvider.Items.AddRange(new object[] {
            "Dogpile",
            "Google",
            "Yahoo",
            "Bing"});
            this.searchProvider.Location = new System.Drawing.Point(148, 229);
            this.searchProvider.Margin = new System.Windows.Forms.Padding(6);
            this.searchProvider.Name = "searchProvider";
            this.searchProvider.Size = new System.Drawing.Size(428, 33);
            this.searchProvider.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Search:";
            // 
            // browseHistoryList
            // 
            this.browseHistoryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browseHistoryList.FullRowSelect = true;
            this.browseHistoryList.Location = new System.Drawing.Point(13, 31);
            this.browseHistoryList.Margin = new System.Windows.Forms.Padding(6);
            this.browseHistoryList.Name = "browseHistoryList";
            this.browseHistoryList.Size = new System.Drawing.Size(539, 331);
            this.browseHistoryList.TabIndex = 25;
            this.browseHistoryList.UseCompatibleStateImageBehavior = false;
            this.browseHistoryList.View = System.Windows.Forms.View.List;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DeleteAllBrowsingHistory);
            this.groupBox1.Controls.Add(this.deleteBrowserHistoryBtn);
            this.groupBox1.Controls.Add(this.browseHistoryList);
            this.groupBox1.Location = new System.Drawing.Point(15, 281);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(566, 429);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Browse History";
            // 
            // DeleteAllBrowsingHistory
            // 
            this.DeleteAllBrowsingHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteAllBrowsingHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.DeleteAllBrowsingHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAllBrowsingHistory.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteAllBrowsingHistory.Location = new System.Drawing.Point(13, 377);
            this.DeleteAllBrowsingHistory.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteAllBrowsingHistory.Name = "DeleteAllBrowsingHistory";
            this.DeleteAllBrowsingHistory.Size = new System.Drawing.Size(138, 44);
            this.DeleteAllBrowsingHistory.TabIndex = 27;
            this.DeleteAllBrowsingHistory.Text = "Delete All";
            this.DeleteAllBrowsingHistory.UseVisualStyleBackColor = false;
            this.DeleteAllBrowsingHistory.Click += new System.EventHandler(this.DeleteAllBrowsingHistory_Click);
            // 
            // deleteBrowserHistoryBtn
            // 
            this.deleteBrowserHistoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBrowserHistoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.deleteBrowserHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBrowserHistoryBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteBrowserHistoryBtn.Location = new System.Drawing.Point(456, 373);
            this.deleteBrowserHistoryBtn.Margin = new System.Windows.Forms.Padding(6);
            this.deleteBrowserHistoryBtn.Name = "deleteBrowserHistoryBtn";
            this.deleteBrowserHistoryBtn.Size = new System.Drawing.Size(99, 44);
            this.deleteBrowserHistoryBtn.TabIndex = 26;
            this.deleteBrowserHistoryBtn.Text = "Delete";
            this.deleteBrowserHistoryBtn.UseVisualStyleBackColor = false;
            this.deleteBrowserHistoryBtn.Click += new System.EventHandler(this.DeleteBrowserHistoryBtn_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(596, 788);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchProvider);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.updateFNBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullnameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homePageBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fullscreenCheckbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 220);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(596, 788);
            this.Name = "settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "General Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.settings_FormClosing);
            this.Load += new System.EventHandler(this.settings_Load);
            this.Shown += new System.EventHandler(this.settings_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox fullscreenCheckbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox homePageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullnameBox;
        private System.Windows.Forms.Button updateFNBtn;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox searchProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView browseHistoryList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteBrowserHistoryBtn;
        private System.Windows.Forms.Button DeleteAllBrowsingHistory;
    }
}
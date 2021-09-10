namespace RainbowLight
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pBoxArrowUp = new System.Windows.Forms.PictureBox();
            this.pBoxArrowDown = new System.Windows.Forms.PictureBox();
            this.PanelMenu2 = new System.Windows.Forms.Panel();
            this.pBoxEmailDev = new System.Windows.Forms.PictureBox();
            this.pBoxDonate = new System.Windows.Forms.PictureBox();
            this.pBoxOptions = new System.Windows.Forms.PictureBox();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.pBoxReservedRooms2 = new System.Windows.Forms.PictureBox();
            this.pBoxExit = new System.Windows.Forms.PictureBox();
            this.pBoxUnlogin = new System.Windows.Forms.PictureBox();
            this.pBoxRainbow = new System.Windows.Forms.PictureBox();
            this.pBoxAddClients = new System.Windows.Forms.PictureBox();
            this.pBoxInfoClients = new System.Windows.Forms.PictureBox();
            this.pBoxAvailRooms = new System.Windows.Forms.PictureBox();
            this.pBoxStatistics = new System.Windows.Forms.PictureBox();
            this.pBoxSearch = new System.Windows.Forms.PictureBox();
            this.labelMain = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxArrowUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxArrowDown)).BeginInit();
            this.PanelMenu2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxEmailDev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDonate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOptions)).BeginInit();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxReservedRooms2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUnlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRainbow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxInfoClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAvailRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = global::RainbowLight.Properties.Resources.rainbowLight;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.pBoxArrowUp);
            this.MainPanel.Controls.Add(this.pBoxArrowDown);
            this.MainPanel.Controls.Add(this.PanelMenu2);
            this.MainPanel.Controls.Add(this.PanelMenu);
            this.MainPanel.Controls.Add(this.labelMain);
            this.MainPanel.Location = new System.Drawing.Point(-7, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(988, 640);
            this.MainPanel.TabIndex = 8;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // pBoxArrowUp
            // 
            this.pBoxArrowUp.BackColor = System.Drawing.Color.Thistle;
            this.pBoxArrowUp.Image = global::RainbowLight.Properties.Resources.arrow_up;
            this.pBoxArrowUp.Location = new System.Drawing.Point(3, 0);
            this.pBoxArrowUp.Name = "pBoxArrowUp";
            this.pBoxArrowUp.Size = new System.Drawing.Size(79, 67);
            this.pBoxArrowUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxArrowUp.TabIndex = 13;
            this.pBoxArrowUp.TabStop = false;
            this.pBoxArrowUp.Click += new System.EventHandler(this.pBoxArrowUp_Click);
            // 
            // pBoxArrowDown
            // 
            this.pBoxArrowDown.BackColor = System.Drawing.Color.Thistle;
            this.pBoxArrowDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxArrowDown.Image = global::RainbowLight.Properties.Resources.arrow_down;
            this.pBoxArrowDown.Location = new System.Drawing.Point(912, 573);
            this.pBoxArrowDown.Name = "pBoxArrowDown";
            this.pBoxArrowDown.Size = new System.Drawing.Size(76, 67);
            this.pBoxArrowDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxArrowDown.TabIndex = 7;
            this.pBoxArrowDown.TabStop = false;
            this.pBoxArrowDown.Click += new System.EventHandler(this.pictureBox_arrowDown_Click);
            // 
            // PanelMenu2
            // 
            this.PanelMenu2.BackColor = System.Drawing.Color.Thistle;
            this.PanelMenu2.Controls.Add(this.pBoxEmailDev);
            this.PanelMenu2.Controls.Add(this.pBoxDonate);
            this.PanelMenu2.Controls.Add(this.pBoxOptions);
            this.PanelMenu2.Location = new System.Drawing.Point(618, 573);
            this.PanelMenu2.Name = "PanelMenu2";
            this.PanelMenu2.Size = new System.Drawing.Size(299, 67);
            this.PanelMenu2.TabIndex = 12;
            // 
            // pBoxEmailDev
            // 
            this.pBoxEmailDev.BackColor = System.Drawing.Color.Transparent;
            this.pBoxEmailDev.Image = global::RainbowLight.Properties.Resources.mail_dev;
            this.pBoxEmailDev.Location = new System.Drawing.Point(99, 0);
            this.pBoxEmailDev.Name = "pBoxEmailDev";
            this.pBoxEmailDev.Size = new System.Drawing.Size(73, 67);
            this.pBoxEmailDev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxEmailDev.TabIndex = 12;
            this.pBoxEmailDev.TabStop = false;
            this.pBoxEmailDev.Click += new System.EventHandler(this.pBoxEmailDev_Click);
            // 
            // pBoxDonate
            // 
            this.pBoxDonate.BackColor = System.Drawing.Color.Transparent;
            this.pBoxDonate.Image = global::RainbowLight.Properties.Resources.donate;
            this.pBoxDonate.Location = new System.Drawing.Point(0, 0);
            this.pBoxDonate.Name = "pBoxDonate";
            this.pBoxDonate.Size = new System.Drawing.Size(73, 67);
            this.pBoxDonate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxDonate.TabIndex = 11;
            this.pBoxDonate.TabStop = false;
            this.pBoxDonate.Click += new System.EventHandler(this.pBoxDonate_Click);
            // 
            // pBoxOptions
            // 
            this.pBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.pBoxOptions.Image = global::RainbowLight.Properties.Resources.options;
            this.pBoxOptions.Location = new System.Drawing.Point(198, 0);
            this.pBoxOptions.Name = "pBoxOptions";
            this.pBoxOptions.Size = new System.Drawing.Size(73, 67);
            this.pBoxOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxOptions.TabIndex = 14;
            this.pBoxOptions.TabStop = false;
            this.pBoxOptions.Click += new System.EventHandler(this.pBoxOptions_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.Thistle;
            this.PanelMenu.Controls.Add(this.pBoxReservedRooms2);
            this.PanelMenu.Controls.Add(this.pBoxExit);
            this.PanelMenu.Controls.Add(this.pBoxUnlogin);
            this.PanelMenu.Controls.Add(this.pBoxRainbow);
            this.PanelMenu.Controls.Add(this.pBoxAddClients);
            this.PanelMenu.Controls.Add(this.pBoxInfoClients);
            this.PanelMenu.Controls.Add(this.pBoxAvailRooms);
            this.PanelMenu.Controls.Add(this.pBoxStatistics);
            this.PanelMenu.Controls.Add(this.pBoxSearch);
            this.PanelMenu.Location = new System.Drawing.Point(81, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(907, 67);
            this.PanelMenu.TabIndex = 6;
            // 
            // pBoxReservedRooms2
            // 
            this.pBoxReservedRooms2.BackColor = System.Drawing.Color.Transparent;
            this.pBoxReservedRooms2.Image = global::RainbowLight.Properties.Resources.reservedRoom;
            this.pBoxReservedRooms2.Location = new System.Drawing.Point(103, 0);
            this.pBoxReservedRooms2.Name = "pBoxReservedRooms2";
            this.pBoxReservedRooms2.Size = new System.Drawing.Size(73, 67);
            this.pBoxReservedRooms2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxReservedRooms2.TabIndex = 14;
            this.pBoxReservedRooms2.TabStop = false;
            this.pBoxReservedRooms2.Click += new System.EventHandler(this.pBoxReservedRooms2_Click);
            // 
            // pBoxExit
            // 
            this.pBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.pBoxExit.Image = global::RainbowLight.Properties.Resources.exit;
            this.pBoxExit.Location = new System.Drawing.Point(831, 0);
            this.pBoxExit.Name = "pBoxExit";
            this.pBoxExit.Size = new System.Drawing.Size(73, 67);
            this.pBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxExit.TabIndex = 13;
            this.pBoxExit.TabStop = false;
            this.pBoxExit.Click += new System.EventHandler(this.pBoxExit_Click);
            // 
            // pBoxUnlogin
            // 
            this.pBoxUnlogin.BackColor = System.Drawing.Color.Transparent;
            this.pBoxUnlogin.Image = global::RainbowLight.Properties.Resources.home;
            this.pBoxUnlogin.Location = new System.Drawing.Point(725, 0);
            this.pBoxUnlogin.Name = "pBoxUnlogin";
            this.pBoxUnlogin.Size = new System.Drawing.Size(73, 67);
            this.pBoxUnlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxUnlogin.TabIndex = 0;
            this.pBoxUnlogin.TabStop = false;
            this.pBoxUnlogin.Click += new System.EventHandler(this.pBoxUnlogin_Click);
            // 
            // pBoxRainbow
            // 
            this.pBoxRainbow.BackColor = System.Drawing.Color.Transparent;
            this.pBoxRainbow.Image = global::RainbowLight.Properties.Resources.rainbow;
            this.pBoxRainbow.Location = new System.Drawing.Point(380, 0);
            this.pBoxRainbow.Name = "pBoxRainbow";
            this.pBoxRainbow.Size = new System.Drawing.Size(109, 67);
            this.pBoxRainbow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxRainbow.TabIndex = 11;
            this.pBoxRainbow.TabStop = false;
            this.pBoxRainbow.Click += new System.EventHandler(this.pBoxRainbow_Click);
            // 
            // pBoxAddClients
            // 
            this.pBoxAddClients.BackColor = System.Drawing.Color.Transparent;
            this.pBoxAddClients.Image = global::RainbowLight.Properties.Resources.addClients;
            this.pBoxAddClients.Location = new System.Drawing.Point(7, 0);
            this.pBoxAddClients.Name = "pBoxAddClients";
            this.pBoxAddClients.Size = new System.Drawing.Size(75, 67);
            this.pBoxAddClients.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxAddClients.TabIndex = 11;
            this.pBoxAddClients.TabStop = false;
            this.pBoxAddClients.Click += new System.EventHandler(this.pBoxAddClients_Click);
            // 
            // pBoxInfoClients
            // 
            this.pBoxInfoClients.BackColor = System.Drawing.Color.Transparent;
            this.pBoxInfoClients.Image = global::RainbowLight.Properties.Resources.Info_clients;
            this.pBoxInfoClients.Location = new System.Drawing.Point(291, 0);
            this.pBoxInfoClients.Name = "pBoxInfoClients";
            this.pBoxInfoClients.Size = new System.Drawing.Size(73, 67);
            this.pBoxInfoClients.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxInfoClients.TabIndex = 9;
            this.pBoxInfoClients.TabStop = false;
            this.pBoxInfoClients.Click += new System.EventHandler(this.pBoxReservedRoom_Click);
            // 
            // pBoxAvailRooms
            // 
            this.pBoxAvailRooms.BackColor = System.Drawing.Color.Transparent;
            this.pBoxAvailRooms.Image = global::RainbowLight.Properties.Resources.bd;
            this.pBoxAvailRooms.Location = new System.Drawing.Point(197, 0);
            this.pBoxAvailRooms.Name = "pBoxAvailRooms";
            this.pBoxAvailRooms.Size = new System.Drawing.Size(73, 67);
            this.pBoxAvailRooms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxAvailRooms.TabIndex = 8;
            this.pBoxAvailRooms.TabStop = false;
            this.pBoxAvailRooms.Click += new System.EventHandler(this.pBoxFreeRooms_Click);
            // 
            // pBoxStatistics
            // 
            this.pBoxStatistics.BackColor = System.Drawing.Color.Transparent;
            this.pBoxStatistics.Image = global::RainbowLight.Properties.Resources.statistics;
            this.pBoxStatistics.Location = new System.Drawing.Point(618, 0);
            this.pBoxStatistics.Name = "pBoxStatistics";
            this.pBoxStatistics.Size = new System.Drawing.Size(73, 67);
            this.pBoxStatistics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxStatistics.TabIndex = 12;
            this.pBoxStatistics.TabStop = false;
            this.pBoxStatistics.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pBoxSearch
            // 
            this.pBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.pBoxSearch.Image = global::RainbowLight.Properties.Resources.search;
            this.pBoxSearch.Location = new System.Drawing.Point(510, 0);
            this.pBoxSearch.Name = "pBoxSearch";
            this.pBoxSearch.Size = new System.Drawing.Size(73, 67);
            this.pBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxSearch.TabIndex = 10;
            this.pBoxSearch.TabStop = false;
            this.pBoxSearch.Click += new System.EventHandler(this.pBoxSearch_Click);
            // 
            // labelMain
            // 
            this.labelMain.BackColor = System.Drawing.Color.Transparent;
            this.labelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMain.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain.ForeColor = System.Drawing.Color.White;
            this.labelMain.Image = global::RainbowLight.Properties.Resources.mainLabel1;
            this.labelMain.Location = new System.Drawing.Point(19, 97);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(955, 473);
            this.labelMain.TabIndex = 17;
            this.labelMain.Text = "Добро пожаловать в систему учета клиентов отеля\r\nRainbow Light";
            this.labelMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 640);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxArrowUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxArrowDown)).EndInit();
            this.PanelMenu2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxEmailDev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDonate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOptions)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxReservedRooms2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUnlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRainbow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxInfoClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAvailRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pBoxUnlogin;
        private System.Windows.Forms.PictureBox pBoxAvailRooms;
        private System.Windows.Forms.PictureBox pBoxExit;
        private System.Windows.Forms.PictureBox pBoxStatistics;
        private System.Windows.Forms.PictureBox pBoxAddClients;
        private System.Windows.Forms.PictureBox pBoxSearch;
        private System.Windows.Forms.PictureBox pBoxInfoClients;
        private System.Windows.Forms.PictureBox pBoxOptions;
        private System.Windows.Forms.PictureBox pBoxRainbow;
        private System.Windows.Forms.PictureBox pBoxEmailDev;
        private System.Windows.Forms.PictureBox pBoxDonate;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.PictureBox pBoxReservedRooms2;
        public System.Windows.Forms.Panel PanelMenu;
        public System.Windows.Forms.Panel PanelMenu2;
        public System.Windows.Forms.PictureBox pBoxArrowDown;
        public System.Windows.Forms.PictureBox pBoxArrowUp;
        public System.Windows.Forms.Panel MainPanel;
    }
}
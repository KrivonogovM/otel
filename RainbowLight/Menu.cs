using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace RainbowLight
{
    public partial class Menu : Form
    {
        internal object nextPageMainmenu;

        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox_arrowDown_Click(object sender, EventArgs e)
        {
            if (PanelMenu2.Visible == false)
            {
                PanelMenu2.Visible = true;
            }
            else
            {
                PanelMenu2.Visible = false;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(UControl_Statistics.nextPageStatistics))
            {
                MainPanel.Controls.Add(UControl_Statistics.nextPageStatistics);
                UControl_Statistics.nextPageStatistics.Dock = DockStyle.Fill;
                UControl_Statistics.nextPageStatistics.BringToFront();

            }
            else
            {
                UControl_Statistics.nextPageStatistics.BringToFront();
            }
            PanelMenu.BringToFront();
            pBoxArrowUp.BringToFront();
        }

        private void pBoxAddClients_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(UControl_AddGuests.nextPageAddGuests))
            {
                MainPanel.Controls.Add(UControl_AddGuests.nextPageAddGuests);
                UControl_AddGuests.nextPageAddGuests.Dock = DockStyle.Fill;
                UControl_AddGuests.nextPageAddGuests.BringToFront();

            }
            else
            {
                UControl_AddGuests.nextPageAddGuests.BringToFront();
            }
            PanelMenu.BringToFront();
            pBoxArrowUp.BringToFront();
        }

        private void pBoxOptions_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(UControl_Options.nextPageOptions))
            {
                MainPanel.Controls.Add(UControl_Options.nextPageOptions);
                UControl_Options.nextPageOptions.Dock = DockStyle.Fill;
                UControl_Options.nextPageOptions.BringToFront();

            }
            else
            {
                UControl_Options.nextPageOptions.BringToFront();
            }
        }

        private void pBoxExit_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Вы уверены что хотите выйти из программы?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
              Environment.Exit(0);
           }
        }

        private void pBoxUnlogin_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Hide();
        }

        private void pBoxRainbow_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void pBoxFreeRooms_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(UControl_AvailabilityRooms.nextPageAvailRooms))
            {
                MainPanel.Controls.Add(UControl_AvailabilityRooms.nextPageAvailRooms);
                UControl_AvailabilityRooms.nextPageAvailRooms.Dock = DockStyle.Fill;
                UControl_AvailabilityRooms.nextPageAvailRooms.BringToFront();

            }
            else
            {
                UControl_AvailabilityRooms.nextPageAvailRooms.BringToFront();
            }
            PanelMenu.BringToFront();
            pBoxArrowUp.BringToFront();
        }

        private void pBoxReservedRoom_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(UControl_InformationClients.nextPageReservedRooms))
            {
                MainPanel.Controls.Add(UControl_InformationClients.nextPageReservedRooms);
                UControl_InformationClients.nextPageReservedRooms.Dock = DockStyle.Fill;
                UControl_InformationClients.nextPageReservedRooms.BringToFront();

            }
            else
            {
                UControl_InformationClients.nextPageReservedRooms.BringToFront();
            }
            PanelMenu.BringToFront();
            pBoxArrowUp.BringToFront();
        }

        private void pBoxSearch_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(UControl_Search.nextPageSearch))
            {
                MainPanel.Controls.Add(UControl_Search.nextPageSearch);
                UControl_Search.nextPageSearch.Dock = DockStyle.Fill;
                UControl_Search.nextPageSearch.BringToFront();

            }
            else
            {
                UControl_Search.nextPageSearch.BringToFront();
            }
            PanelMenu.BringToFront();
            pBoxArrowUp.BringToFront();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pBoxArrowUp_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Visible == false)
            {
                PanelMenu.Visible = true;
            }
            else
            {
                PanelMenu.Visible = false;
            }
        }

        private void pBoxInfoClients_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(UControl_InformationClients.nextPageReservedRooms))
            {
                MainPanel.Controls.Add(UControl_InformationClients.nextPageReservedRooms);
                UControl_InformationClients.nextPageReservedRooms.Dock = DockStyle.Fill;
                UControl_InformationClients.nextPageReservedRooms.BringToFront();

            }
            else
            {
                UControl_InformationClients.nextPageReservedRooms.BringToFront();
            }
            PanelMenu.BringToFront();
            pBoxArrowUp.BringToFront();
        }

        private void pBoxReservedRooms2_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(UControl_ResRooms.nextPageResRooms))
            {
                MainPanel.Controls.Add(UControl_ResRooms.nextPageResRooms);
                UControl_ResRooms.nextPageResRooms.Dock = DockStyle.Fill;
                UControl_ResRooms.nextPageResRooms.BringToFront();

            }
            else
            {
                UControl_ResRooms.nextPageResRooms.BringToFront();
            }
            PanelMenu.BringToFront();
            pBoxArrowUp.BringToFront();
        }

        private void pBoxDonate_Click(object sender, EventArgs e)
        {
            Process.Start("https://donate.qiwi.com/payin/EzIK");
        }

        private void pBoxEmailDev_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/krivonogov_maxim");
        }
    }
}

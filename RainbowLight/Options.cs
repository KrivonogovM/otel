using System;
using System.Drawing;
using System.Windows.Forms;

namespace RainbowLight
{
    public partial class UControl_Options : UserControl
    {
        public UControl_Options()
        {
            InitializeComponent();
        }

        private static UControl_Options nextPage_Opt1;
        private static Menu mainmenu;
        Menu Menu = new Menu();
        public static Menu nextPageMainmenu
        {
            get
            {
                if (mainmenu == null)
                {
                    mainmenu = new Menu();
                }
                return mainmenu;
            }
        }

        public static UControl_Options nextPageOptions
        {
            get
            {
                if (nextPage_Opt1 == null)
                {
                    nextPage_Opt1 = new UControl_Options();
                }
                return nextPage_Opt1;
            }
        }

        private void pBoxRainbow_Click(object sender, EventArgs e)
        {
            nextPageMainmenu.Show();
            this.Hide();
        }

        private void pictureBoxRed_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromKnownColor(KnownColor.Red);
            nextPageMainmenu.PanelMenu.BackColor= Color.FromKnownColor(KnownColor.Red);
            nextPageMainmenu.PanelMenu2.BackColor= Color.FromKnownColor(KnownColor.Red);
            nextPageMainmenu.pBoxArrowUp.BackColor= Color.FromKnownColor(KnownColor.Red);
            nextPageMainmenu.pBoxArrowDown.BackColor= Color.FromKnownColor(KnownColor.Red);
        }

        private void pictureBoxYellow_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromKnownColor(KnownColor.Yellow);
            nextPageMainmenu.PanelMenu.BackColor = Color.FromKnownColor(KnownColor.Yellow);
            nextPageMainmenu.PanelMenu2.BackColor = Color.FromKnownColor(KnownColor.Yellow);
            nextPageMainmenu.pBoxArrowUp.BackColor = Color.FromKnownColor(KnownColor.Yellow);
            nextPageMainmenu.pBoxArrowDown.BackColor = Color.FromKnownColor(KnownColor.Yellow);
        }

        private void pictureBoxGreen_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromKnownColor(KnownColor.Green);
            nextPageMainmenu.PanelMenu.BackColor = Color.FromKnownColor(KnownColor.Green);
            nextPageMainmenu.PanelMenu2.BackColor = Color.FromKnownColor(KnownColor.Green);
            nextPageMainmenu.pBoxArrowUp.BackColor = Color.FromKnownColor(KnownColor.Green);
            nextPageMainmenu.pBoxArrowDown.BackColor = Color.FromKnownColor(KnownColor.Green);
        }

        private void pictureBoxBlue_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromKnownColor(KnownColor.Blue);
            nextPageMainmenu.PanelMenu.BackColor = Color.FromKnownColor(KnownColor.Blue);
            nextPageMainmenu.PanelMenu2.BackColor = Color.FromKnownColor(KnownColor.Blue);
            nextPageMainmenu.pBoxArrowUp.BackColor = Color.FromKnownColor(KnownColor.Blue);
            nextPageMainmenu.pBoxArrowDown.BackColor = Color.FromKnownColor(KnownColor.Blue);
        }

        private void pictureBoxOrange_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromKnownColor(KnownColor.Orange);
            nextPageMainmenu.PanelMenu.BackColor = Color.FromKnownColor(KnownColor.Orange);
            nextPageMainmenu.PanelMenu2.BackColor = Color.FromKnownColor(KnownColor.Orange);
            nextPageMainmenu.pBoxArrowUp.BackColor = Color.FromKnownColor(KnownColor.Orange);
            nextPageMainmenu.pBoxArrowDown.BackColor = Color.FromKnownColor(KnownColor.Orange);
        }

        private void pictureBoxPurple_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromKnownColor(KnownColor.Purple);
            nextPageMainmenu.PanelMenu.BackColor = Color.FromKnownColor(KnownColor.Purple);
            nextPageMainmenu.PanelMenu2.BackColor = Color.FromKnownColor(KnownColor.Purple);
            nextPageMainmenu.pBoxArrowUp.BackColor = Color.FromKnownColor(KnownColor.Purple);
            nextPageMainmenu.pBoxArrowDown.BackColor = Color.FromKnownColor(KnownColor.Purple);
        }

        private void pictureBoxCyan_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromKnownColor(KnownColor.Cyan);
            nextPageMainmenu.PanelMenu.BackColor = Color.FromKnownColor(KnownColor.Cyan);
            nextPageMainmenu.PanelMenu2.BackColor = Color.FromKnownColor(KnownColor.Cyan);
            nextPageMainmenu.pBoxArrowUp.BackColor = Color.FromKnownColor(KnownColor.Cyan);
            nextPageMainmenu.pBoxArrowDown.BackColor = Color.FromKnownColor(KnownColor.Cyan);
        }

        private void pictureBoxPink_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromKnownColor(KnownColor.Thistle);
            nextPageMainmenu.PanelMenu.BackColor = Color.FromKnownColor(KnownColor.Thistle);
            nextPageMainmenu.PanelMenu2.BackColor = Color.FromKnownColor(KnownColor.Thistle);
            nextPageMainmenu.pBoxArrowUp.BackColor = Color.FromKnownColor(KnownColor.Thistle);
            nextPageMainmenu.pBoxArrowDown.BackColor = Color.FromKnownColor(KnownColor.Thistle);
        }
    }
}

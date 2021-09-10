using System;
using System.Windows.Forms;

namespace RainbowLight
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        void pas()
        {
            if(textBox_LoginPass.Text == "admin")
            {
                Form menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Сообщение", MessageBoxButtons.OK);
            }
        }


        private void button_Login_Click(object sender, EventArgs e)
        {
            pas();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox_LoginUser.Text = "admin";
        }

        private void pictureBoxExitIco_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

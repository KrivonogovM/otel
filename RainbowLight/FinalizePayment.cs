using System;
using System.Drawing;
using System.Windows.Forms;

namespace RainbowLight
{
    public partial class FinalizePayment : Form
    {
        public FinalizePayment()
        {
            InitializeComponent();
        }

        double typeRoomFin1 = 30, typeRoomFin2 = 40, typeRoomFin3 = 50, typeRoomFin4 = 60, typeRoomFin5 = 70, s, s0, s1, s2, s3;


        private void pictureBoxExitIco_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите выйти из формы оплаты?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            comboBoxCVC.Text = null;
            comboBoxCVC.ForeColor = Color.Black;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBoxNumberCard.Text = null;
            comboBoxNumberCard.ForeColor = Color.Black;
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            comboBoxMonthCard.ForeColor = Color.Black;
        }

        private void comboBox4_DropDown(object sender, EventArgs e)
        {
            comboBoxYearCard.ForeColor = Color.Black;
        }

        private void FinalizePayment_Load(object sender, EventArgs e)
        {/*
            if (UControl_AddGuests.nextPageAddGuests.comboBoxTypeRoom.SelectedItem == "Одноместный")
            {
                textBoxTotalforRoom.Clear();
                textBoxTotalforRoom.Text = Convert.ToString(typeRoomFin1);
                textBoxTotalAmount.Text = Convert.ToString(typeRoomFin1);
            }
            else if (UControl_AddGuests.nextPageAddGuests.comboBoxTypeRoom.SelectedItem == "Дуплекс")
            {
                textBoxTotalforRoom.Clear();
                textBoxTotalforRoom.Text = Convert.ToString(typeRoomFin2);
                textBoxTotalAmount.Text = Convert.ToString(typeRoomFin2);
            }
            else if (UControl_AddGuests.nextPageAddGuests.comboBoxTypeRoom.SelectedItem == "Люкс")
            {
                textBoxTotalforRoom.Clear();
                textBoxTotalforRoom.Text = Convert.ToString(typeRoomFin3);
                textBoxTotalAmount.Text = Convert.ToString(typeRoomFin3);
            }
            else if (UControl_AddGuests.nextPageAddGuests.comboBoxTypeRoom.SelectedItem == "Апартаменты")
            {
                textBoxTotalforRoom.Clear();
                textBoxTotalforRoom.Text = Convert.ToString(typeRoomFin4);
                textBoxTotalAmount.Text = Convert.ToString(typeRoomFin4);
            }
            else if (UControl_AddGuests.nextPageAddGuests.comboBoxTypeRoom.SelectedItem == "Семейный")
            {
                textBoxTotalforRoom.Clear();
                textBoxTotalforRoom.Text = Convert.ToString(typeRoomFin5);
                textBoxTotalAmount.Text = Convert.ToString(typeRoomFin5);
            }


            if (textBoxTotalforUslugi.Text == null)
            {
                s1 = Convert.ToInt32(textBoxTotalforVozm.Text) + Convert.ToInt32(textBoxTotalforRoom.Text);
                textBoxTotalAmount.Text = Convert.ToString(s1);
            }
            else if (textBoxTotalforVozm.Text == null)
            {
                s2 = Convert.ToInt32(textBoxTotalforUslugi.Text) + Convert.ToInt32(textBoxTotalforRoom.Text);
                textBoxTotalAmount.Text = Convert.ToString(s2);
            }
            else if (textBoxTotalAmount.Text != null)
            {
                s = Convert.ToInt32(textBoxTotalforRoom.Text) + Convert.ToInt32(textBoxTotalforUslugi.Text) + Convert.ToInt32(textBoxTotalforVozm.Text);
                textBoxTotalAmount.Text = Convert.ToString(s);
            }*/
        }
    }
}

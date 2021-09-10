using System;
using System.Windows.Forms;

namespace RainbowLight
{
    public partial class DopUslugi : Form
    {
        public DopUslugi()
        {
            InitializeComponent();
        }
        FinalizePayment nextpageFinalizePayment = new FinalizePayment();
        UControl_AddGuests nextpageUControl = new UControl_AddGuests();
        double typeRoomFin1 = 30, typeRoomFin2 = 40, typeRoomFin3 = 50, typeRoomFin4 = 60, typeRoomFin5 = 70,s,s1,s2;

        private void pictureBoxExitIco_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите выйти из меню доп.услуг?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void buttonReserved2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Номер забронирован!", "Сообщение", MessageBoxButtons.OK);
        }

        public void button1_Click(object sender, EventArgs e)
        {

            if (UControl_AddGuests.nextPageAddGuests.comboBoxTypeRoom.SelectedItem == "Одноместный")
            {
                nextpageFinalizePayment.textBoxTotalforRoom.Clear();
                nextpageFinalizePayment.textBoxTotalforRoom.Text = Convert.ToString(typeRoomFin1);
                nextpageFinalizePayment.textBoxTotalAmount.Text = Convert.ToString(typeRoomFin1);
            }
            else if (UControl_AddGuests.nextPageAddGuests.comboBoxTypeRoom.SelectedItem == "Дуплекс")
            {
                nextpageFinalizePayment.textBoxTotalforRoom.Clear();
                nextpageFinalizePayment.textBoxTotalforRoom.Text = Convert.ToString(typeRoomFin2);
                nextpageFinalizePayment.textBoxTotalAmount.Text = Convert.ToString(typeRoomFin2);
            }
            else if (UControl_AddGuests.nextPageAddGuests.comboBoxTypeRoom.SelectedItem == "Люкс")
            {
                nextpageFinalizePayment.textBoxTotalforRoom.Clear();
                nextpageFinalizePayment.textBoxTotalforRoom.Text = Convert.ToString(typeRoomFin3);
                nextpageFinalizePayment.textBoxTotalAmount.Text = Convert.ToString(typeRoomFin3);
            }
            else if (UControl_AddGuests.nextPageAddGuests.comboBoxTypeRoom.SelectedItem == "Апартаменты")
            {
                nextpageFinalizePayment.textBoxTotalforRoom.Clear();
                nextpageFinalizePayment.textBoxTotalforRoom.Text = Convert.ToString(typeRoomFin4);
                nextpageFinalizePayment.textBoxTotalAmount.Text = Convert.ToString(typeRoomFin4);
            }
            else if (UControl_AddGuests.nextPageAddGuests.comboBoxTypeRoom.SelectedItem == "Семейный")
            {
                nextpageFinalizePayment.textBoxTotalforRoom.Clear();
                nextpageFinalizePayment.textBoxTotalforRoom.Text = Convert.ToString(typeRoomFin5);
                nextpageFinalizePayment.textBoxTotalAmount.Text = Convert.ToString(typeRoomFin5);
            }
            if (checkBoxZavtrak.Checked | checkBoxCleaning.Checked | checkBoxTowel.Checked)
            {
                double zavtrak = 10;
                double towel = 10;
                double clean = 20;
                double sd;
                sd = zavtrak + towel + clean;
                nextpageFinalizePayment.textBoxTotalforUslugi.Text = Convert.ToString(zavtrak);
                nextpageFinalizePayment.textBoxTotalforVozm.Text = Convert.ToString(towel + clean);

            }

            if (nextpageFinalizePayment.textBoxTotalforUslugi.Text == null)
            {
                s1 = Convert.ToInt32(nextpageFinalizePayment.textBoxTotalforVozm.Text) + Convert.ToInt32(nextpageFinalizePayment.textBoxTotalforRoom.Text);
                nextpageFinalizePayment.textBoxTotalAmount.Text = Convert.ToString(s1);
            }
            else if (nextpageFinalizePayment.textBoxTotalforVozm.Text == null)
            {
                s2 = Convert.ToInt32(nextpageFinalizePayment.textBoxTotalforUslugi.Text) + Convert.ToInt32(nextpageFinalizePayment.textBoxTotalforRoom.Text);
                nextpageFinalizePayment.textBoxTotalAmount.Text = Convert.ToString(s2);
            }
            else if (nextpageFinalizePayment.textBoxTotalAmount.Text != null)
            {
                s = Convert.ToInt32(nextpageFinalizePayment.textBoxTotalforRoom.Text) + Convert.ToInt32(nextpageFinalizePayment.textBoxTotalforUslugi.Text) + Convert.ToInt32(nextpageFinalizePayment.textBoxTotalforVozm.Text);
                nextpageFinalizePayment.textBoxTotalAmount.Text = Convert.ToString(s);
            }
            nextpageFinalizePayment.Show();
            this.Hide();
        }
    }
}

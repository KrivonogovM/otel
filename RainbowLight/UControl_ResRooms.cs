using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using RainbowLight.Resources;
using System.Data.SqlClient;

namespace RainbowLight
{
    public partial class UControl_ResRooms : UserControl
    {
        public UControl_ResRooms()
        {
            InitializeComponent();
            dgv.TableDesign(dgvReservedRooms2);
        }

        Dgv dgv = new Dgv();
        public static UControl_ResRooms nextPage7;

        public static UControl_ResRooms nextPageResRooms
        {
            get
            {
                if (nextPage7 == null)
                {
                    nextPage7 = new UControl_ResRooms();
                }
                return nextPage7;
            }
        }
        public void LoadDb2()
        {
            try
            {
                string Constring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_RainbowLight.mdf;Integrated Security=True");//@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Учение\Диплом\RainbowLight\test\RainbowLight\RainbowLight\Database_RainbowLight.mdf;Integrated Security=True");
                SqlConnection sql_con = new SqlConnection(Constring);
                sql_con.Open();
                SqlDataAdapter sql_adapter = new SqlDataAdapter("SELECT * FROM ЗабронированныеНомера", sql_con);
                DataTable dt = new DataTable();
                sql_adapter.Fill(dt);
                dgvReservedRooms2.DataSource = dt;
                sql_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        void InsDb2()
        {
            try
            {
                string Constring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_RainbowLight.mdf;Integrated Security=True");
                string insstring = ("INSERT INTO ЗабронированныеНомера (Имя,Фамилия,НомерТелефона,ДатаВъездаRes,ДатаВыездаRes,ТипНомера,НомерКомнаты) VALUES (@Имя,@Фамилия,@НомерТелефона,@ДатаВъездаRes,@ДатаВыездаRes,@ТипНомера,@НомерКомнаты)");
                SqlCommand sql_com = new SqlCommand();
                SqlConnection sql_con = new SqlConnection(Constring);
                sql_con.Open();
                sql_com.CommandText = (insstring);
                sql_com.Connection = sql_con;
                int i = 0;
                sql_com.Parameters.AddWithValue("@Id", dgvReservedRooms2.Rows[i].Cells[0].Value == null ?
                string.Empty : dgvReservedRooms2.Rows[i].Cells[0].Value.ToString());
                sql_com.Parameters.AddWithValue("@Имя", textBoxNameGuests2.Text);
                sql_com.Parameters.AddWithValue("@Фамилия", textBoxSurnameGuests2.Text);
                sql_com.Parameters.AddWithValue("@НомерТелефона", Convert.ToInt64(textBoxNumberPhone2.Text));
                sql_com.Parameters.AddWithValue("@ДатаВъездаRes", Convert.ToDateTime(dateTimePickerEntry2.Text));
                sql_com.Parameters.AddWithValue("@ДатаВыездаRes", Convert.ToDateTime(dateTimePickerDeperture2.Text));
                sql_com.Parameters.AddWithValue("@ТипНомера", Convert.ToString(comboBoxTypeRoom2.Text));
                sql_com.Parameters.AddWithValue("@НомерКомнаты", Convert.ToInt64(comboBoxNumberRoom2.Text));
                sql_com.ExecuteNonQuery();
                sql_con.Close();
                sql_com.Parameters.Clear();
                MessageBox.Show("Номер забронирован!", "Сообщение", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void buttonReserved_Click(object sender, EventArgs e)
        {
            InsDb2();
            LoadDb2();
            try
            {
                string Constring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_RainbowLight.mdf;Integrated Security=True");
                SqlConnection sql_con = new SqlConnection(Constring);
                sql_con.Open();
                SqlDataAdapter sql_adapter = new SqlDataAdapter("SELECT * FROM ЗабронированныеНомера", sql_con);
                DataTable dt = new DataTable();
                sql_adapter.Fill(dt);
                UControl_AvailabilityRooms.nextPageAvailRooms.dgvReservedRooms.DataSource = dt;
                sql_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void textBoxNameGuests2_Click(object sender, EventArgs e)
        {
            textBoxNameGuests2.Text = null;
            textBoxNameGuests2.ForeColor = Color.Black;
        }

        private void textBoxSurnameGuests2_Click(object sender, EventArgs e)
        {
            textBoxSurnameGuests2.Text = null;
            textBoxSurnameGuests2.ForeColor = Color.Black;
        }

        private void textBoxPatronymicGuests2_Click(object sender, EventArgs e)
        {
            textBoxPatronymicGuests2.Text = null;
            textBoxPatronymicGuests2.ForeColor = Color.Black;
        }

        private void textBoxNumberPhone2_Click(object sender, EventArgs e)
        {
            textBoxNumberPhone2.Text = null;
            textBoxNumberPhone2.ForeColor = Color.Black;
        }

        private void textBoxEmail2_Click(object sender, EventArgs e)
        {
            textBoxEmail2.Text = null;
            textBoxEmail2.ForeColor = Color.Black;
        }

        private void UControl_ResRooms_Load(object sender, EventArgs e)
        {
            LoadDb2();
        }

        private void comboBoxTypeRoom2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNumberRoom2.Items.Clear();
            comboBoxNumberRoom2.ForeColor = Color.Black;
            if (comboBoxTypeRoom2.SelectedItem.Equals("Одноместный"))
            {
                comboBoxNumberRoom2.Items.Add(101);
                comboBoxNumberRoom2.Items.Add(102);
                comboBoxNumberRoom2.Items.Add(201);
                comboBoxNumberRoom2.Items.Add(202);
                comboBoxNumberRoom2.Items.Add(301);
                comboBoxNumberRoom2.Items.Add(302);
                comboBoxNumberRoom2.Items.Add(401);
                comboBoxNumberRoom2.Items.Add(402);
                comboBoxNumberRoom2.Items.Add(501);
                comboBoxNumberRoom2.Items.Add(502);
            }
            else if (comboBoxTypeRoom2.SelectedItem.Equals("Люкс"))
            {
                comboBoxNumberRoom2.Items.Clear();
                comboBoxNumberRoom2.Items.Add(103);
                comboBoxNumberRoom2.Items.Add(105);
                comboBoxNumberRoom2.Items.Add(203);
                comboBoxNumberRoom2.Items.Add(303);
                comboBoxNumberRoom2.Items.Add(403);
                comboBoxNumberRoom2.Items.Add(503);
            }
            else if (comboBoxTypeRoom2.SelectedItem.Equals("Апартаменты"))
            {
                comboBoxNumberRoom2.Items.Clear();
                comboBoxNumberRoom2.Items.Add(104);
                comboBoxNumberRoom2.Items.Add(204);
                comboBoxNumberRoom2.Items.Add(304);
                comboBoxNumberRoom2.Items.Add(404);
            }
            else if (comboBoxTypeRoom2.SelectedItem.Equals("Дуплекс"))
            {
                comboBoxNumberRoom2.Items.Clear();
                comboBoxNumberRoom2.Items.Add(504);
                comboBoxNumberRoom2.Items.Add(505);
            }
            else if (comboBoxTypeRoom2.SelectedItem.Equals("Семейный"))
            {
                comboBoxNumberRoom2.Items.Clear();
                comboBoxNumberRoom2.Items.Add(205);
                comboBoxNumberRoom2.Items.Add(305);
            }
        }

        private void comboBoxNumberRoom2_Click(object sender, EventArgs e)
        {
            comboBoxNumberRoom2.ForeColor = Color.Black;
        }
    }
}

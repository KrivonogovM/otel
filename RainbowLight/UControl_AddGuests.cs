using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using RainbowLight.Resources;


namespace RainbowLight
{
    public partial class UControl_AddGuests : UserControl
    {
        public UControl_AddGuests()
        {
            InitializeComponent();
            dgv.TableDesign(dgvGuests);
        }

        Dgv dgv = new Dgv();
        public static UControl_AddGuests nextPage1;
        Form FinalizePayment = new FinalizePayment();
        double typeRoomFin1 = 30, typeRoomFin2 = 40, typeRoomFin3 = 50, typeRoomFin4 = 60, typeRoomFin5 = 70,s,s0,s1,s2,s3;

        public static FinalizePayment finPay;
        public static FinalizePayment nextPageFinPay
        {
            get
            {
                if (finPay == null)
                {
                    finPay = new FinalizePayment();
                }
                return finPay;
            }
        }
        public static UControl_AddGuests nextPageAddGuests
        {
            get
            {
                if (nextPage1 == null)
                {
                    nextPage1 = new UControl_AddGuests();
                }
                return nextPage1;
            }
        }

        public void LoadDb()
        {
            try
            {
                string Constring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_RainbowLight.mdf;Integrated Security=True");//@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Учение\Диплом\RainbowLight\test\RainbowLight\RainbowLight\Database_RainbowLight.mdf;Integrated Security=True");
                SqlConnection sql_con = new SqlConnection(Constring);
                sql_con.Open();
                SqlDataAdapter sql_adapter = new SqlDataAdapter("SELECT * FROM Гости", sql_con);
                DataTable dt = new DataTable();
                sql_adapter.Fill(dt);
                dgvGuests.DataSource = dt;
                sql_con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void InsDb()
        {
            try
            {
                string Constring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_RainbowLight.mdf;Integrated Security=True");
                string insstring = ("INSERT INTO Гости (Имя,Фамилия,Отчество,Пол,ДатаРождения,НомерТелефона,Email,Страна,Область,Город,Улица,Дом,Квартира) VALUES (@Имя,@Фамилия,@Отчество,@Пол,@ДатаРождения,@НомерТелефона,@Email,@Страна,@Область,@Город,@Улица,@Дом,@Квартира)");
                SqlCommand sql_com = new SqlCommand();
                SqlConnection sql_con = new SqlConnection(Constring);
                sql_con.Open();
                sql_com.CommandText = (insstring);
                sql_com.Connection = sql_con;
                int i = 0;
                sql_com.Parameters.AddWithValue("@Id", dgvGuests.Rows[i].Cells[0].Value == null ?
                string.Empty : dgvGuests.Rows[i].Cells[0].Value.ToString());
                sql_com.Parameters.AddWithValue("@Имя", textBoxNameGuests.Text);
                sql_com.Parameters.AddWithValue("@Фамилия", textBoxSurnameGuests.Text);
                sql_com.Parameters.AddWithValue("@Отчество", textBoxPatronymicGuests.Text);
                sql_com.Parameters.AddWithValue("@Пол", comboBoxGenderGuests.Text);
                sql_com.Parameters.AddWithValue("@ДатаРождения", Convert.ToDateTime(comboBoxDayGuests.Text + comboBoxMonthGuests.Text + textBoxYearGuests.Text));
                sql_com.Parameters.AddWithValue("@НомерТелефона", Convert.ToInt64(textBoxNumberPhone.Text));
                sql_com.Parameters.AddWithValue("@Email", Convert.ToString(textBoxEmail.Text));
                sql_com.Parameters.AddWithValue("@Страна", textBoxCountry.Text);
                sql_com.Parameters.AddWithValue("@Область", comboBoxRegion.Text);
                sql_com.Parameters.AddWithValue("@Город", textBoxCity.Text);
                sql_com.Parameters.AddWithValue("@Улица", textBoxStreet.Text);
                sql_com.Parameters.AddWithValue("@Дом", Convert.ToInt64(textBoxHouse.Text));
                sql_com.Parameters.AddWithValue("@Квартира", Convert.ToInt64(textBoxApartment.Text));
                sql_com.ExecuteNonQuery();
                sql_con.Close();
                sql_com.Parameters.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        /*
        void UpdDb()
        {
            try
            {
                string Constring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_RainbowLight.mdf;Integrated Security=True");//@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Учение\Диплом\RainbowLight\test\RainbowLight\RainbowLight\Database_RainbowLight.mdf;Integrated Security=True");
                SqlConnection sql_con = new SqlConnection(Constring);
                SqlCommand sql_com = new SqlCommand();
                sql_con.Open();
                SqlDataAdapter sql_adapter1 = new SqlDataAdapter("UPDATE [Гости] SET Имя=@Имя,Фамилия=@Фамилия,Отчество=@Отчество,Пол=@Пол,ДатаРождения=@ДатаРождения,НомерТелефона=@НомерТелефона,Email=@Email,Страна=@Страна,Область=@Область,Город=@Город,Улица=@Улица,Дом=@Дом,Квартира=@Квартира WHERE Id=@Id", sql_con);
                for (int i = 0; i < dgvGuests.RowCount; i++)
                {
                    sql_com.Parameters.AddWithValue("@Id", dgvGuests.Rows[i].Cells[0].Value == null ?
                    string.Empty : dgvGuests.Rows[i].Cells[0].Value.ToString());
                    sql_com.Parameters.AddWithValue("@Имя", dgvGuests.Rows[i].Cells[1].Value == null ?
                    string.Empty : dgvGuests.Rows[i].Cells[1].Value.ToString());
                    sql_com.Parameters.AddWithValue("@Фамилия", dgvGuests.Rows[i].Cells[2].Value == null ?
                    string.Empty : dgvGuests.Rows[i].Cells[2].Value.ToString());
                    sql_com.Parameters.AddWithValue("@Отчество", dgvGuests.Rows[i].Cells[3].Value == null ?
                    string.Empty : dgvGuests.Rows[i].Cells[3].Value.ToString());
                    sql_com.Parameters.AddWithValue("@Пол", dgvGuests.Rows[i].Cells[4].Value == null ?
                    string.Empty : dgvGuests.Rows[i].Cells[4].Value.ToString());
                    sql_com.Parameters.AddWithValue("@ДатаРождения", dgvGuests.Rows[i].Cells[5].Value == null ?
                    string.Empty : dgvGuests.Rows[i].Cells[5].Value.ToString());
                    sql_com.Parameters.AddWithValue("@НомерТелефона", dgvGuests.Rows[i].Cells[6].Value == null ?
                    string.Empty : dgvGuests.Rows[i].Cells[6].Value.ToString());
                    sql_com.Parameters.AddWithValue("@Email", dgvGuests.Rows[i].Cells[7].Value == null ?
                    string.Empty : dgvGuests.Rows[i].Cells[7].Value.ToString());
                    sql_com.Parameters.AddWithValue("@Страна", dgvGuests.Rows[i].Cells[8].Value == null ?
                    string.Empty : dgvGuests.Rows[i].Cells[8].Value.ToString());
                    sql_com.Parameters.AddWithValue("@Область", dgvGuests.Rows[i].Cells[9].Value == null ?
                    string.Empty : dgvGuests.Rows[i].Cells[9].Value.ToString());
                    sql_com.Parameters.AddWithValue("@Город", dgvGuests.Rows[i].Cells[10].Value == null ?
                    string.Empty : dgvGuests.Rows[i].Cells[10].Value.ToString());
                    sql_com.Parameters.AddWithValue("@Улица", dgvGuests.Rows[i].Cells[11].Value == null ?
                    string.Empty : dgvGuests.Rows[i].Cells[11].Value.ToString());
                    sql_com.Parameters.AddWithValue("@Дом", dgvGuests.Rows[i].Cells[12].Value == null ?
                    string.Empty : dgvGuests.Rows[i].Cells[12].Value.ToString());
                    sql_com.Parameters.AddWithValue("@Квартира", dgvGuests.Rows[i].Cells[13].Value == null ?
                    string.Empty : dgvGuests.Rows[i].Cells[13].Value.ToString());
                }
                DataTable dt1 = new DataTable();
                sql_adapter1.Fill(dt1);
                dgvGuests.DataSource = dt1;
                sql_con.Close();
                sql_com.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }*/

        public void SaveTable(DataGridView dgvSave, string save)
        {
            if (File.Exists(@save))
            {
                File.Delete(@save);
            }
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\" + save;
                Excel.Application excelapp = new Excel.Application();
                Excel.Workbook workbook = excelapp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.ActiveSheet;

                for (int i = 1; i < dgvSave.RowCount + 1; i++)
                {
                    for (int j = 1; j < dgvSave.ColumnCount + 1; j++)
                    {
                        worksheet.Rows[i].Columns[j] = dgvSave.Rows[i - 1].Cells[j - 1].Value;
                    }
                }
                excelapp.AlertBeforeOverwriting = false;
                workbook.SaveAs(path);
                excelapp.Quit();
                MessageBox.Show("База сохранена в excel формате", "Сообщение", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonDop_Click(object sender, EventArgs e)
        {
            Form DopUslugi = new DopUslugi();
            if (Convert.ToString(comboBoxTypeRoom.Text) == "" || Convert.ToString(textBoxNameGuests.Text) == "" || Convert.ToString(comboBoxMonthGuests.Text) == "" ||
                Convert.ToString(comboBoxNumberRoom.Text) == "" || Convert.ToString(comboBoxTypePayment.Text) == "")
            {
                MessageBox.Show("Заполните обязательные поля", "Сообщение", MessageBoxButtons.OK);
            }
            else
            {
                DopUslugi.Show();
            }
            InsDb();
            //UpdDb();
            LoadDb();
        }

        private void comboBox6_DropDown(object sender, EventArgs e)
        {
            comboBoxNumberGuests.ForeColor = Color.Black;
        }

        private void comboBox4_DropDown(object sender, EventArgs e)
        {
            comboBoxTypeRoom.ForeColor = Color.Black;
        }

        private void comboBox7_DropDown(object sender, EventArgs e)
        {
            comboBoxRegion.ForeColor = Color.Black;
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBoxDayGuests.ForeColor = Color.Black;
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            comboBoxMonthGuests.ForeColor = Color.Black;
        }

        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            comboBoxGenderGuests.ForeColor = Color.Black;
        }

        private void comboBox8_DropDown(object sender, EventArgs e)
        {
            comboBoxTypePayment.ForeColor = Color.Black;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBoxNameGuests.Text = null;
            textBoxNameGuests.ForeColor = Color.Black;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBoxSurnameGuests.Text = null;
            textBoxSurnameGuests.ForeColor = Color.Black;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBoxPatronymicGuests.Text = null;
            textBoxPatronymicGuests.ForeColor = Color.Black;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBoxYearGuests.Text = null;
            textBoxYearGuests.ForeColor = Color.Black;
        }

        private void textBox4_Click(object sender, EventArgs textBox4_Click)
        {
            textBoxNumberPhone.Text = null;
            textBoxNumberPhone.ForeColor = Color.Black;
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBoxEmail.Text = null;
            textBoxEmail.ForeColor = Color.Black;
        }

        private void textBox12_Click(object sender, EventArgs e)
        {
            textBoxCountry.Text = null;
            textBoxCountry.ForeColor = Color.Black;
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            textBoxCity.Text = null;
            textBoxCity.ForeColor = Color.Black;
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            textBoxStreet.Text = null;
            textBoxStreet.ForeColor = Color.Black;
        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            textBoxHouse.Text = null;
            textBoxHouse.ForeColor = Color.Black;
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            textBoxApartment.Text = null;
            textBoxApartment.ForeColor = Color.Black;
        }

        public void UControl_AddGuests_Load(object sender, EventArgs e)
        {
            LoadDb();
            textBoxCountry.Text = "Россия";
        }

        private void buttonPodsch_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(comboBoxTypeRoom.Text) == "" || Convert.ToString(textBoxNameGuests.Text) == "" || Convert.ToString(comboBoxMonthGuests.Text) == "" || 
                Convert.ToString(comboBoxNumberRoom.Text) == "" || Convert.ToString(comboBoxTypePayment.Text) == "")
            {
                MessageBox.Show("Заполните обязательные поля", "Сообщение", MessageBoxButtons.OK);
            }
            else
            {
                nextPageFinPay.Show();
            }
            InsDb();
            //UpdDb();
            LoadDb();

            if (comboBoxTypeRoom.SelectedItem == "Одноместный")
            {
                nextPageFinPay.textBoxTotalforRoom.Clear();
                nextPageFinPay.textBoxTotalforRoom.Text = Convert.ToString(typeRoomFin1);
                nextPageFinPay.textBoxTotalAmount.Text = Convert.ToString(typeRoomFin1);
            }
            else if (comboBoxTypeRoom.SelectedItem == "Дуплекс")
            {
                nextPageFinPay.textBoxTotalforRoom.Clear();
                nextPageFinPay.textBoxTotalforRoom.Text = Convert.ToString(typeRoomFin2);
                nextPageFinPay.textBoxTotalAmount.Text = Convert.ToString(typeRoomFin2);
            }
            else if (comboBoxTypeRoom.SelectedItem == "Люкс")
            {
                nextPageFinPay.textBoxTotalforRoom.Clear();
                nextPageFinPay.textBoxTotalforRoom.Text = Convert.ToString(typeRoomFin3);
                nextPageFinPay.textBoxTotalAmount.Text = Convert.ToString(typeRoomFin3);
            }
            else if (comboBoxTypeRoom.SelectedItem == "Апартаменты")
            {
                nextPageFinPay.textBoxTotalforRoom.Clear();
                nextPageFinPay.textBoxTotalforRoom.Text = Convert.ToString(typeRoomFin4);
                nextPageFinPay.textBoxTotalAmount.Text = Convert.ToString(typeRoomFin4);
            }
            else if (comboBoxTypeRoom.SelectedItem == "Семейный")
            {
                nextPageFinPay.textBoxTotalforRoom.Clear();
                nextPageFinPay.textBoxTotalforRoom.Text = Convert.ToString(typeRoomFin5);
                nextPageFinPay.textBoxTotalAmount.Text = Convert.ToString(typeRoomFin5);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNumberRoom.Items.Clear();
            comboBoxNumberRoom.ForeColor = Color.Black;
            if (comboBoxTypeRoom.SelectedItem.Equals("Одноместный"))
            {
                comboBoxNumberRoom.Items.Add(101);
                comboBoxNumberRoom.Items.Add(102);
                comboBoxNumberRoom.Items.Add(201);
                comboBoxNumberRoom.Items.Add(202);
                comboBoxNumberRoom.Items.Add(301);
                comboBoxNumberRoom.Items.Add(302);
                comboBoxNumberRoom.Items.Add(401);
                comboBoxNumberRoom.Items.Add(402);
                comboBoxNumberRoom.Items.Add(501);
                comboBoxNumberRoom.Items.Add(502);
            }
            else if (comboBoxTypeRoom.SelectedItem.Equals("Люкс"))
            {
                comboBoxNumberRoom.Items.Clear();
                comboBoxNumberRoom.Items.Add(103);
                comboBoxNumberRoom.Items.Add(105);
                comboBoxNumberRoom.Items.Add(203);
                comboBoxNumberRoom.Items.Add(303);
                comboBoxNumberRoom.Items.Add(403);
                comboBoxNumberRoom.Items.Add(503);
            }
            else if (comboBoxTypeRoom.SelectedItem.Equals("Апартаменты"))
            {
                comboBoxNumberRoom.Items.Clear();
                comboBoxNumberRoom.Items.Add(104);
                comboBoxNumberRoom.Items.Add(204);
                comboBoxNumberRoom.Items.Add(304);
                comboBoxNumberRoom.Items.Add(404);
            }
            else if (comboBoxTypeRoom.SelectedItem.Equals("Дуплекс"))
            {
                comboBoxNumberRoom.Items.Clear();
                comboBoxNumberRoom.Items.Add(504);
                comboBoxNumberRoom.Items.Add(505);
            }
            else if (comboBoxTypeRoom.SelectedItem.Equals("Семейный"))
            {
                comboBoxNumberRoom.Items.Clear();
                comboBoxNumberRoom.Items.Add(205);
                comboBoxNumberRoom.Items.Add(305);
            }
        }

        private void textBoxNumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void panelBot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxPatronymicGuests_KeyPress(object sender, KeyPressEventArgs e)
        {
            char let = e.KeyChar;
            if ((let < 'а' || let > 'я') && (let < 'А' || let > 'Я') && (let < 'A' || let > 'z') && (let < 'a' || let > 'z') && let != 'ё' && let != 'Ё' && let != 8 && let != 9 && let != 11)
            {
                e.Handled = true;
            }
        }

        private void textBoxSurnameGuests_KeyPress(object sender, KeyPressEventArgs e)
        {
            char let = e.KeyChar;
            if ((let < 'а' || let > 'я') && (let < 'А' || let > 'Я') && (let < 'A' || let > 'z') && (let < 'a' || let > 'z') && let != 'ё' && let != 'Ё' && let != 8 && let != 9 && let != 11)
            {
                e.Handled = true;
            }
        }

        private void textBoxNameGuests_KeyPress(object sender, KeyPressEventArgs e)
        {
            char let = e.KeyChar;
            if ((let < 'а' || let > 'я') && (let < 'А' || let > 'Я') && (let < 'A' || let > 'z') && (let < 'a' || let > 'z') && let != 'ё' && let != 'Ё' && let != 8 && let != 9 && let != 11)
            {
                e.Handled = true;
            }
        }

        private void textBoxStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            char let = e.KeyChar;
            if ((let < 'а' || let > 'я') && (let < 'А' || let > 'Я') && (let < 'A' || let > 'z') && (let < 'a' || let > 'z') && let != 'ё' && let != 'Ё' && let != 8 && let != 9 && let != 11)
            {
                e.Handled = true;
            }
        }

        private void textBoxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char let = e.KeyChar;
            if ((let < 'а' || let > 'я') && (let < 'А' || let > 'Я') && (let < 'A' || let > 'z') && (let < 'a' || let > 'z') && let != 'ё' && let != 'Ё' && let != 8 && let != 9 && let != 11)
            {
                e.Handled = true;
            }
        }

        private void textBoxYearGuests_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxHouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxApartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonPech_Click(object sender, EventArgs e)
        {
            SaveTable(dgvGuests,"Гости");
        }
    }
}
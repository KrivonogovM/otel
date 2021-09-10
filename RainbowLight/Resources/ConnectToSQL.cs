using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;



namespace RainbowLight.Resources
{
    public class ConnectToSQL
    {
        /*
        public void LoadDb()
        {
            string Constring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Учение\Диплом\RainbowLight\test\RainbowLight\RainbowLight\Database_RainbowLight.mdf;Integrated Security=True");
            SqlConnection sql_con = new SqlConnection(Constring);
            sql_con.Open();
            SqlDataAdapter sql_adapter = new SqlDataAdapter("SELECT * FROM Гости", sql_con);
            DataTable dt = new DataTable();
            sql_adapter.Fill(dt);
            dgvGuests.DataSource = dt;
            полDataGridViewTextBoxColumn.DataSource = dt;
            полDataGridViewTextBoxColumn.ValueMember = "Пол";
            sql_con.Close();
        }
        public void InsDb()
        {
            SqlConnection Sql_con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Учение\Диплом\RainbowLight\test\RainbowLight\RainbowLight\Database_RainbowLight.mdf;Integrated Security=True");
            SqlCommand Sql_com = new SqlCommand();
            Sql_com.Connection = Sql_con;

            int i = 0;
            Sql_com.Parameters.AddWithValue("@Id", nextPageAddGuests_Sql.dgvGuests.Rows[i].Cells[0].Value == null ?
            string.Empty : nextPageAddGuests_Sql.dgvGuests.Rows[i].Cells[0].Value.ToString());
            Sql_com.Parameters.AddWithValue("@Имя", nextPageAddGuests_Sql.textBoxNameGuests.Text);
            Sql_com.Parameters.AddWithValue("@Фамилия", nextPageAddGuests_Sql.textBoxSurnameGuests.Text);
            Sql_com.Parameters.AddWithValue("@Отчество", nextPageAddGuests_Sql.textBoxPatronymicGuests.Text);
            Sql_com.Parameters.AddWithValue("@Пол", nextPageAddGuests_Sql.comboBoxGenderGuests.Text);
            Sql_com.Parameters.AddWithValue("@Дата рождения", nextPageAddGuests_Sql.comboBoxDayGuests.Text + nextPageAddGuests_Sql.comboBoxMonthGuests.Text + nextPageAddGuests_Sql.textBoxYearGuests.Text);
            Sql_com.Parameters.AddWithValue("@Номер телефона", nextPageAddGuests_Sql.textBoxNumberPhone.Text);
            Sql_com.Parameters.AddWithValue("@E-mail", nextPageAddGuests_Sql.textBoxEmail.Text);
            Sql_com.Parameters.AddWithValue("@Страна", nextPageAddGuests_Sql.textBoxCountry.Text);
            Sql_com.Parameters.AddWithValue("@Область", nextPageAddGuests_Sql.comboBoxRegion.Text);
            Sql_com.Parameters.AddWithValue("@Город", nextPageAddGuests_Sql.textBoxCity.Text);
            Sql_com.Parameters.AddWithValue("@Улица", nextPageAddGuests_Sql.textBoxStreet.Text);
            Sql_com.Parameters.AddWithValue("@Дом", nextPageAddGuests_Sql.textBoxHouse.Text);
            Sql_com.Parameters.AddWithValue("@Квартира", nextPageAddGuests_Sql.textBoxApartment.Text);

            Sql_con.Open();
            Sql_com.ExecuteNonQuery();
            Sql_com.Parameters.Clear();
            Sql_com.CommandText = ("insert into Гости values (@Имя,@Фамилия,@Отчество,@Пол,@Дата рождения,@Номер телефона,@E-mail,@Страна,@Область,@Город,@Улица,@Дом,@Квартира,@Оплата)");
            Database_RainbowLightDataSet Sql_dataset = new Database_RainbowLightDataSet();
            SqlDataAdapter Sql_adapter = new SqlDataAdapter(Sql_com);
            nextPageAddGuests_Sql.dgvGuests.DataSource = Sql_dataset;
            Sql_adapter.Fill(Sql_dataset);
            Sql_con.Close();
        }
        */
        //            string Delstring = ("delete from Гости where Id=@Id");
        public void ConToSQL()
        {
            SqlDataAdapter Sql_adapter = new SqlDataAdapter();
            SqlConnection Sql_con = new SqlConnection();
            SqlCommand Sql_com = new SqlCommand();
            //Database_RainbowLightDataSetGuests Sql_dataset = new Database_RainbowLightDataSetGuests();
            /*  string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string path = (System.IO.Path.GetDirectoryName(executable));
                AppDomain.CurrentDomain.SetData("DataDirectory", path);   */

            //ConnectionString = @"Data Source=|DataDirectory|\Database_RainbowLight.mdf;Integrated Security=True"; - относительный; локальный путь
            //@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Учение\Диплом\RainbowLight\test\RainbowLight\RainbowLight\Database_RainbowLight.mdf;Integrated Security=True"; - не относительный; локальный путь



            //полDataGridViewTextBoxColumn.DataSource = dt;
            //полDataGridViewTextBoxColumn.ValueMember = "Пол";
            //SqlDataAdapter sql_adapterCombo = new SqlDataAdapter("SELECT Пол FROM Гости", sql_con);





            /*
            string Constring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Учение\Диплом\RainbowLight\test\RainbowLight\RainbowLight\Database_RainbowLight.mdf;Integrated Security=True");
            SqlConnection sql_con = new SqlConnection(Constring);
            sql_con.Open();
            //SqlDataAdapter sql_adapter = new SqlDataAdapter("INSERT INTO Гости VALUES @Имя,@Фамилия,@Отчество,@Пол,@Дата рождения,@Номер телефона,@Email,@Страна,@Область,@Город,@Улица,@Дом,@Квартира", sql_con);
            //DataTable dt = new DataTable();
            SqlCommand sql_com = new SqlCommand();
            sql_com.Connection = sql_con;
            sql_com.CommandText = ("INSERT INTO Гости VALUES @Имя,@Фамилия,@Отчество,@Пол,@Дата рождения,@Номер телефона,@Email,@Страна,@Область,@Город,@Улица,@Дом,@Квартира");
            //(Имя,Фамилия,Отчество,Пол,[Дата рождения],[Номер телефона],Email,Страна,Область,Город,Улица,Дом,Квартира)
            int i = 0;
            sql_com.Parameters.Add(new SqlParameter("@Id", dgvGuests.Rows[i].Cells[0].Value == null ?
            string.Empty : dgvGuests.Rows[i].Cells[0].Value.ToString()));
            sql_com.Parameters.Add(new SqlParameter("@Имя", textBoxNameGuests.Text));
            sql_com.Parameters.Add(new SqlParameter("@Фамилия", textBoxSurnameGuests.Text));
            sql_com.Parameters.Add(new SqlParameter("@Отчество", textBoxPatronymicGuests.Text));
            sql_com.Parameters.Add(new SqlParameter("@Пол", comboBoxGenderGuests.Text));
            sql_com.Parameters.Add(new SqlParameter("@Дата рождения", comboBoxDayGuests.Text)); //+ comboBoxMonthGuests.Text + textBoxYearGuests.Text);
            sql_com.Parameters.Add(new SqlParameter("@Номер телефона", textBoxNumberPhone.Text));
            sql_com.Parameters.Add(new SqlParameter("@Email", textBoxEmail.Text));
            sql_com.Parameters.Add(new SqlParameter("@Страна", textBoxCountry.Text));
            sql_com.Parameters.Add(new SqlParameter("@Область", comboBoxRegion.Text));
            sql_com.Parameters.Add(new SqlParameter("@Город", textBoxCity.Text));
            sql_com.Parameters.Add(new SqlParameter("@Улица", textBoxStreet.Text));
            sql_com.Parameters.Add(new SqlParameter("@Дом", textBoxHouse.Text));
            sql_com.Parameters.Add(new SqlParameter("@Квартира", textBoxApartment.Text));

            //sql_adapter.Fill(dt);
            sql_com.ExecuteNonQuery();
            sql_com.Parameters.Clear();
            sql_con.Close();*/
        }
    }  
}

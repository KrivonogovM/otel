using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using RainbowLight.Resources;

namespace RainbowLight
{
    public partial class UControl_Search : UserControl
    {
        public UControl_Search()
        {
            InitializeComponent();
            dgv.TableDesign(dgvSearch);
        }

        Dgv dgv = new Dgv();
        public static UControl_Search nextPage4;

        public static UControl_Search nextPageSearch
        {
            get
            {
                if (nextPage4 == null)
                {
                    nextPage4 = new UControl_Search();
                }
                return nextPage4;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_RainbowLight.mdf;Integrated Security=True");

            connection.Open();
            string query = "Select * FROM Гости WHERE Id like '%" + textBoxSearch.Text + "%' OR Имя like '%" + textBoxSearch.Text + "%' OR Фамилия like '%" + textBoxSearch.Text + "%' OR Отчество like '%" + textBoxSearch.Text + "%' OR ДатаРождения like '%" + textBoxSearch.Text + "%' OR НомерТелефона like '%" + textBoxSearch.Text + "%' OR Email like '%" + textBoxSearch.Text + "%' OR Страна like '%" + textBoxSearch.Text + "%' OR Город like '%" + textBoxSearch.Text + "%' OR Квартира like '%" + textBoxSearch.Text + "%'";

            SqlCommand com = new SqlCommand(query, connection);
            SqlDataAdapter data_adapter = new SqlDataAdapter(query, connection);
            DataTable data_table = new DataTable();

            data_adapter.Fill(data_table);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = data_table;
            dgvSearch.DataSource = bindingSource;
            data_adapter.Update(data_table);

            SqlDataReader reader;
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                buttonSearch.Location = new Point(799, 575);
                textBoxSearch.Location = new Point(126, 575);
                dgvSearch.Visible = true;
                labelSearchError.Visible = false;

            }
            else
            {
                dgvSearch.Visible = false;
                labelSearchError.Visible = true;
                labelSearchError.Text = "Простите." + "\n"
                    + "Не нашло по такому запросу:" + textBoxSearch.Text + "\n."
                + "Попробуйте еще раз.";
            }
        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = null;
            textBoxSearch.ForeColor = Color.Black;
            textBoxSearch.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
        }
    }
}

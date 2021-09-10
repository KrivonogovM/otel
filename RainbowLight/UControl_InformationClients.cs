using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using RainbowLight.Resources;

namespace RainbowLight
{
    public partial class UControl_InformationClients : UserControl
    {
        public UControl_InformationClients()
        {
            InitializeComponent();
            dgv.TableDesign(dgvInfoClients);
        }

        Dgv dgv = new Dgv();
        public static UControl_InformationClients nextPage3;

        void DelDb()
        {
            try
            {
                string Constring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_RainbowLight.mdf;Integrated Security=True");
                string Delstring = ("DELETE FROM InformationClients WHERE Id=@Id");
                SqlCommand sql_com = new SqlCommand();
                SqlConnection sql_con = new SqlConnection(Constring);
                sql_com.CommandText = (Delstring);
                sql_com.Connection = sql_con;
                int Id = int.Parse(dgvInfoClients.CurrentRow.Cells[0].Value.ToString());
                sql_com.CommandText = ("SELECT * FROM InformationClients");
                sql_com.CommandText = (Delstring);
                sql_com.Connection = sql_con;
                sql_com.Parameters.AddWithValue("@Id", Id);
                sql_con.Open();
                sql_com.ExecuteNonQuery();
                sql_con.Close();
                sql_com.Parameters.Clear();
                int IdDel = dgvInfoClients.SelectedCells[0].RowIndex;
                dgvInfoClients.Rows.RemoveAt(IdDel);
                dgvInfoClients.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public static UControl_InformationClients nextPageReservedRooms
        {
            get
            {
                if (nextPage3 == null)
                {
                    nextPage3 = new UControl_InformationClients();
                }
                return nextPage3;
            }
        }

        private void buttonPech_Click(object sender, EventArgs e)
        {
            UControl_AddGuests.nextPageAddGuests.SaveTable(dgvInfoClients, "Информация о клиентах");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DelDb();
        }
    }
}

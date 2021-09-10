using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using RainbowLight.Resources;

namespace RainbowLight
{
    public partial class UControl_AvailabilityRooms : UserControl
    {
        public UControl_AvailabilityRooms()
        {
            InitializeComponent();
            dgv.TableDesign(dgvCloseRooms);
        }

        Dgv dgv = new Dgv();
        public static UControl_AvailabilityRooms nextPage2;

        public static UControl_AvailabilityRooms nextPageAvailRooms
        {
            get
            {
                if (nextPage2 == null)
                {
                    nextPage2 = new UControl_AvailabilityRooms();
                }
                return nextPage2;
            }
        }

        private void UControl_AvailabilityRooms_Load(object sender, EventArgs e)
        {
            try
            {
                string Constring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_RainbowLight.mdf;Integrated Security=True");
                SqlConnection sql_con = new SqlConnection(Constring);
                sql_con.Open();
                SqlDataAdapter sql_adapter = new SqlDataAdapter("SELECT * FROM ЗабронированныеНомера", sql_con);
                DataTable dt = new DataTable();
                sql_adapter.Fill(dt);
                dgvReservedRooms.DataSource = dt;
                sql_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}

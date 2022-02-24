using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UAS_OOP_1204055
{
    public partial class View_Daftar_Ulang : Form
    {
        public View_Daftar_Ulang()
        {
            InitializeComponent();

            string query = "SELECT * from ms_daftar_ulang";


            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4Q4UGOSK\P6_1204055;Initial Catalog=UAS;Integrated Security=True");
            conn.Open();
            SqlCommand sc = new SqlCommand(query, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            sda.Fill(ds, "ms_daftar_ulang");

            dgVDU.DataSource = ds;
            dgVDU.DataMember = "ms_daftar_ulang";
            dgVDU.Refresh();

            conn.Close();
        }
    }
}

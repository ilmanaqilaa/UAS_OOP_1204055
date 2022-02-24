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
    public partial class Tampil_Mahasiswa : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd1;
        private SqlDataAdapter da;
        private DataSet ds;

        public Tampil_Mahasiswa()
        {
            InitializeComponent();
        }

        private void Tampil_Mahasiswa_Load(object sender, EventArgs e)
        {
            string constr = @"Data Source=LAPTOP-4Q4UGOSK\P6_1204055;Initial Catalog=UAS;Integrated Security=True";
            conn = new SqlConnection(constr);
            conn.Open();
            cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from ms_mhs";
            ds = new DataSet();
            da = new SqlDataAdapter(cmd1);
            da.Fill(ds, "NPM");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "NPM";
            dataGridView1.Refresh();
            conn.Close();
        }
    }
}

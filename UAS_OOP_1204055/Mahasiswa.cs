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
    public partial class Mahasiswa : Form
    {
        public Mahasiswa()
        {
            InitializeComponent();

            SqlConnection connectDB = new SqlConnection(@"Data Source=LAPTOP-4Q4UGOSK\P6_1204055;Initial Catalog=UAS;Integrated Security=True");
            connectDB.Open();
            SqlCommand sc = new SqlCommand("SELECT * FROM ms_prodi", connectDB);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable tabel = new DataTable();
            tabel.Columns.Add("kode_prodi", typeof(string));
            tabel.Columns.Add("singkatan", typeof(string));
            tabel.Load(reader);

            cbProdi.ValueMember = "kode_prodi";
            cbProdi.DisplayMember = "singkatan";
            cbProdi.DataSource = tabel;

            connectDB.Close();
        }

        private void UpdateDB(string cmd)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(@"Data Source=LAPTOP-4Q4UGOSK\P6_1204055;Initial Catalog=UAS;Integrated Security=True");

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand();

                myCommand.Connection = myConnection;

                myCommand.CommandText = cmd;

                myCommand.ExecuteNonQuery();

                MessageBox.Show("Data prodi baru sudah dimasukkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            string myCmd = "INSERT INTO ms_mhs VALUES('"
            + tbNPM.Text + "','"
            + tbNamaMahasiswa.Text + "','"
            + cbProdi.SelectedValue.ToString() + "')";

            UpdateDB(myCmd);
        }
    }
}
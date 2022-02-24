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
using System.Text.RegularExpressions;

namespace UAS_OOP_1204055
{
    public partial class programStudi : Form
    {
        public programStudi()
        {
            InitializeComponent();

            string getLastIdSql = "SELECT kode_prodi FROM ms_prodi ORDER BY kode_prodi DESC";

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4Q4UGOSK\P6_1204055;Initial Catalog=UAS;Integrated Security=True");
            conn.Open();
            SqlCommand sc = new SqlCommand(getLastIdSql, conn);
            SqlDataReader result;

            result = sc.ExecuteReader();

            string newKode = "";
            if (result.HasRows)
            {
                int newKodeProdi = 0;
                while (result.Read())
                {
                    newKode = result["kode_prodi"].ToString();
                    string angkaKode = Regex.Match(newKode, @"\d+").Value;
                    newKodeProdi = Int16.Parse(angkaKode) + 1;
                    if (newKodeProdi >= 10)
                    {
                        newKode = "PRD" + newKodeProdi;
                    }
                    else
                    {
                        newKode = "PRD0" + newKodeProdi;
                    }
                    break;
                }
            }
            else
            {
                newKode = "PRD01";
            }
            tbKodeProdi.Text = newKode;
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
            string myCmd = "INSERT INTO ms_prodi VALUES('"
            + tbKodeProdi.Text + "','"
            + tbNamaProdi.Text + "','"
            + tbSingkatan.Text + "','"
            + tbBiayaKuliah.Text + "')";

            UpdateDB(myCmd);
        }

        private void clear()
        {
            tbKodeProdi.Text = "";
            tbNamaProdi.Text = "";
            tbSingkatan.Text = "";
            tbBiayaKuliah.Text = "";
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}


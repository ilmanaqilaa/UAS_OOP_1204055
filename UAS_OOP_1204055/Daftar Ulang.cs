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
    
    public partial class daftarUlang : Form
    {
        public daftarUlang()
        {
            InitializeComponent();
            rbA.Checked = false;
        }

        private void clear()
        {
            tbNPM.Text = "";
            tbNamaMahasiswa.Text = "";
            tbProdi.Text = "";
            tbBiayaKuliah.Text = "";
            rbA.Checked = false;
            rbB.Checked = false;
            rbB.Checked = false;
            tbPotonganBiaya.Text = "";
            tbPotonganBiayaKuliah.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void inputDatabase(string sql)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4Q4UGOSK\P6_1204055;Initial Catalog=UAS;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Daftar ulang berhasil dilakukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbNPM.Text != "")
            {
                if (tbPotonganBiayaKuliah.Text != "")
                {
                    if (rbA.Checked != false || rbB.Checked != false || rbC.Checked != false)
                    {
                        string grade = "";
                        if (rbA.Checked)
                        {
                            grade = "A";
                        }
                        if (rbB.Checked)
                        {
                            grade = "B";
                        }
                        if (rbC.Checked)
                        {
                            grade = "C";
                        }
                        string sql = "INSERT INTO ms_daftar_ulang VALUES('"
                            + tbNPM.Text + "','"
                            + grade + "','"
                            + tbPotonganBiayaKuliah.Text + "')";

                        inputDatabase(sql);

                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Harap pilih grade untuk mahasiswa!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Potongan biaya kuliah tidak boleh kosong!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("NPM tidak boleh kosong!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void rbA_MouseClick(object sender, MouseEventArgs e)
        {
            int diskon = (Int32.Parse(tbBiayaKuliah.Text.ToString()) * 50) / 100;
            tbPotonganBiaya.Text = diskon.ToString();
            int total = Int32.Parse(tbBiayaKuliah.Text.ToString()) - diskon;
            tbPotonganBiayaKuliah.Text = total.ToString();
        }

        private void rbB_MouseClick(object sender, MouseEventArgs e)
        {
            int diskon = (Int32.Parse(tbBiayaKuliah.Text.ToString()) * 25) / 100;
            tbPotonganBiaya.Text = diskon.ToString();
            int total = Int32.Parse(tbBiayaKuliah.Text.ToString()) - diskon;
            tbPotonganBiayaKuliah.Text = total.ToString();
        }

        private void rbC_MouseClick(object sender, MouseEventArgs e)
        {
            int diskon = (Int32.Parse(tbBiayaKuliah.Text.ToString()) * 10) / 100;
            tbPotonganBiaya.Text = diskon.ToString();
            int total = Int32.Parse(tbBiayaKuliah.Text.ToString()) - diskon;
            tbPotonganBiayaKuliah.Text = total.ToString();
        }

        private void tbNPM_Leave(object sender, EventArgs e)
        {
            string getLastIdSql = "SELECT nama_mhs,nama_prodi,biaya_kuliah FROM ms_mhs " +
                "JOIN ms_prodi ON ms_mhs.kode_prodi=ms_prodi.kode_prodi WHERE npm='" + tbNPM.Text + "'";

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4Q4UGOSK\P6_1204055;Initial Catalog=UAS;Integrated Security=True");
            conn.Open();
            SqlCommand sc = new SqlCommand(getLastIdSql, conn);
            SqlDataReader result;

            result = sc.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    tbNamaMahasiswa.Text = result["nama_mhs"].ToString();
                    tbProdi.Text = result["nama_prodi"].ToString();
                    tbBiayaKuliah.Text = result["biaya_kuliah"].ToString();
                }
            }
        }

        private void tbNPM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void tbPotonganBiayaKuliah_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;

        }
    }
}

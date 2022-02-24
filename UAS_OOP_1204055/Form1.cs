using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_OOP_1204055
{
    public partial class fHome : Form
    {
        public fHome()
        {
            InitializeComponent();
        }

        private void msProdi_Click(object sender, EventArgs e)
        {
            programStudi newProgram = new programStudi();
            newProgram.MdiParent = this;
            newProgram.Show();
        }

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mahasiswa newMahasiswa = new Mahasiswa();
            newMahasiswa.MdiParent = this;
            newMahasiswa.Show();
        }

        private void msProdiView_Click(object sender, EventArgs e)
        {
            TampilProdi newProdi = new TampilProdi();
            newProdi.MdiParent = this;
            newProdi.Show();
        }

        private void msMahasiswa_Click(object sender, EventArgs e)
        {
            Tampil_Mahasiswa newMahasiswa = new Tampil_Mahasiswa();
            newMahasiswa.MdiParent = this;
            newMahasiswa.Show();
        }

        private void msUpdateProdi_Click(object sender, EventArgs e)
        {
            Update_Prodi newUpProd = new Update_Prodi();
            newUpProd.MdiParent = this;
            newUpProd.Show();
        }

        private void msDaftarUlangMahasiswa_Click(object sender, EventArgs e)
        {
            daftarUlang newDaftar = new daftarUlang();
            newDaftar.MdiParent = this;
            newDaftar.Show();
        }

        private void msUpdateMahasiswa_Click(object sender, EventArgs e)
        {
            Ubah_Data_Mahasiswa newUpdateMah = new Ubah_Data_Mahasiswa();
            newUpdateMah.MdiParent = this;
            newUpdateMah.Show();
        }

        private void msViewDaftarUlang_Click(object sender, EventArgs e)
        {
            View_Daftar_Ulang newViewDU = new View_Daftar_Ulang();
            newViewDU.MdiParent = this;
            newViewDU.Show();
        }

        private void msUDU_Click(object sender, EventArgs e)
        {
            Update_Daftar_Ulang newUDU = new Update_Daftar_Ulang();
            newUDU.MdiParent = this;
            newUDU.Show();        
        }

        private void msLDU_Click(object sender, EventArgs e)
        {
            Laporan_Daftar_Ulang newLDU = new Laporan_Daftar_Ulang();
            newLDU.MdiParent = this;
            newLDU.Show();
        }
    }
}

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
    public partial class Update_Daftar_Ulang : Form
    {
        public Update_Daftar_Ulang()
        {
            InitializeComponent();

            RefreshDataset();
        }

        private DataSet dsProdi;

        public DataSet CreateProdiDataSet()
        {
            DataSet myDataSet = new DataSet();

            try
            {
                //string myConnectionString = "Data Source=LAPTOP-4Q4UGOSK\P6_1204055;Initial Catalog=P6_1204055;Integrated Security=True";

                SqlConnection myConnection = new SqlConnection(@"Data Source=LAPTOP-4Q4UGOSK\P6_1204055;Initial Catalog=UAS;Integrated Security=True");

                SqlCommand myCommand = new SqlCommand();

                myCommand.Connection = myConnection;

                myCommand.CommandText = "SELECT * FROM ms_daftar_ulang";
                myCommand.CommandType = CommandType.Text;

                SqlDataAdapter myDataAdapter = new SqlDataAdapter();
                myDataAdapter.SelectCommand = myCommand;
                myDataAdapter.TableMappings.Add("Table", "Prodi");

                myDataAdapter.Fill(myDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return myDataSet;

        }

        private void RefreshDataset()
        {
            dsProdi = CreateProdiDataSet();

            dgUDU.DataSource = dsProdi.Tables["Prodi"];
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(@"Data Source=LAPTOP-4Q4UGOSK\P6_1204055;Initial Catalog=UAS;Integrated Security=True");

            myConnection.Open();

            SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT * FROM ms_daftar_ulang", myConnection);
            SqlCommandBuilder myCmdBuilder = new SqlCommandBuilder(myAdapter);

            myAdapter.UpdateCommand = myCmdBuilder.GetUpdateCommand();
            myAdapter.DeleteCommand = myCmdBuilder.GetDeleteCommand();

            SqlTransaction myTransaction;
            myTransaction = myConnection.BeginTransaction();
            myAdapter.UpdateCommand.Transaction = myTransaction;
            myAdapter.DeleteCommand.Transaction = myTransaction;

            try
            {
                int rowsUpdated = myAdapter.Update(dsProdi, "Prodi");

                myTransaction.Commit();

                MessageBox.Show(rowsUpdated.ToString() + " baris diperbarui", "informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshDataset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: ", ex.Message);

                myTransaction.Rollback();
            }

        }
    }
}

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

namespace Medical_Examination
{
    public partial class ScanGetPatientByRecipe : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;

        public ScanGetPatientByRecipe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ScanGetPatientByRecipe_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();
            sqlCommand = new SqlCommand("Select dbo.Pacient.FIO_Pacient From dbo.Pacient", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                comboBox1.Items.Add(sqlDataReader.GetString(0));
            }
            sqlDataReader.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            sqlCommand = new SqlCommand("Select * From dbo.uf_ScanGetPatientByRecipe(@fio_patient)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("fio_patient", comboBox1.Text);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                dataGridView1.Rows.Add(sqlDataReader.GetString(0), sqlDataReader.GetInt16(1), sqlDataReader.GetString(2));
            }
            sqlDataReader.Close();
        }
    }
}

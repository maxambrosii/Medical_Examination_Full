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
    public partial class ScanGetPatientByDiagnosis : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;

        public ScanGetPatientByDiagnosis()
        {
            InitializeComponent();
        }

        private void ScanGetPatientByDiagnosis_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();
            sqlCommand = new SqlCommand("Select dbo.Pacient.FIO_Pacient From dbo.Pacient", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                comboBoxPatient.Items.Add(sqlDataReader.GetString(0));
            }
            sqlDataReader.Close();
        }


        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewPatients.Rows.Clear();
            sqlCommand = new SqlCommand("Select * From dbo.uf_ScanGetPatientByDiagnosis(@fio_patient)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("fio_patient", comboBoxPatient.Text);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                dataGridViewPatients.Rows.Add(sqlDataReader.GetString(0), sqlDataReader.GetDateTime(1).ToShortDateString(), sqlDataReader.GetString(2));
            }
            sqlDataReader.Close();
        }

        private void dataGridViewPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

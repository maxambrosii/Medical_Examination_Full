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
    public partial class ScanGetDoctorAndCountOfPatientWithUserDiagnosisForm : Form
    {

        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;

        public ScanGetDoctorAndCountOfPatientWithUserDiagnosisForm()
        {
            InitializeComponent();
        }

        private void ScanGetDoctorAndCountOfPatientWithUserDiagnosis_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();
            sqlCommand = new SqlCommand("Select Diagnoz From DocDiagnoz", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                comboBox_diagnoz.Items.Add(sqlDataReader.GetString(0));
            }
            sqlDataReader.Close();

        }


        private void comboBox_diagnoz_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_Patients.Rows.Clear();
            sqlCommand = new SqlCommand("Select * From dbo.uf_GetDoctorWithDiagnoz(@diagnosis)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("diagnosis", comboBox_diagnoz.Text);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                dataGridView_Patients.Rows.Add(sqlDataReader.GetString(0), sqlDataReader.GetInt32(1));
            }
            sqlDataReader.Close();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_Patients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

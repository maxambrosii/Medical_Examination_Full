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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            sqlCommand = new SqlCommand("Select * From dbo.uf_GetDoctorWithDiagnoz(@diagnosis)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("diagnosis", comboBox1.Text);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                dataGridView1.Rows.Add(sqlDataReader.GetString(0), sqlDataReader.GetInt32(1));
            }
            sqlDataReader.Close();
        }

        private void ScanGetDoctorAndCountOfPatientWithUserDiagnosis_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();
            sqlCommand = new SqlCommand("Select Diagnoz From DocDiagnoz", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                comboBox1.Items.Add(sqlDataReader.GetString(0));
            }
            sqlDataReader.Close();

        }

        private void ScanGetDoctorAndCountOfPatientWithUserDiagnosis_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

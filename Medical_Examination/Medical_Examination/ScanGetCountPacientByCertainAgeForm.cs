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
    public partial class ScanGetCountPacientByCertainAgeForm : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;

        public ScanGetCountPacientByCertainAgeForm()
        {
            InitializeComponent();
        }

        private void ScanGetCountPacientByCertainAgeForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();
        }

        private void ScanGetCountPacientByCertainAgeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_Age_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewPatients.Rows.Clear();
            sqlCommand = new SqlCommand("Select * From dbo.uf_GetCountPacientByCertainAge(@agetype)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("agetype", comboBox_Age.SelectedIndex + 1);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                dataGridViewPatients.Rows.Add(sqlDataReader.GetString(0));
            }
            sqlDataReader.Close();
        }

        private void dataGridViewPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

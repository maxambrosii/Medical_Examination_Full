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
    public partial class ScanGetCountPacientByAreaForm : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;

        public ScanGetCountPacientByAreaForm()
        {
            InitializeComponent();
        }

        private void ScanGetCountPacientByAreaForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();
            sqlCommand = new SqlCommand("Select dbo.Pacient.Nr_Uchastka From dbo.Pacient group by dbo.Pacient.Nr_Uchastka", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                comboBox_Area.Items.Add(sqlDataReader.GetInt16(0));
            }
            sqlDataReader.Close();
        }

        private void ScanGetCountPacientByAreaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_Patients.Rows.Clear();
            sqlCommand = new SqlCommand("Select dbo.Pacient.FIO_Pacient From dbo.Pacient where dbo.Pacient.Nr_Uchastka = @area", sqlConnection);
            sqlCommand.Parameters.AddWithValue("area", comboBox_Area.Text);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                dataGridView_Patients.Rows.Add(sqlDataReader.GetString(0));
            }
            sqlDataReader.Close();
        }

        private void dataGridView_Patients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

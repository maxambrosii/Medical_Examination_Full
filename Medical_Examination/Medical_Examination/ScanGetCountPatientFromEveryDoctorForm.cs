﻿using System;
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
    public partial class ScanGetCountPatientFromEveryDoctorForm : Form
    {

        //List<string> _errors = new List<string>();
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;

        public ScanGetCountPatientFromEveryDoctorForm()
        {
            InitializeComponent();
        }

        private void ScanGetCountPatientFromEveryDoctor_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();
        }

        private void ScanGetCountPatientFromEveryDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker_Date_ValueChanged(object sender, EventArgs e)
        {
            dataGridView_Patients.Rows.Clear();
            sqlCommand = new SqlCommand("Select * From dbo.uf_GetPatientByDate(@date)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("date", dateTimePicker_Date.Value.Date);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                dataGridView_Patients.Rows.Add(sqlDataReader.GetString(0), sqlDataReader.GetInt32(1));
            }
            sqlDataReader.Close();
        }

        private void dataGridView_Patients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

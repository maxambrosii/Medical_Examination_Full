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
    public partial class UpdateReceptionForm : Form
    {
        List<string> _errors = new List<string>();
        List<int> _Reception = new List<int>();
        int reception;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;

        public UpdateReceptionForm()
        {
            InitializeComponent();
          
            dateTimePickerDate.Enabled = false;
            dateTimePickerTime.Enabled = false;
        }

        
     
        private void UpdateReceptionForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();
            sqlCommand = new SqlCommand("Select Cod_Priema From Priem", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                reception = sqlDataReader.GetInt32(0);
                _Reception.Add(reception);
                comboBoxN_Reception.Items.Add(reception);
            }
            sqlDataReader.Close();
            
        }

        private void UpdateReceptionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            _errors.Clear();
            if (comboBoxN_Reception.Text == "")
                _errors.Add("*Вы не выбрали № приема");
            if (checkBox_Date.Checked == false && checkBoxTime.Checked == false)
                _errors.Add("*Вы ничего не выбрали для изменения");
            if (!_errors.Any())
            {
                string stringSqlCommand = "Update Priem SetWhere Cod_Priema = @codPriema";
                if (checkBox_Date.Checked)
                    stringSqlCommand = stringSqlCommand.Insert(stringSqlCommand.IndexOf("Where"), " Data_Priema = @dataPriema,");
                if (checkBoxTime.Checked)
                    stringSqlCommand = stringSqlCommand.Insert(stringSqlCommand.IndexOf("Where"), " Time_Priema = @timePriema,");
                StringBuilder sbSqlCommand = new StringBuilder(stringSqlCommand);
                sbSqlCommand[stringSqlCommand.IndexOf("Where") - 1] = ' ';
                stringSqlCommand = sbSqlCommand.ToString();

                sqlCommand = new SqlCommand(stringSqlCommand, sqlConnection);
                sqlCommand.Parameters.AddWithValue("codPriema", Convert.ToInt32(comboBoxN_Reception.Text));
                if (checkBox_Date.Checked)
                    sqlCommand.Parameters.AddWithValue("dataPriema", dateTimePickerDate.Value.Date);
                if (checkBoxTime.Checked)
                    sqlCommand.Parameters.AddWithValue("timePriema", dateTimePickerTime.Value.TimeOfDay);
                sqlCommand.ExecuteNonQuery();
                labelSuccesfully.Visible = true;
                labelSuccesfully.ForeColor = Color.Lime;
                labelSuccesfully.Text = "Иноформация успешно обновленна";
                comboBoxN_Reception.Text = "";
            }
            else
            {
                labelSuccesfully.ForeColor = Color.Red;
                labelSuccesfully.Text = _errors.First();
            }
        }

        private void checkBox_Date_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Date.Checked)
            {
                dateTimePickerDate.BackColor = Color.FromArgb(255, 255, 255);
                dateTimePickerDate.Enabled = true;
            }
            else
            {
                dateTimePickerDate.BackColor = Color.FromArgb(160, 160, 160);
                dateTimePickerDate.Enabled = false;
            }
        }

        private void checkBoxTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Date.Checked)
            {
                dateTimePickerTime.BackColor = Color.FromArgb(255, 255, 255);
                dateTimePickerTime.Enabled = true;
            }
            else
            {
                dateTimePickerTime.BackColor = Color.FromArgb(160, 160, 160);
                dateTimePickerTime.Enabled = false;
            }
        }
    }
}

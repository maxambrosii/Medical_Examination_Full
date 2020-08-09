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
          
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker1.BackColor = Color.FromArgb(255, 255, 255);
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.BackColor = Color.FromArgb(160, 160, 160);
                dateTimePicker1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker2.BackColor = Color.FromArgb(255, 255, 255);
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker2.BackColor = Color.FromArgb(160, 160, 160);
                dateTimePicker2.Enabled = false;
            }
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
                comboBox1.Items.Add(reception);
            }
            sqlDataReader.Close();
            
        }

        private void UpdateReceptionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _errors.Clear();
            if (comboBox1.Text == "")
                _errors.Add("*Вы не выбрали № приема");
            if (checkBox1.Checked == false && checkBox2.Checked == false)
                _errors.Add("*Вы ничего не выбрали для изменения");
            if (!_errors.Any())
            {
                string stringSqlCommand = "Update Priem SetWhere Cod_Priema = @codPriema";
                if (checkBox1.Checked)
                    stringSqlCommand = stringSqlCommand.Insert(stringSqlCommand.IndexOf("Where"), " Data_Priema = @dataPriema,");
                if (checkBox2.Checked)
                    stringSqlCommand = stringSqlCommand.Insert(stringSqlCommand.IndexOf("Where"), " Time_Priema = @timePriema,");
                StringBuilder sbSqlCommand = new StringBuilder(stringSqlCommand);
                sbSqlCommand[stringSqlCommand.IndexOf("Where") - 1] = ' ';
                stringSqlCommand = sbSqlCommand.ToString();

                sqlCommand = new SqlCommand(stringSqlCommand, sqlConnection);
                sqlCommand.Parameters.AddWithValue("codPriema", Convert.ToInt32(comboBox1.Text));
                if (checkBox1.Checked)
                    sqlCommand.Parameters.AddWithValue("dataPriema", dateTimePicker1.Value.Date);
                if (checkBox2.Checked)
                    sqlCommand.Parameters.AddWithValue("timePriema", dateTimePicker2.Value.TimeOfDay);
                sqlCommand.ExecuteNonQuery();

                label2.ForeColor = Color.Lime;
                label2.Text = "Иноформация успешно обновленна";
                comboBox1.Text = "";
            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = _errors.First();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class UpdateDoctorForm : Form
    {
        struct ListIntAndString
        {
            public int cod { get; set; }
            public string str { get; set; }
        }
        List<string> _errors = new List<string>();
        List<ListIntAndString> _Doctor = new List<ListIntAndString>();
        ListIntAndString doctor = new ListIntAndString();
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;

        public UpdateDoctorForm()
        {
            InitializeComponent();
          
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox1.BackColor = Color.FromArgb(160, 160, 160);
            textBox2.BackColor = Color.FromArgb(160, 160, 160);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.BackColor = Color.FromArgb(79, 118, 208);
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.BackColor = Color.FromArgb(160, 160, 160);
                textBox1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.BackColor = Color.FromArgb(79, 118, 208);
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.BackColor = Color.FromArgb(160, 160, 160);
                textBox2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

            private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void UpdateDoctorForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();
            sqlCommand = new SqlCommand("Select Cod_Doctor, FIO_Doctor From Doctor", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                doctor.cod = sqlDataReader.GetInt32(0);
                doctor.str = sqlDataReader.GetString(1);
                _Doctor.Add(doctor);
                comboBox1.Items.Add(doctor.str);
            }
            sqlDataReader.Close();
        }

        private void UpdateDoctorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            _errors.Clear();
            if (comboBox1.Text == "")
                _errors.Add("*Вы не выбрали доктора");
            if (checkBox1.Checked == false && checkBox2.Checked == false)
                _errors.Add("*Вы ничего не выбрали для изменения");
            if (checkBox1.Checked && textBox1.Text == "")
                _errors.Add("*Неправильный формат ввода № участка");
            if (checkBox2.Checked && textBox2.Text == "")
                _errors.Add("*Неправильный формат ввода № кабинета");
            if (textBox1.Text != "")
            {
                if (Convert.ToInt32(textBox1.Text) < 0)
                    _errors.Add("*Такой участок не существует");
            }
            if (textBox2.Text != "")
            {
                if (Convert.ToInt32(textBox2.Text) < 0)
                    _errors.Add("*Такой кабинет не существует");
            }
            if (!_errors.Any())
            {
                string stringSqlCommand = "Update Doctor SetWhere Cod_Doctor = @codDoctor";
                if (checkBox1.Checked)
                    stringSqlCommand = stringSqlCommand.Insert(stringSqlCommand.IndexOf("Where"), " Nr_Uchastka_DOC = @nrUchastkaDoc,");
                if (checkBox2.Checked)
                    stringSqlCommand = stringSqlCommand.Insert(stringSqlCommand.IndexOf("Where"), " Nr_Cabinet = @nrCabinet,");
                StringBuilder sbSqlCommand = new StringBuilder(stringSqlCommand);
                sbSqlCommand[stringSqlCommand.IndexOf("Where") - 1] = ' ';
                stringSqlCommand = sbSqlCommand.ToString();

                ListIntAndString liasD = _Doctor.Find(_Doctor => _Doctor.str == comboBox1.Text);

                sqlCommand = new SqlCommand(stringSqlCommand, sqlConnection);
                sqlCommand.Parameters.AddWithValue("codDoctor", liasD.cod);
                if (checkBox1.Checked)
                    sqlCommand.Parameters.AddWithValue("nrUchastkaDoc", textBox1.Text);
                if (checkBox2.Checked)
                    sqlCommand.Parameters.AddWithValue("nrCabinet", textBox2.Text);
                sqlCommand.ExecuteNonQuery();

                label2.ForeColor = Color.Lime;
                label2.Text = "Иноформация успешно обновленна";
                comboBox1.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = _errors.First();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

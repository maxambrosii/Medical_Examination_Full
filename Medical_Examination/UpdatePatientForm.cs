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
    public partial class UpdatePatientForm : Form
    {
        struct ListIntAndString
        {
            public int cod { get; set; }
            public string str { get; set; }
        }
        List<string> _errors = new List<string>();
        List<ListIntAndString> _Patient = new List<ListIntAndString>();
        ListIntAndString patient = new ListIntAndString();
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;

        public UpdatePatientForm()
        {
            InitializeComponent();
           
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox1.BackColor = Color.FromArgb(160, 160, 160);
            textBox2.BackColor = Color.FromArgb(160, 160, 160);
            textBox3.BackColor = Color.FromArgb(160, 160, 160);
            //label1.ForeColor = AuthorizationForm.textcolor;
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox3.BackColor = Color.FromArgb(79, 118, 208);
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.BackColor = Color.FromArgb(160, 160, 160);
                textBox3.Enabled = false;
            }
        }

        private void UpdatePatientForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();
            sqlCommand = new SqlCommand("Select Cod_Pacient, FIO_Pacient From Pacient", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                patient.cod = sqlDataReader.GetInt32(0);
                patient.str = sqlDataReader.GetString(1);
                _Patient.Add(patient);
                comboBox1.Items.Add(patient.str);
            }
            sqlDataReader.Close();
        }

        private void UpdatePatientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _errors.Clear();
            if (comboBox1.Text == "")
                _errors.Add("*Вы не выбрали пациента");
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
                _errors.Add("*Вы ничего не выбрали для изменения");
            if (checkBox1.Checked && textBox1.Text == "")
                _errors.Add("*Неправильный формат адреса");
            if (checkBox2.Checked && (textBox2.Text == "" || textBox2.Text.Length != 15))
                _errors.Add("*Неправильный формат страховки");
            if (checkBox3.Checked && textBox3.Text == "")
                _errors.Add("*Неправильный формат № участка");
            if (textBox3.Text != "")
            {
                if (Convert.ToInt32(textBox3.Text) < 0)
                    _errors.Add("*Такой участок не существует");
            }
            if (!_errors.Any())
            {
                string stringSqlCommand = "Update Pacient SetWhere Cod_Pacient = @codPacient";
                if (checkBox1.Checked)
                    stringSqlCommand = stringSqlCommand.Insert(stringSqlCommand.IndexOf("Where"), " Adress = @adress,");
                if (checkBox2.Checked)
                    stringSqlCommand = stringSqlCommand.Insert(stringSqlCommand.IndexOf("Where"), " Strahovka = @strahovka,");
                if (checkBox3.Checked)
                    stringSqlCommand = stringSqlCommand.Insert(stringSqlCommand.IndexOf("Where"), " Nr_Uchastka = @nrUchastka,");
                StringBuilder sbSqlCommand = new StringBuilder(stringSqlCommand);
                sbSqlCommand[stringSqlCommand.IndexOf("Where") - 1] = ' ';
                stringSqlCommand = sbSqlCommand.ToString();

                ListIntAndString liasP = _Patient.Find(_Doctor => _Doctor.str == comboBox1.Text);

                sqlCommand = new SqlCommand(stringSqlCommand, sqlConnection);
                sqlCommand.Parameters.AddWithValue("codPacient", liasP.cod);
                if (checkBox1.Checked)
                    sqlCommand.Parameters.AddWithValue("adress", textBox1.Text);
                if (checkBox2.Checked)
                    sqlCommand.Parameters.AddWithValue("strahovka", textBox2.Text);
                if (checkBox3.Checked)
                    sqlCommand.Parameters.AddWithValue("nrUchastka", textBox3.Text);
                sqlCommand.ExecuteNonQuery();

                label2.ForeColor = Color.Lime;
                label2.Text = "Информация успешно обновленна";
                comboBox1.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label7.Text = "IDNP:";
                label4.Text = "Адрес:";
                label5.Text = "№ cтраховки:";
                label6.Text = "№ участка:";

            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = _errors.First();
            }
        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListIntAndString liasP = _Patient.Find(_Doctor => _Doctor.str == comboBox1.Text);
            sqlCommand = new SqlCommand("Select IDNP, Adress, Strahovka, Nr_Uchastka From Pacient where Cod_Pacient=@codPatient", sqlConnection);
            sqlCommand.Parameters.AddWithValue("codPatient", liasP.cod);
            sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            label7.Text = "IDNP: " + sqlDataReader.GetString(0);
            label4.Text = "Адрес: " + sqlDataReader.GetString(1);
            label5.Text = "№ cтраховки: " + sqlDataReader.GetString(2);
            label6.Text = "№ участка: " + sqlDataReader.GetInt16(3).ToString();

            sqlDataReader.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }
    }
}

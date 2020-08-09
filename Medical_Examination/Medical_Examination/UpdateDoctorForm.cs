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
          
            textBoxArea.Enabled = false;
            textBox_N_Cabinet.Enabled = false;
            textBoxArea.BackColor = Color.FromArgb(23, 64, 96);
            textBox_N_Cabinet.BackColor = Color.FromArgb(23, 64, 96);
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
                comboBoxDoctor.Items.Add(doctor.str);
            }
            sqlDataReader.Close();
        }

        private void UpdateDoctorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }


        private void checkBox_N_Area_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_N_Area.Checked)
            {
                textBoxArea.BackColor = Color.FromArgb(23, 64, 96);
                textBoxArea.Enabled = true;
            }
            else
            {
                textBoxArea.BackColor = Color.FromArgb(23, 64, 96);
                textBoxArea.Enabled = false;
            }
        }

        private void checkBox_N_cabinet_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_N_cabinet.Checked)
            {
                textBox_N_Cabinet.BackColor = Color.FromArgb(23, 64, 96);
                textBox_N_Cabinet.Enabled = true;
            }
            else
            {
                textBox_N_Cabinet.BackColor = Color.FromArgb(23, 64, 96);
                textBox_N_Cabinet.Enabled = false;
            }
        }

        private void textBoxArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_N_Cabinet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            _errors.Clear();
            if (comboBoxDoctor.Text == "")
                _errors.Add("*Вы не выбрали доктора");
            if (checkBox_N_Area.Checked == false && checkBox_N_cabinet.Checked == false)
                _errors.Add("*Вы ничего не выбрали для изменения");
            if (checkBox_N_Area.Checked && textBoxArea.Text == "")
                _errors.Add("*Неправильный формат ввода № участка");
            if (checkBox_N_cabinet.Checked && textBox_N_Cabinet.Text == "")
                _errors.Add("*Неправильный формат ввода № кабинета");
            if (textBoxArea.Text != "")
            {
                if (Convert.ToInt32(textBoxArea.Text) < 0)
                    _errors.Add("*Такой участок не существует");
            }
            if (textBox_N_Cabinet.Text != "")
            {
                if (Convert.ToInt32(textBox_N_Cabinet.Text) < 0)
                    _errors.Add("*Такой кабинет не существует");
            }
            if (!_errors.Any())
            {
                string stringSqlCommand = "Update Doctor SetWhere Cod_Doctor = @codDoctor";
                if (checkBox_N_Area.Checked)
                    stringSqlCommand = stringSqlCommand.Insert(stringSqlCommand.IndexOf("Where"), " Nr_Uchastka_DOC = @nrUchastkaDoc,");
                if (checkBox_N_cabinet.Checked)
                    stringSqlCommand = stringSqlCommand.Insert(stringSqlCommand.IndexOf("Where"), " Nr_Cabinet = @nrCabinet,");
                StringBuilder sbSqlCommand = new StringBuilder(stringSqlCommand);
                sbSqlCommand[stringSqlCommand.IndexOf("Where") - 1] = ' ';
                stringSqlCommand = sbSqlCommand.ToString();

                ListIntAndString liasD = _Doctor.Find(_Doctor => _Doctor.str == comboBoxDoctor.Text);

                sqlCommand = new SqlCommand(stringSqlCommand, sqlConnection);
                sqlCommand.Parameters.AddWithValue("codDoctor", liasD.cod);
                if (checkBox_N_Area.Checked)
                    sqlCommand.Parameters.AddWithValue("nrUchastkaDoc", textBoxArea.Text);
                if (checkBox_N_cabinet.Checked)
                    sqlCommand.Parameters.AddWithValue("nrCabinet", textBox_N_Cabinet.Text);
                sqlCommand.ExecuteNonQuery();
                labelSuccesfullyUpdate.Visible = true;
                labelSuccesfullyUpdate.ForeColor = Color.Lime;
                labelSuccesfullyUpdate.Text = "Иноформация успешно обновленна";
                comboBoxDoctor.Text = "";
                textBoxArea.Text = "";
                textBox_N_Cabinet.Text = "";
            }
            else
            {
                labelSuccesfullyUpdate.ForeColor = Color.Red;
                labelSuccesfullyUpdate.Text = _errors.First();
            }
        }
    }
}

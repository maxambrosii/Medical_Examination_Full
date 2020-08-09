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
           
            textBoxAdress.Enabled = false;
            textBoxBelay.Enabled = false;
            textBox_N_Area.Enabled = false;
            textBoxAdress.BackColor = Color.FromArgb(23, 64, 96);
            textBoxBelay.BackColor = Color.FromArgb(23, 64, 96);
            textBox_N_Area.BackColor = Color.FromArgb(23, 64, 96);
          
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
                comboBoxPatient.Items.Add(patient.str);
            }
            sqlDataReader.Close();
        }

        private void UpdatePatientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListIntAndString liasP = _Patient.Find(_Doctor => _Doctor.str == comboBoxPatient.Text);
            sqlCommand = new SqlCommand("Select IDNP, Adress, Strahovka, Nr_Uchastka From Pacient where Cod_Pacient=@codPatient", sqlConnection);
            sqlCommand.Parameters.AddWithValue("codPatient", liasP.cod);
            sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            labelIDNP.Text = "IDNP: " + sqlDataReader.GetString(0);
            labelAdress.Text = "Адрес: " + sqlDataReader.GetString(1);
            labelN_Belay.Text = "№ cтраховки: " + sqlDataReader.GetString(2);
            label_N_Area.Text = "№ участка: " + sqlDataReader.GetInt16(3).ToString();

            sqlDataReader.Close();
        }

        private void checkBoxAdress_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdress.Checked)
            {
                textBoxAdress.BackColor = Color.FromArgb(23, 64, 96);
                textBoxAdress.Enabled = true;
            }
            else
            {
                textBoxAdress.BackColor = Color.FromArgb(23, 64, 96);
                textBoxAdress.Enabled = false;
            }
        }

        private void checkBoxN_belay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxN_belay.Checked)
            {
                textBoxBelay.BackColor = Color.FromArgb(23, 64, 96);
                textBoxBelay.Enabled = true;
            }
            else
            {
                textBoxBelay.BackColor = Color.FromArgb(23, 64, 96);
                textBoxBelay.Enabled = false;
            }
        }

        private void checkBox_N_Area_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_N_Area.Checked)
            {
                textBox_N_Area.BackColor = Color.FromArgb(23, 64, 96);
                textBox_N_Area.Enabled = true;
            }
            else
            {
                textBox_N_Area.BackColor = Color.FromArgb(23, 64, 96);
                textBox_N_Area.Enabled = false;
            }
        }

        private void textBoxBelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            _errors.Clear();
            if (comboBoxPatient.Text == "")
                _errors.Add("*Вы не выбрали пациента");
            if (checkBoxAdress.Checked == false && checkBoxN_belay.Checked == false && checkBox_N_Area.Checked == false)
                _errors.Add("*Вы ничего не выбрали для изменения");
            if (checkBoxAdress.Checked && textBoxAdress.Text == "")
                _errors.Add("*Неправильный формат адреса");
            if (checkBoxN_belay.Checked && (textBoxBelay.Text == "" || textBoxBelay.Text.Length != 15))
                _errors.Add("*Неправильный формат страховки");
            if (checkBox_N_Area.Checked && textBox_N_Area.Text == "")
                _errors.Add("*Неправильный формат № участка");
            if (textBox_N_Area.Text != "")
            {
                if (Convert.ToInt32(textBox_N_Area.Text) < 0)
                    _errors.Add("*Такой участок не существует");
            }
            if (!_errors.Any())
            {
                string stringSqlCommand = "Update Pacient SetWhere Cod_Pacient = @codPacient";
                if (checkBoxAdress.Checked)
                    stringSqlCommand = stringSqlCommand.Insert(stringSqlCommand.IndexOf("Where"), " Adress = @adress,");
                if (checkBoxN_belay.Checked)
                    stringSqlCommand = stringSqlCommand.Insert(stringSqlCommand.IndexOf("Where"), " Strahovka = @strahovka,");
                if (checkBox_N_Area.Checked)
                    stringSqlCommand = stringSqlCommand.Insert(stringSqlCommand.IndexOf("Where"), " Nr_Uchastka = @nrUchastka,");
                StringBuilder sbSqlCommand = new StringBuilder(stringSqlCommand);
                sbSqlCommand[stringSqlCommand.IndexOf("Where") - 1] = ' ';
                stringSqlCommand = sbSqlCommand.ToString();

                ListIntAndString liasP = _Patient.Find(_Doctor => _Doctor.str == comboBoxPatient.Text);

                sqlCommand = new SqlCommand(stringSqlCommand, sqlConnection);
                sqlCommand.Parameters.AddWithValue("codPacient", liasP.cod);
                if (checkBoxAdress.Checked)
                    sqlCommand.Parameters.AddWithValue("adress", textBoxAdress.Text);
                if (checkBoxN_belay.Checked)
                    sqlCommand.Parameters.AddWithValue("strahovka", textBoxBelay.Text);
                if (checkBox_N_Area.Checked)
                    sqlCommand.Parameters.AddWithValue("nrUchastka", textBox_N_Area.Text);
                sqlCommand.ExecuteNonQuery();
                labelSuccesfullyUpdate.Visible = true;
                labelSuccesfullyUpdate.ForeColor = Color.Lime;
                labelSuccesfullyUpdate.Text = "Информация успешно обновленна";
                comboBoxPatient.Text = "";
                textBoxAdress.Text = "";
                textBoxBelay.Text = "";
                textBox_N_Area.Text = "";
                labelIDNP.Text = "IDNP:";
                labelAdress.Text = "Адрес:";
                labelN_Belay.Text = "№ cтраховки:";
                label_N_Area.Text = "№ участка:";

            }
            else
            {
                labelSuccesfullyUpdate.ForeColor = Color.Red;
                labelSuccesfullyUpdate.Text = _errors.First();
            }
        }
    }
}

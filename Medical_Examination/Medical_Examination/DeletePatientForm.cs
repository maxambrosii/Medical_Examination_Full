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
    public partial class DeletePatientForm : Form
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

        public DeletePatientForm()
        {
            InitializeComponent();
         
        }

        private void DeletePatientForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();
            rewriteComboBox();
        }

        private void DeletePatientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }
        private void rewriteComboBox()
        {
            comboBox_Patient.Items.Clear();
            sqlCommand = new SqlCommand("Select Cod_Pacient, FIO_Pacient, IDNP From Pacient", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                patient.cod = sqlDataReader.GetInt32(0);
                patient.str = sqlDataReader.GetString(1);
                _Patient.Add(patient);
                comboBox_Patient.Items.Add(patient.str);
            }
            sqlDataReader.Close();
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить?", "Удаление пациента", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ListIntAndString liasP = _Patient.Find(_Doctor => _Doctor.str == comboBox_Patient.Text);

                sqlCommand = new SqlCommand("Delete From Pacient where Cod_Pacient = @codPacient ", sqlConnection);
                sqlCommand.Parameters.AddWithValue("codPacient", liasP.cod);
                sqlCommand.ExecuteNonQuery();
                lblSuccesfullyDeleted.Visible = true;
                lblSuccesfullyDeleted.Text = "";
                lbl_IDNP.Text = "IDNP:";
                lbl_Adress.Text = "Адрес:";
                lbl_N_Strahovki.Text = "№ cтраховки:";
                lbl_N_Area.Text = "№ участка:";
                lblSuccesfullyDeleted.Text = "Вы успешно удалили данные";
                comboBox_Patient.Text = "";
                rewriteComboBox();
            }
            else if (dialogResult == DialogResult.No)
            {
                lblSuccesfullyDeleted.Text = "";

                comboBox_Patient.Text = "";
            }
            button_delete.Visible = false;
        }

        private void comboBox_Patient_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_delete.Visible = true;
          
            ListIntAndString liasP = _Patient.Find(_Doctor => _Doctor.str == comboBox_Patient.Text);
            sqlCommand = new SqlCommand("Select IDNP, Adress, Strahovka, Nr_Uchastka From Pacient where Cod_Pacient=@codPatient", sqlConnection);
            sqlCommand.Parameters.AddWithValue("codPatient", liasP.cod);
            sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            lbl_IDNP.Text = "IDNP: " + sqlDataReader.GetString(0);
            lbl_Adress.Text = "Адрес: " + sqlDataReader.GetString(1);
            lbl_N_Strahovki.Text = "№ cтраховки: " + sqlDataReader.GetString(2);
            lbl_N_Area.Text = "№ участка: " + sqlDataReader.GetInt16(3).ToString();

            sqlDataReader.Close();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (lbl_Info.Left > -lbl_Info.Width)
            {
                lbl_Info.Left -= 3;
            }
            else
            {
                lbl_Info.Left = lbl_Info.Width;
            }
        }
    }
}

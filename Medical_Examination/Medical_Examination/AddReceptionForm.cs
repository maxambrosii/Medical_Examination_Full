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
    public partial class AddReceptionForm : Form
    {
        struct ListIntAndString
        {
            public int cod { get; set; }
            public string str { get; set; }
        }
        int codPriem, CodPriemFromRecipe;
        bool isWriteRecipe = false, isRewriteReception = true, firstInsertOfReception = false;
        List<string> _errors = new List<string>();
        List<ListIntAndString> _Patient = new List<ListIntAndString>();
        ListIntAndString patient = new ListIntAndString();
        List<ListIntAndString> _Doctor = new List<ListIntAndString>();
        ListIntAndString doctor = new ListIntAndString();
        List<ListIntAndString> _Diagnosis = new List<ListIntAndString>();
        ListIntAndString diagnosis = new ListIntAndString();
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\Medical_Examination\Medical_Examination\Dispanserizatsia.mdf;Integrated Security=True;Connect Timeout=30");


        public AddReceptionForm()
        {
            InitializeComponent();

        }

        private void AddReceptionForm_Load(object sender, EventArgs e)
        {
            //подключение бд
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();
            //новый код приема
            sqlCommand = new SqlCommand("SELECT MAX(Cod_Priema) FROM Priem", sqlConnection);
            codPriem = Convert.ToInt32(sqlCommand.ExecuteScalar());
            codPriem++;
            //Добавление пациентов
            sqlCommand = new SqlCommand("Select Cod_Pacient, FIO_Pacient From Pacient", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                patient.cod = sqlDataReader.GetInt32(0);
                patient.str = sqlDataReader.GetString(1);
                _Patient.Add(patient);
                comboBox_Patient.Items.Add(patient.str);
            }
            sqlDataReader.Close();
            //Добавление докторов
            sqlCommand = new SqlCommand("Select Cod_Doctor, FIO_Doctor From Doctor", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                doctor.cod = sqlDataReader.GetInt32(0);
                doctor.str = sqlDataReader.GetString(1);
                _Doctor.Add(doctor);
                comboBox_Doctor.Items.Add(doctor.str);
            }
            sqlDataReader.Close();
            //Добавление диагнозов
            sqlCommand = new SqlCommand("Select Cod_Diagnoz, Diagnoz From DocDiagnoz", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                diagnosis.cod = sqlDataReader.GetInt16(0);
                diagnosis.str = sqlDataReader.GetString(1);
                _Diagnosis.Add(diagnosis);
                comboBox_Diagnoz.Items.Add(diagnosis.str);
            }
            sqlDataReader.Close();
        }

        private void AddReceptionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _errors.Clear();
            int error = 0;
            if (comboBox_Patient.Text == "")
            {
                _errors.Add("Вы не выбрали пациента!");
                error++;
                comboBox_Patient.BackColor = Color.Red;
            }
            if (comboBox_Doctor.Text == "")
            {
                _errors.Add("Вы не выбрали доктора!");
                error++;
                comboBox_Doctor.BackColor = Color.Red;
            }
            if (comboBox_Diagnoz.Text == "")
            {
                _errors.Add("Вы не выбрали диагноз!");
                error++;
                comboBox_Diagnoz.BackColor = Color.Red;
            }
            if (!_errors.Any())
            {
                if (error == 0)
                {
                    dTP_Date_P.Value = DateTime.Today;
                    dTP_Time_P.Value = DateTime.Now;
                    lblSuccesfullyAdded.Text = "Вы успешно внести данные!";
                    lblSuccesfullyAdded.ForeColor = Color.Lime;

                    comboBox_Patient.Text = "";
                    comboBox_Doctor.Text = "";
                    comboBox_Diagnoz.Text = "";

                    lbl_Doctor.Visible = false;
                    lbl_Diagnoz.Visible = false;
                    lbl_Date_P.Visible = false;
                    lbl_Time_P.Visible = false;
                    lbl_Recipe.Visible = false;
                    comboBox_Doctor.Visible = false;
                    comboBox_Diagnoz.Visible = false;
                    dTP_Date_P.Visible = false;
                    dTP_Time_P.Visible = false;
                    buttonAddRecipe.Visible = false;
                    buttonAdd.Enabled = false;
                    lblSuccesfullyAdded.Visible = true;

                    if (isWriteRecipe == true && isRewriteReception == false)
                        Close();
                    else if (isRewriteReception == true)
                    {

                    }
                }
            }
            else
            {
                lblSuccesfullyAdded.Visible = true;
                lblSuccesfullyAdded.ForeColor = Color.Red;
                lblSuccesfullyAdded.Text = _errors.First();
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            //Вносим прием, до открытия рецепта
            patient = _Patient.Find(_Patient => _Patient.str == comboBox_Patient.Text);
            doctor = _Doctor.Find(_Doctor => _Doctor.str == comboBox_Doctor.Text);
            diagnosis = _Diagnosis.Find(_Diagnosis => _Diagnosis.str == comboBox_Diagnoz.Text);

            if (firstInsertOfReception == false)
            {
                sqlCommand = new SqlCommand("INSERT INTO Priem(Cod_Priema, Cod_Doctor, Cod_Pacient, Cod_Diagnoz, Data_Priema, Time_Priema) VALUES(@codPriema, @codDoctor, @codPacient, @codDiagnoz, @dataPriema, @timePriema)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("codPriema", codPriem);
                sqlCommand.Parameters.AddWithValue("codDoctor", doctor.cod);
                sqlCommand.Parameters.AddWithValue("codPacient", patient.cod);
                sqlCommand.Parameters.AddWithValue("codDiagnoz", diagnosis.cod);
                sqlCommand.Parameters.AddWithValue("dataPriema", dTP_Date_P.Value.Date);
                sqlCommand.Parameters.AddWithValue("timePriema", dTP_Time_P.Value.TimeOfDay);
                sqlCommand.ExecuteNonQuery();
                firstInsertOfReception = true;
            }
            this.Hide();
            AddRecipeForm recipeform = new AddRecipeForm(codPriem, isWriteRecipe);
            recipeform.ShowDialog();
            recipeform = null;
            this.Show();

            sqlCommand = new SqlCommand("Select MAX(Cod_Priema) From Retsept", sqlConnection);
            CodPriemFromRecipe = Convert.ToInt32(sqlCommand.ExecuteScalar());

            if (CodPriemFromRecipe == codPriem)
            {
                buttonAdd.Enabled = true;
                isWriteRecipe = true;
            }
            isRewriteReception = false;
        }

        private void dTP_Time_P_ValueChanged(object sender, EventArgs e)
        {
            buttonAddRecipe.Visible = true;
            lbl_Recipe.Visible = true;
            isRewriteReception = true;
        }

        private void dTP_Time_P_KeyDown(object sender, KeyEventArgs e)
        {
            buttonReturn.Enabled = true;
        }

        private void dTP_Date_P_ValueChanged(object sender, EventArgs e)
        {
            lbl_Time_P.Visible = true;
            dTP_Time_P.Visible = true;
            isRewriteReception = true;
        }

        private void dTP_Date_P_KeyDown(object sender, KeyEventArgs e)
        {
            lbl_Time_P.Visible = true;
            dTP_Time_P.Visible = true;
        }

        private void comboBox_Diagnoz_SelectedIndexChanged(object sender, EventArgs e)
        {
            //---
            isRewriteReception = true;
            lbl_Date_P.Visible = true;
            dTP_Date_P.Visible = true;
        }

        private void comboBox_Diagnoz_Click(object sender, EventArgs e)
        {
            comboBox_Diagnoz.BackColor = Color.FromArgb(23, 64, 96);
        }

        private void comboBox_Patient_Click(object sender, EventArgs e)
        {
            comboBox_Patient.BackColor = Color.FromArgb(23, 64, 96);
        }

        private void comboBox_Patient_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Doctor.Visible = true;
            lbl_Doctor.Visible = true;
            lblSuccesfullyAdded.Visible = false;
            isRewriteReception = true;
        }

        private void comboBox_Patient_KeyDown(object sender, KeyEventArgs e)
        {
            comboBox_Doctor.Visible = true;
            lbl_Doctor.Visible = true;
        }

        private void buttonAddRecipe_KeyDown(object sender, KeyEventArgs e)
        {
            lbl_Date_P.Visible = true;
            dTP_Date_P.Visible = true;
        }

        private void comboBox_Doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Diagnoz.Visible = true;
            lbl_Diagnoz.Visible = true;
            isRewriteReception = true;
        }

        private void comboBox_Doctor_KeyDown(object sender, KeyEventArgs e)
        {
            comboBox_Diagnoz.Visible = true;
            lbl_Diagnoz.Visible = true;
        }

        private void comboBox_Diagnoz_KeyDown(object sender, KeyEventArgs e)
        {
            buttonAddRecipe.Visible = true;
            lbl_Recipe.Visible = true;
        }
    }
}

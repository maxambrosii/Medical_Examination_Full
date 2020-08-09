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

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Вносим прием, до открытия рецепта
            patient = _Patient.Find(_Patient => _Patient.str == comboBox1.Text);
            doctor = _Doctor.Find(_Doctor => _Doctor.str == comboBox2.Text);
            diagnosis = _Diagnosis.Find(_Diagnosis => _Diagnosis.str == comboBox3.Text);

            if (firstInsertOfReception == false)
            {
                sqlCommand = new SqlCommand("INSERT INTO Priem(Cod_Priema, Cod_Doctor, Cod_Pacient, Cod_Diagnoz, Data_Priema, Time_Priema) VALUES(@codPriema, @codDoctor, @codPacient, @codDiagnoz, @dataPriema, @timePriema)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("codPriema", codPriem);
                sqlCommand.Parameters.AddWithValue("codDoctor", doctor.cod);
                sqlCommand.Parameters.AddWithValue("codPacient", patient.cod);
                sqlCommand.Parameters.AddWithValue("codDiagnoz", diagnosis.cod);
                sqlCommand.Parameters.AddWithValue("dataPriema", dateTimePicker1.Value.Date);
                sqlCommand.Parameters.AddWithValue("timePriema", dateTimePicker2.Value.TimeOfDay);
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
                button2.Enabled = true;
                isWriteRecipe = true;
            }
            isRewriteReception = false;
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
                comboBox1.Items.Add(patient.str);
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
                comboBox2.Items.Add(doctor.str);
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
                comboBox3.Items.Add(diagnosis.str);
            }
            sqlDataReader.Close();
        }

        private void AddReceptionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            comboBox2.Visible = true;
            label2.Visible = true;
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            comboBox3.Visible = true;
            label3.Visible = true;
        }

        private void comboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            button3.Visible = true;
            label7.Visible = true;
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            label4.Visible = true;
            dateTimePicker1.Visible = true;

        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            label5.Visible = true;
            dateTimePicker2.Visible = true;
        }

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {
            button1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            label2.Visible = true;
            label11.Visible = false;
            isRewriteReception = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Visible = true;
            label3.Visible = true;
            isRewriteReception = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //---
            isRewriteReception = true;
            label4.Visible = true;
            dateTimePicker1.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            dateTimePicker2.Visible = true;
            isRewriteReception = true;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            button3.Visible = true;
            label7.Visible = true;
            isRewriteReception = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            _errors.Clear();
            int error = 0;
            if (comboBox1.Text == "")
            {
                _errors.Add("Вы не выбрали пациента!");
                error++;
                comboBox1.BackColor = Color.Red;
            }
            if (comboBox2.Text == "")
            {
                _errors.Add("Вы не выбрали доктора!");
                error++;
                comboBox2.BackColor = Color.Red;
            }
            if (comboBox3.Text == "")
            {
                _errors.Add("Вы не выбрали диагноз!");
                error++;
                comboBox3.BackColor = Color.Red;
            }
            if (!_errors.Any())
            {
                if (error == 0)
                {
                    dateTimePicker1.Value = DateTime.Today;
                    dateTimePicker2.Value = DateTime.Now;
                    label11.Text = "Вы успешно внести данные!";
                    label11.ForeColor = Color.Lime;

                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    comboBox3.Text = "";

                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label7.Visible = false;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    dateTimePicker1.Visible = false;
                    dateTimePicker2.Visible = false;
                    button3.Visible = false;
                    button2.Enabled = false;
                    label11.Visible = true;

                    if (isWriteRecipe == true && isRewriteReception == false)
                        Close();
                    else if (isRewriteReception == true)
                    {
                        /*
                        sqlCommand = new SqlCommand("Delete from Priem where Cod_Priema = @codPriema", sqlConnection);
                        sqlCommand.Parameters.AddWithValue("codPriema", codPriem);
                        sqlCommand.ExecuteNonQuery();

                        patient = _Patient.Find(_Patient => _Patient.str == comboBox1.Text);
                        doctor = _Doctor.Find(_Doctor => _Doctor.str == comboBox2.Text);
                        diagnosis = _Diagnosis.Find(_Diagnosis => _Diagnosis.str == comboBox3.Text);

                        sqlCommand = new SqlCommand("INSERT INTO Priem(Cod_Priema, Cod_Doctor, Cod_Pacient, Cod_Diagnoz, Data_Priema, Time_Priema) VALUES(@codPriema, @codDoctor, @codPacient, @codDiagnoz, @dataPriema, @timePriema)", sqlConnection);
                        sqlCommand.Parameters.AddWithValue("codPriema", codPriem);
                        sqlCommand.Parameters.AddWithValue("codDoctor", doctor.cod);
                        sqlCommand.Parameters.AddWithValue("codPacient", patient.cod);
                        sqlCommand.Parameters.AddWithValue("codDiagnoz", diagnosis.cod);
                        sqlCommand.Parameters.AddWithValue("dataPriema", dateTimePicker1.Value.Date);
                        sqlCommand.Parameters.AddWithValue("timePriema", dateTimePicker2.Value.TimeOfDay);
                        sqlCommand.ExecuteNonQuery();
                        */

                    }
                }
            }
            else
            {
                label11.Visible = true;
                label11.ForeColor = Color.Red;
                label11.Text = _errors.First();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.White;
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            comboBox2.BackColor = Color.White;
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            comboBox3.BackColor = Color.White;
        }
    }
}

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

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
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
            comboBox1.Items.Clear();
            sqlCommand = new SqlCommand("Select Cod_Pacient, FIO_Pacient, IDNP From Pacient", sqlConnection);
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

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить?", "Удаление пациента", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ListIntAndString liasP = _Patient.Find(_Doctor => _Doctor.str == comboBox1.Text);

                sqlCommand = new SqlCommand("Delete From Pacient where Cod_Pacient = @codPacient ", sqlConnection);
                sqlCommand.Parameters.AddWithValue("codPacient", liasP.cod);
                sqlCommand.ExecuteNonQuery();
                label4.Visible = true;
                label4.Text = "";
                label7.Text = "IDNP:";
                label11.Text = "Адрес:";
                label5.Text = "№ cтраховки:";
                label6.Text = "№ участка:";
                label4.Text = "Вы успешно удалили данные";
                comboBox1.Text = "";
                rewriteComboBox();
            }
            else if (dialogResult == DialogResult.No)
            {
                label4.Text = "";
               
                comboBox1.Text = "";
            }
            button4.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Left > -label1.Width)
            {
                label1.Left -= 3;
            }
            else
            {
                label1.Left = label1.Width;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Visible = true;
            //====
            //ListIntAndString liasP = _Patient.Find(_Doctor => _Doctor.str == comboBox1.Text);

            //sqlCommand = new SqlCommand("Select dbo.Patient.IDNP From dbo.Pacient where dbo.Patient.Cod_Pacient = @codPacient ", sqlConnection);
            //sqlCommand.Parameters.AddWithValue("codPacient", liasP.cod);

            //sqlDataReader = sqlCommand.ExecuteReader();
            //label3.Visible = true;
            //label3.Text = "IDNP выбранного пациента: " + sqlDataReader.GetString(0);
            ////=====
            ListIntAndString liasP = _Patient.Find(_Doctor => _Doctor.str == comboBox1.Text);
            sqlCommand = new SqlCommand("Select IDNP, Adress, Strahovka, Nr_Uchastka From Pacient where Cod_Pacient=@codPatient", sqlConnection);
            sqlCommand.Parameters.AddWithValue("codPatient", liasP.cod);
            sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            label7.Text = "IDNP: " + sqlDataReader.GetString(0);
            label11.Text = "Адрес: " + sqlDataReader.GetString(1);
            label5.Text = "№ cтраховки: " + sqlDataReader.GetString(2);
            label6.Text = "№ участка: " + sqlDataReader.GetInt16(3).ToString();

            sqlDataReader.Close();




        }
    }
}

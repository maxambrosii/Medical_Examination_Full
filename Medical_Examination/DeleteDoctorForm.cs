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
    public partial class DeleteDoctorForm : Form
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

        public DeleteDoctorForm()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteDoctorForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();
            rewriteComboBox();
        }

        private void DeleteDoctorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }
        private void rewriteComboBox()
        {
            comboBox1.Items.Clear();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить?", "Удаление пациента", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ListIntAndString liasD = _Doctor.Find(_Doctor => _Doctor.str == comboBox1.Text);

                sqlCommand = new SqlCommand("Delete From Doctor where Cod_Doctor = @codDoctor ", sqlConnection);
                sqlCommand.Parameters.AddWithValue("codDoctor", liasD.cod);
                sqlCommand.ExecuteNonQuery();
                label2.Text = "Вы успешно удалили данные";
                comboBox1.Text = "";
                rewriteComboBox();
            }
            else if (dialogResult == DialogResult.No)
            {
                label2.Text = "";
                comboBox1.Text = "";
            }
            button4.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label3.Left > -label3.Width)
            {
                label3.Left -= 3;
            }
            else
            {
                label3.Left = label3.Width;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Visible = true;

        }
    }
}

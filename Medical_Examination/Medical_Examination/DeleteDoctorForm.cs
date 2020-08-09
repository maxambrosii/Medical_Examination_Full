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
            comboBox_Doctor.Items.Clear();
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
        }

        private void comboBox_Doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_Delete.Visible = true;
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

        private void button_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить?", "Удаление пациента", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ListIntAndString liasD = _Doctor.Find(_Doctor => _Doctor.str == comboBox_Doctor.Text);

                sqlCommand = new SqlCommand("Delete From Doctor where Cod_Doctor = @codDoctor ", sqlConnection);
                sqlCommand.Parameters.AddWithValue("codDoctor", liasD.cod);
                sqlCommand.ExecuteNonQuery();
                lblSuccesfullyDeleted.Visible = true;
                lblSuccesfullyDeleted.Text = "Вы успешно удалили данные";
                comboBox_Doctor.Text = "";
                rewriteComboBox();
            }
            else if (dialogResult == DialogResult.No)
            {
                lblSuccesfullyDeleted.Text = "";
                comboBox_Doctor.Text = "";
            }
            button_Delete.Visible = false;
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class AddDoctorForm : Form
    {
        int codDoctor;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\Medical_Examination\Medical_Examination\Dispanserizatsia.mdf;Integrated Security=True;Connect Timeout=30");
        List<string> _errors = new List<string>();

        public AddDoctorForm()
        {
            InitializeComponent();
         //   textBox2.MaxLength = 5;
         //   textBox3.MaxLength = 5;
        }




        private void AddDoctorForm_Load(object sender, EventArgs e)
        {

            try
            {
                connection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            connection.Open();
        }

        private void AddDoctorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

       

        private void bunifuMaterialTextbox1_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.BackColor = Color.FromArgb(79, 118, 208);
        }

        private void bunifuMaterialTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            bunifuMaterialTextbox2.Visible = true;
            label2.Visible = true;
        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void bunifuMaterialTextbox1_Click_1(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.BackColor = Color.FromArgb(79, 118, 208);
        }

        private void bunifuMaterialTextbox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void bunifuMaterialTextbox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            bunifuMaterialTextbox3.Visible = true;
            label3.Visible = true;
        }

        private void bunifuMaterialTextbox2_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox3.BackColor = Color.FromArgb(79, 118, 208);
        }

        private void bunifuMaterialTextbox2_KeyDown(object sender, KeyEventArgs e)
        {
            button4.Enabled = true;
        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            _errors.Clear();
            int error = 0;

            if (bunifuMaterialTextbox1.Text == "")
            {

                _errors.Add("Вы не ввели ФИО доктора!");

                error++;
                bunifuMaterialTextbox1.BackColor = Color.Red;
            }
            if (bunifuMaterialTextbox2.Text == "")
            {


                _errors.Add("Вы не ввели номер участка!");
                error++;
                bunifuMaterialTextbox2.BackColor = Color.Red;
            }
            if (bunifuMaterialTextbox3.Text == "")
            {
                _errors.Add("Вы не ввели № кабинета!");
                error++;
                bunifuMaterialTextbox3.BackColor = Color.Red;
            }
            if (!_errors.Any())
            {
                if (error == 0)
                {


                    SqlCommand command = new SqlCommand("SELECT MAX(Cod_Doctor) FROM Doctor", connection);

                    codDoctor = 0;
                    codDoctor = Convert.ToInt32(command.ExecuteScalar());
                    codDoctor++;

                    command = new SqlCommand("INSERT INTO Doctor(Cod_Doctor, FIO_Doctor, Nr_Uchastka_DOC, Nr_Cabinet) VALUES(@codDoctor, @fio, @NrUchastkaDOC, @NrCabinet)", connection);
                    command.Parameters.AddWithValue("codDoctor", codDoctor);
                    command.Parameters.AddWithValue("fio", bunifuMaterialTextbox1.Text);
                    command.Parameters.AddWithValue("NrUchastkaDOC", bunifuMaterialTextbox2.Text);
                    command.Parameters.AddWithValue("NrCabinet", bunifuMaterialTextbox3.Text);
                    command.ExecuteNonQuery();
                    bunifuMaterialTextbox1.Text = "";
                    bunifuMaterialTextbox2.Text = "";
                    bunifuMaterialTextbox3.Text = "";

                    bunifuMaterialTextbox2.Visible = false;
                    bunifuMaterialTextbox3.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label11.Text = "Вы успешно внести данные!";
                    label11.ForeColor = Color.Lime;
                    bunifuMaterialTextbox1.Enabled = true;
                    bunifuMaterialTextbox2.Enabled = true;
                    bunifuMaterialTextbox3.Enabled = true;

                    bunifuTransition1.Show(label11); 

                    button4.Enabled = false;

                }
            }
            else
            {
                label11.Visible = true;
                label11.ForeColor = Color.Red;
                label11.Text = _errors.First();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text.Length > 3) bunifuMaterialTextbox2.Enabled = false;
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox3.Text.Length > 3) bunifuMaterialTextbox3.Enabled = false;
        }
    }
}

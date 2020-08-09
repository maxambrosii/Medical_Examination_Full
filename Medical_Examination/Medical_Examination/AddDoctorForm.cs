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

        private void Textbox_FIO_Click(object sender, EventArgs e)
        {
            Textbox_FIO.BackColor = Color.FromArgb(23, 64, 96);
        }

        private void Textbox_FIO_KeyDown(object sender, KeyEventArgs e)
        {
            Textbox_N_Region.Visible = true;
            lblN_Region.Visible = true;

           
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _errors.Clear();
            int error = 0;

            if (Textbox_FIO.Text == "")
            {

                _errors.Add("Вы не ввели ФИО доктора!");

                error++;
                Textbox_FIO.BackColor = Color.Red;
            }
            if (Textbox_N_Region.Text == "")
            {


                _errors.Add("Вы не ввели номер участка!");
                error++;
                Textbox_N_Region.BackColor = Color.Red;
            }
            if (Textbox_n_Cabinet.Text == "")
            {
                _errors.Add("Вы не ввели № кабинета!");
                error++;
                Textbox_n_Cabinet.BackColor = Color.Red;
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
                    command.Parameters.AddWithValue("fio", Textbox_FIO.Text);
                    command.Parameters.AddWithValue("NrUchastkaDOC", Textbox_N_Region.Text);
                    command.Parameters.AddWithValue("NrCabinet", Textbox_n_Cabinet.Text);
                    command.ExecuteNonQuery();
                    Textbox_FIO.Text = "";
                    Textbox_N_Region.Text = "";
                    Textbox_n_Cabinet.Text = "";

                    Textbox_N_Region.Visible = false;
                    Textbox_n_Cabinet.Visible = false;
                    lblN_Region.Visible = false;
                    lbl_n_Cabinet.Visible = false;
                    lblSuccesfullAdded.Text = "Вы успешно внести данные!";
                    lblSuccesfullAdded.ForeColor = Color.Lime;
                    Textbox_FIO.Enabled = true;
                    Textbox_N_Region.Enabled = true;
                    Textbox_n_Cabinet.Enabled = true;

                    Transition.Show(lblSuccesfullAdded);

                    buttonAdd.Enabled = false;

                }
            }
            else
            {
                lblSuccesfullAdded.Visible = true;
                lblSuccesfullAdded.ForeColor = Color.Red;
                lblSuccesfullAdded.Text = _errors.First();
            }
        }

        private void Textbox_N_Region_KeyDown(object sender, KeyEventArgs e)
        {
            
            Textbox_n_Cabinet.Visible = true;
            lbl_n_Cabinet.Visible = true;
        }

        private void Textbox_FIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void Textbox_N_Region_OnValueChanged(object sender, EventArgs e)
        {
            if (Textbox_N_Region.Text.Length > 3) Textbox_N_Region.Enabled = false;
        }

        private void Textbox_n_Cabinet_OnValueChanged(object sender, EventArgs e)
        {
            if (Textbox_n_Cabinet.Text.Length > 3) Textbox_n_Cabinet.Enabled = false;
        }

        private void Textbox_N_Region_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void Textbox_N_Region_Click(object sender, EventArgs e)
        {
            Textbox_N_Region.BackColor = Color.FromArgb(23, 64, 96);
          
        }

        private void Textbox_n_Cabinet_KeyDown(object sender, KeyEventArgs e)
        {
            buttonAdd.Enabled = true;
        }

        private void Textbox_n_Cabinet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void Textbox_n_Cabinet_Click(object sender, EventArgs e)
        {
            Textbox_n_Cabinet.BackColor = Color.FromArgb(23, 64, 96);
        }
    }
}

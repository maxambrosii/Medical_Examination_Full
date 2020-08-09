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
    public partial class AddPatientForm : Form
    {
        int codPatient;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\Medical_Examination\Medical_Examination\Dispanserizatsia.mdf;Integrated Security=True;Connect Timeout=30");
        List<string> _errors = new List<string>();

        public AddPatientForm()
        {
            InitializeComponent();  
            radioButton_Masculin.Checked = true;

        }

        private void AddPatientForm_Load(object sender, EventArgs e)
        {
            dTP_Date_R.MaxDate = DateTime.Now;

            try
            {
                connection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            connection.Open();
        }

        private void AddPatientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void bunifuMaterialTextbox1_Click(object sender, EventArgs e)
        {
            Textbox_FIO.BackColor = Color.FromArgb(23, 64, 96);
            LblAddSuccesfull.Visible = false;
        }
        
        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {
            if (TextBox_N_Region.Text.Length > 3) TextBox_N_Region.Enabled = false;
        }


        private void TextBox_N_Region_OnValueChanged(object sender, EventArgs e)
        {
            TextBox_N_Region.BackColor = Color.FromArgb(23, 64, 96);
            LblAddSuccesfull.Visible = false;
        }

        private void TextBox_N_Region_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void TextBox_N_Region_KeyDown(object sender, KeyEventArgs e)
        {
            radioButton_Masculin.Visible = true;
            radioButtonFemenin.Visible = true;
            lbl_Pol.Visible = true;
            dTP_Date_R.Visible = true;
            lbl_Date.Visible = true;
        }

        private void Textbox_N_strahovki_OnValueChanged(object sender, EventArgs e)
        {
            if (Textbox_N_strahovki.Text.Length > 14) Textbox_N_strahovki.Enabled = false;
        }

        private void Textbox_N_strahovki_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void Textbox_N_strahovki_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox_N_Region.Visible = true;
            lbl_N_Ucastka.Visible = true;
        }

        private void Textbox_N_strahovki_Click(object sender, EventArgs e)
        {
            Textbox_N_strahovki.BackColor = Color.FromArgb(23, 64, 96);
            LblAddSuccesfull.Visible = false;
        }

        private void Textbox_Adress_KeyDown(object sender, KeyEventArgs e)
        {
            Textbox_N_strahovki.Visible = true;
            lbl_N_Strahovka.Visible = true;
        }

        private void Textbox_Adress_Click(object sender, EventArgs e)
        {
            Textbox_Adress.BackColor = Color.FromArgb(23, 64, 96);
            LblAddSuccesfull.Visible = false;
        }

        private void Textbox_Adress_Enter(object sender, EventArgs e)
        {
            Textbox_Adress.Text = "";
        }

        private void Textbox_IDNP_OnValueChanged(object sender, EventArgs e)
        {
            if (Textbox_IDNP.Text.Length > 12) Textbox_IDNP.Enabled = false;
        }

        private void Textbox_IDNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }

        }

        private void Textbox_IDNP_KeyDown(object sender, KeyEventArgs e)
        {
            Textbox_Adress.Visible = true;
            lblAdres.Visible = true;
        }

        private void Textbox_IDNP_Click(object sender, EventArgs e)
        {
            Textbox_IDNP.BackColor = Color.FromArgb(23, 64, 96);
            LblAddSuccesfull.Visible = false;
        }

        private void Textbox_FIO_MouseDown(object sender, MouseEventArgs e)
        {
            Textbox_FIO.BackColor = Color.FromArgb(23, 64, 96);
            Textbox_FIO.ForeColor = Color.Black;
        }

        private void Textbox_FIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void Textbox_FIO_KeyDown(object sender, KeyEventArgs e)
        {
            Textbox_IDNP.Visible = true;
            lblIDNP.Visible = true;
        }

        private void Textbox_FIO_Enter(object sender, EventArgs e)
        {
            Textbox_FIO.Text = "";
        }

        private void dTP_Date_R_ValueChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = true;
            LblAddSuccesfull.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Textbox_IDNP.Enabled = true;
            Textbox_N_strahovki.Enabled = true;
            TextBox_N_Region.Enabled = true;
            _errors.Clear();
            int errors = 0;

            if (Textbox_FIO.Text == "")
            {

                _errors.Add("Вы не ввели ФИО пациента!");

                Textbox_FIO.Focus();

                errors++;
            }

            if (Textbox_IDNP.Text.Length < 13)
            {
                _errors.Add("Вы ввели неправильное IDNP!");

                Textbox_IDNP.Focus();
                Textbox_IDNP.Enabled = true;

                errors++;

            }

            if (Textbox_Adress.Text == "")
            {
                _errors.Add("Вы не ввели адрес пациента!");
                Textbox_Adress.Focus();

                errors++;

            }

            if (Textbox_N_strahovki.Text.Length < 15)
            {
                _errors.Add("Вы ввели неверный номер страховки!");
                Textbox_N_strahovki.Focus();
                errors++;
                Textbox_N_strahovki.Enabled = true;
            }

            if (TextBox_N_Region.Text == "")
            {
                _errors.Add("Вы ввели неверный номер участка!");
                TextBox_N_Region.Focus();
                TextBox_N_Region.Enabled = true;

                errors++;
            }


            if (!_errors.Any())
            {
                if (errors == 0)
                {

                    int gender;
                    if (radioButton_Masculin.Checked)
                        gender = 0;
                    else
                        gender = 1;

                    SqlCommand command = new SqlCommand("SELECT MAX(Cod_Pacient) FROM Pacient", connection);

                    codPatient = 0;
                    codPatient = Convert.ToInt32(command.ExecuteScalar());
                    codPatient++;

                    command = new SqlCommand("INSERT INTO Pacient(Cod_Pacient, FIO_Pacient, IDNP, Adress, Strahovka, Nr_Uchastka, age, gender) VALUES(@codPatient, @fio, @idnp, @adress, @strahovka, @nr_uchastka, @age, @gender)", connection);
                    command.Parameters.AddWithValue("codPatient", codPatient);
                    command.Parameters.AddWithValue("fio", Textbox_FIO.Text);
                    command.Parameters.AddWithValue("idnp", Textbox_IDNP.Text);
                    command.Parameters.AddWithValue("adress", Textbox_Adress.Text);
                    command.Parameters.AddWithValue("strahovka", Textbox_N_strahovki.Text);
                    command.Parameters.AddWithValue("nr_uchastka", TextBox_N_Region.Text);
                    command.Parameters.AddWithValue("age", DateTime.Now.Year - dTP_Date_R.Value.Year);
                    command.Parameters.AddWithValue("gender", gender);
                    command.ExecuteNonQuery();
                    LblAddSuccesfull.ForeColor = Color.Lime;
                    LblAddSuccesfull.Text = "Вы успешно внесли данные!";
                    Textbox_FIO.Text = "";
                    Textbox_IDNP.Text = "";
                    Textbox_Adress.Text = "";
                    Textbox_N_strahovki.Text = "";
                    TextBox_N_Region.Text = "";
                    Textbox_Adress.Visible = false;
                    Textbox_IDNP.Visible = false;
                    lblIDNP.Visible = false;
                    lblAdres.Visible = false;
                    lbl_N_Strahovka.Visible = false;
                    Textbox_N_strahovki.Visible = false;
                    TextBox_N_Region.Visible = false;
                    lbl_N_Ucastka.Visible = false;
                    lbl_Pol.Visible = false;
                    lbl_Date.Visible = false;
                    radioButton_Masculin.Visible = false;
                    radioButtonFemenin.Visible = false;
                    dTP_Date_R.Visible = false;
                    LblAddSuccesfull.Visible = true;
                    buttonAdd.Enabled = false;
                    Textbox_IDNP.Enabled = true;
                    Textbox_N_strahovki.Enabled = true;
                    TextBox_N_Region.Enabled = true;
                }

            }
            else
            {
                LblAddSuccesfull.Visible = true;
                LblAddSuccesfull.ForeColor = Color.Red;
                LblAddSuccesfull.Text = _errors.First();
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton_Masculin_Click(object sender, EventArgs e)
        {
            LblAddSuccesfull.Visible = false;
        }

     
    }
    }
 

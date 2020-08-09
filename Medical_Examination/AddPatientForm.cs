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
       
    radioButton1.Checked = true;

      
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
       
        }

        private void AddPatientForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;

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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
        
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
        
            
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
            label11.Visible = false;
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
           bunifuMaterialTextbox4.BackColor = Color.FromArgb(79, 118, 208);
            label11.Visible = false;

        }

        private void textBox5_Click(object sender, EventArgs e)
        {
          
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            label11.Visible = false;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            label11.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.Enabled = true;
            bunifuMaterialTextbox4.Enabled = true;
            bunifuMaterialTextbox5.Enabled = true;
            _errors.Clear();
            int errors = 0;

            if (bunifuMaterialTextbox1.Text == "")
            {

                _errors.Add("Вы не ввели ФИО пациента!");

                bunifuMaterialTextbox1.Focus();
                
                errors++;
            }

            if (bunifuMaterialTextbox2.Text.Length < 13)
            {
                _errors.Add("Вы ввели неправильное IDNP!");

                bunifuMaterialTextbox2.Focus();
                bunifuMaterialTextbox2.Enabled = true;
              
                errors++;

            }

            if (bunifuMaterialTextbox3.Text == "")
            {
                _errors.Add("Вы не ввели адрес пациента!");
                bunifuMaterialTextbox3.Focus();
        
                errors++;

            }

            if (bunifuMaterialTextbox4.Text.Length < 15)
            {
                _errors.Add("Вы ввели неверный номер страховки!");
                bunifuMaterialTextbox4.Focus();
               errors++;
                bunifuMaterialTextbox4.Enabled = true;
            }

            if (bunifuMaterialTextbox5.Text == "")
            {
                _errors.Add("Вы ввели неверный номер участка!");
                bunifuMaterialTextbox5.Focus();
                bunifuMaterialTextbox5.Enabled = true;
               
                errors++;
            }


            if (!_errors.Any())
            {
                if (errors == 0)
                {

                    int gender;
                    if (radioButton1.Checked)
                        gender = 0;
                    else
                        gender = 1;

                    SqlCommand command = new SqlCommand("SELECT MAX(Cod_Pacient) FROM Pacient", connection);

                    codPatient = 0;
                    codPatient = Convert.ToInt32(command.ExecuteScalar());
                    codPatient++;

                    command = new SqlCommand("INSERT INTO Pacient(Cod_Pacient, FIO_Pacient, IDNP, Adress, Strahovka, Nr_Uchastka, age, gender) VALUES(@codPatient, @fio, @idnp, @adress, @strahovka, @nr_uchastka, @age, @gender)", connection);
                    command.Parameters.AddWithValue("codPatient", codPatient);
                    command.Parameters.AddWithValue("fio", bunifuMaterialTextbox1.Text);
                    command.Parameters.AddWithValue("idnp", bunifuMaterialTextbox2.Text);
                    command.Parameters.AddWithValue("adress", bunifuMaterialTextbox3.Text);
                    command.Parameters.AddWithValue("strahovka", bunifuMaterialTextbox4.Text);
                    command.Parameters.AddWithValue("nr_uchastka", bunifuMaterialTextbox5.Text);
                    command.Parameters.AddWithValue("age", DateTime.Now.Year - dateTimePicker1.Value.Year);
                    command.Parameters.AddWithValue("gender", gender);
                    command.ExecuteNonQuery();
                    label11.ForeColor = Color.Lime;
                    label11.Text = "Вы успешно внесли данные!";
                    bunifuMaterialTextbox1.Text = "";
                    bunifuMaterialTextbox2.Text = "";
                    bunifuMaterialTextbox3.Text = "";
                    bunifuMaterialTextbox4.Text = "";
                    bunifuMaterialTextbox5.Text = "";
                    bunifuMaterialTextbox3.Visible = false;
                    bunifuMaterialTextbox2.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    bunifuMaterialTextbox4.Visible = false;
                    bunifuMaterialTextbox5.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    dateTimePicker1.Visible = false;
                    label11.Visible = true;
                    button4.Enabled = false;
                    bunifuMaterialTextbox2.Enabled = true;
                    bunifuMaterialTextbox4.Enabled = true;
                    bunifuMaterialTextbox5.Enabled = true;
                }

            }
            else
            {
                label11.Visible = true;
                label11.ForeColor = Color.Red;
                label11.Text = _errors.First();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuMaterialTextbox1_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.BackColor = Color.FromArgb(79, 118, 208);
            label11.Visible = false;
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = "";
        }

        private void bunifuMaterialTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            bunifuMaterialTextbox2.Visible = true;
            label2.Visible = true;
        }

        private void bunifuMaterialTextbox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void bunifuMaterialTextbox1_MouseDown(object sender, MouseEventArgs e)
        {
            bunifuMaterialTextbox1.BackColor = Color.FromArgb(79, 118, 208);
            bunifuMaterialTextbox1.ForeColor = Color.Black;
        }

        private void bunifuMaterialTextbox2_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.BackColor = Color.FromArgb(79, 118, 208);
            label11.Visible = false;
        }

        private void bunifuMaterialTextbox2_KeyDown(object sender, KeyEventArgs e)
        {
            bunifuMaterialTextbox3.Visible = true;
            label3.Visible = true;
        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void bunifuMaterialTextbox3_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox3.BackColor = Color.FromArgb(79, 118, 208);
            label11.Visible = false;
        }

        private void bunifuMaterialTextbox3_KeyDown(object sender, KeyEventArgs e)
        {
            bunifuMaterialTextbox4.Visible = true;
            label4.Visible = true;
        }

        private void bunifuMaterialTextbox4_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox4.BackColor = Color.FromArgb(79, 118, 208);
            label11.Visible = false;
        }

        private void bunifuMaterialTextbox4_KeyDown(object sender, KeyEventArgs e)
        {
            bunifuMaterialTextbox5.Visible = true;
            label5.Visible = true;
        }

        private void bunifuMaterialTextbox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void bunifuMaterialTextbox5_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox5.BackColor = Color.FromArgb(79, 118, 208);
            label11.Visible = false;
        }

        private void bunifuMaterialTextbox5_KeyDown(object sender, KeyEventArgs e)
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            label6.Visible = true;
            dateTimePicker1.Visible = true;
            label7.Visible = true;
        }

        private void bunifuMaterialTextbox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text.Length > 12) bunifuMaterialTextbox2.Enabled = false;
        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox4.Text.Length > 14) bunifuMaterialTextbox4.Enabled = false;
        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox5.Text.Length > 3) bunifuMaterialTextbox5.Enabled = false;
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_Enter(object sender, EventArgs e)
        {
            bunifuMaterialTextbox3.Text = "";
        }
    }
    }
 

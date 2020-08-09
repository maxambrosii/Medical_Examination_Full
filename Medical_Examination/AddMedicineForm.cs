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
    public partial class AddMedicineForm : Form
    {
        int codMedicine;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\Medical_Examination\Medical_Examination\Dispanserizatsia.mdf;Integrated Security=True;Connect Timeout=30");
        List<string> _errors = new List<string>();


        public AddMedicineForm()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void AddMedicineForm_Load(object sender, EventArgs e)
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            comboBox2.Visible = true;
            label4.Visible = true;
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            button2.Enabled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            button2.Enabled = true;

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            label4.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            label4.Visible = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            label3.Visible = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
        
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            comboBox3.BackColor = Color.White;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.White;
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            comboBox2.BackColor = Color.White;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           textBox2.Enabled = true;
          
            _errors.Clear();
            int error = 0;
            if (textBox1.Text == "")
            {
                _errors.Add("Вы не ввели название лекарства!");
                error++;
                textBox1.BackColor = Color.Red;
            }

            if (textBox2.Text != "")
            {

                if (Convert.ToInt32(textBox2.Text) > 30000)
                {
                    _errors.Add("Дозировка слишком большая!");
                    error++;
                    textBox2.BackColor = Color.Red;
                }
            }

            if (textBox2.Text == "")
            {
                _errors.Add("Вы не ввели дозировку!");
                error++;
                textBox2.BackColor = Color.Red;

            }
            if (comboBox1.Text == "")
            {
                _errors.Add("Вы не выбрали тип упаковки!");
                error++;
                comboBox1.BackColor = Color.Red;

            }
            if (comboBox2.Text == "")
            {
                _errors.Add("Вы не выбрали группу лекарства!");
                error++;
                comboBox2.BackColor = Color.Red;

            }
            if (comboBox3.Text == "")
            {
                _errors.Add("Вы не выбрали ед. измерения дозировки!");
                error++;
                comboBox3.BackColor = Color.Red;
            }

            if (!_errors.Any())
            {
                if (error == 0)
                {
                    SqlCommand command = new SqlCommand("SELECT MAX(Cod_Lekarstva) FROM Lekarstvo", connection);

                    codMedicine = 0;
                    codMedicine = Convert.ToInt32(command.ExecuteScalar());
                    codMedicine++;

                    command = new SqlCommand("INSERT INTO Lekarstvo(Cod_Lekarstva, Name_Lekarstva, Dozirovka, Type_Upakovka, Gruppa) VALUES(@cod, @nameLek, @Doza, @type, @grupa)", connection);
                    command.Parameters.AddWithValue("cod", codMedicine);
                    command.Parameters.AddWithValue("nameLek", textBox1.Text);
                    command.Parameters.AddWithValue("Doza", textBox2.Text);
                    command.Parameters.AddWithValue("type", comboBox1.Text);
                    command.Parameters.AddWithValue("grupa", comboBox2.Text);

                    command.ExecuteNonQuery();

                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    comboBox3.Text = "";

                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    textBox2.Visible = false;

                    label11.Text = "Вы успешно внести данные!";
                    label11.ForeColor = Color.Lime;
                    label11.Visible = true;

                    button2.Enabled = false;
                    textBox2.BackColor = Color.FromArgb(79, 118, 208);
                    textBox2.Enabled = true;
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

        private void bunifuMaterialTextbox1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox2_Click(object sender, EventArgs e)
        {
        
        }

        private void bunifuMaterialTextbox2_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            label2.Visible = true;
            textBox2.Visible = true;
            comboBox3.Visible = true;
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 6) textBox2.Enabled = false;
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyDown_1(object sender, KeyEventArgs e)
        {
            label3.Visible = true;
            comboBox1.Visible = true;
        }

        private void textBox2_Click_1(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }
    }
}

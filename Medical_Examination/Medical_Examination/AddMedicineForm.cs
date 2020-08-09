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

     
        private void comboBoxTypePackage_KeyDown(object sender, KeyEventArgs e)
        {
            comboBoxGruppa.Visible = true;
            lblGruppa.Visible = true;
        }

        private void comboBoxTypeDoz_Click(object sender, EventArgs e)
        {
            comboBoxTypeDoz.BackColor = Color.FromArgb(23, 64, 96);
        }

        private void comboBoxGruppa_KeyDown(object sender, KeyEventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void textBoxNumberDoz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
           
        }

        private void comboBoxGruppa_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void comboBoxTypePackage_TextChanged(object sender, EventArgs e)
        {
            comboBoxGruppa.Visible = true;
            lblGruppa.Visible = true;
        }

        private void comboBoxTypePackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxGruppa.Visible = true;
            lblGruppa.Visible = true;
        }

        private void comboBoxTypeDoz_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTypePackage.Visible = true;
            lblType_Package.Visible = true;
        }

        private void comboBoxGruppa_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void comboBoxTypePackage_Click(object sender, EventArgs e)
        {
            comboBoxTypePackage.BackColor = Color.FromArgb(23, 64, 96);
        }

        private void comboBoxGruppa_Click(object sender, EventArgs e)
        {
            comboBoxGruppa.BackColor = Color.FromArgb(23, 64, 96);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textBoxNumberDoz.Enabled = true;

            _errors.Clear();
            int error = 0;
            if (textBoxName.Text == "")
            {
                _errors.Add("Вы не ввели название лекарства!");
                error++;
                textBoxName.BackColor = Color.Red;
            }

            if (textBoxNumberDoz.Text != "")
            {

                if (Convert.ToInt32(textBoxNumberDoz.Text) > 30000)
                {
                    _errors.Add("Дозировка слишком большая!");
                    error++;
                    textBoxNumberDoz.BackColor = Color.Red;
                }
            }

            if (textBoxNumberDoz.Text == "")
            {
                _errors.Add("Вы не ввели дозировку!");
                error++;
                textBoxNumberDoz.BackColor = Color.Red;

            }
            if (comboBoxTypePackage.Text == "")
            {
                _errors.Add("Вы не выбрали тип упаковки!");
                error++;
                comboBoxTypePackage.BackColor = Color.Red;

            }
            if (comboBoxGruppa.Text == "")
            {
                _errors.Add("Вы не выбрали группу лекарства!");
                error++;
                comboBoxGruppa.BackColor = Color.Red;

            }
            if (comboBoxTypeDoz.Text == "")
            {
                _errors.Add("Вы не выбрали ед. измерения дозировки!");
                error++;
                comboBoxTypeDoz.BackColor = Color.Red;
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
                    command.Parameters.AddWithValue("nameLek", textBoxName.Text);
                    command.Parameters.AddWithValue("Doza", textBoxNumberDoz.Text);
                    command.Parameters.AddWithValue("type", comboBoxTypePackage.Text);
                    command.Parameters.AddWithValue("grupa", comboBoxGruppa.Text);

                    command.ExecuteNonQuery();

                    textBoxName.Text = "";
                    textBoxNumberDoz.Text = "";
                    comboBoxTypePackage.Text = "";
                    comboBoxGruppa.Text = "";
                    comboBoxTypeDoz.Text = "";

                    comboBoxTypePackage.Visible = false;
                    comboBoxGruppa.Visible = false;
                    comboBoxTypeDoz.Visible = false;
                    lblDozirovka.Visible = false;
                    lblType_Package.Visible = false;
                    lblGruppa.Visible = false;
                    textBoxNumberDoz.Visible = false;

                    lblSuccesfullAdded.Text = "Вы успешно внести данные!";
                    lblSuccesfullAdded.ForeColor = Color.Lime;
                    lblSuccesfullAdded.Visible = true;

                    btnAdd.Enabled = false;
                    textBoxNumberDoz.BackColor = Color.FromArgb(23, 64, 96);
                    textBoxNumberDoz.Enabled = true;
                }
            }
            else
            {
                lblSuccesfullAdded.Visible = true;
                lblSuccesfullAdded.ForeColor = Color.Red;
                lblSuccesfullAdded.Text = _errors.First();
            }
        }

        private void textBoxName_Click(object sender, EventArgs e)
        {
            textBoxName.BackColor = Color.FromArgb(23, 64, 96);
        }

        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            lblDozirovka.Visible = true;
            textBoxNumberDoz.Visible = true;
            comboBoxTypeDoz.Visible = true;
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumberDoz_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNumberDoz.Text.Length > 6) textBoxNumberDoz.Enabled = false;
        }

        private void textBoxNumberDoz_KeyDown(object sender, KeyEventArgs e)
        {
            lblType_Package.Visible = true;
            comboBoxTypePackage.Visible = true;
        }

        private void textBoxNumberDoz_Click(object sender, EventArgs e)
        {
            textBoxNumberDoz.BackColor = Color.FromArgb(23, 64, 96);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

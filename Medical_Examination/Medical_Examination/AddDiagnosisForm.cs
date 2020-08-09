using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Examination
{

    public partial class AddDiagnosisForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\Medical_Examination\Medical_Examination\Dispanserizatsia.mdf;Integrated Security=True;Connect Timeout=30");
        int codDiagnosis;
        List<string> _errors = new List<string>();
        public AddDiagnosisForm()
        {
            InitializeComponent();

        }

      

        private void AddDiagnosisForm_Load(object sender, EventArgs e)
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

        private void AddDiagnosisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

    

        private void bunifuMaterialTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            buttonAdd.Enabled = true;
        }

     
     

        private void TextboxDiagnoz_Click(object sender, EventArgs e)
        {
            TextboxDiagnoz.BackColor = Color.FromArgb(23, 64, 96);
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {


            _errors.Clear();
            int errors = 0;

            if (TextboxDiagnoz.Text == "")
            {
                _errors.Add("Вы не ввели диагноз!");
                errors++;
                TextboxDiagnoz.BackColor = Color.Red;

            }

            if (!_errors.Any())
            {
                if (errors == 0)
                {
                    SqlCommand command = new SqlCommand("SELECT MAX(Cod_Diagnoz) FROM DocDiagnoz", connection);

                    codDiagnosis = 0;
                    codDiagnosis = Convert.ToInt32(command.ExecuteScalar());
                    codDiagnosis++;

                    command = new SqlCommand("INSERT INTO DocDiagnoz(Cod_Diagnoz, Diagnoz) VALUES(@Cod, @Diagnoz)", connection);
                    command.Parameters.AddWithValue("Cod", codDiagnosis);
                    command.Parameters.AddWithValue("Diagnoz", TextboxDiagnoz.Text);

                    command.ExecuteNonQuery();
                    TextboxDiagnoz.Text = "";
                    lblInfo.Text = "Вы успешно внести данные!";

                    lblInfo.ForeColor = Color.Lime;
                    Transition.Show(lblInfo);
                    buttonAdd.Enabled = false;
                    TextboxDiagnoz.BackColor = Color.FromArgb(23, 64, 96);
                }


            }
            else
            {
                lblInfo.Visible = true;
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = _errors.First();
            }
        }
    }
}
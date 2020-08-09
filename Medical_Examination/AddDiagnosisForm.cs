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

            bunifuTransition1.Show(label10);
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

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

      
    

        private void bunifuMaterialTextbox1_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.BackColor = Color.FromArgb(79, 118, 208);
        }

        private void bunifuMaterialTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            _errors.Clear();
            int errors = 0;

            if (bunifuMaterialTextbox1.Text == "")
            {
                _errors.Add("Вы не ввели диагноз!");
                errors++;
                bunifuMaterialTextbox1.BackColor = Color.Red;

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
                    command.Parameters.AddWithValue("Diagnoz", bunifuMaterialTextbox1.Text);

                    command.ExecuteNonQuery();
                    bunifuMaterialTextbox1.Text = "";
                    label11.Text = "Вы успешно внести данные!";

                    label11.ForeColor = Color.Lime;
                    bunifuTransition1.Show(label11);
                    button1.Enabled = false;
                    bunifuMaterialTextbox1.BackColor = Color.FromArgb(79, 118, 208);
                }


            }
            else
            {
                label11.Visible = true;
                label11.ForeColor = Color.Red;
                label11.Text = _errors.First();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
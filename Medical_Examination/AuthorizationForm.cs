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
using System.IO;

namespace Medical_Examination
{
    public partial class AuthorizationForm : Form
    {
        public SqlConnection connection = null;
        public static Color bgcolor, textcolor;
        public static Image bgimage;
        public static string pathSqlConnection;
        private int error_login = 0, lvlacces = 0;
        string passwordAccount;
        private bool isCorrect = false;

        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;

        public AuthorizationForm()
        {
            InitializeComponent();
            this.ActiveControl = bunifuMaterialTextbox1;
          

            bgcolor = Color.FromArgb(45, 45, 45);
            textcolor = Color.FromArgb(255, 255, 255);

            var path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString();
            path = path.Remove(path.Length - 10, 10);
            AuthorizationForm.pathSqlConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + path + @"\Dispanserizatsia.mdf; Integrated Security = True; Connect Timeout = 30";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }


        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();
           
            bunifuTransition1.Show(pictureBox2);
           
            bunifuTransition2.Show(pictureBox1);
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void buttonLoginGroup_Click(object sender, EventArgs e)
        {
     
            SignIn();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            AuthorizationForm.ActiveForm.Close();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
           
            if (bunifuMaterialTextbox1.Text == "" || bunifuMaterialTextbox2.Text == "")
            {
                button1.Enabled = false;
            }
            else button1.Enabled = true;

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged_1(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;

            if (bunifuMaterialTextbox1.Text == "" || bunifuMaterialTextbox2.Text == "")
            {
                button1.Enabled = false;
            }
            else button1.Enabled = true;
        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                SignIn();
        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                SignIn();
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void SignIn()
        {
            int numLogins = 0;
            sqlCommand = new SqlCommand("Select COUNT(*) From Accounts where loginAccount = @loginAccount", sqlConnection);
            sqlCommand.Parameters.AddWithValue("loginAccount", bunifuMaterialTextbox1.Text);
            numLogins = (int)sqlCommand.ExecuteScalar();
            if (numLogins > 0)
            {
                sqlCommand = new SqlCommand("Select passwordAccount, lvlAccept From Accounts where loginAccount = @loginAccount", sqlConnection);
                sqlCommand.Parameters.AddWithValue("loginAccount", bunifuMaterialTextbox1.Text);
                sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();
                passwordAccount = sqlDataReader.GetString(0);
                lvlacces = sqlDataReader.GetInt16(1);
                sqlDataReader.Close();
            }
            else
                isCorrect = false;

            if (bunifuMaterialTextbox2.Text == passwordAccount)
                isCorrect = true;
            else
                isCorrect = false;
            if (isCorrect == true)
            {
                /*
                this.Hide();
                GeneralForm gform = new GeneralForm(lvlacces);
                gform.ShowDialog();
                gform = null;
                this.Show();
                */
                this.Hide();
                var generalform = new GeneralForm(lvlacces);
                generalform.Closed += (s, args) => this.Close();
                generalform.Show();
                label3.Text = "";
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox2.Text = "";
                isCorrect = false;
                this.BackColor = AuthorizationForm.bgcolor;
            }
            else
            {
                bunifuMaterialTextbox1.Text="";
                bunifuMaterialTextbox2.Text="";
                label3.Text = "Неправильный логин или пароль";
                error_login++;
            }
            if (error_login == 3)
                Application.Exit();
            this.ActiveControl = bunifuMaterialTextbox1;
        }
    }
}

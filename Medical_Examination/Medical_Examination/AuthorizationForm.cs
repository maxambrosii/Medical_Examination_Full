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
            this.ActiveControl = Textbox_Login;
          

            bgcolor = Color.FromArgb(23, 64, 96);
            textcolor = Color.FromArgb(255, 255, 255);

            var path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString();
            path = path.Remove(path.Length - 10, 10);
            AuthorizationForm.pathSqlConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + path + @"\Dispanserizatsia.mdf; Integrated Security = True; Connect Timeout = 30";
        }
  
        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();
           
            bunifuTransition1.Show(pictureBox_Line);
           
            bunifuTransition2.Show(pictureBox_Image);
            
            
        }

        private void buttonLoginGroup_Click(object sender, EventArgs e)
        {
     
            SignIn();
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }

        private void Textbox_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                SignIn();
        }

        private void Textbox_Login_OnValueChanged(object sender, EventArgs e)
        {
            if (Textbox_Login.Text == "" || Textbox_Password.Text == "")
            {
                button_Authorization.Enabled = false;
            }
            else button_Authorization.Enabled = true;

        }

        private void Textbox_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                SignIn();
        }

        private void Textbox_Password_OnValueChanged(object sender, EventArgs e)
        {
            Textbox_Password.isPassword = true;

            if (Textbox_Login.Text == "" || Textbox_Password.Text == "")
            {
                button_Authorization.Enabled = false;
            }
            else button_Authorization.Enabled = true;
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {

            Application.Exit();
            AuthorizationForm.ActiveForm.Close();
        }

        private void SignIn()
        {
            int numLogins = 0;
            sqlCommand = new SqlCommand("Select COUNT(*) From Accounts where loginAccount = @loginAccount", sqlConnection);
            sqlCommand.Parameters.AddWithValue("loginAccount", Textbox_Login.Text);
            numLogins = (int)sqlCommand.ExecuteScalar();
            if (numLogins > 0)
            {
                sqlCommand = new SqlCommand("Select passwordAccount, lvlAccept From Accounts where loginAccount = @loginAccount", sqlConnection);
                sqlCommand.Parameters.AddWithValue("loginAccount", Textbox_Login.Text);
                sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();
                passwordAccount = sqlDataReader.GetString(0);
                lvlacces = sqlDataReader.GetInt16(1);
                sqlDataReader.Close();
            }
            else
                isCorrect = false;

            if (Textbox_Password.Text == passwordAccount)
                isCorrect = true;
            else
                isCorrect = false;
            if (isCorrect == true)
            {
               
                this.Hide();
                var generalform = new GeneralForm(lvlacces);
                generalform.Closed += (s, args) => this.Close();
                generalform.Show();
                label3.Text = "";
                Textbox_Login.Text = "";
                Textbox_Password.Text = "";
                isCorrect = false;
                this.BackColor = AuthorizationForm.bgcolor;
            }
            else
            {
                Textbox_Login.Text="";
                Textbox_Password.Text="";
                label3.Text = "Неправильный логин или пароль";
                error_login++;
            }
            if (error_login == 3)
                Application.Exit();
            this.ActiveControl = Textbox_Login;
        }
    }
}

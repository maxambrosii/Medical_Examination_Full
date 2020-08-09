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
    public partial class AddRecipeForm : Form
    {

        struct ListIntAndString
        {
            public int cod { get; set; }
            public string str { get; set; }
        }
        List<string> _errors = new List<string>();
        List<ListIntAndString> _Medicine = new List<ListIntAndString>();
        ListIntAndString medicine = new ListIntAndString();
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        int codRecipe, codReception;
        bool isWriteRecipe;

        public AddRecipeForm(int codReceptionConstructor, bool isWriteRecipeConstruct)
        {
            InitializeComponent();
            lblTitle.Text += codReceptionConstructor.ToString();
            codReception = codReceptionConstructor;
            listBox_Medicaments.Text = "";
            isWriteRecipe = isWriteRecipeConstruct;
        }

        private void AddRecipeForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();

            //Код рецепта
            SqlCommand command = new SqlCommand("SELECT MAX(Nr_Retsepta) FROM Retsept", sqlConnection);
            codRecipe = Convert.ToInt32(command.ExecuteScalar());

            //Проверка на перезапись рецепта
            if (isWriteRecipe == true) // Удаление
            {
                sqlCommand = new SqlCommand("Delete from Retsept where Cod_Priema = @codReception", sqlConnection);
                sqlCommand.Parameters.AddWithValue("codReception", codReception);
                sqlCommand.ExecuteNonQuery();

                sqlCommand = new SqlCommand("Delete from Lechenie where Nr_Retsepta = @nrRecipe", sqlConnection);
                sqlCommand.Parameters.AddWithValue("nrRecipe", codRecipe);
                sqlCommand.ExecuteNonQuery();
            }
            else
            {
                codRecipe++;
            }

            sqlCommand = new SqlCommand("Select Cod_Lekarstva, Name_Lekarstva From Lekarstvo", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                medicine.cod = sqlDataReader.GetInt16(0);
                medicine.str = sqlDataReader.GetString(1);
                _Medicine.Add(medicine);
                comboBox_Medicament.Items.Add(medicine.str);
            }
            sqlDataReader.Close();
        }

        private void AddRecipeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (listBox_Medicaments.Items.Count != 0)
            {

                sqlCommand = new SqlCommand("INSERT INTO Retsept(Nr_Retsepta, Cod_Priema) VALUES(@nrRecipe, @codReception)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("nrRecipe", codRecipe);
                sqlCommand.Parameters.AddWithValue("codReception", codReception);
                sqlCommand.ExecuteNonQuery();

                for (int i = 0; i < listBox_Medicaments.Items.Count; i++)
                {
                    medicine = _Medicine.Find(_Medicine => _Medicine.str == listBox_Medicaments.Items[i].ToString());
                    sqlCommand = new SqlCommand("INSERT INTO Lechenie(Cod_Lekarstva, Nr_Retsepta) VALUES(@codMedicine, @nrRecipe)", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("codMedicine", medicine.cod);
                    sqlCommand.Parameters.AddWithValue("nrRecipe", codRecipe);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            Close();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            listBox_Medicaments.Items.Clear();
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_Medicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_Save.Enabled = true;
            if (listBox_Medicaments.FindString(comboBox_Medicament.Text) == -1)
                listBox_Medicaments.Items.Add(comboBox_Medicament.Text);
        }
    }
}

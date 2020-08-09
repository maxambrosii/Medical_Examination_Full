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
    public partial class report : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            reportViewerRecipe.Visible = false;
            reportViewerDiagnoz.Visible = false;
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();
            sqlCommand = new SqlCommand("Select dbo.Pacient.FIO_Pacient From dbo.Pacient", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();

           
            while (sqlDataReader.Read())
            {
                comboBox_Patient.Items.Add(sqlDataReader.GetString(0));
                comboBoxPatientt.Items.Add(sqlDataReader.GetString(0));

            }
            sqlDataReader.Close();

            // TODO: данная строка кода позволяет загрузить данные в таблицу "DispanserizatsiaDataSetRECIPEREPORT.REPORT_RECIPE". При необходимости она может быть перемещена или удалена.
            this.REPORT_RECIPETableAdapter.Fill(this.DispanserizatsiaDataSetRECIPEREPORT.REPORT_RECIPE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DispanserizatsiaDataSet1.GetPatientsAgeReport". При необходимости она может быть перемещена или удалена.
            this.GetPatientsAgeReportTableAdapter.Fill(this.DispanserizatsiaDataSet1.GetPatientsAgeReport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DispanserizatsiaDataSet.Priem". При необходимости она может быть перемещена или удалена.
            this.PriemTableAdapter.Fill(this.DispanserizatsiaDataSet.Priem);

            this.reportViewer_Age.RefreshReport();
            this.reportViewerRecipe.RefreshReport();
            this.reportViewerDiagnoz.RefreshReport();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxExitt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_exit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void comboBoxPatientt_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxDate.Items.Clear();
            labelDate.Visible = true;
            comboBoxDate.Visible = true;
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();
            sqlCommand = new SqlCommand("Select Distinct Data_Priema From REPORT_DIAGNOZ WHERE FIO_Pacient = '" + comboBoxPatientt.Text + "'", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();


            while (sqlDataReader.Read())
            {
                comboBoxDate.Items.Add(sqlDataReader.GetDateTime(0));

            }
            sqlDataReader.Close();


            try
            {
                this.REPORT_DIAGNOZTableAdapter.FillBy(this.DispanserizatsiaDataSetREPORT_DIAGNOZ.REPORT_DIAGNOZ, comboBoxPatientt.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.reportViewerDiagnoz.RefreshReport();
        }

        private void comboBoxDate_SelectedValueChanged(object sender, EventArgs e)
        {
            reportViewerDiagnoz.Visible = true;


            this.reportViewerDiagnoz.RefreshReport();
            try
            {
                this.REPORT_DIAGNOZTableAdapter.FillBy2(this.DispanserizatsiaDataSetREPORT_DIAGNOZ.REPORT_DIAGNOZ, comboBoxPatientt.Text, comboBoxDate.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.reportViewerDiagnoz.RefreshReport();
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_Patient_SelectedValueChanged(object sender, EventArgs e)
        {
            reportViewerRecipe.Visible = true;
            try
            {
                this.REPORT_RECIPETableAdapter.FillBy(this.DispanserizatsiaDataSetRECIPEREPORT.REPORT_RECIPE, comboBox_Patient.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.reportViewer_Age.RefreshReport();
            this.reportViewerRecipe.RefreshReport();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackImg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelBack_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void reportViewer_Age_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

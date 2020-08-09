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
            reportViewer2.Visible = false;
            reportViewer3.Visible = false;
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();
            sqlCommand = new SqlCommand("Select dbo.Pacient.FIO_Pacient From dbo.Pacient", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();

           
            while (sqlDataReader.Read())
            {
                comboBox1.Items.Add(sqlDataReader.GetString(0));
                comboBox2.Items.Add(sqlDataReader.GetString(0));

            }
            sqlDataReader.Close();

            // TODO: данная строка кода позволяет загрузить данные в таблицу "DispanserizatsiaDataSetRECIPEREPORT.REPORT_RECIPE". При необходимости она может быть перемещена или удалена.
            this.REPORT_RECIPETableAdapter.Fill(this.DispanserizatsiaDataSetRECIPEREPORT.REPORT_RECIPE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DispanserizatsiaDataSet1.GetPatientsAgeReport". При необходимости она может быть перемещена или удалена.
            this.GetPatientsAgeReportTableAdapter.Fill(this.DispanserizatsiaDataSet1.GetPatientsAgeReport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DispanserizatsiaDataSet.Priem". При необходимости она может быть перемещена или удалена.
            this.PriemTableAdapter.Fill(this.DispanserizatsiaDataSet.Priem);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            reportViewer2.Visible = true;
            try
            {
                this.REPORT_RECIPETableAdapter.FillBy(this.DispanserizatsiaDataSetRECIPEREPORT.REPORT_RECIPE, comboBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            label1.Visible = true;
            comboBox3.Visible = true;
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();
            sqlCommand = new SqlCommand("Select Distinct Data_Priema From REPORT_DIAGNOZ WHERE FIO_Pacient = '"+comboBox2.Text+"'", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();


            while (sqlDataReader.Read())
            {
                comboBox3.Items.Add(sqlDataReader.GetDateTime(0));

            }
            sqlDataReader.Close();


            try
            {
                this.REPORT_DIAGNOZTableAdapter.FillBy(this.DispanserizatsiaDataSetREPORT_DIAGNOZ.REPORT_DIAGNOZ, comboBox2.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.reportViewer3.RefreshReport();
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            reportViewer3.Visible = true;


            this.reportViewer3.RefreshReport();
            try
            {
                this.REPORT_DIAGNOZTableAdapter.FillBy2(this.DispanserizatsiaDataSetREPORT_DIAGNOZ.REPORT_DIAGNOZ, comboBox2.Text, comboBox3.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.reportViewer3.RefreshReport();
        }


        private void reportViewer3_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

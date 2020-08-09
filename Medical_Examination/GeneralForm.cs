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
    public partial class GeneralForm : Form
    {

        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        bool panelOpen = true;
        bool panelOpenHelp = true;
        bool panelOpenPrefer = true;
        bool panelOpenView = true;
        bool panelOpenView1 = true;
        bool panelOpenRedact = true;
        bool panelOpenAdd = true;
        bool panelOpenUpdate = true;
        bool panelOpenDelete = true;
        bool OpenFull = false;
        public GeneralForm(int lvlaccept)
        { 
            InitializeComponent();
           
            //EditThemeToolStripMenuItem.Enabled = false;
            // lvlaccept; 1 - admin, 2 - moderator, 3 - user; 
            if (lvlaccept == 2)
            {
                // EditToolStripMenuItem.Enabled = false;
                label1.Enabled = false;
                pictureBox2.Enabled = false;
                label2.Enabled = false;
                pictureBox3.Enabled = false;

            //EditToolStripMenuItem.Visible = false;
             //   BackupToolStripMenuItem.Enabled = false;
            }
            
          
        }
       

        private void GeneralForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
            sqlConnection.Open();
        }

        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panelOpenDelete == false)
            {
                
                bunifuTransition1.Hide(panelDELETE);
                panelOpenDelete = true;
            }
            if (panelOpenUpdate == false)
            {
             

                bunifuTransition1.Hide(panelUPDATE);
                panelOpenUpdate = true;
            }
            if (panelOpenAdd == false)
            {
                bunifuTransition1.Hide(panelADD);
                panelOpenAdd = true;
            }

            if (panelOpenRedact == false)
            {
                bunifuTransition1.Hide(panelREDACT);
                panelOpenRedact = true;
            }


            if (panelOpenView1 == false)
            {
                bunifuTransition1.Hide(panelView1);
                panelOpenView1 = true;
            }
            if (panelOpenView == false)
            {
                bunifuTransition1.Hide(panelView);
                panelOpenView = true;
            }


            if (panelOpenPrefer == false)
            {
                bunifuTransition1.Hide(panelProperties);
                panelOpenPrefer = true;
            }

            if (panelOpenHelp == false)
            {
                bunifuTransition1.Hide(panelHelp);
                panelOpenHelp = true;
            }

            if (panelOpen == false)
            {    
              pictureBox1.Image = Properties.Resources.rotateMenu;
              bunifuTransition1.Show(panel1);
                panelOpen = true;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.menu_icon_5;
                bunifuTransition1.Hide(panel1);
                panelOpen = false;
            }
           
        }

        private void ViewDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            AuthorizationForm.ActiveForm.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (panelOpenDelete == false)
            {

                bunifuTransition1.Hide(panelDELETE);
                panelOpenDelete = true;
            }
            if (panelOpenUpdate == false)
            {


                bunifuTransition1.Hide(panelUPDATE);
                panelOpenUpdate = true;
            }
            if (panelOpenAdd == false)
            {
                bunifuTransition1.Hide(panelADD);
                panelOpenAdd = true;
            }
            if (panelOpenRedact == false)
            {
                bunifuTransition1.Hide(panelREDACT);
                panelOpenRedact = true;
            }


            if (panelOpenView1 == false)
            {
                bunifuTransition1.Hide(panelView1);
                panelOpenView1 = true;
            }
            if (panelOpenView == false)
            {
                bunifuTransition1.Hide(panelView);
                panelOpenView = true;
            }


            if (panelOpenPrefer == false)
            {
                bunifuTransition1.Hide(panelProperties);
                panelOpenPrefer = true;
            }

            if (panelOpenHelp == false)
            {
                bunifuTransition1.Hide(panelHelp);
                panelOpenHelp = true;
            }
            if (panelOpenRedact == true)
            {
                bunifuTransition1.Show(panelREDACT);
                panelOpenRedact = false;
            }
            else
            {

                bunifuTransition1.Hide(panelREDACT);
                panelOpenRedact = true;
            }
            }

        private void label19_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeletePatientForm deletepatientform = new DeletePatientForm();
            deletepatientform.ShowDialog();
            deletepatientform = null;
            this.Show();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeletePatientForm deletepatientform = new DeletePatientForm();
            deletepatientform.ShowDialog();
            deletepatientform = null;
            this.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteDoctorForm deletedoctorform = new DeleteDoctorForm();
            deletedoctorform.ShowDialog();
            deletedoctorform = null;
            this.Show();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteDoctorForm deletedoctorform = new DeleteDoctorForm();
            deletedoctorform.ShowDialog();
            deletedoctorform = null;
            this.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdatePatientForm pacientform = new UpdatePatientForm();
            pacientform.ShowDialog();
            pacientform = null;
            this.Show();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdatePatientForm pacientform = new UpdatePatientForm();
            pacientform.ShowDialog();
            pacientform = null;
            this.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateDoctorForm doctorform = new UpdateDoctorForm();
            doctorform.ShowDialog();
            doctorform = null;
            this.Show();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateDoctorForm doctorform = new UpdateDoctorForm();
            doctorform.ShowDialog();
            doctorform = null;
            this.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateReceptionForm receptionform = new UpdateReceptionForm();
            receptionform.ShowDialog();
            receptionform = null;
            this.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateReceptionForm receptionform = new UpdateReceptionForm();
            receptionform.ShowDialog();
            receptionform = null;
            this.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPatientForm pacientform = new AddPatientForm();
            pacientform.ShowDialog();
            pacientform = null;
            this.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPatientForm pacientform = new AddPatientForm();
            pacientform.ShowDialog();
            pacientform = null;
            this.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddDoctorForm doctorform = new AddDoctorForm();
            doctorform.ShowDialog();
            doctorform = null;
            this.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddDoctorForm doctorform = new AddDoctorForm();
            doctorform.ShowDialog();
            doctorform = null;
            this.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMedicineForm medicineform = new AddMedicineForm();
            medicineform.ShowDialog();
            medicineform = null;
            this.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMedicineForm medicineform = new AddMedicineForm();
            medicineform.ShowDialog();
            medicineform = null;
            this.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDiagnosisForm diagnosisform = new AddDiagnosisForm();
            diagnosisform.ShowDialog();
            diagnosisform = null;
            this.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDiagnosisForm diagnosisform = new AddDiagnosisForm();
            diagnosisform.ShowDialog();
            diagnosisform = null;
            this.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddReceptionForm receptionform = new AddReceptionForm();
            receptionform.ShowDialog();
            receptionform = null;
            this.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddReceptionForm receptionform = new AddReceptionForm();
            receptionform.ShowDialog();
            receptionform = null;
            this.Show();
        }

        private void ReferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScanGetDoctorAndCountOfPatientWithUserDiagnosisForm scanGetDoctorAndCountOfPatientWithUserDiagnosisForm = new ScanGetDoctorAndCountOfPatientWithUserDiagnosisForm();
            scanGetDoctorAndCountOfPatientWithUserDiagnosisForm.ShowDialog();
            scanGetDoctorAndCountOfPatientWithUserDiagnosisForm = null;
            this.Show();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScanGetDoctorAndCountOfPatientWithUserDiagnosisForm scanGetDoctorAndCountOfPatientWithUserDiagnosisForm = new ScanGetDoctorAndCountOfPatientWithUserDiagnosisForm();
            scanGetDoctorAndCountOfPatientWithUserDiagnosisForm.ShowDialog();
            scanGetDoctorAndCountOfPatientWithUserDiagnosisForm = null;
            this.Show();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScanGetCountPatientFromEveryDoctorForm scanGetCountPatientFromEveryDoctorForm = new ScanGetCountPatientFromEveryDoctorForm();
            scanGetCountPatientFromEveryDoctorForm.ShowDialog();
            scanGetCountPatientFromEveryDoctorForm = null;
            this.Show();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScanGetCountPatientFromEveryDoctorForm scanGetCountPatientFromEveryDoctorForm = new ScanGetCountPatientFromEveryDoctorForm();
            scanGetCountPatientFromEveryDoctorForm.ShowDialog();
            scanGetCountPatientFromEveryDoctorForm = null;
            this.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScanGetCountPacientByCertainAgeForm scanGetCountPacientByCertainAgeForm = new ScanGetCountPacientByCertainAgeForm();
            scanGetCountPacientByCertainAgeForm.ShowDialog();
            scanGetCountPacientByCertainAgeForm = null;
            this.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScanGetCountPacientByCertainAgeForm scanGetCountPacientByCertainAgeForm = new ScanGetCountPacientByCertainAgeForm();
            scanGetCountPacientByCertainAgeForm.ShowDialog();
            scanGetCountPacientByCertainAgeForm = null;
            this.Show();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScanGetCountPacientByAreaForm scanGetCountPacientByAreaForm = new ScanGetCountPacientByAreaForm();
            scanGetCountPacientByAreaForm.ShowDialog();
            scanGetCountPacientByAreaForm = null;
            this.Show();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScanGetCountPacientByAreaForm scanGetCountPacientByAreaForm = new ScanGetCountPacientByAreaForm();
            scanGetCountPacientByAreaForm.ShowDialog();
            scanGetCountPacientByAreaForm = null;
            this.Show();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Базы данных (*.bak)|*.bak|Все файлы (*.*)|*.*";
            sfd.ShowDialog();
            //string query = String.Format(@"BACKUP DATABASE Dispanserizatsia TO DISK = '{0}'", sfd.FileName);
            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString();
            path = path.Remove(path.Length - 10, 10);
            path += @"\Dispanserizatsia.mdf";
            string query = string.Format(@"BACKUP DATABASE @DBName TO DISK = '{0}'", sfd.FileName);
            sqlCommand = new SqlCommand(query, sqlConnection);
            this.Hide();
            LoaderForm scanGetCountPacientByAreaForm = new LoaderForm();
            scanGetCountPacientByAreaForm.ShowDialog();
            scanGetCountPacientByAreaForm = null;
            this.Show();
            MessageBox.Show(path.ToUpper());
            sqlCommand.Parameters.AddWithValue("DBName", path.ToUpper());
            sqlCommand.ExecuteNonQuery();

            
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Базы данных (*.bak)|*.bak|Все файлы (*.*)|*.*";
            sfd.ShowDialog();
            //string query = String.Format(@"BACKUP DATABASE Dispanserizatsia TO DISK = '{0}'", sfd.FileName);
            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString();
            path = path.Remove(path.Length - 10, 10);
            path += @"\Dispanserizatsia.mdf";
            string query = string.Format(@"BACKUP DATABASE @DBName TO DISK = '{0}'", sfd.FileName);
            sqlCommand = new SqlCommand(query, sqlConnection);
            this.Hide();
            LoaderForm scanGetCountPacientByAreaForm = new LoaderForm();
            scanGetCountPacientByAreaForm.ShowDialog();
            scanGetCountPacientByAreaForm = null;
            this.Show();
            MessageBox.Show(path.ToUpper());
            sqlCommand.Parameters.AddWithValue("DBName", path.ToUpper());
            sqlCommand.ExecuteNonQuery();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupportForm supportForm = new SupportForm();
            supportForm.ShowDialog();
            supportForm = null;
            this.Show();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupportForm supportForm = new SupportForm();
            supportForm.ShowDialog();
            supportForm = null;
            this.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (panelOpenDelete == false)
            {

                bunifuTransition1.Hide(panelDELETE);
                panelOpenDelete = true;
            }
            if (panelOpenUpdate == false)
            {


                bunifuTransition1.Hide(panelUPDATE);
                panelOpenUpdate = true;
            }
            if (panelOpenAdd == false)
            {
                bunifuTransition1.Hide(panelADD);
                panelOpenAdd = true;
            }
            if (panelOpenRedact == false)
            {
                bunifuTransition1.Hide(panelREDACT);
                panelOpenRedact = true;
            }

            if (panelOpenPrefer == false)
            {
                bunifuTransition1.Hide(panelProperties);
                panelOpenPrefer = true;
            }

            if (panelOpenHelp == false)
            {
                bunifuTransition1.Hide(panelHelp);
                panelOpenHelp = true;
            }

            if (panelOpen == false)
            {
                pictureBox1.Image = Properties.Resources.rotateMenu;
                bunifuTransition1.Show(panel1);
                panelOpen = true;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.menu_icon_5;
                bunifuTransition1.Hide(panel1);
                panelOpen = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (panelOpenDelete == false)
            {

                bunifuTransition1.Hide(panelDELETE);
                panelOpenDelete = true;
            }
            if (panelOpenUpdate == false)
            {


                bunifuTransition1.Hide(panelUPDATE);
                panelOpenUpdate = true;
            }
            if (panelOpenAdd == false)
            {
                bunifuTransition1.Hide(panelADD);
                panelOpenAdd = true;
            }
            if (panelOpenRedact == false)
            {
                bunifuTransition1.Hide(panelREDACT);
                panelOpenRedact = true;
            }

            if (panelOpenView1 == false)
            {
                bunifuTransition1.Hide(panelView1);
                panelOpenView1 = true;
            }
            if (panelOpenView == false)
            {
                bunifuTransition1.Hide(panelView);
                panelOpenView = true;
            }
            if (panelOpenPrefer == false)
            {
                bunifuTransition1.Hide(panelProperties);
                panelOpenPrefer = true;
            }

            if (panelOpenHelp == true)
            {
                bunifuTransition1.Show(panelHelp);
                panelOpenHelp = false;
            }
            else
            {
                bunifuTransition1.Hide(panelHelp);
                panelOpenHelp = true;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (panelOpenDelete == false)
            {

                bunifuTransition1.Hide(panelDELETE);
                panelOpenDelete = true;
            }
            if (panelOpenUpdate == false)
            {


                bunifuTransition1.Hide(panelUPDATE);
                panelOpenUpdate = true;
            }
            if (panelOpenAdd == false)
            {
                bunifuTransition1.Hide(panelADD);
                panelOpenAdd = true;
            }
            if (panelOpenRedact == false)
            {
                bunifuTransition1.Hide(panelREDACT);
                panelOpenRedact = true;
            }

            if (panelOpenView1 == false)
            {
                bunifuTransition1.Hide(panelView1);
                panelOpenView1 = true;
            }
            if (panelOpenView == false)
            {
                bunifuTransition1.Hide(panelView);
                panelOpenView = true;
            }
            if (panelOpenPrefer == false)
            {
                bunifuTransition1.Hide(panelProperties);
                panelOpenPrefer = true;
            }

            if (panelOpenHelp == true)
            {
                bunifuTransition1.Show(panelHelp);
                panelOpenHelp = false;
            }
            else
            {
                bunifuTransition1.Hide(panelHelp);
                panelOpenHelp = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (panelOpenDelete == false)
            {

                bunifuTransition1.Hide(panelDELETE);
                panelOpenDelete = true;
            }
            if (panelOpenUpdate == false)
            {


                bunifuTransition1.Hide(panelUPDATE);
                panelOpenUpdate = true;
            }
            if (panelOpenAdd == false)
            {
                bunifuTransition1.Hide(panelADD);
                panelOpenAdd = true;
            }
            if (panelOpenRedact == false)
            {
                bunifuTransition1.Hide(panelREDACT);
                panelOpenRedact = true;
            }

            if (panelOpenView1 == false)
            {
                bunifuTransition1.Hide(panelView1);
                panelOpenView1 = true;
            }
            if (panelOpenView == false)
            {
                bunifuTransition1.Hide(panelView);
                panelOpenView = true;
            }
            if (panelOpenHelp == false)
            {
                bunifuTransition1.Hide(panelHelp);
                panelOpenHelp = true;
            }

            if (panelOpenPrefer == true)
            {
                bunifuTransition1.Show(panelProperties);
                panelOpenPrefer = false;
            }
            else
            {
                bunifuTransition1.Hide(panelProperties);
                panelOpenPrefer = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (panelOpenDelete == false)
            {

                bunifuTransition1.Hide(panelDELETE);
                panelOpenDelete = true;
            }
            if (panelOpenUpdate == false)
            {


                bunifuTransition1.Hide(panelUPDATE);
                panelOpenUpdate = true;
            }
            if (panelOpenAdd == false)
            {
                bunifuTransition1.Hide(panelADD);
                panelOpenAdd = true;
            }
            if (panelOpenRedact == false)
            {
                bunifuTransition1.Hide(panelREDACT);
                panelOpenRedact = true;
            }

            if (panelOpenView1 == false)
            {
                bunifuTransition1.Hide(panelView1);
                panelOpenView1 = true;
            }
            if (panelOpenView == false)
            {
                bunifuTransition1.Hide(panelView);
                panelOpenView = true;
            }
            if (panelOpenHelp == false)
            {
                bunifuTransition1.Hide(panelHelp);
                panelOpenHelp = true;
            }

            if (panelOpenPrefer == true)
            {
                bunifuTransition1.Show(panelProperties);
                panelOpenPrefer = false;
            }
            else
            {
                bunifuTransition1.Hide(panelProperties);
                panelOpenPrefer = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (panelOpenDelete == false)
            {

                bunifuTransition1.Hide(panelDELETE);
                panelOpenDelete = true;
            }
            if (panelOpenUpdate == false)
            {


                bunifuTransition1.Hide(panelUPDATE);
                panelOpenUpdate = true;
            }
            if (panelOpenAdd == false)
            {
                bunifuTransition1.Hide(panelADD);
                panelOpenAdd = true;
            }
            if (panelOpenRedact == false)
            {
                bunifuTransition1.Hide(panelREDACT);
                panelOpenRedact = true;
            }

            if (panelOpenView1 == false)
            {
                bunifuTransition1.Hide(panelView1);
                panelOpenView1 = true;
            }
            if (panelOpenView == false)
            {
                bunifuTransition1.Hide(panelView);
                panelOpenView = true;
            }


            if (panelOpenPrefer == false)
            {
                bunifuTransition1.Hide(panelProperties);
                panelOpenPrefer = true;
            }

            if (panelOpenHelp == false)
            {
                bunifuTransition1.Hide(panelHelp);
                panelOpenHelp = true;
            }
            if (panelOpenView == true)
            {
                bunifuTransition1.Show(panelView);
                panelOpenView = false;
            }
            else
            {
                bunifuTransition1.Hide(panelView);
                panelOpenView = true;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (panelOpenDelete == false)
            {

                bunifuTransition1.Hide(panelDELETE);
                panelOpenDelete = true;
            }
            if (panelOpenUpdate == false)
            {


                bunifuTransition1.Hide(panelUPDATE);
                panelOpenUpdate = true;
            }
            if (panelOpenAdd == false)
            {
                bunifuTransition1.Hide(panelADD);
                panelOpenAdd = true;
            }
            if (panelOpenRedact == false)
            {
                bunifuTransition1.Hide(panelREDACT);
                panelOpenRedact = true;
            }

            if (panelOpenView1 == false)
            {
                bunifuTransition1.Hide(panelView1);
                panelOpenView1 = true;
            }
            if (panelOpenView == false)
            {
                bunifuTransition1.Hide(panelView);
                panelOpenView = true;
            }


            if (panelOpenPrefer == false)
            {
                bunifuTransition1.Hide(panelProperties);
                panelOpenPrefer = true;
            }

            if (panelOpenHelp == false)
            {
                bunifuTransition1.Hide(panelHelp);
                panelOpenHelp = true;
            }
            if (panelOpenView == true)
            {
                bunifuTransition1.Show(panelView);
                panelOpenView = false;
            }
            else
            {
                bunifuTransition1.Hide(panelView);
                panelOpenView = true;
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            if (panelOpenDelete == false)
            {

                bunifuTransition1.Hide(panelDELETE);
                panelOpenDelete = true;
            }
            if (panelOpenUpdate == false)
            {


                bunifuTransition1.Hide(panelUPDATE);
                panelOpenUpdate = true;
            }
            if (panelOpenAdd == false)
            {
                bunifuTransition1.Hide(panelADD);
                panelOpenAdd = true;
            }
            if (panelOpenRedact == false)
            {
                bunifuTransition1.Hide(panelREDACT);
                panelOpenRedact = true;
            }

            if (panelOpenView1 == false)
            {
                bunifuTransition1.Hide(panelView1);
                panelOpenView1 = true;
            }
          
           

            if (panelOpenPrefer == false)
            {
                bunifuTransition1.Hide(panelProperties);
                panelOpenPrefer = true;
            }

            if (panelOpenHelp == false)
            {
                bunifuTransition1.Hide(panelHelp);
                panelOpenHelp = true;
            }

            if (panelOpenView1 == true)
            {
                bunifuTransition1.Show(panelView1);
                panelOpenView1 = false;
            }
            else
            {
                bunifuTransition1.Hide(panelView1);
                panelOpenView1 = true;
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (panelOpenDelete == false)
            {

                bunifuTransition1.Hide(panelDELETE);
                panelOpenDelete = true;
            }
            if (panelOpenUpdate == false)
            {


                bunifuTransition1.Hide(panelUPDATE);
                panelOpenUpdate = true;
            }
            if (panelOpenAdd == false)
            {
                bunifuTransition1.Hide(panelADD);
                panelOpenAdd = true;
            }
            if (panelOpenRedact == false)
            {
                bunifuTransition1.Hide(panelREDACT);
                panelOpenRedact = true;
            }

            if (panelOpenView1 == false)
            {
                bunifuTransition1.Hide(panelView1);
                panelOpenView1 = true;
            }



            if (panelOpenPrefer == false)
            {
                bunifuTransition1.Hide(panelProperties);
                panelOpenPrefer = true;
            }

            if (panelOpenHelp == false)
            {
                bunifuTransition1.Hide(panelHelp);
                panelOpenHelp = true;
            }

            if (panelOpenView1 == true)
            {
                bunifuTransition1.Show(panelView1);
                panelOpenView1 = false;
            }
            else
            {
                bunifuTransition1.Hide(panelView1);
                panelOpenView1 = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panelOpenDelete == false)
            {

                bunifuTransition1.Hide(panelDELETE);
                panelOpenDelete = true;
            }
            if (panelOpenUpdate == false)
            {


                bunifuTransition1.Hide(panelUPDATE);
                panelOpenUpdate = true;
            }
            if (panelOpenAdd == false)
            {
                bunifuTransition1.Hide(panelADD);
                panelOpenAdd = true;
            }
            if (panelOpenRedact == false)
            {
                bunifuTransition1.Hide(panelREDACT);
                panelOpenRedact = true;
            }


            if (panelOpenView1 == false)
            {
                bunifuTransition1.Hide(panelView1);
                panelOpenView1 = true;
            }
            if (panelOpenView == false)
            {
                bunifuTransition1.Hide(panelView);
                panelOpenView = true;
            }


            if (panelOpenPrefer == false)
            {
                bunifuTransition1.Hide(panelProperties);
                panelOpenPrefer = true;
            }

            if (panelOpenHelp == false)
            {
                bunifuTransition1.Hide(panelHelp);
                panelOpenHelp = true;
            }
            if (panelOpenRedact == true)
            {
                bunifuTransition1.Show(panelREDACT);
                panelOpenRedact = false;
            }
            else
            {

                bunifuTransition1.Hide(panelREDACT);
                panelOpenRedact = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (panelOpenDelete == false)
            {

                bunifuTransition1.Hide(panelDELETE);
                panelOpenDelete = true;
            }
            if (panelOpenUpdate == false)
            {


                bunifuTransition1.Hide(panelUPDATE);
                panelOpenUpdate = true;
            }

            if (panelOpenView1 == false)
            {
                bunifuTransition1.Hide(panelView1);
                panelOpenView1 = true;
            }
            if (panelOpenView == false)
            {
                bunifuTransition1.Hide(panelView);
                panelOpenView = true;
            }


            if (panelOpenPrefer == false)
            {
                bunifuTransition1.Hide(panelProperties);
                panelOpenPrefer = true;
            }

            if (panelOpenHelp == false)
            {
                bunifuTransition1.Hide(panelHelp);
                panelOpenHelp = true;
            }
            if (panelOpenAdd == true)
            {
                bunifuTransition1.Show(panelADD);
                panelOpenAdd = false;
            }
            else
            {
                bunifuTransition1.Hide(panelADD);
                panelOpenAdd = true;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

            if (panelOpenDelete == false)
            {

                bunifuTransition1.Hide(panelDELETE);
                panelOpenDelete = true;
            }

            if (panelOpenUpdate == false)
            {


                bunifuTransition1.Hide(panelUPDATE);
                panelOpenUpdate = true;
            }
            if (panelOpenView1 == false)
            {
                bunifuTransition1.Hide(panelView1);
                panelOpenView1 = true;
            }
            if (panelOpenView == false)
            {
                bunifuTransition1.Hide(panelView);
                panelOpenView = true;
            }


            if (panelOpenPrefer == false)
            {
                bunifuTransition1.Hide(panelProperties);
                panelOpenPrefer = true;
            }

            if (panelOpenHelp == false)
            {
                bunifuTransition1.Hide(panelHelp);
                panelOpenHelp = true;
            }
            if (panelOpenAdd == true)
            {
                bunifuTransition1.Show(panelADD);
                panelOpenAdd = false;
            }
            else
            {
                bunifuTransition1.Hide(panelADD);
                panelOpenAdd = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

            if (panelOpenDelete == false)
            {

                bunifuTransition1.Hide(panelDELETE);
                panelOpenDelete = true;
            }
            if (panelOpenAdd == false)
            {
                bunifuTransition1.Hide(panelADD);
                panelOpenAdd = true;
            }

           

            if (panelOpenView1 == false)
            {
                bunifuTransition1.Hide(panelView1);
                panelOpenView1 = true;
            }
            if (panelOpenView == false)
            {
                bunifuTransition1.Hide(panelView);
                panelOpenView = true;
            }


            if (panelOpenPrefer == false)
            {
                bunifuTransition1.Hide(panelProperties);
                panelOpenPrefer = true;
            }

            if (panelOpenHelp == false)
            {
                bunifuTransition1.Hide(panelHelp);
                panelOpenHelp = true;
            }
            if (panelOpenUpdate == true)
            {
                bunifuTransition1.Show(panelUPDATE);
                panelOpenUpdate = false;
            }
            else
            {

                bunifuTransition1.Hide(panelUPDATE);
                panelOpenUpdate = true;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (panelOpenDelete == false)
            {

                bunifuTransition1.Hide(panelDELETE);
                panelOpenDelete = true;
            }
            if (panelOpenAdd == false)
            {
                bunifuTransition1.Hide(panelADD);
                panelOpenAdd = true;
            }



            if (panelOpenView1 == false)
            {
                bunifuTransition1.Hide(panelView1);
                panelOpenView1 = true;
            }
            if (panelOpenView == false)
            {
                bunifuTransition1.Hide(panelView);
                panelOpenView = true;
            }


            if (panelOpenPrefer == false)
            {
                bunifuTransition1.Hide(panelProperties);
                panelOpenPrefer = true;
            }

            if (panelOpenHelp == false)
            {
                bunifuTransition1.Hide(panelHelp);
                panelOpenHelp = true;
            }
            if (panelOpenUpdate == true)
            {
                bunifuTransition1.Show(panelUPDATE);
                panelOpenUpdate = false;
            }
            else
            {

                bunifuTransition1.Hide(panelUPDATE);
                panelOpenUpdate = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
       
            if (panelOpenUpdate == false)
            {


                bunifuTransition1.Hide(panelUPDATE);
                panelOpenUpdate = true;
            }
            if (panelOpenAdd == false)
            {
                bunifuTransition1.Hide(panelADD);
                panelOpenAdd = true;
            }

        

            if (panelOpenView1 == false)
            {
                bunifuTransition1.Hide(panelView1);
                panelOpenView1 = true;
            }
            if (panelOpenView == false)
            {
                bunifuTransition1.Hide(panelView);
                panelOpenView = true;
            }


            if (panelOpenPrefer == false)
            {
                bunifuTransition1.Hide(panelProperties);
                panelOpenPrefer = true;
            }

            if (panelOpenHelp == false)
            {
                bunifuTransition1.Hide(panelHelp);
                panelOpenHelp = true;
            }
            if (panelOpenDelete == true)
            {
                bunifuTransition1.Show(panelDELETE);
                panelOpenDelete = false;
            }
            else
            {

                bunifuTransition1.Hide(panelDELETE);
                panelOpenDelete = true;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (panelOpenUpdate == false)
            {


                bunifuTransition1.Hide(panelUPDATE);
                panelOpenUpdate = true;
            }
            if (panelOpenAdd == false)
            {
                bunifuTransition1.Hide(panelADD);
                panelOpenAdd = true;
            }



            if (panelOpenView1 == false)
            {
                bunifuTransition1.Hide(panelView1);
                panelOpenView1 = true;
            }
            if (panelOpenView == false)
            {
                bunifuTransition1.Hide(panelView);
                panelOpenView = true;
            }


            if (panelOpenPrefer == false)
            {
                bunifuTransition1.Hide(panelProperties);
                panelOpenPrefer = true;
            }

            if (panelOpenHelp == false)
            {
                bunifuTransition1.Hide(panelHelp);
                panelOpenHelp = true;
            }
            if (panelOpenDelete == true)
            {
                bunifuTransition1.Show(panelDELETE);
                panelOpenDelete = false;
            }
            else
            {

                bunifuTransition1.Hide(panelDELETE);
                panelOpenDelete = true;
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            Application.Exit();
            AuthorizationForm.ActiveForm.Close();
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox31_Click_1(object sender, EventArgs e)
        {
            if (OpenFull == false)
            {
                this.WindowState = FormWindowState.Maximized;
             
                OpenFull = true;
                pictureBox31.Image = Properties.Resources.Svernuti;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Width = 856;
                this.Height = 602;
                pictureBox31.Image = Properties.Resources.Razvernuti;
                OpenFull = false;
            }
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            
        }

        private void label27_Click(object sender, EventArgs e)
        {
            this.Hide();
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
            helpForm = null;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            report rep = new report();
            rep.ShowDialog();
            rep = null;
            this.Show();
        }

        private void panelView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScanGetPatientByDiagnosis scanGetPatientByDiagnosis = new ScanGetPatientByDiagnosis();
            scanGetPatientByDiagnosis.ShowDialog();
            scanGetPatientByDiagnosis = null;
            this.Show();
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScanGetPatientByDiagnosis scanGetPatientByDiagnosis = new ScanGetPatientByDiagnosis();
            scanGetPatientByDiagnosis.ShowDialog();
            scanGetPatientByDiagnosis = null;
            this.Show();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            this.Hide();

            ScanGetPatientByRecipe scanGetPatientByRecipe = new ScanGetPatientByRecipe();
            scanGetPatientByRecipe.ShowDialog();
            scanGetPatientByRecipe = null;
            this.Show();

        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            this.Hide();

            ScanGetPatientByRecipe scanGetPatientByRecipe = new ScanGetPatientByRecipe();
            scanGetPatientByRecipe.ShowDialog();
            scanGetPatientByRecipe = null;
            this.Show();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Title = "Browse Text Files";

            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            openFileDialog.DefaultExt = "BAK";
            openFileDialog.Filter = "Text files (*.bak)|*.bak";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            openFileDialog.ReadOnlyChecked = true;
            openFileDialog.ShowReadOnly = true;

            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString();
            path = path.Remove(path.Length - 10, 10);
            path += @"\Dispanserizatsia.mdf";
            

            string FileName = "";
            this.Hide();
           
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;



                SqlConnection sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
                sqlConnection.Open();

                string s1 = "USE master;";
                string s2 = "ALTER DATABASE [" + path.ToUpper() + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                string s3 = string.Format(@"RESTORE DATABASE @DBName FROM DISK = '{0}' WITH REPLACE", openFileDialog.FileName);
                LoaderForm scanGetCountPacientByAreaForm = new LoaderForm();
                scanGetCountPacientByAreaForm.ShowDialog();
                scanGetCountPacientByAreaForm = null;
                this.Show();
                MessageBox.Show(s3);
                SqlCommand cmd1 = new SqlCommand(s1, sqlConnection);
                SqlCommand cmd2 = new SqlCommand(@s2, sqlConnection);
                SqlCommand cmd3 = new SqlCommand(s3, sqlConnection);
                cmd3.Parameters.AddWithValue("DBName", path.ToUpper());

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();

                sqlConnection.Close();

                if (MessageBox.Show("Database Recovered Successful. It is recommended to restart the application to apply all changes.\nReload app now ? ", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Title = "Browse Text Files";

            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            openFileDialog.DefaultExt = "BAK";
            openFileDialog.Filter = "Text files (*.bak)|*.bak";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            openFileDialog.ReadOnlyChecked = true;
            openFileDialog.ShowReadOnly = true;

            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString();
            path = path.Remove(path.Length - 10, 10);
            path += @"\Dispanserizatsia.mdf";


            string FileName = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;



                SqlConnection sqlConnection = new SqlConnection(AuthorizationForm.pathSqlConnection);
                sqlConnection.Open();

                string s1 = "USE master;";
                string s2 = "ALTER DATABASE [" + path.ToUpper() + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                string s3 = string.Format(@"RESTORE DATABASE @DBName FROM DISK = '{0}' WITH REPLACE", openFileDialog.FileName);
                LoaderForm scanGetCountPacientByAreaForm = new LoaderForm();
                scanGetCountPacientByAreaForm.ShowDialog();
                scanGetCountPacientByAreaForm = null;
                this.Show();
                MessageBox.Show(s3);
                SqlCommand cmd1 = new SqlCommand(s1, sqlConnection);
                SqlCommand cmd2 = new SqlCommand(@s2, sqlConnection);
                SqlCommand cmd3 = new SqlCommand(s3, sqlConnection);
                cmd3.Parameters.AddWithValue("DBName", path.ToUpper());

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();

                sqlConnection.Close();

                if (MessageBox.Show("Database Recovered Successful. It is recommended to restart the application to apply all changes.\nReload app now ? ", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            this.Hide();
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
            helpForm = null;
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void label30_Click(object sender, EventArgs e)
        {
            this.Hide();
            report helpForm = new report();
            helpForm.ShowDialog();
            helpForm = null;
            this.Show();
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            this.Hide();
            report helpForm = new report();
            helpForm.ShowDialog();
            helpForm = null;
            this.Show();
        }

        private void panelADD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Loader2 helpForm = new Loader2();
            helpForm.ShowDialog();
            helpForm = null;
            this.Show();
        }
    }

    public class MyRenderer : ToolStripProfessionalRenderer
    {
        public static Color CurrentColor = Color.FromArgb(255, 255, 255);
        public static Color MenuItemBorderColor = Color.DarkBlue;
        public static Color MenuItemSelectedColor = Color.LightBlue;
        public MyRenderer() : base(new MyColors()) { }
    }

    public class MyColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return MyRenderer.MenuItemSelectedColor; } // эта
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return MyRenderer.CurrentColor; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return MyRenderer.CurrentColor; } // и эта
        }
        //public override Color MenuStripGradientBegin
        //{
        //    get { return Color.Green; }
        //}
        //public override Color MenuBorder
        //{
        //    get { return Color.Red; }
        //}
        public override Color MenuItemPressedGradientMiddle
        {
            get { return Color.HotPink; }
        }
        public override Color MenuItemPressedGradientBegin // this
        {
            get { return MyRenderer.CurrentColor; }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get { return MyRenderer.CurrentColor; }
        }
        public override Color MenuItemBorder
        {
            get { return MyRenderer.MenuItemBorderColor; } // Обводка итемов при навидение
        }
    }
}

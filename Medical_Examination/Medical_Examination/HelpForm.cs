using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Examination
{
    public partial class HelpForm : Form
    {
        bool OpenPanel = false;
        bool OpenPanelAdd = false;
        bool OpenPanelUpdate = false;
        bool OpenPanelDelete = false;
        bool OpenPanelView = false;
        bool OpenPanelBackUp1 = false;
        bool OpenPanelBackUpAdd = false;
        bool OpenPanelBackUpDO = false;
        bool OpenPanelOtziv = false;
        bool OpenPanelOtcet = false;
        public HelpForm()
        {
            InitializeComponent();
          
        }

        private void panelREDACT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (OpenPanelOtcet == true)
            {
             
                bunifuTransition4.Hide(panel4);
                OpenPanelOtcet = false;

            }
            if (OpenPanelOtziv == true)
            {

                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
            if (OpenPanelBackUpDO == true)
            {
                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }
            if (OpenPanelBackUpAdd == true)
            {

                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }
            if (OpenPanelBackUp1 == true)
            {

                bunifuTransition3.Hide(panelBack);
                OpenPanelBackUp1 = false;
            }
            if (OpenPanelView == true)
            {
           
                bunifuTransition4.Hide(panelHELPVIEW);
                OpenPanelView = false;
            }
            if (OpenPanelDelete == true)
            {

                bunifuTransition4.Hide(panelHELPDELETE);
                OpenPanelDelete = false;
            }
            if (OpenPanelUpdate == true)
            {

                bunifuTransition4.Hide(panelHELPUPDATE);
                OpenPanelUpdate = false;

            }
            if (OpenPanelAdd == true)
            {
                bunifuTransition4.Hide(panelHELPADD);
                OpenPanelAdd = false;

            }

            if (OpenPanel == false)
            {
                label1.Text = "Справка по редактированию▼";
                OpenPanel = true;
                bunifuTransition3.Show(panelREDACT);
            }
            else
            {
                label1.Text = "Справка по редактированию►";
                OpenPanel = false;
                bunifuTransition3.Hide(panelREDACT);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (OpenPanelOtcet == true)
            {

                bunifuTransition4.Hide(panel4);
                OpenPanelOtcet = false;

            }
            if (OpenPanelOtziv == true)
            {

                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
            if (OpenPanelBackUpDO == true)
            {
                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }
            if (OpenPanelBackUpAdd == true)
            {

                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }
            if (OpenPanelBackUp1 == true)
            {

                bunifuTransition3.Hide(panelBack);
                OpenPanelBackUp1 = false;
            }

            if (OpenPanelView == true)
            {

                bunifuTransition4.Hide(panelHELPVIEW);
                OpenPanelView = false;
            }
            if (OpenPanelDelete == true)
            {

                bunifuTransition4.Hide(panelHELPDELETE);
                OpenPanelDelete = false;
            }
            if (OpenPanelUpdate == true)
            {

                bunifuTransition4.Hide(panelHELPUPDATE);
                OpenPanelUpdate = false;

            }
            if (OpenPanelAdd == true)
            {
                bunifuTransition4.Hide(panelHELPADD);
                OpenPanelAdd = false;

            }

            if (OpenPanel == false)
            {
                label1.Text = "Справка по редактированию▼";
                OpenPanel = true;
                bunifuTransition3.Show(panelREDACT);
            }
            else
            {
                label1.Text = "Справка по редактированию►";
                OpenPanel = false;
                bunifuTransition3.Hide(panelREDACT);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (OpenPanelOtcet == true)
            {

                bunifuTransition4.Hide(panel4);
                OpenPanelOtcet = false;

            }
            if (OpenPanelOtziv == true)
            {
             
                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
            if (OpenPanelBackUpDO == true)
            {
                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }

            if (OpenPanelBackUpAdd == true)
            {
            
                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }
            if (OpenPanelBackUp1 == true)
            {

                bunifuTransition3.Hide(panelBack);
                OpenPanelBackUp1 = false;
            }
            if (OpenPanelView == true)
            {

                bunifuTransition4.Hide(panelHELPVIEW);
                OpenPanelView = false;
            }
            if (OpenPanelDelete == true)
            {
             
                bunifuTransition4.Hide(panelHELPDELETE);
                OpenPanelDelete = false;
            }
            if (OpenPanelUpdate == true)
            {

                bunifuTransition4.Hide(panelHELPUPDATE);
                OpenPanelUpdate = false;

            }
            if (OpenPanelAdd == false)
            {
                bunifuTransition4.Show(panelHELPADD);
                OpenPanelAdd = true;
            }
            else
            {
                bunifuTransition4.Hide(panelHELPADD);
                OpenPanelAdd = false;

            }

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (OpenPanelOtcet == true)
            {

                bunifuTransition4.Hide(panel4);
                OpenPanelOtcet = false;

            }
            if (OpenPanelOtziv == true)
            {

                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
            if (OpenPanelBackUpDO == true)
            {
                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }
            if (OpenPanelBackUpAdd == true)
            {

                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }
            if (OpenPanelBackUp1 == true)
            {

                bunifuTransition3.Hide(panelBack);
                OpenPanelBackUp1 = false;
            }
            if (OpenPanelView == true)
            {

                bunifuTransition4.Hide(panelHELPVIEW);
                OpenPanelView = false;
            }
            if (OpenPanelDelete == true)
            {

                bunifuTransition4.Hide(panelHELPDELETE);
                OpenPanelDelete = false;
            }
            if (OpenPanelUpdate == true)
            {
          
                bunifuTransition4.Hide(panelHELPUPDATE);
                OpenPanelUpdate = false;

            }
            if (OpenPanelAdd == false)
            {
                bunifuTransition4.Show(panelHELPADD);
                OpenPanelAdd = true;
            }
            else
            {
                bunifuTransition4.Hide(panelHELPADD);
                OpenPanelAdd = false;

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (OpenPanelOtcet == true)
            {

                bunifuTransition4.Hide(panel4);
                OpenPanelOtcet = false;

            }
            if (OpenPanelOtziv == true)
            {

                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
            if (OpenPanelBackUpDO == true)
            {
                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }
            if (OpenPanelBackUpAdd == true)
            {

                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }
            if (OpenPanelBackUp1 == true)
            {

                bunifuTransition3.Hide(panelBack);
                OpenPanelBackUp1 = false;
            }
            if (OpenPanelView == true)
            {

                bunifuTransition4.Hide(panelHELPVIEW);
                OpenPanelView = false;
            }
            if (OpenPanelDelete == true)
            {

                bunifuTransition4.Hide(panelHELPDELETE);
                OpenPanelDelete = false;
            }
            if (OpenPanelAdd == true)
            {
                bunifuTransition4.Hide(panelHELPADD);
                OpenPanelAdd = false;

            }
            if (OpenPanelUpdate == false)
            {
                bunifuTransition4.Show(panelHELPUPDATE);
                OpenPanelUpdate = true;
            }
            else
            {
                bunifuTransition4.Hide(panelHELPUPDATE);
                OpenPanelUpdate = false;

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (OpenPanelOtcet == true)
            {

                bunifuTransition4.Hide(panel4);
                OpenPanelOtcet = false;

            }
            if (OpenPanelOtziv == true)
            {

                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
            if (OpenPanelBackUpDO == true)
            {
                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }
            if (OpenPanelBackUpAdd == true)
            {

                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }
            if (OpenPanelBackUp1 == true)
            {

                bunifuTransition3.Hide(panelBack);
                OpenPanelBackUp1 = false;
            }
            if (OpenPanelView == true)
            {

                bunifuTransition4.Hide(panelHELPVIEW);
                OpenPanelView = false;
            }
            if (OpenPanelUpdate == true)
            {

                bunifuTransition4.Hide(panelHELPUPDATE);
                OpenPanelUpdate = false;

            }
            if (OpenPanelAdd == true)
            {
                bunifuTransition4.Hide(panelHELPADD);
                OpenPanelAdd = false;

            }

            if (OpenPanelDelete == false)
            {
                bunifuTransition4.Show(panelHELPDELETE);
                OpenPanelDelete = true;
            }
            else
            {
                bunifuTransition4.Hide(panelHELPDELETE);
                OpenPanelDelete = false;
            }
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            this.Width = 1300;
            this.Height = 789;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (OpenPanelOtcet == true)
            {

                bunifuTransition4.Hide(panel4);
                OpenPanelOtcet = false;

            }
            if (OpenPanelOtziv == true)
            {

                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
            if (OpenPanelBackUpDO == true)
            {
                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }
            if (OpenPanelBackUpAdd == true)
            {

                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }
            if (OpenPanelBackUp1 == true)
            {

                bunifuTransition3.Hide(panelBack);
                OpenPanelBackUp1 = false;
            }
            if (OpenPanelView == true)
            {

                bunifuTransition4.Hide(panelHELPVIEW);
                OpenPanelView = false;
            }
            if (OpenPanelDelete == true)
            {

                bunifuTransition4.Hide(panelHELPDELETE);
                OpenPanelDelete = false;
            }
            if (OpenPanelAdd == true)
            {
                bunifuTransition4.Hide(panelHELPADD);
                OpenPanelAdd = false;

            }
            if (OpenPanelUpdate == false)
            {
                bunifuTransition4.Show(panelHELPUPDATE);
                OpenPanelUpdate = true;
            }
            else
            {
                bunifuTransition4.Hide(panelHELPUPDATE);
                OpenPanelUpdate = false;

            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (OpenPanelOtcet == true)
            {

                bunifuTransition4.Hide(panel4);
                OpenPanelOtcet = false;

            }
            if (OpenPanelOtziv == true)
            {

                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
            if (OpenPanelBackUpDO == true)
            {
                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }
            if (OpenPanelBackUpAdd == true)
            {

                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }
            if (OpenPanelBackUp1 == true)
            {

                bunifuTransition3.Hide(panelBack);
                OpenPanelBackUp1 = false;
            }
            if (OpenPanelView == true)
            {

                bunifuTransition4.Hide(panelHELPVIEW);
                OpenPanelView = false;
            }
            if (OpenPanelUpdate == true)
            {

                bunifuTransition4.Hide(panelHELPUPDATE);
                OpenPanelUpdate = false;

            }
            if (OpenPanelAdd == true)
            {
                bunifuTransition4.Hide(panelHELPADD);
                OpenPanelAdd = false;

            }
            if (OpenPanelDelete == false)
            {
                bunifuTransition4.Show(panelHELPDELETE);
                OpenPanelDelete = true;
            }
            else
            {
                bunifuTransition4.Hide(panelHELPDELETE);
                OpenPanelDelete = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (OpenPanelOtcet == true)
            {

                bunifuTransition4.Hide(panel4);
                OpenPanelOtcet = false;

            }
            if (OpenPanelOtziv == true)
            {

                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
            if (OpenPanelBackUpDO == true)
            {
                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }
            if (OpenPanelBackUpAdd == true)
            {

                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }
            if (OpenPanelBackUp1 == true)
            {

                bunifuTransition3.Hide(panelBack);
                OpenPanelBackUp1 = false;
            }
            if (OpenPanelDelete == true)
            {

                bunifuTransition4.Hide(panelHELPDELETE);
                OpenPanelDelete = false;
            }
            if (OpenPanelUpdate == true)
            {

                bunifuTransition4.Hide(panelHELPUPDATE);
                OpenPanelUpdate = false;

            }
            if (OpenPanelAdd == true)
            {
                bunifuTransition4.Hide(panelHELPADD);
                OpenPanelAdd = false;

            }

            if (OpenPanel == true)
            {
             
                label1.Text = "Справка по редактированию►";
                OpenPanel = false;
                bunifuTransition3.Hide(panelREDACT);
            }

            if (OpenPanelView == false)
            {
                bunifuTransition4.Show(panelHELPVIEW);
                OpenPanelView = true;

            }
            else
            {

                bunifuTransition4.Hide(panelHELPVIEW);
                OpenPanelView = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (OpenPanelOtcet == true)
            {

                bunifuTransition4.Hide(panel4);
                OpenPanelOtcet = false;

            }
            if (OpenPanelOtziv == true)
            {

                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
            if (OpenPanelBackUpDO == true)
            {
                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }
            if (OpenPanelBackUpAdd == true)
            {

                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }
            if (OpenPanelView == true)
            {

                bunifuTransition4.Hide(panelHELPVIEW);
                OpenPanelView = false;
            }
            if (OpenPanelDelete == true)
            {

                bunifuTransition4.Hide(panelHELPDELETE);
                OpenPanelDelete = false;
            }
            if (OpenPanelUpdate == true)
            {

                bunifuTransition4.Hide(panelHELPUPDATE);
                OpenPanelUpdate = false;

            }
            if (OpenPanelAdd == true)
            {
                bunifuTransition4.Hide(panelHELPADD);
                OpenPanelAdd = false;

            }

            if (OpenPanel == true)
            {
                label1.Text = "Справка по редактированию►";
                OpenPanel = false;
                bunifuTransition3.Hide(panelREDACT);
            }


            if (OpenPanelBackUp1 == false)
            {
                bunifuTransition3.Show(panelBack);
                OpenPanelBackUp1 = true;
            }
            else
            {

                bunifuTransition3.Hide(panelBack);
                OpenPanelBackUp1 = false;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (OpenPanelOtcet == true)
            {

                bunifuTransition4.Hide(panel4);
                OpenPanelOtcet = false;

            }
            if (OpenPanelOtziv == true)
            {

                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
            if (OpenPanelBackUpDO == true)
            {
                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }
            if (OpenPanelBackUpAdd == true)
            {

                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }
            if (OpenPanelBackUp1 == true)
            {

                bunifuTransition3.Hide(panelBack);
                OpenPanelBackUp1 = false;
            }
            if (OpenPanelDelete == true)
            {

                bunifuTransition4.Hide(panelHELPDELETE);
                OpenPanelDelete = false;
            }
            if (OpenPanelUpdate == true)
            {

                bunifuTransition4.Hide(panelHELPUPDATE);
                OpenPanelUpdate = false;

            }
            if (OpenPanelAdd == true)
            {
                bunifuTransition4.Hide(panelHELPADD);
                OpenPanelAdd = false;

            }

            if (OpenPanel == true)
            {

                label1.Text = "Справка по редактированию►";
                OpenPanel = false;
                bunifuTransition3.Hide(panelREDACT);
            }

            if (OpenPanelView == false)
            {
                bunifuTransition4.Show(panelHELPVIEW);
                OpenPanelView = true;

            }
            else
            {

                bunifuTransition4.Hide(panelHELPVIEW);
                OpenPanelView = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (OpenPanelOtcet == true)
            {

                bunifuTransition4.Hide(panel4);
                OpenPanelOtcet = false;

            }
            if (OpenPanelOtziv == true)
            {

                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
            if (OpenPanelBackUpDO == true)
            {
                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }
            if (OpenPanelBackUpAdd == true)
            {

                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }
            if (OpenPanelView == true)
            {

                bunifuTransition4.Hide(panelHELPVIEW);
                OpenPanelView = false;
            }
            if (OpenPanelDelete == true)
            {

                bunifuTransition4.Hide(panelHELPDELETE);
                OpenPanelDelete = false;
            }
            if (OpenPanelUpdate == true)
            {

                bunifuTransition4.Hide(panelHELPUPDATE);
                OpenPanelUpdate = false;

            }
            if (OpenPanelAdd == true)
            {
                bunifuTransition4.Hide(panelHELPADD);
                OpenPanelAdd = false;

            }

            if (OpenPanel == true)
            {
                label1.Text = "Справка по редактированию►";
                OpenPanel = false;
                bunifuTransition3.Hide(panelREDACT);
            }


            if (OpenPanelBackUp1 == false)
            {
                bunifuTransition3.Show(panelBack);
                OpenPanelBackUp1 = true;
            }
            else
            {

                bunifuTransition3.Hide(panelBack);
                OpenPanelBackUp1 = false;
            }
        }

        private void label47_Click(object sender, EventArgs e)
        {
            if (OpenPanelOtcet == true)
            {

                bunifuTransition4.Hide(panel4);
                OpenPanelOtcet = false;

            }
            if (OpenPanelOtziv == true)
            {

                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
            if (OpenPanelBackUpDO == true)
            {
                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }
            if (OpenPanelBackUpAdd == true)
            {

                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }
           
            if (OpenPanelView == true)
            {

                bunifuTransition4.Hide(panelHELPVIEW);
                OpenPanelView = false;
            }
            if (OpenPanelDelete == true)
            {

                bunifuTransition4.Hide(panelHELPDELETE);
                OpenPanelDelete = false;
            }
            if (OpenPanelUpdate == true)
            {

                bunifuTransition4.Hide(panelHELPUPDATE);
                OpenPanelUpdate = false;

            }
            if (OpenPanelAdd == true)
            {
                bunifuTransition4.Hide(panelHELPADD);
                OpenPanelAdd = false;

            }

            if (OpenPanel == true)
            {
               
                label1.Text = "Справка по редактированию►";
                OpenPanel = false;
                bunifuTransition3.Hide(panelREDACT);
            }

            if (OpenPanelBackUpAdd == false)
            {
                bunifuTransition4.Show(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = true;
            }
            else
            {

                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            if (OpenPanelOtcet == true)
            {

                bunifuTransition4.Hide(panel4);
                OpenPanelOtcet = false;

            }
            if (OpenPanelOtziv == true)
            {

                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
            if (OpenPanelBackUpDO == true)
            {
                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }
            if (OpenPanelBackUpAdd == true)
            {

                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }
          
            if (OpenPanelView == true)
            {

                bunifuTransition4.Hide(panelHELPVIEW);
                OpenPanelView = false;
            }
            if (OpenPanelDelete == true)
            {

                bunifuTransition4.Hide(panelHELPDELETE);
                OpenPanelDelete = false;
            }
            if (OpenPanelUpdate == true)
            {

                bunifuTransition4.Hide(panelHELPUPDATE);
                OpenPanelUpdate = false;

            }
            if (OpenPanelAdd == true)
            {
                bunifuTransition4.Hide(panelHELPADD);
                OpenPanelAdd = false;

            }

            if (OpenPanel == true)
            {

                label1.Text = "Справка по редактированию►";
                OpenPanel = false;
                bunifuTransition3.Hide(panelREDACT);
            }

            if (OpenPanelBackUpAdd == false)
            {
                bunifuTransition4.Show(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = true;
            }
            else
            {

                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }
        }

        private void label48_Click(object sender, EventArgs e)
        {
            if (OpenPanelOtcet == true)
            {

                bunifuTransition4.Hide(panel4);
                OpenPanelOtcet = false;

            }
            if (OpenPanelOtziv == true)
            {

                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
            if (OpenPanelBackUpDO == true)
            {
                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }
            if (OpenPanelBackUpAdd == true)
            {

                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }
           
            if (OpenPanelView == true)
            {

                bunifuTransition4.Hide(panelHELPVIEW);
                OpenPanelView = false;
            }
            if (OpenPanelDelete == true)
            {

                bunifuTransition4.Hide(panelHELPDELETE);
                OpenPanelDelete = false;
            }
            if (OpenPanelUpdate == true)
            {

                bunifuTransition4.Hide(panelHELPUPDATE);
                OpenPanelUpdate = false;

            }
            if (OpenPanelAdd == true)
            {
                bunifuTransition4.Hide(panelHELPADD);
                OpenPanelAdd = false;

            }

            if (OpenPanel == true)
            {
             
                label1.Text = "Справка по редактированию►";
                OpenPanel = false;
                bunifuTransition3.Hide(panelREDACT);
            }


            if (OpenPanelBackUpDO == false)
            {
                bunifuTransition4.Show(panel2);
                OpenPanelBackUpDO = true;
            }
            else
            {

                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            if (OpenPanelOtcet == true)
            {

                bunifuTransition4.Hide(panel4);
                OpenPanelOtcet = false;

            }
            if (OpenPanelOtziv == true)
            {

                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
            if (OpenPanelBackUpDO == true)
            {
                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }
            if (OpenPanelBackUpAdd == true)
            {

                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }

            if (OpenPanelView == true)
            {

                bunifuTransition4.Hide(panelHELPVIEW);
                OpenPanelView = false;
            }
            if (OpenPanelDelete == true)
            {

                bunifuTransition4.Hide(panelHELPDELETE);
                OpenPanelDelete = false;
            }
            if (OpenPanelUpdate == true)
            {

                bunifuTransition4.Hide(panelHELPUPDATE);
                OpenPanelUpdate = false;

            }
            if (OpenPanelAdd == true)
            {
                bunifuTransition4.Hide(panelHELPADD);
                OpenPanelAdd = false;

            }

            if (OpenPanel == true)
            {

                label1.Text = "Справка по редактированию►";
                OpenPanel = false;
                bunifuTransition3.Hide(panelREDACT);
            }


            if (OpenPanelBackUpDO == false)
            {
                bunifuTransition4.Show(panel2);
                OpenPanelBackUpDO = true;
            }
            else
            {

                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (OpenPanelOtcet == true)
            {

                bunifuTransition4.Hide(panel4);
                OpenPanelOtcet = false;

            }
            if (OpenPanelOtziv == true)
            {

                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
            if (OpenPanelBackUpDO == true)
            {
                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }
            if (OpenPanelBackUpAdd == true)
            {

                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }
            if (OpenPanelBackUp1 == true)
            {

                bunifuTransition3.Hide(panelBack);
                OpenPanelBackUp1 = false;
            }
            if (OpenPanelView == true)
            {

                bunifuTransition4.Hide(panelHELPVIEW);
                OpenPanelView = false;
            }
            if (OpenPanelDelete == true)
            {

                bunifuTransition4.Hide(panelHELPDELETE);
                OpenPanelDelete = false;
            }
            if (OpenPanelUpdate == true)
            {

                bunifuTransition4.Hide(panelHELPUPDATE);
                OpenPanelUpdate = false;

            }
            if (OpenPanelAdd == true)
            {
                bunifuTransition4.Hide(panelHELPADD);
                OpenPanelAdd = false;

            }

            if (OpenPanel == true)
            {
              
                label1.Text = "Справка по редактированию►";
                OpenPanel = false;
                bunifuTransition3.Hide(panelREDACT);
            }

            if (OpenPanelOtziv == false)
            {
                bunifuTransition4.Show(panel3);
                OpenPanelOtziv = true;
            }
            else
            {
                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (OpenPanelOtcet == true)
            {

                bunifuTransition4.Hide(panel4);
                OpenPanelOtcet = false;

            }
            if (OpenPanelOtziv == true)
            {

                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
            if (OpenPanelBackUpDO == true)
            {
                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }
            if (OpenPanelBackUpAdd == true)
            {

                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }
            if (OpenPanelBackUp1 == true)
            {

                bunifuTransition3.Hide(panelBack);
                OpenPanelBackUp1 = false;
            }
            if (OpenPanelView == true)
            {

                bunifuTransition4.Hide(panelHELPVIEW);
                OpenPanelView = false;
            }
            if (OpenPanelDelete == true)
            {

                bunifuTransition4.Hide(panelHELPDELETE);
                OpenPanelDelete = false;
            }
            if (OpenPanelUpdate == true)
            {

                bunifuTransition4.Hide(panelHELPUPDATE);
                OpenPanelUpdate = false;

            }
            if (OpenPanelAdd == true)
            {
                bunifuTransition4.Hide(panelHELPADD);
                OpenPanelAdd = false;

            }

            if (OpenPanel == true)
            {

                label1.Text = "Справка по редактированию►";
                OpenPanel = false;
                bunifuTransition3.Hide(panelREDACT);
            }

            if (OpenPanelOtziv == false)
            {
                bunifuTransition4.Show(panel3);
                OpenPanelOtziv = true;
            }
            else
            {
                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (OpenPanelOtziv == true)
            {

                bunifuTransition4.Hide(panel3);
                OpenPanelOtziv = false;

            }
            if (OpenPanelBackUpDO == true)
            {
                bunifuTransition4.Hide(panel2);
                OpenPanelBackUpDO = false;
            }
            if (OpenPanelBackUpAdd == true)
            {

                bunifuTransition4.Hide(panelHELPBACKUPADD);
                OpenPanelBackUpAdd = false;
            }
            if (OpenPanelBackUp1 == true)
            {

                bunifuTransition3.Hide(panelBack);
                OpenPanelBackUp1 = false;
            }
            if (OpenPanelView == true)
            {

                bunifuTransition4.Hide(panelHELPVIEW);
                OpenPanelView = false;
            }
            if (OpenPanelDelete == true)
            {

                bunifuTransition4.Hide(panelHELPDELETE);
                OpenPanelDelete = false;
            }
            if (OpenPanelUpdate == true)
            {

                bunifuTransition4.Hide(panelHELPUPDATE);
                OpenPanelUpdate = false;

            }
            if (OpenPanelAdd == true)
            {
                bunifuTransition4.Hide(panelHELPADD);
                OpenPanelAdd = false;

            }

            if (OpenPanel == true)
            {
                label1.Text = "Справка по редактированию►";
                OpenPanel = false;
                bunifuTransition3.Hide(panelREDACT);
            }
            if (OpenPanelOtcet == false)
            {
                bunifuTransition4.Show(panel4);
                OpenPanelOtcet = true;

            }
            else
            {
                bunifuTransition4.Hide(panel4);
                OpenPanelOtcet = false;

            }
        }
    }
}

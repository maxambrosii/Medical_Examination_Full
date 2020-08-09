namespace Medical_Examination
{
    partial class report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report));
            this.GetPatientsAgeReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DispanserizatsiaDataSet1 = new Medical_Examination.DispanserizatsiaDataSet1();
            this.REPORT_RECIPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DispanserizatsiaDataSetRECIPEREPORT = new Medical_Examination.DispanserizatsiaDataSetRECIPEREPORT();
            this.REPORT_DIAGNOZBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DispanserizatsiaDataSetREPORT_DIAGNOZ = new Medical_Examination.DispanserizatsiaDataSetREPORT_DIAGNOZ();
            this.PriemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DispanserizatsiaDataSet = new Medical_Examination.DispanserizatsiaDataSet();
            this.reportViewer_Age = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PriemTableAdapter = new Medical_Examination.DispanserizatsiaDataSetTableAdapters.PriemTableAdapter();
            this.GetPatientsAgeReportTableAdapter = new Medical_Examination.DispanserizatsiaDataSet1TableAdapters.GetPatientsAgeReportTableAdapter();
            this.getPatientsAgeReportTableAdapter1 = new Medical_Examination.DispanserizatsiaDataSet1TableAdapters.GetPatientsAgeReportTableAdapter();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelBack = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Label();
            this.BackImg = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelExit = new System.Windows.Forms.Panel();
            this.label_Exit = new System.Windows.Forms.Label();
            this.pictureBox_exit = new System.Windows.Forms.PictureBox();
            this.label_Patient = new System.Windows.Forms.Label();
            this.comboBox_Patient = new System.Windows.Forms.ComboBox();
            this.reportViewerRecipe = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewerDiagnoz = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel_exit = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.pictureBoxExitt = new System.Windows.Forms.PictureBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.label_Patientt = new System.Windows.Forms.Label();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.comboBoxPatientt = new System.Windows.Forms.ComboBox();
            this.REPORT_RECIPETableAdapter = new Medical_Examination.DispanserizatsiaDataSetRECIPEREPORTTableAdapters.REPORT_RECIPETableAdapter();
            this.REPORT_DIAGNOZTableAdapter = new Medical_Examination.DispanserizatsiaDataSetREPORT_DIAGNOZTableAdapters.REPORT_DIAGNOZTableAdapter();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GetPatientsAgeReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DispanserizatsiaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_RECIPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DispanserizatsiaDataSetRECIPEREPORT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_DIAGNOZBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DispanserizatsiaDataSetREPORT_DIAGNOZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DispanserizatsiaDataSet)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackImg)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel_exit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExitt)).BeginInit();
            this.SuspendLayout();
            // 
            // GetPatientsAgeReportBindingSource
            // 
            this.GetPatientsAgeReportBindingSource.DataMember = "GetPatientsAgeReport";
            this.GetPatientsAgeReportBindingSource.DataSource = this.DispanserizatsiaDataSet1;
            // 
            // DispanserizatsiaDataSet1
            // 
            this.DispanserizatsiaDataSet1.DataSetName = "DispanserizatsiaDataSet1";
            this.DispanserizatsiaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // REPORT_RECIPEBindingSource
            // 
            this.REPORT_RECIPEBindingSource.DataMember = "REPORT_RECIPE";
            this.REPORT_RECIPEBindingSource.DataSource = this.DispanserizatsiaDataSetRECIPEREPORT;
            // 
            // DispanserizatsiaDataSetRECIPEREPORT
            // 
            this.DispanserizatsiaDataSetRECIPEREPORT.DataSetName = "DispanserizatsiaDataSetRECIPEREPORT";
            this.DispanserizatsiaDataSetRECIPEREPORT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // REPORT_DIAGNOZBindingSource
            // 
            this.REPORT_DIAGNOZBindingSource.DataMember = "REPORT_DIAGNOZ";
            this.REPORT_DIAGNOZBindingSource.DataSource = this.DispanserizatsiaDataSetREPORT_DIAGNOZ;
            // 
            // DispanserizatsiaDataSetREPORT_DIAGNOZ
            // 
            this.DispanserizatsiaDataSetREPORT_DIAGNOZ.DataSetName = "DispanserizatsiaDataSetREPORT_DIAGNOZ";
            this.DispanserizatsiaDataSetREPORT_DIAGNOZ.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PriemBindingSource
            // 
            this.PriemBindingSource.DataMember = "Priem";
            this.PriemBindingSource.DataSource = this.DispanserizatsiaDataSet;
            // 
            // DispanserizatsiaDataSet
            // 
            this.DispanserizatsiaDataSet.DataSetName = "DispanserizatsiaDataSet";
            this.DispanserizatsiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer_Age
            // 
            this.reportViewer_Age.BackColor = System.Drawing.Color.Silver;
            this.reportViewer_Age.BackgroundImage = global::Medical_Examination.Properties.Resources.fuzzy_1800136_19203;
            this.reportViewer_Age.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportViewer_Age.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewer_Age.Dock = System.Windows.Forms.DockStyle.Top;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GetPatientsAgeReportBindingSource;
            this.reportViewer_Age.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer_Age.LocalReport.ReportEmbeddedResource = "Medical_Examination.Report1.rdlc";
            this.reportViewer_Age.Location = new System.Drawing.Point(2, 2);
            this.reportViewer_Age.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer_Age.Name = "reportViewer_Age";
            this.reportViewer_Age.ServerReport.BearerToken = null;
            this.reportViewer_Age.Size = new System.Drawing.Size(760, 486);
            this.reportViewer_Age.TabIndex = 0;
            this.reportViewer_Age.Load += new System.EventHandler(this.reportViewer_Age_Load);
            // 
            // PriemTableAdapter
            // 
            this.PriemTableAdapter.ClearBeforeFill = true;
            // 
            // GetPatientsAgeReportTableAdapter
            // 
            this.GetPatientsAgeReportTableAdapter.ClearBeforeFill = true;
            // 
            // getPatientsAgeReportTableAdapter1
            // 
            this.getPatientsAgeReportTableAdapter1.ClearBeforeFill = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(772, 596);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelBack);
            this.tabPage1.Controls.Add(this.reportViewer_Age);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(764, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " Возрастные категории  ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelBack
            // 
            this.panelBack.Controls.Add(this.BackBtn);
            this.panelBack.Controls.Add(this.BackImg);
            this.panelBack.Location = new System.Drawing.Point(607, 508);
            this.panelBack.Margin = new System.Windows.Forms.Padding(2);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(134, 54);
            this.panelBack.TabIndex = 45;
            this.panelBack.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBack_Paint);
            // 
            // BackBtn
            // 
            this.BackBtn.AutoSize = true;
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.ForeColor = System.Drawing.Color.Black;
            this.BackBtn.Location = new System.Drawing.Point(58, 13);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(69, 22);
            this.BackBtn.TabIndex = 43;
            this.BackBtn.Text = "Назад";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // BackImg
            // 
            this.BackImg.BackColor = System.Drawing.Color.Transparent;
            this.BackImg.BackgroundImage = global::Medical_Examination.Properties.Resources.logout;
            this.BackImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackImg.Location = new System.Drawing.Point(10, 6);
            this.BackImg.Margin = new System.Windows.Forms.Padding(2);
            this.BackImg.Name = "BackImg";
            this.BackImg.Size = new System.Drawing.Size(44, 38);
            this.BackImg.TabIndex = 42;
            this.BackImg.TabStop = false;
            this.BackImg.Click += new System.EventHandler(this.BackImg_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.reportViewerRecipe);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(764, 564);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " Рецепт  ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panelExit);
            this.panel1.Controls.Add(this.label_Patient);
            this.panel1.Controls.Add(this.comboBox_Patient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 86);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelExit
            // 
            this.panelExit.Controls.Add(this.label_Exit);
            this.panelExit.Controls.Add(this.pictureBox_exit);
            this.panelExit.Location = new System.Drawing.Point(616, 17);
            this.panelExit.Margin = new System.Windows.Forms.Padding(2);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(134, 54);
            this.panelExit.TabIndex = 45;
            this.panelExit.Click += new System.EventHandler(this.panelExit_Click);
            // 
            // label_Exit
            // 
            this.label_Exit.AutoSize = true;
            this.label_Exit.BackColor = System.Drawing.Color.Transparent;
            this.label_Exit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Exit.ForeColor = System.Drawing.Color.White;
            this.label_Exit.Location = new System.Drawing.Point(58, 13);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(69, 22);
            this.label_Exit.TabIndex = 43;
            this.label_Exit.Text = "Назад";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            // 
            // pictureBox_exit
            // 
            this.pictureBox_exit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_exit.BackgroundImage = global::Medical_Examination.Properties.Resources.logout;
            this.pictureBox_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_exit.Location = new System.Drawing.Point(10, 6);
            this.pictureBox_exit.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_exit.Name = "pictureBox_exit";
            this.pictureBox_exit.Size = new System.Drawing.Size(44, 38);
            this.pictureBox_exit.TabIndex = 42;
            this.pictureBox_exit.TabStop = false;
            this.pictureBox_exit.Click += new System.EventHandler(this.pictureBox_exit_Click);
            // 
            // label_Patient
            // 
            this.label_Patient.AutoSize = true;
            this.label_Patient.BackColor = System.Drawing.Color.Transparent;
            this.label_Patient.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Patient.ForeColor = System.Drawing.Color.White;
            this.label_Patient.Location = new System.Drawing.Point(156, 29);
            this.label_Patient.Name = "label_Patient";
            this.label_Patient.Size = new System.Drawing.Size(204, 22);
            this.label_Patient.TabIndex = 35;
            this.label_Patient.Text = "Выберите пациента:";
            // 
            // comboBox_Patient
            // 
            this.comboBox_Patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.comboBox_Patient.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBox_Patient.FormattingEnabled = true;
            this.comboBox_Patient.Location = new System.Drawing.Point(381, 32);
            this.comboBox_Patient.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Patient.Name = "comboBox_Patient";
            this.comboBox_Patient.Size = new System.Drawing.Size(208, 27);
            this.comboBox_Patient.TabIndex = 1;
            this.comboBox_Patient.SelectedValueChanged += new System.EventHandler(this.comboBox_Patient_SelectedValueChanged);
            // 
            // reportViewerRecipe
            // 
            this.reportViewerRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerRecipe.BackColor = System.Drawing.Color.Gainsboro;
            this.reportViewerRecipe.BackgroundImage = global::Medical_Examination.Properties.Resources.fuzzy_1800136_19203;
            this.reportViewerRecipe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.REPORT_RECIPEBindingSource;
            this.reportViewerRecipe.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerRecipe.LocalReport.ReportEmbeddedResource = "Medical_Examination.Report2.rdlc";
            this.reportViewerRecipe.Location = new System.Drawing.Point(2, 93);
            this.reportViewerRecipe.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewerRecipe.Name = "reportViewerRecipe";
            this.reportViewerRecipe.ServerReport.BearerToken = null;
            this.reportViewerRecipe.Size = new System.Drawing.Size(763, 473);
            this.reportViewerRecipe.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewerDiagnoz);
            this.tabPage3.Controls.Add(this.panelTop);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(764, 564);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = " Назначение/Диагноз  ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewerDiagnoz
            // 
            this.reportViewerDiagnoz.BackColor = System.Drawing.Color.Gainsboro;
            this.reportViewerDiagnoz.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource3.Name = "DataSetDIAGNOZ_REPORT";
            reportDataSource3.Value = this.REPORT_DIAGNOZBindingSource;
            this.reportViewerDiagnoz.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerDiagnoz.LocalReport.ReportEmbeddedResource = "Medical_Examination.Report3.rdlc";
            this.reportViewerDiagnoz.Location = new System.Drawing.Point(0, 87);
            this.reportViewerDiagnoz.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewerDiagnoz.Name = "reportViewerDiagnoz";
            this.reportViewerDiagnoz.ServerReport.BearerToken = null;
            this.reportViewerDiagnoz.Size = new System.Drawing.Size(764, 477);
            this.reportViewerDiagnoz.TabIndex = 3;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop.Controls.Add(this.panel_exit);
            this.panelTop.Controls.Add(this.labelDate);
            this.panelTop.Controls.Add(this.label_Patientt);
            this.panelTop.Controls.Add(this.comboBoxDate);
            this.panelTop.Controls.Add(this.comboBoxPatientt);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(764, 86);
            this.panelTop.TabIndex = 2;
            // 
            // panel_exit
            // 
            this.panel_exit.Controls.Add(this.lblExit);
            this.panel_exit.Controls.Add(this.pictureBoxExitt);
            this.panel_exit.Location = new System.Drawing.Point(615, 18);
            this.panel_exit.Margin = new System.Windows.Forms.Padding(2);
            this.panel_exit.Name = "panel_exit";
            this.panel_exit.Size = new System.Drawing.Size(134, 54);
            this.panel_exit.TabIndex = 44;
            this.panel_exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_exit_MouseClick);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(58, 13);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(69, 22);
            this.lblExit.TabIndex = 43;
            this.lblExit.Text = "Назад";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // pictureBoxExitt
            // 
            this.pictureBoxExitt.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExitt.BackgroundImage = global::Medical_Examination.Properties.Resources.logout;
            this.pictureBoxExitt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxExitt.Location = new System.Drawing.Point(10, 6);
            this.pictureBoxExitt.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxExitt.Name = "pictureBoxExitt";
            this.pictureBoxExitt.Size = new System.Drawing.Size(44, 38);
            this.pictureBoxExitt.TabIndex = 42;
            this.pictureBoxExitt.TabStop = false;
            this.pictureBoxExitt.Click += new System.EventHandler(this.pictureBoxExitt_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(214, 52);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(130, 21);
            this.labelDate.TabIndex = 37;
            this.labelDate.Text = "Выберите дату:";
            this.labelDate.Visible = false;
            // 
            // label_Patientt
            // 
            this.label_Patientt.AutoSize = true;
            this.label_Patientt.BackColor = System.Drawing.Color.Transparent;
            this.label_Patientt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Patientt.ForeColor = System.Drawing.Color.White;
            this.label_Patientt.Location = new System.Drawing.Point(214, 14);
            this.label_Patientt.Name = "label_Patientt";
            this.label_Patientt.Size = new System.Drawing.Size(174, 21);
            this.label_Patientt.TabIndex = 36;
            this.label_Patientt.Text = "Выберите пациента:";
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.comboBoxDate.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Location = new System.Drawing.Point(392, 52);
            this.comboBoxDate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.Size = new System.Drawing.Size(154, 27);
            this.comboBoxDate.TabIndex = 3;
            this.comboBoxDate.Visible = false;
            this.comboBoxDate.SelectedValueChanged += new System.EventHandler(this.comboBoxDate_SelectedValueChanged);
            // 
            // comboBoxPatientt
            // 
            this.comboBoxPatientt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.comboBoxPatientt.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.comboBoxPatientt.FormattingEnabled = true;
            this.comboBoxPatientt.Location = new System.Drawing.Point(392, 14);
            this.comboBoxPatientt.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPatientt.Name = "comboBoxPatientt";
            this.comboBoxPatientt.Size = new System.Drawing.Size(154, 27);
            this.comboBoxPatientt.TabIndex = 1;
            this.comboBoxPatientt.SelectedValueChanged += new System.EventHandler(this.comboBoxPatientt_SelectedValueChanged);
            // 
            // REPORT_RECIPETableAdapter
            // 
            this.REPORT_RECIPETableAdapter.ClearBeforeFill = true;
            // 
            // REPORT_DIAGNOZTableAdapter
            // 
            this.REPORT_DIAGNOZTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 596);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(772, 596);
            this.MinimumSize = new System.Drawing.Size(772, 596);
            this.Name = "report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёты";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetPatientsAgeReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DispanserizatsiaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_RECIPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DispanserizatsiaDataSetRECIPEREPORT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_DIAGNOZBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DispanserizatsiaDataSetREPORT_DIAGNOZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DispanserizatsiaDataSet)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackImg)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelExit.ResumeLayout(false);
            this.panelExit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel_exit.ResumeLayout(false);
            this.panel_exit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExitt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_Age;
        private System.Windows.Forms.BindingSource PriemBindingSource;
        private DispanserizatsiaDataSet DispanserizatsiaDataSet;
        private DispanserizatsiaDataSetTableAdapters.PriemTableAdapter PriemTableAdapter;
        private System.Windows.Forms.BindingSource GetPatientsAgeReportBindingSource;
        private DispanserizatsiaDataSet1 DispanserizatsiaDataSet1;
        private DispanserizatsiaDataSet1TableAdapters.GetPatientsAgeReportTableAdapter GetPatientsAgeReportTableAdapter;
        private DispanserizatsiaDataSet1TableAdapters.GetPatientsAgeReportTableAdapter getPatientsAgeReportTableAdapter1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerRecipe;
        private System.Windows.Forms.BindingSource REPORT_RECIPEBindingSource;
        private DispanserizatsiaDataSetRECIPEREPORT DispanserizatsiaDataSetRECIPEREPORT;
        private DispanserizatsiaDataSetRECIPEREPORTTableAdapters.REPORT_RECIPETableAdapter REPORT_RECIPETableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_Patient;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDiagnoz;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ComboBox comboBoxPatientt;
        private System.Windows.Forms.BindingSource REPORT_DIAGNOZBindingSource;
        private DispanserizatsiaDataSetREPORT_DIAGNOZ DispanserizatsiaDataSetREPORT_DIAGNOZ;
        private DispanserizatsiaDataSetREPORT_DIAGNOZTableAdapters.REPORT_DIAGNOZTableAdapter REPORT_DIAGNOZTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.Label label_Patient;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label_Patientt;
        private System.Windows.Forms.Panel panel_exit;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox pictureBoxExitt;
        private System.Windows.Forms.Panel panelExit;
        private System.Windows.Forms.Label label_Exit;
        private System.Windows.Forms.PictureBox pictureBox_exit;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Label BackBtn;
        private System.Windows.Forms.PictureBox BackImg;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
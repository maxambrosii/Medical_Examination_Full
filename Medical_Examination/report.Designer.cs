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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PriemTableAdapter = new Medical_Examination.DispanserizatsiaDataSetTableAdapters.PriemTableAdapter();
            this.GetPatientsAgeReportTableAdapter = new Medical_Examination.DispanserizatsiaDataSet1TableAdapters.GetPatientsAgeReportTableAdapter();
            this.getPatientsAgeReportTableAdapter1 = new Medical_Examination.DispanserizatsiaDataSet1TableAdapters.GetPatientsAgeReportTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
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
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Silver;
            this.reportViewer1.BackgroundImage = global::Medical_Examination.Properties.Resources.fuzzy_1800136_19203;
            this.reportViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Top;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GetPatientsAgeReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Medical_Examination.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1016, 597);
            this.reportViewer1.TabIndex = 0;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1030, 733);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1022, 699);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " Возрастные категории  ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(809, 625);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(179, 66);
            this.panel5.TabIndex = 45;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(78, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 30);
            this.label5.TabIndex = 43;
            this.label5.Text = "Назад";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Medical_Examination.Properties.Resources.logout;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(13, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 47);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1022, 699);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " Рецепт  ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Medical_Examination.Properties.Resources.fuzzy_1800136_19203;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 106);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(822, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 66);
            this.panel4.TabIndex = 45;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 30);
            this.label3.TabIndex = 43;
            this.label3.Text = "Назад";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Medical_Examination.Properties.Resources.logout;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 47);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(208, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 30);
            this.label4.TabIndex = 35;
            this.label4.Text = "Выберите пациента:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(508, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(276, 29);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer2.BackColor = System.Drawing.Color.Gainsboro;
            this.reportViewer2.BackgroundImage = global::Medical_Examination.Properties.Resources.fuzzy_1800136_19203;
            this.reportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.REPORT_RECIPEBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Medical_Examination.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 115);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1016, 581);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1022, 699);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = " Назначение/Диагноз  ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.BackColor = System.Drawing.Color.Gainsboro;
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource3.Name = "DataSetDIAGNOZ_REPORT";
            reportDataSource3.Value = this.REPORT_DIAGNOZBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Medical_Examination.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 112);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1022, 587);
            this.reportViewer3.TabIndex = 3;
            this.reportViewer3.Load += new System.EventHandler(this.reportViewer3_Load);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Medical_Examination.Properties.Resources.fuzzy_1800136_19203;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 106);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Location = new System.Drawing.Point(820, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 66);
            this.panel3.TabIndex = 44;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(78, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 30);
            this.label10.TabIndex = 43;
            this.label10.Text = "Назад";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::Medical_Examination.Properties.Resources.logout;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(13, 8);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(59, 47);
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(285, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Выберите дату:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(285, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Выберите пациента:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(522, 64);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(204, 29);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.Visible = false;
            this.comboBox3.SelectedValueChanged += new System.EventHandler(this.comboBox3_SelectedValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(522, 17);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(204, 29);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 733);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1030, 733);
            this.MinimumSize = new System.Drawing.Size(1030, 733);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PriemBindingSource;
        private DispanserizatsiaDataSet DispanserizatsiaDataSet;
        private DispanserizatsiaDataSetTableAdapters.PriemTableAdapter PriemTableAdapter;
        private System.Windows.Forms.BindingSource GetPatientsAgeReportBindingSource;
        private DispanserizatsiaDataSet1 DispanserizatsiaDataSet1;
        private DispanserizatsiaDataSet1TableAdapters.GetPatientsAgeReportTableAdapter GetPatientsAgeReportTableAdapter;
        private DispanserizatsiaDataSet1TableAdapters.GetPatientsAgeReportTableAdapter getPatientsAgeReportTableAdapter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource REPORT_RECIPEBindingSource;
        private DispanserizatsiaDataSetRECIPEREPORT DispanserizatsiaDataSetRECIPEREPORT;
        private DispanserizatsiaDataSetRECIPEREPORTTableAdapters.REPORT_RECIPETableAdapter REPORT_RECIPETableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource REPORT_DIAGNOZBindingSource;
        private DispanserizatsiaDataSetREPORT_DIAGNOZ DispanserizatsiaDataSetREPORT_DIAGNOZ;
        private DispanserizatsiaDataSetREPORT_DIAGNOZTableAdapters.REPORT_DIAGNOZTableAdapter REPORT_DIAGNOZTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
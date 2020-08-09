namespace Medical_Examination
{
    partial class ScanGetDoctorAndCountOfPatientWithUserDiagnosisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanGetDoctorAndCountOfPatientWithUserDiagnosisForm));
            this.dataGridView_Patients = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_diagnoz = new System.Windows.Forms.ComboBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxShowImg = new System.Windows.Forms.PictureBox();
            this.labelLine = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Diagnoz = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Patients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowImg)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Patients
            // 
            this.dataGridView_Patients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.dataGridView_Patients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Patients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView_Patients.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Patients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Patients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Patients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Patients.Location = new System.Drawing.Point(12, 117);
            this.dataGridView_Patients.Name = "dataGridView_Patients";
            this.dataGridView_Patients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_Patients.Size = new System.Drawing.Size(644, 293);
            this.dataGridView_Patients.TabIndex = 27;
            this.dataGridView_Patients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Patients_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ФИО Врача";
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Количество пациентов";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // comboBox_diagnoz
            // 
            this.comboBox_diagnoz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.comboBox_diagnoz.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox_diagnoz.FormattingEnabled = true;
            this.comboBox_diagnoz.Location = new System.Drawing.Point(356, 78);
            this.comboBox_diagnoz.Name = "comboBox_diagnoz";
            this.comboBox_diagnoz.Size = new System.Drawing.Size(200, 21);
            this.comboBox_diagnoz.TabIndex = 31;
            this.comboBox_diagnoz.SelectedIndexChanged += new System.EventHandler(this.comboBox_diagnoz_SelectedIndexChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(189, 1);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(359, 48);
            this.labelTitle.TabIndex = 69;
            this.labelTitle.Text = "   Количество пациентов у врача \r     по определенному диагнозу";
            // 
            // pictureBoxShowImg
            // 
            this.pictureBoxShowImg.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShowImg.BackgroundImage = global::Medical_Examination.Properties.Resources._262540;
            this.pictureBoxShowImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxShowImg.Location = new System.Drawing.Point(12, 1);
            this.pictureBoxShowImg.Name = "pictureBoxShowImg";
            this.pictureBoxShowImg.Size = new System.Drawing.Size(77, 72);
            this.pictureBoxShowImg.TabIndex = 71;
            this.pictureBoxShowImg.TabStop = false;
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.BackColor = System.Drawing.Color.Transparent;
            this.labelLine.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLine.ForeColor = System.Drawing.Color.White;
            this.labelLine.Location = new System.Drawing.Point(106, 34);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(516, 24);
            this.labelLine.TabIndex = 70;
            this.labelLine.Text = "______________________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(150, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(392, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 67;
            // 
            // lbl_Diagnoz
            // 
            this.lbl_Diagnoz.AutoSize = true;
            this.lbl_Diagnoz.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Diagnoz.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Diagnoz.ForeColor = System.Drawing.Color.White;
            this.lbl_Diagnoz.Location = new System.Drawing.Point(166, 76);
            this.lbl_Diagnoz.Name = "lbl_Diagnoz";
            this.lbl_Diagnoz.Size = new System.Drawing.Size(188, 22);
            this.lbl_Diagnoz.TabIndex = 72;
            this.lbl_Diagnoz.Text = "Выберите диагноз:";
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Transparent;
            this.buttonReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonReturn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReturn.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.buttonReturn.ForeColor = System.Drawing.Color.White;
            this.buttonReturn.Location = new System.Drawing.Point(430, 420);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(126, 43);
            this.buttonReturn.TabIndex = 73;
            this.buttonReturn.Text = "Вернуться";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // ScanGetDoctorAndCountOfPatientWithUserDiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 477);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.lbl_Diagnoz);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxShowImg);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_diagnoz);
            this.Controls.Add(this.dataGridView_Patients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScanGetDoctorAndCountOfPatientWithUserDiagnosisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanGetDoctorAndCountOfPatientWithUserDiagnosis";
            this.Load += new System.EventHandler(this.ScanGetDoctorAndCountOfPatientWithUserDiagnosis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Patients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Patients;
        private System.Windows.Forms.ComboBox comboBox_diagnoz;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxShowImg;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Diagnoz;
        private System.Windows.Forms.Button buttonReturn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
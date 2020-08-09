namespace Medical_Examination
{
    partial class ScanGetCountPacientByAreaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanGetCountPacientByAreaForm));
            this.dataGridView_Patients = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_Area = new System.Windows.Forms.ComboBox();
            this.pictureBoxShowImg = new System.Windows.Forms.PictureBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Return = new System.Windows.Forms.Button();
            this.label_Area = new System.Windows.Forms.Label();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Patients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Patients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Patients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Patients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.dataGridView_Patients.Location = new System.Drawing.Point(12, 117);
            this.dataGridView_Patients.Name = "dataGridView_Patients";
            this.dataGridView_Patients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Patients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Patients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_Patients.Size = new System.Drawing.Size(644, 293);
            this.dataGridView_Patients.TabIndex = 32;
            this.dataGridView_Patients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Patients_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя Пациента";
            this.Column1.Name = "Column1";
            this.Column1.Width = 600;
            // 
            // comboBox_Area
            // 
            this.comboBox_Area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.comboBox_Area.FormattingEnabled = true;
            this.comboBox_Area.Location = new System.Drawing.Point(341, 82);
            this.comboBox_Area.Name = "comboBox_Area";
            this.comboBox_Area.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Area.TabIndex = 35;
            this.comboBox_Area.SelectedIndexChanged += new System.EventHandler(this.comboBox_Area_SelectedIndexChanged);
            // 
            // pictureBoxShowImg
            // 
            this.pictureBoxShowImg.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShowImg.BackgroundImage = global::Medical_Examination.Properties.Resources._262540;
            this.pictureBoxShowImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxShowImg.Location = new System.Drawing.Point(12, 3);
            this.pictureBoxShowImg.Name = "pictureBoxShowImg";
            this.pictureBoxShowImg.Size = new System.Drawing.Size(77, 72);
            this.pictureBoxShowImg.TabIndex = 40;
            this.pictureBoxShowImg.TabStop = false;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.BackColor = System.Drawing.Color.Transparent;
            this.lblLine.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLine.ForeColor = System.Drawing.Color.White;
            this.lblLine.Location = new System.Drawing.Point(95, 28);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(560, 24);
            this.lblLine.TabIndex = 39;
            this.lblLine.Text = "__________________________________________________";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(130, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(398, 24);
            this.lblTitle.TabIndex = 38;
            this.lblTitle.Text = "Пациенты с определенного участка";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(150, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(316, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 36;
            // 
            // button_Return
            // 
            this.button_Return.BackColor = System.Drawing.Color.Transparent;
            this.button_Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Return.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_Return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Return.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.button_Return.ForeColor = System.Drawing.Color.White;
            this.button_Return.Location = new System.Drawing.Point(430, 420);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(126, 43);
            this.button_Return.TabIndex = 52;
            this.button_Return.Text = "Вернуться";
            this.button_Return.UseVisualStyleBackColor = false;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // label_Area
            // 
            this.label_Area.AutoSize = true;
            this.label_Area.BackColor = System.Drawing.Color.Transparent;
            this.label_Area.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Area.ForeColor = System.Drawing.Color.White;
            this.label_Area.Location = new System.Drawing.Point(147, 78);
            this.label_Area.Name = "label_Area";
            this.label_Area.Size = new System.Drawing.Size(187, 22);
            this.label_Area.TabIndex = 53;
            this.label_Area.Text = "Выберите участок:";
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // ScanGetCountPacientByAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 477);
            this.Controls.Add(this.label_Area);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.pictureBoxShowImg);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Area);
            this.Controls.Add(this.dataGridView_Patients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScanGetCountPacientByAreaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanGetCountPacientByAreaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScanGetCountPacientByAreaForm_FormClosing);
            this.Load += new System.EventHandler(this.ScanGetCountPacientByAreaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Patients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Patients;
        private System.Windows.Forms.ComboBox comboBox_Area;
        private System.Windows.Forms.PictureBox pictureBoxShowImg;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.Label label_Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
    }
}
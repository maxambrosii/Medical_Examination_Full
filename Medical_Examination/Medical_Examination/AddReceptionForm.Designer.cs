namespace Medical_Examination
{
    partial class AddReceptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReceptionForm));
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Time_P = new System.Windows.Forms.Label();
            this.lbl_Date_P = new System.Windows.Forms.Label();
            this.lbl_Diagnoz = new System.Windows.Forms.Label();
            this.lbl_Doctor = new System.Windows.Forms.Label();
            this.lbl_patient = new System.Windows.Forms.Label();
            this.comboBox_Patient = new System.Windows.Forms.ComboBox();
            this.comboBox_Doctor = new System.Windows.Forms.ComboBox();
            this.comboBox_Diagnoz = new System.Windows.Forms.ComboBox();
            this.dTP_Date_P = new System.Windows.Forms.DateTimePicker();
            this.lbl_Recipe = new System.Windows.Forms.Label();
            this.buttonAddRecipe = new System.Windows.Forms.Button();
            this.pictureBoxAddImg = new System.Windows.Forms.PictureBox();
            this.lblSuccesfullyAdded = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dTP_Time_P = new System.Windows.Forms.DateTimePicker();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(339, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 23;
            this.label6.Visible = false;
            // 
            // lbl_Time_P
            // 
            this.lbl_Time_P.AutoSize = true;
            this.lbl_Time_P.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Time_P.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Time_P.ForeColor = System.Drawing.Color.White;
            this.lbl_Time_P.Location = new System.Drawing.Point(53, 301);
            this.lbl_Time_P.Name = "lbl_Time_P";
            this.lbl_Time_P.Size = new System.Drawing.Size(255, 22);
            this.lbl_Time_P.TabIndex = 22;
            this.lbl_Time_P.Text = "Выберите время приема:";
            this.lbl_Time_P.Visible = false;
            // 
            // lbl_Date_P
            // 
            this.lbl_Date_P.AutoSize = true;
            this.lbl_Date_P.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date_P.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Date_P.ForeColor = System.Drawing.Color.White;
            this.lbl_Date_P.Location = new System.Drawing.Point(69, 260);
            this.lbl_Date_P.Name = "lbl_Date_P";
            this.lbl_Date_P.Size = new System.Drawing.Size(239, 22);
            this.lbl_Date_P.TabIndex = 20;
            this.lbl_Date_P.Text = "Выберите дату приема:";
            this.lbl_Date_P.Visible = false;
            // 
            // lbl_Diagnoz
            // 
            this.lbl_Diagnoz.AutoSize = true;
            this.lbl_Diagnoz.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Diagnoz.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Diagnoz.ForeColor = System.Drawing.Color.White;
            this.lbl_Diagnoz.Location = new System.Drawing.Point(120, 219);
            this.lbl_Diagnoz.Name = "lbl_Diagnoz";
            this.lbl_Diagnoz.Size = new System.Drawing.Size(188, 22);
            this.lbl_Diagnoz.TabIndex = 18;
            this.lbl_Diagnoz.Text = "Выберите диагноз:\r\n";
            this.lbl_Diagnoz.Visible = false;
            // 
            // lbl_Doctor
            // 
            this.lbl_Doctor.AutoSize = true;
            this.lbl_Doctor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Doctor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Doctor.ForeColor = System.Drawing.Color.White;
            this.lbl_Doctor.Location = new System.Drawing.Point(138, 177);
            this.lbl_Doctor.Name = "lbl_Doctor";
            this.lbl_Doctor.Size = new System.Drawing.Size(170, 22);
            this.lbl_Doctor.TabIndex = 16;
            this.lbl_Doctor.Text = "Выберите врача:\r\n";
            this.lbl_Doctor.Visible = false;
            // 
            // lbl_patient
            // 
            this.lbl_patient.AutoSize = true;
            this.lbl_patient.BackColor = System.Drawing.Color.Transparent;
            this.lbl_patient.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_patient.ForeColor = System.Drawing.Color.White;
            this.lbl_patient.Location = new System.Drawing.Point(104, 138);
            this.lbl_patient.Name = "lbl_patient";
            this.lbl_patient.Size = new System.Drawing.Size(204, 22);
            this.lbl_patient.TabIndex = 14;
            this.lbl_patient.Text = "Выберите пациента:";
            // 
            // comboBox_Patient
            // 
            this.comboBox_Patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.comboBox_Patient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBox_Patient.FormattingEnabled = true;
            this.comboBox_Patient.Location = new System.Drawing.Point(334, 141);
            this.comboBox_Patient.Name = "comboBox_Patient";
            this.comboBox_Patient.Size = new System.Drawing.Size(178, 21);
            this.comboBox_Patient.TabIndex = 26;
            this.comboBox_Patient.SelectedIndexChanged += new System.EventHandler(this.comboBox_Patient_SelectedIndexChanged);
            this.comboBox_Patient.Click += new System.EventHandler(this.comboBox_Patient_Click);
            this.comboBox_Patient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_Patient_KeyDown);
            // 
            // comboBox_Doctor
            // 
            this.comboBox_Doctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.comboBox_Doctor.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox_Doctor.FormattingEnabled = true;
            this.comboBox_Doctor.Location = new System.Drawing.Point(334, 180);
            this.comboBox_Doctor.Name = "comboBox_Doctor";
            this.comboBox_Doctor.Size = new System.Drawing.Size(178, 21);
            this.comboBox_Doctor.TabIndex = 27;
            this.comboBox_Doctor.Visible = false;
            this.comboBox_Doctor.SelectedIndexChanged += new System.EventHandler(this.comboBox_Doctor_SelectedIndexChanged);
            this.comboBox_Doctor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_Doctor_KeyDown);
            // 
            // comboBox_Diagnoz
            // 
            this.comboBox_Diagnoz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.comboBox_Diagnoz.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox_Diagnoz.FormattingEnabled = true;
            this.comboBox_Diagnoz.Location = new System.Drawing.Point(334, 221);
            this.comboBox_Diagnoz.Name = "comboBox_Diagnoz";
            this.comboBox_Diagnoz.Size = new System.Drawing.Size(178, 21);
            this.comboBox_Diagnoz.TabIndex = 28;
            this.comboBox_Diagnoz.Visible = false;
            this.comboBox_Diagnoz.SelectedIndexChanged += new System.EventHandler(this.comboBox_Diagnoz_SelectedIndexChanged);
            this.comboBox_Diagnoz.Click += new System.EventHandler(this.comboBox_Diagnoz_Click);
            this.comboBox_Diagnoz.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_Diagnoz_KeyDown);
            // 
            // dTP_Date_P
            // 
            this.dTP_Date_P.CustomFormat = "dd.MM.yyyy";
            this.dTP_Date_P.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_Date_P.Location = new System.Drawing.Point(334, 262);
            this.dTP_Date_P.Name = "dTP_Date_P";
            this.dTP_Date_P.Size = new System.Drawing.Size(178, 20);
            this.dTP_Date_P.TabIndex = 29;
            this.dTP_Date_P.Visible = false;
            this.dTP_Date_P.ValueChanged += new System.EventHandler(this.dTP_Date_P_ValueChanged);
            this.dTP_Date_P.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dTP_Date_P_KeyDown);
            // 
            // lbl_Recipe
            // 
            this.lbl_Recipe.AutoSize = true;
            this.lbl_Recipe.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Recipe.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Recipe.ForeColor = System.Drawing.Color.White;
            this.lbl_Recipe.Location = new System.Drawing.Point(132, 342);
            this.lbl_Recipe.Name = "lbl_Recipe";
            this.lbl_Recipe.Size = new System.Drawing.Size(176, 22);
            this.lbl_Recipe.TabIndex = 31;
            this.lbl_Recipe.Text = "Добавьте рецепт:";
            this.lbl_Recipe.Visible = false;
            // 
            // buttonAddRecipe
            // 
            this.buttonAddRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddRecipe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddRecipe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddRecipe.Image = global::Medical_Examination.Properties.Resources._123;
            this.buttonAddRecipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddRecipe.Location = new System.Drawing.Point(334, 343);
            this.buttonAddRecipe.Name = "buttonAddRecipe";
            this.buttonAddRecipe.Size = new System.Drawing.Size(178, 23);
            this.buttonAddRecipe.TabIndex = 32;
            this.buttonAddRecipe.Text = "Добавить рецепт";
            this.buttonAddRecipe.UseVisualStyleBackColor = true;
            this.buttonAddRecipe.Visible = false;
            this.buttonAddRecipe.Click += new System.EventHandler(this.buttonAddRecipe_Click);
            this.buttonAddRecipe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonAddRecipe_KeyDown);
            // 
            // pictureBoxAddImg
            // 
            this.pictureBoxAddImg.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAddImg.BackgroundImage = global::Medical_Examination.Properties.Resources.add_1_icon;
            this.pictureBoxAddImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAddImg.Location = new System.Drawing.Point(10, 11);
            this.pictureBoxAddImg.Name = "pictureBoxAddImg";
            this.pictureBoxAddImg.Size = new System.Drawing.Size(77, 72);
            this.pictureBoxAddImg.TabIndex = 38;
            this.pictureBoxAddImg.TabStop = false;
            // 
            // lblSuccesfullyAdded
            // 
            this.lblSuccesfullyAdded.AutoSize = true;
            this.lblSuccesfullyAdded.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccesfullyAdded.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSuccesfullyAdded.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblSuccesfullyAdded.Location = new System.Drawing.Point(182, 89);
            this.lblSuccesfullyAdded.Name = "lblSuccesfullyAdded";
            this.lblSuccesfullyAdded.Size = new System.Drawing.Size(282, 23);
            this.lblSuccesfullyAdded.TabIndex = 37;
            this.lblSuccesfullyAdded.Text = "Вы успешно внесли данные!";
            this.lblSuccesfullyAdded.Visible = false;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.BackColor = System.Drawing.Color.Transparent;
            this.lblLine.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLine.ForeColor = System.Drawing.Color.White;
            this.lblLine.Location = new System.Drawing.Point(93, 35);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(483, 24);
            this.lblLine.TabIndex = 36;
            this.lblLine.Text = "___________________________________________";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(100, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(486, 24);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Добавление информации о новом приёме";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(148, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(194, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 33;
            // 
            // dTP_Time_P
            // 
            this.dTP_Time_P.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTP_Time_P.Location = new System.Drawing.Point(334, 303);
            this.dTP_Time_P.Name = "dTP_Time_P";
            this.dTP_Time_P.ShowUpDown = true;
            this.dTP_Time_P.Size = new System.Drawing.Size(178, 20);
            this.dTP_Time_P.TabIndex = 30;
            this.dTP_Time_P.Visible = false;
            this.dTP_Time_P.ValueChanged += new System.EventHandler(this.dTP_Time_P_ValueChanged);
            this.dTP_Time_P.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dTP_Time_P_KeyDown);
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
            this.buttonReturn.Location = new System.Drawing.Point(374, 392);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(130, 43);
            this.buttonReturn.TabIndex = 57;
            this.buttonReturn.Text = "Вернуться";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(115, 392);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 43);
            this.buttonAdd.TabIndex = 56;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // AddReceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 472);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.pictureBoxAddImg);
            this.Controls.Add(this.lblSuccesfullyAdded);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonAddRecipe);
            this.Controls.Add(this.lbl_Recipe);
            this.Controls.Add(this.dTP_Time_P);
            this.Controls.Add(this.dTP_Date_P);
            this.Controls.Add(this.comboBox_Diagnoz);
            this.Controls.Add(this.comboBox_Doctor);
            this.Controls.Add(this.comboBox_Patient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Time_P);
            this.Controls.Add(this.lbl_Date_P);
            this.Controls.Add(this.lbl_Diagnoz);
            this.Controls.Add(this.lbl_Doctor);
            this.Controls.Add(this.lbl_patient);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddReceptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddReceptionForm_FormClosing);
            this.Load += new System.EventHandler(this.AddReceptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Time_P;
        private System.Windows.Forms.Label lbl_Date_P;
        private System.Windows.Forms.Label lbl_Diagnoz;
        private System.Windows.Forms.Label lbl_Doctor;
        private System.Windows.Forms.Label lbl_patient;
        private System.Windows.Forms.ComboBox comboBox_Patient;
        private System.Windows.Forms.ComboBox comboBox_Doctor;
        private System.Windows.Forms.ComboBox comboBox_Diagnoz;
        private System.Windows.Forms.DateTimePicker dTP_Date_P;
        private System.Windows.Forms.Label lbl_Recipe;
        private System.Windows.Forms.Button buttonAddRecipe;
        private System.Windows.Forms.PictureBox pictureBoxAddImg;
        private System.Windows.Forms.Label lblSuccesfullyAdded;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dTP_Time_P;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonAdd;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
    }
}
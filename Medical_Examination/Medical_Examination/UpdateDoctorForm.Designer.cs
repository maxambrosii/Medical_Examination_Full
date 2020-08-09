namespace Medical_Examination
{
    partial class UpdateDoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDoctorForm));
            this.label_Doctor = new System.Windows.Forms.Label();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.checkBox_N_cabinet = new System.Windows.Forms.CheckBox();
            this.checkBox_N_Area = new System.Windows.Forms.CheckBox();
            this.pictureBoxUpdate = new System.Windows.Forms.PictureBox();
            this.labelLine = new System.Windows.Forms.Label();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelSuccesfullyUpdate = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxArea = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBox_N_Cabinet = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Doctor
            // 
            this.label_Doctor.AutoSize = true;
            this.label_Doctor.BackColor = System.Drawing.Color.Transparent;
            this.label_Doctor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Doctor.ForeColor = System.Drawing.Color.White;
            this.label_Doctor.Location = new System.Drawing.Point(98, 135);
            this.label_Doctor.Name = "label_Doctor";
            this.label_Doctor.Size = new System.Drawing.Size(170, 22);
            this.label_Doctor.TabIndex = 9;
            this.label_Doctor.Text = "Выберите врача:";
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.comboBoxDoctor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(276, 138);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(226, 21);
            this.comboBoxDoctor.TabIndex = 18;
            // 
            // checkBox_N_cabinet
            // 
            this.checkBox_N_cabinet.AutoSize = true;
            this.checkBox_N_cabinet.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_N_cabinet.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_N_cabinet.ForeColor = System.Drawing.Color.White;
            this.checkBox_N_cabinet.Location = new System.Drawing.Point(24, 229);
            this.checkBox_N_cabinet.Name = "checkBox_N_cabinet";
            this.checkBox_N_cabinet.Size = new System.Drawing.Size(246, 26);
            this.checkBox_N_cabinet.TabIndex = 32;
            this.checkBox_N_cabinet.Text = "Изменить № кабинета:";
            this.checkBox_N_cabinet.UseVisualStyleBackColor = false;
            this.checkBox_N_cabinet.CheckedChanged += new System.EventHandler(this.checkBox_N_cabinet_CheckedChanged);
            // 
            // checkBox_N_Area
            // 
            this.checkBox_N_Area.AutoSize = true;
            this.checkBox_N_Area.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_N_Area.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_N_Area.ForeColor = System.Drawing.Color.White;
            this.checkBox_N_Area.Location = new System.Drawing.Point(24, 180);
            this.checkBox_N_Area.Name = "checkBox_N_Area";
            this.checkBox_N_Area.Size = new System.Drawing.Size(230, 26);
            this.checkBox_N_Area.TabIndex = 31;
            this.checkBox_N_Area.Text = "Изменить № участка:";
            this.checkBox_N_Area.UseVisualStyleBackColor = false;
            this.checkBox_N_Area.CheckedChanged += new System.EventHandler(this.checkBox_N_Area_CheckedChanged);
            // 
            // pictureBoxUpdate
            // 
            this.pictureBoxUpdate.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUpdate.BackgroundImage = global::Medical_Examination.Properties.Resources.View_refresh_Gion_simple_svg;
            this.pictureBoxUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUpdate.Location = new System.Drawing.Point(10, 7);
            this.pictureBoxUpdate.Name = "pictureBoxUpdate";
            this.pictureBoxUpdate.Size = new System.Drawing.Size(77, 72);
            this.pictureBoxUpdate.TabIndex = 46;
            this.pictureBoxUpdate.TabStop = false;
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.BackColor = System.Drawing.Color.Transparent;
            this.labelLine.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLine.ForeColor = System.Drawing.Color.White;
            this.labelLine.Location = new System.Drawing.Point(101, 34);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(417, 24);
            this.labelLine.TabIndex = 45;
            this.labelLine.Text = "_____________________________________";
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.BackColor = System.Drawing.Color.Transparent;
            this.labelDoctor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDoctor.ForeColor = System.Drawing.Color.White;
            this.labelDoctor.Location = new System.Drawing.Point(101, 7);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(377, 24);
            this.labelDoctor.TabIndex = 44;
            this.labelDoctor.Text = "Изменение информации о враче";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(148, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 43;
            // 
            // labelSuccesfullyUpdate
            // 
            this.labelSuccesfullyUpdate.AutoSize = true;
            this.labelSuccesfullyUpdate.BackColor = System.Drawing.Color.Transparent;
            this.labelSuccesfullyUpdate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSuccesfullyUpdate.ForeColor = System.Drawing.Color.Lime;
            this.labelSuccesfullyUpdate.Location = new System.Drawing.Point(134, 80);
            this.labelSuccesfullyUpdate.Name = "labelSuccesfullyUpdate";
            this.labelSuccesfullyUpdate.Size = new System.Drawing.Size(299, 22);
            this.labelSuccesfullyUpdate.TabIndex = 47;
            this.labelSuccesfullyUpdate.Text = "Вы успешно обновили данные";
            this.labelSuccesfullyUpdate.Visible = false;
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
            this.buttonReturn.Location = new System.Drawing.Point(307, 295);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(149, 43);
            this.buttonReturn.TabIndex = 49;
            this.buttonReturn.Text = "Вернуться";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(82, 295);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(149, 43);
            this.buttonUpdate.TabIndex = 48;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxArea
            // 
            this.textBoxArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.textBoxArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textBoxArea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxArea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxArea.ForeColor = System.Drawing.Color.White;
            this.textBoxArea.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxArea.HintText = "";
            this.textBoxArea.isPassword = false;
            this.textBoxArea.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBoxArea.LineIdleColor = System.Drawing.Color.Black;
            this.textBoxArea.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBoxArea.LineThickness = 3;
            this.textBoxArea.Location = new System.Drawing.Point(276, 174);
            this.textBoxArea.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(225, 32);
            this.textBoxArea.TabIndex = 50;
            this.textBoxArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxArea_KeyPress);
            // 
            // textBox_N_Cabinet
            // 
            this.textBox_N_Cabinet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.textBox_N_Cabinet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textBox_N_Cabinet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_N_Cabinet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_N_Cabinet.ForeColor = System.Drawing.Color.White;
            this.textBox_N_Cabinet.HintForeColor = System.Drawing.Color.Empty;
            this.textBox_N_Cabinet.HintText = "";
            this.textBox_N_Cabinet.isPassword = false;
            this.textBox_N_Cabinet.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBox_N_Cabinet.LineIdleColor = System.Drawing.Color.Black;
            this.textBox_N_Cabinet.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBox_N_Cabinet.LineThickness = 3;
            this.textBox_N_Cabinet.Location = new System.Drawing.Point(276, 223);
            this.textBox_N_Cabinet.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox_N_Cabinet.Name = "textBox_N_Cabinet";
            this.textBox_N_Cabinet.Size = new System.Drawing.Size(225, 32);
            this.textBox_N_Cabinet.TabIndex = 51;
            this.textBox_N_Cabinet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_N_Cabinet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_N_Cabinet_KeyPress);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // UpdateDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 363);
            this.Controls.Add(this.textBox_N_Cabinet);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelSuccesfullyUpdate);
            this.Controls.Add(this.pictureBoxUpdate);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.labelDoctor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox_N_cabinet);
            this.Controls.Add(this.checkBox_N_Area);
            this.Controls.Add(this.comboBoxDoctor);
            this.Controls.Add(this.label_Doctor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateDoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateDoctorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateDoctorForm_FormClosing);
            this.Load += new System.EventHandler(this.UpdateDoctorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Doctor;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.CheckBox checkBox_N_cabinet;
        private System.Windows.Forms.CheckBox checkBox_N_Area;
        private System.Windows.Forms.PictureBox pictureBoxUpdate;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelSuccesfullyUpdate;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonUpdate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxArea;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox_N_Cabinet;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
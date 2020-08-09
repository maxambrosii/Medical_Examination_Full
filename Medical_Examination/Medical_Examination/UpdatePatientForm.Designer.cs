namespace Medical_Examination
{
    partial class UpdatePatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePatientForm));
            this.labelPatient = new System.Windows.Forms.Label();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.checkBoxAdress = new System.Windows.Forms.CheckBox();
            this.checkBoxN_belay = new System.Windows.Forms.CheckBox();
            this.checkBox_N_Area = new System.Windows.Forms.CheckBox();
            this.labelSuccesfullyUpdate = new System.Windows.Forms.Label();
            this.pictureBoxShowImg = new System.Windows.Forms.PictureBox();
            this.labelLine = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxAdress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxBelay = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBox_N_Area = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelIDNP = new System.Windows.Forms.Label();
            this.label_N_Area = new System.Windows.Forms.Label();
            this.labelN_Belay = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowImg)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.BackColor = System.Drawing.Color.Transparent;
            this.labelPatient.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatient.ForeColor = System.Drawing.Color.White;
            this.labelPatient.Location = new System.Drawing.Point(37, 138);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(204, 22);
            this.labelPatient.TabIndex = 14;
            this.labelPatient.Text = "Выберите пациента:";
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.comboBoxPatient.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(274, 141);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(226, 21);
            this.comboBoxPatient.TabIndex = 26;
            this.comboBoxPatient.SelectedIndexChanged += new System.EventHandler(this.comboBoxPatient_SelectedIndexChanged);
            // 
            // checkBoxAdress
            // 
            this.checkBoxAdress.AutoSize = true;
            this.checkBoxAdress.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdress.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAdress.ForeColor = System.Drawing.Color.White;
            this.checkBoxAdress.Location = new System.Drawing.Point(25, 177);
            this.checkBoxAdress.Name = "checkBoxAdress";
            this.checkBoxAdress.Size = new System.Drawing.Size(191, 26);
            this.checkBoxAdress.TabIndex = 27;
            this.checkBoxAdress.Text = "Изменить адрес:";
            this.checkBoxAdress.UseVisualStyleBackColor = false;
            this.checkBoxAdress.CheckedChanged += new System.EventHandler(this.checkBoxAdress_CheckedChanged);
            // 
            // checkBoxN_belay
            // 
            this.checkBoxN_belay.AutoSize = true;
            this.checkBoxN_belay.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxN_belay.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxN_belay.ForeColor = System.Drawing.Color.White;
            this.checkBoxN_belay.Location = new System.Drawing.Point(25, 222);
            this.checkBoxN_belay.Name = "checkBoxN_belay";
            this.checkBoxN_belay.Size = new System.Drawing.Size(252, 26);
            this.checkBoxN_belay.TabIndex = 28;
            this.checkBoxN_belay.Text = "Изменить № cтраховки:";
            this.checkBoxN_belay.UseVisualStyleBackColor = false;
            this.checkBoxN_belay.CheckedChanged += new System.EventHandler(this.checkBoxN_belay_CheckedChanged);
            // 
            // checkBox_N_Area
            // 
            this.checkBox_N_Area.AutoSize = true;
            this.checkBox_N_Area.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_N_Area.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_N_Area.ForeColor = System.Drawing.Color.White;
            this.checkBox_N_Area.Location = new System.Drawing.Point(25, 266);
            this.checkBox_N_Area.Name = "checkBox_N_Area";
            this.checkBox_N_Area.Size = new System.Drawing.Size(230, 26);
            this.checkBox_N_Area.TabIndex = 29;
            this.checkBox_N_Area.Text = "Изменить № участка:";
            this.checkBox_N_Area.UseVisualStyleBackColor = false;
            this.checkBox_N_Area.CheckedChanged += new System.EventHandler(this.checkBox_N_Area_CheckedChanged);
            // 
            // labelSuccesfullyUpdate
            // 
            this.labelSuccesfullyUpdate.AutoSize = true;
            this.labelSuccesfullyUpdate.BackColor = System.Drawing.Color.Transparent;
            this.labelSuccesfullyUpdate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSuccesfullyUpdate.ForeColor = System.Drawing.Color.Lime;
            this.labelSuccesfullyUpdate.Location = new System.Drawing.Point(130, 80);
            this.labelSuccesfullyUpdate.Name = "labelSuccesfullyUpdate";
            this.labelSuccesfullyUpdate.Size = new System.Drawing.Size(299, 22);
            this.labelSuccesfullyUpdate.TabIndex = 52;
            this.labelSuccesfullyUpdate.Text = "Вы успешно обновили данные";
            this.labelSuccesfullyUpdate.Visible = false;
            // 
            // pictureBoxShowImg
            // 
            this.pictureBoxShowImg.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShowImg.BackgroundImage = global::Medical_Examination.Properties.Resources.View_refresh_Gion_simple_svg;
            this.pictureBoxShowImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxShowImg.Location = new System.Drawing.Point(6, 7);
            this.pictureBoxShowImg.Name = "pictureBoxShowImg";
            this.pictureBoxShowImg.Size = new System.Drawing.Size(77, 72);
            this.pictureBoxShowImg.TabIndex = 51;
            this.pictureBoxShowImg.TabStop = false;
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.BackColor = System.Drawing.Color.Transparent;
            this.labelLine.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLine.ForeColor = System.Drawing.Color.White;
            this.labelLine.Location = new System.Drawing.Point(98, 34);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(736, 24);
            this.labelLine.TabIndex = 50;
            this.labelLine.Text = "__________________________________________________________________";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(290, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(418, 24);
            this.labelTitle.TabIndex = 49;
            this.labelTitle.Text = "Изменение информации о пациенте";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(144, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 48;
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
            this.buttonReturn.Location = new System.Drawing.Point(331, 332);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(149, 43);
            this.buttonReturn.TabIndex = 54;
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
            this.buttonUpdate.Location = new System.Drawing.Point(102, 332);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(149, 43);
            this.buttonUpdate.TabIndex = 53;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.textBoxAdress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textBoxAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAdress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAdress.ForeColor = System.Drawing.Color.White;
            this.textBoxAdress.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxAdress.HintText = "";
            this.textBoxAdress.isPassword = false;
            this.textBoxAdress.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBoxAdress.LineIdleColor = System.Drawing.Color.Black;
            this.textBoxAdress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBoxAdress.LineThickness = 3;
            this.textBoxAdress.Location = new System.Drawing.Point(274, 173);
            this.textBoxAdress.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(225, 32);
            this.textBoxAdress.TabIndex = 55;
            this.textBoxAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxBelay
            // 
            this.textBoxBelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.textBoxBelay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textBoxBelay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxBelay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBelay.ForeColor = System.Drawing.Color.White;
            this.textBoxBelay.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxBelay.HintText = "";
            this.textBoxBelay.isPassword = false;
            this.textBoxBelay.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBoxBelay.LineIdleColor = System.Drawing.Color.Black;
            this.textBoxBelay.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBoxBelay.LineThickness = 3;
            this.textBoxBelay.Location = new System.Drawing.Point(274, 217);
            this.textBoxBelay.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxBelay.Name = "textBoxBelay";
            this.textBoxBelay.Size = new System.Drawing.Size(225, 32);
            this.textBoxBelay.TabIndex = 56;
            this.textBoxBelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxBelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBelay_KeyPress);
            // 
            // textBox_N_Area
            // 
            this.textBox_N_Area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.textBox_N_Area.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textBox_N_Area.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_N_Area.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_N_Area.ForeColor = System.Drawing.Color.White;
            this.textBox_N_Area.HintForeColor = System.Drawing.Color.Empty;
            this.textBox_N_Area.HintText = "";
            this.textBox_N_Area.isPassword = false;
            this.textBox_N_Area.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBox_N_Area.LineIdleColor = System.Drawing.Color.Black;
            this.textBox_N_Area.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBox_N_Area.LineThickness = 3;
            this.textBox_N_Area.Location = new System.Drawing.Point(274, 262);
            this.textBox_N_Area.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox_N_Area.Name = "textBox_N_Area";
            this.textBox_N_Area.Size = new System.Drawing.Size(225, 32);
            this.textBox_N_Area.TabIndex = 57;
            this.textBox_N_Area.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_N_Area.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress_1);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelInfo.Controls.Add(this.labelIDNP);
            this.panelInfo.Controls.Add(this.label_N_Area);
            this.panelInfo.Controls.Add(this.labelN_Belay);
            this.panelInfo.Controls.Add(this.labelAdress);
            this.panelInfo.Location = new System.Drawing.Point(507, 129);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(328, 195);
            this.panelInfo.TabIndex = 58;
            // 
            // labelIDNP
            // 
            this.labelIDNP.AutoSize = true;
            this.labelIDNP.BackColor = System.Drawing.Color.Transparent;
            this.labelIDNP.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIDNP.ForeColor = System.Drawing.Color.Black;
            this.labelIDNP.Location = new System.Drawing.Point(3, 15);
            this.labelIDNP.Name = "labelIDNP";
            this.labelIDNP.Size = new System.Drawing.Size(59, 22);
            this.labelIDNP.TabIndex = 63;
            this.labelIDNP.Text = "IDNP:";
            // 
            // label_N_Area
            // 
            this.label_N_Area.AutoSize = true;
            this.label_N_Area.BackColor = System.Drawing.Color.Transparent;
            this.label_N_Area.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_N_Area.ForeColor = System.Drawing.Color.Black;
            this.label_N_Area.Location = new System.Drawing.Point(3, 159);
            this.label_N_Area.Name = "label_N_Area";
            this.label_N_Area.Size = new System.Drawing.Size(116, 22);
            this.label_N_Area.TabIndex = 62;
            this.label_N_Area.Text = "№ участка:";
            // 
            // labelN_Belay
            // 
            this.labelN_Belay.AutoSize = true;
            this.labelN_Belay.BackColor = System.Drawing.Color.Transparent;
            this.labelN_Belay.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN_Belay.ForeColor = System.Drawing.Color.Black;
            this.labelN_Belay.Location = new System.Drawing.Point(3, 111);
            this.labelN_Belay.Name = "labelN_Belay";
            this.labelN_Belay.Size = new System.Drawing.Size(138, 22);
            this.labelN_Belay.TabIndex = 61;
            this.labelN_Belay.Text = "№ cтраховки:";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.BackColor = System.Drawing.Color.Transparent;
            this.labelAdress.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdress.ForeColor = System.Drawing.Color.Black;
            this.labelAdress.Location = new System.Drawing.Point(3, 63);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(79, 22);
            this.labelAdress.TabIndex = 60;
            this.labelAdress.Text = "Адрес:";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(550, 89);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(255, 22);
            this.labelInfo.TabIndex = 59;
            this.labelInfo.Text = "Информация о пациенте";
            // 
            // UpdatePatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 419);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.textBox_N_Area);
            this.Controls.Add(this.textBoxBelay);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelSuccesfullyUpdate);
            this.Controls.Add(this.pictureBoxShowImg);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox_N_Area);
            this.Controls.Add(this.checkBoxN_belay);
            this.Controls.Add(this.checkBoxAdress);
            this.Controls.Add(this.comboBoxPatient);
            this.Controls.Add(this.labelPatient);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdatePatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePatientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdatePatientForm_FormClosing);
            this.Load += new System.EventHandler(this.UpdatePatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowImg)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.CheckBox checkBoxAdress;
        private System.Windows.Forms.CheckBox checkBoxN_belay;
        private System.Windows.Forms.CheckBox checkBox_N_Area;
        private System.Windows.Forms.Label labelSuccesfullyUpdate;
        private System.Windows.Forms.PictureBox pictureBoxShowImg;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonUpdate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxAdress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxBelay;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox_N_Area;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label label_N_Area;
        private System.Windows.Forms.Label labelN_Belay;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelIDNP;
    }
}
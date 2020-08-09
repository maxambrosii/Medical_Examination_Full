namespace Medical_Examination
{
    partial class DeletePatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletePatientForm));
            this.comboBox_Patient = new System.Windows.Forms.ComboBox();
            this.button_return = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.lblSuccesfullyDeleted = new System.Windows.Forms.Label();
            this.lbl_Patient = new System.Windows.Forms.Label();
            this.pictureBoxDeleteImg = new System.Windows.Forms.PictureBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label_Info_Patient = new System.Windows.Forms.Label();
            this.panel_info = new System.Windows.Forms.Panel();
            this.lbl_IDNP = new System.Windows.Forms.Label();
            this.lbl_N_Area = new System.Windows.Forms.Label();
            this.lbl_N_Strahovki = new System.Windows.Forms.Label();
            this.lbl_Adress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeleteImg)).BeginInit();
            this.panel_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Patient
            // 
            this.comboBox_Patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.comboBox_Patient.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBox_Patient.FormattingEnabled = true;
            this.comboBox_Patient.Location = new System.Drawing.Point(299, 150);
            this.comboBox_Patient.Name = "comboBox_Patient";
            this.comboBox_Patient.Size = new System.Drawing.Size(178, 21);
            this.comboBox_Patient.TabIndex = 18;
            this.comboBox_Patient.SelectedIndexChanged += new System.EventHandler(this.comboBox_Patient_SelectedIndexChanged);
            // 
            // button_return
            // 
            this.button_return.BackColor = System.Drawing.Color.Transparent;
            this.button_return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_return.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_return.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.button_return.ForeColor = System.Drawing.Color.White;
            this.button_return.Location = new System.Drawing.Point(299, 221);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(149, 43);
            this.button_return.TabIndex = 29;
            this.button_return.Text = "Вернуться";
            this.button_return.UseVisualStyleBackColor = false;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Transparent;
            this.button_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_delete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(69, 221);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(149, 43);
            this.button_delete.TabIndex = 28;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Visible = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // lblSuccesfullyDeleted
            // 
            this.lblSuccesfullyDeleted.AutoSize = true;
            this.lblSuccesfullyDeleted.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccesfullyDeleted.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSuccesfullyDeleted.ForeColor = System.Drawing.Color.Lime;
            this.lblSuccesfullyDeleted.Location = new System.Drawing.Point(147, 90);
            this.lblSuccesfullyDeleted.Name = "lblSuccesfullyDeleted";
            this.lblSuccesfullyDeleted.Size = new System.Drawing.Size(288, 22);
            this.lblSuccesfullyDeleted.TabIndex = 30;
            this.lblSuccesfullyDeleted.Text = "Вы успешно удалили данные";
            this.lblSuccesfullyDeleted.Visible = false;
            // 
            // lbl_Patient
            // 
            this.lbl_Patient.AutoSize = true;
            this.lbl_Patient.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Patient.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Patient.ForeColor = System.Drawing.Color.White;
            this.lbl_Patient.Location = new System.Drawing.Point(77, 147);
            this.lbl_Patient.Name = "lbl_Patient";
            this.lbl_Patient.Size = new System.Drawing.Size(204, 22);
            this.lbl_Patient.TabIndex = 31;
            this.lbl_Patient.Text = "Выберите пациента:";
            // 
            // pictureBoxDeleteImg
            // 
            this.pictureBoxDeleteImg.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDeleteImg.BackgroundImage = global::Medical_Examination.Properties.Resources.w512h5121380984637delete1;
            this.pictureBoxDeleteImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDeleteImg.Location = new System.Drawing.Point(10, 11);
            this.pictureBoxDeleteImg.Name = "pictureBoxDeleteImg";
            this.pictureBoxDeleteImg.Size = new System.Drawing.Size(77, 72);
            this.pictureBoxDeleteImg.TabIndex = 46;
            this.pictureBoxDeleteImg.TabStop = false;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.BackColor = System.Drawing.Color.Transparent;
            this.lblLine.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLine.ForeColor = System.Drawing.Color.White;
            this.lblLine.Location = new System.Drawing.Point(101, 37);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(417, 24);
            this.lblLine.TabIndex = 45;
            this.lblLine.Text = "_____________________________________";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(114, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(401, 24);
            this.lblTitle.TabIndex = 44;
            this.lblTitle.Text = "Удаление информации о пациенте";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(148, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 43;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Info.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Info.ForeColor = System.Drawing.Color.White;
            this.lbl_Info.Location = new System.Drawing.Point(-2, 283);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(2714, 24);
            this.lbl_Info.TabIndex = 47;
            this.lbl_Info.Text = resources.GetString("lbl_Info.Text");
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // label_Info_Patient
            // 
            this.label_Info_Patient.AutoSize = true;
            this.label_Info_Patient.BackColor = System.Drawing.Color.Transparent;
            this.label_Info_Patient.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Info_Patient.ForeColor = System.Drawing.Color.White;
            this.label_Info_Patient.Location = new System.Drawing.Point(539, 50);
            this.label_Info_Patient.Name = "label_Info_Patient";
            this.label_Info_Patient.Size = new System.Drawing.Size(255, 22);
            this.label_Info_Patient.TabIndex = 61;
            this.label_Info_Patient.Text = "Информация о пациенте";
            // 
            // panel_info
            // 
            this.panel_info.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel_info.Controls.Add(this.lbl_IDNP);
            this.panel_info.Controls.Add(this.lbl_N_Area);
            this.panel_info.Controls.Add(this.lbl_N_Strahovki);
            this.panel_info.Controls.Add(this.lbl_Adress);
            this.panel_info.Location = new System.Drawing.Point(490, 90);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(328, 195);
            this.panel_info.TabIndex = 60;
            // 
            // lbl_IDNP
            // 
            this.lbl_IDNP.AutoSize = true;
            this.lbl_IDNP.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IDNP.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_IDNP.ForeColor = System.Drawing.Color.Black;
            this.lbl_IDNP.Location = new System.Drawing.Point(3, 15);
            this.lbl_IDNP.Name = "lbl_IDNP";
            this.lbl_IDNP.Size = new System.Drawing.Size(59, 22);
            this.lbl_IDNP.TabIndex = 63;
            this.lbl_IDNP.Text = "IDNP:";
            // 
            // lbl_N_Area
            // 
            this.lbl_N_Area.AutoSize = true;
            this.lbl_N_Area.BackColor = System.Drawing.Color.Transparent;
            this.lbl_N_Area.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_N_Area.ForeColor = System.Drawing.Color.Black;
            this.lbl_N_Area.Location = new System.Drawing.Point(3, 159);
            this.lbl_N_Area.Name = "lbl_N_Area";
            this.lbl_N_Area.Size = new System.Drawing.Size(116, 22);
            this.lbl_N_Area.TabIndex = 62;
            this.lbl_N_Area.Text = "№ участка:";
            // 
            // lbl_N_Strahovki
            // 
            this.lbl_N_Strahovki.AutoSize = true;
            this.lbl_N_Strahovki.BackColor = System.Drawing.Color.Transparent;
            this.lbl_N_Strahovki.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_N_Strahovki.ForeColor = System.Drawing.Color.Black;
            this.lbl_N_Strahovki.Location = new System.Drawing.Point(3, 111);
            this.lbl_N_Strahovki.Name = "lbl_N_Strahovki";
            this.lbl_N_Strahovki.Size = new System.Drawing.Size(138, 22);
            this.lbl_N_Strahovki.TabIndex = 61;
            this.lbl_N_Strahovki.Text = "№ cтраховки:";
            // 
            // lbl_Adress
            // 
            this.lbl_Adress.AutoSize = true;
            this.lbl_Adress.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Adress.CausesValidation = false;
            this.lbl_Adress.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Adress.ForeColor = System.Drawing.Color.Black;
            this.lbl_Adress.Location = new System.Drawing.Point(3, 63);
            this.lbl_Adress.Name = "lbl_Adress";
            this.lbl_Adress.Size = new System.Drawing.Size(79, 22);
            this.lbl_Adress.TabIndex = 60;
            this.lbl_Adress.Text = "Адрес:";
            // 
            // DeletePatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 317);
            this.Controls.Add(this.label_Info_Patient);
            this.Controls.Add(this.panel_info);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.pictureBoxDeleteImg);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_Patient);
            this.Controls.Add(this.lblSuccesfullyDeleted);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.comboBox_Patient);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeletePatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeletePatientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeletePatientForm_FormClosing);
            this.Load += new System.EventHandler(this.DeletePatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeleteImg)).EndInit();
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_Patient;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label lblSuccesfullyDeleted;
        private System.Windows.Forms.Label lbl_Patient;
        private System.Windows.Forms.PictureBox pictureBoxDeleteImg;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Timer timer;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.Label label_Info_Patient;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.Label lbl_IDNP;
        private System.Windows.Forms.Label lbl_N_Area;
        private System.Windows.Forms.Label lbl_N_Strahovki;
        private System.Windows.Forms.Label lbl_Adress;
    }
}
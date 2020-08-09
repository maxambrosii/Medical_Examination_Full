namespace Medical_Examination
{
    partial class DeleteDoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteDoctorForm));
            this.comboBox_Doctor = new System.Windows.Forms.ComboBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblSuccesfullyDeleted = new System.Windows.Forms.Label();
            this.button_Return = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.pictureBoxDeleteImg = new System.Windows.Forms.PictureBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeleteImg)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Doctor
            // 
            this.comboBox_Doctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.comboBox_Doctor.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBox_Doctor.FormattingEnabled = true;
            this.comboBox_Doctor.Location = new System.Drawing.Point(256, 146);
            this.comboBox_Doctor.Name = "comboBox_Doctor";
            this.comboBox_Doctor.Size = new System.Drawing.Size(181, 21);
            this.comboBox_Doctor.TabIndex = 24;
            this.comboBox_Doctor.SelectedIndexChanged += new System.EventHandler(this.comboBox_Doctor_SelectedIndexChanged);
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDoctor.ForeColor = System.Drawing.Color.White;
            this.lblDoctor.Location = new System.Drawing.Point(80, 143);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(170, 22);
            this.lblDoctor.TabIndex = 19;
            this.lblDoctor.Text = "Выберите врача:";
            // 
            // lblSuccesfullyDeleted
            // 
            this.lblSuccesfullyDeleted.AutoSize = true;
            this.lblSuccesfullyDeleted.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccesfullyDeleted.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSuccesfullyDeleted.ForeColor = System.Drawing.Color.Lime;
            this.lblSuccesfullyDeleted.Location = new System.Drawing.Point(130, 80);
            this.lblSuccesfullyDeleted.Name = "lblSuccesfullyDeleted";
            this.lblSuccesfullyDeleted.Size = new System.Drawing.Size(288, 22);
            this.lblSuccesfullyDeleted.TabIndex = 25;
            this.lblSuccesfullyDeleted.Text = "Вы успешно удалили данные";
            this.lblSuccesfullyDeleted.Visible = false;
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
            this.button_Return.Location = new System.Drawing.Point(298, 203);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(149, 43);
            this.button_Return.TabIndex = 27;
            this.button_Return.Text = "Вернуться";
            this.button_Return.UseVisualStyleBackColor = false;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Transparent;
            this.button_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Delete.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.Location = new System.Drawing.Point(72, 203);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(149, 43);
            this.button_Delete.TabIndex = 26;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Visible = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // pictureBoxDeleteImg
            // 
            this.pictureBoxDeleteImg.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDeleteImg.BackgroundImage = global::Medical_Examination.Properties.Resources.w512h5121380984637delete1;
            this.pictureBoxDeleteImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDeleteImg.Location = new System.Drawing.Point(2, 7);
            this.pictureBoxDeleteImg.Name = "pictureBoxDeleteImg";
            this.pictureBoxDeleteImg.Size = new System.Drawing.Size(77, 72);
            this.pictureBoxDeleteImg.TabIndex = 42;
            this.pictureBoxDeleteImg.TabStop = false;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.BackColor = System.Drawing.Color.Transparent;
            this.lblLine.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLine.ForeColor = System.Drawing.Color.White;
            this.lblLine.Location = new System.Drawing.Point(93, 34);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(395, 24);
            this.lblLine.TabIndex = 41;
            this.lblLine.Text = "___________________________________";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(106, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 24);
            this.lblTitle.TabIndex = 40;
            this.lblTitle.Text = "Удаление информации о враче";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(140, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 39;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Info.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Info.ForeColor = System.Drawing.Color.White;
            this.lbl_Info.Location = new System.Drawing.Point(-3, 259);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(2714, 24);
            this.lbl_Info.TabIndex = 48;
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
            // DeleteDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(506, 293);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.pictureBoxDeleteImg);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.lblSuccesfullyDeleted);
            this.Controls.Add(this.comboBox_Doctor);
            this.Controls.Add(this.lblDoctor);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteDoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteDoctorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteDoctorForm_FormClosing);
            this.Load += new System.EventHandler(this.DeleteDoctorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeleteImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Doctor;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblSuccesfullyDeleted;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.PictureBox pictureBoxDeleteImg;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Timer timer;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
    }
}
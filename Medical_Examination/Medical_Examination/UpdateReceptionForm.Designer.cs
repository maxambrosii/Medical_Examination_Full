namespace Medical_Examination
{
    partial class UpdateReceptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateReceptionForm));
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxN_Reception = new System.Windows.Forms.ComboBox();
            this.labelN_Reception = new System.Windows.Forms.Label();
            this.checkBox_Date = new System.Windows.Forms.CheckBox();
            this.checkBoxTime = new System.Windows.Forms.CheckBox();
            this.labelSuccesfully = new System.Windows.Forms.Label();
            this.pictureBoxUpdateImage = new System.Windows.Forms.PictureBox();
            this.labelLine = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdateImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(341, 221);
            this.dateTimePickerTime.MinDate = new System.DateTime(2019, 3, 30, 0, 0, 0, 0);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(159, 20);
            this.dateTimePickerTime.TabIndex = 45;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(341, 181);
            this.dateTimePickerDate.MinDate = new System.DateTime(2019, 3, 30, 0, 0, 0, 0);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(159, 20);
            this.dateTimePickerDate.TabIndex = 44;
            // 
            // comboBoxN_Reception
            // 
            this.comboBoxN_Reception.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.comboBoxN_Reception.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.comboBoxN_Reception.FormattingEnabled = true;
            this.comboBoxN_Reception.Location = new System.Drawing.Point(323, 141);
            this.comboBoxN_Reception.Name = "comboBoxN_Reception";
            this.comboBoxN_Reception.Size = new System.Drawing.Size(178, 21);
            this.comboBoxN_Reception.TabIndex = 41;
            // 
            // labelN_Reception
            // 
            this.labelN_Reception.AutoSize = true;
            this.labelN_Reception.BackColor = System.Drawing.Color.Transparent;
            this.labelN_Reception.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN_Reception.ForeColor = System.Drawing.Color.White;
            this.labelN_Reception.Location = new System.Drawing.Point(62, 135);
            this.labelN_Reception.Name = "labelN_Reception";
            this.labelN_Reception.Size = new System.Drawing.Size(217, 22);
            this.labelN_Reception.TabIndex = 33;
            this.labelN_Reception.Text = "Выберите № приема:";
            // 
            // checkBox_Date
            // 
            this.checkBox_Date.AutoSize = true;
            this.checkBox_Date.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Date.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Date.ForeColor = System.Drawing.Color.White;
            this.checkBox_Date.Location = new System.Drawing.Point(62, 175);
            this.checkBox_Date.Name = "checkBox_Date";
            this.checkBox_Date.Size = new System.Drawing.Size(257, 26);
            this.checkBox_Date.TabIndex = 46;
            this.checkBox_Date.Text = "Изменить Дату приема:";
            this.checkBox_Date.UseVisualStyleBackColor = false;
            this.checkBox_Date.CheckedChanged += new System.EventHandler(this.checkBox_Date_CheckedChanged);
            // 
            // checkBoxTime
            // 
            this.checkBoxTime.AutoSize = true;
            this.checkBoxTime.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxTime.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxTime.ForeColor = System.Drawing.Color.White;
            this.checkBoxTime.Location = new System.Drawing.Point(62, 214);
            this.checkBoxTime.Name = "checkBoxTime";
            this.checkBoxTime.Size = new System.Drawing.Size(273, 26);
            this.checkBoxTime.TabIndex = 47;
            this.checkBoxTime.Text = "Изменить Время приема:";
            this.checkBoxTime.UseVisualStyleBackColor = false;
            this.checkBoxTime.CheckedChanged += new System.EventHandler(this.checkBoxTime_CheckedChanged);
            // 
            // labelSuccesfully
            // 
            this.labelSuccesfully.AutoSize = true;
            this.labelSuccesfully.BackColor = System.Drawing.Color.Transparent;
            this.labelSuccesfully.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSuccesfully.ForeColor = System.Drawing.Color.Lime;
            this.labelSuccesfully.Location = new System.Drawing.Point(136, 83);
            this.labelSuccesfully.Name = "labelSuccesfully";
            this.labelSuccesfully.Size = new System.Drawing.Size(299, 22);
            this.labelSuccesfully.TabIndex = 57;
            this.labelSuccesfully.Text = "Вы успешно обновили данные";
            this.labelSuccesfully.Visible = false;
            // 
            // pictureBoxUpdateImage
            // 
            this.pictureBoxUpdateImage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUpdateImage.BackgroundImage = global::Medical_Examination.Properties.Resources.View_refresh_Gion_simple_svg;
            this.pictureBoxUpdateImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUpdateImage.Location = new System.Drawing.Point(5, 7);
            this.pictureBoxUpdateImage.Name = "pictureBoxUpdateImage";
            this.pictureBoxUpdateImage.Size = new System.Drawing.Size(77, 72);
            this.pictureBoxUpdateImage.TabIndex = 56;
            this.pictureBoxUpdateImage.TabStop = false;
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.BackColor = System.Drawing.Color.Transparent;
            this.labelLine.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLine.ForeColor = System.Drawing.Color.White;
            this.labelLine.Location = new System.Drawing.Point(97, 34);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(406, 24);
            this.labelLine.TabIndex = 55;
            this.labelLine.Text = "____________________________________";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(97, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(401, 24);
            this.labelTitle.TabIndex = 54;
            this.labelTitle.Text = "Изменение информации о приёме";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(143, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 53;
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
            this.buttonReturn.Location = new System.Drawing.Point(310, 280);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(149, 43);
            this.buttonReturn.TabIndex = 59;
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
            this.buttonUpdate.Location = new System.Drawing.Point(91, 280);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(149, 43);
            this.buttonUpdate.TabIndex = 58;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // UpdateReceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 364);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelSuccesfully);
            this.Controls.Add(this.pictureBoxUpdateImage);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxTime);
            this.Controls.Add(this.checkBox_Date);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.comboBoxN_Reception);
            this.Controls.Add(this.labelN_Reception);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateReceptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateReceptionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateReceptionForm_FormClosing);
            this.Load += new System.EventHandler(this.UpdateReceptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdateImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ComboBox comboBoxN_Reception;
        private System.Windows.Forms.Label labelN_Reception;
        private System.Windows.Forms.CheckBox checkBox_Date;
        private System.Windows.Forms.CheckBox checkBoxTime;
        private System.Windows.Forms.Label labelSuccesfully;
        private System.Windows.Forms.PictureBox pictureBoxUpdateImage;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonUpdate;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
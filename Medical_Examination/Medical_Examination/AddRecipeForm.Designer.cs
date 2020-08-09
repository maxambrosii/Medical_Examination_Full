namespace Medical_Examination
{
    partial class AddRecipeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRecipeForm));
            this.label6 = new System.Windows.Forms.Label();
            this.listBox_Medicaments = new System.Windows.Forms.ListBox();
            this.comboBox_Medicament = new System.Windows.Forms.ComboBox();
            this.lbl_Medicament = new System.Windows.Forms.Label();
            this.pictureBoxAddImg = new System.Windows.Forms.PictureBox();
            this.lblSuccesfullyAdded = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_List_Medicaments = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Return = new System.Windows.Forms.Button();
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
            this.label6.Location = new System.Drawing.Point(172, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 32;
            // 
            // listBox_Medicaments
            // 
            this.listBox_Medicaments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.listBox_Medicaments.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox_Medicaments.FormattingEnabled = true;
            this.listBox_Medicaments.Location = new System.Drawing.Point(357, 167);
            this.listBox_Medicaments.Name = "listBox_Medicaments";
            this.listBox_Medicaments.Size = new System.Drawing.Size(255, 199);
            this.listBox_Medicaments.TabIndex = 34;
            // 
            // comboBox_Medicament
            // 
            this.comboBox_Medicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.comboBox_Medicament.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox_Medicament.FormattingEnabled = true;
            this.comboBox_Medicament.Location = new System.Drawing.Point(62, 176);
            this.comboBox_Medicament.Name = "comboBox_Medicament";
            this.comboBox_Medicament.Size = new System.Drawing.Size(176, 21);
            this.comboBox_Medicament.TabIndex = 35;
            this.comboBox_Medicament.SelectedIndexChanged += new System.EventHandler(this.comboBox_Medicament_SelectedIndexChanged);
            // 
            // lbl_Medicament
            // 
            this.lbl_Medicament.AutoSize = true;
            this.lbl_Medicament.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Medicament.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Medicament.ForeColor = System.Drawing.Color.White;
            this.lbl_Medicament.Location = new System.Drawing.Point(51, 137);
            this.lbl_Medicament.Name = "lbl_Medicament";
            this.lbl_Medicament.Size = new System.Drawing.Size(211, 22);
            this.lbl_Medicament.TabIndex = 39;
            this.lbl_Medicament.Text = "Выберите лекарство:";
            // 
            // pictureBoxAddImg
            // 
            this.pictureBoxAddImg.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAddImg.BackgroundImage = global::Medical_Examination.Properties.Resources.add_1_icon;
            this.pictureBoxAddImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAddImg.Location = new System.Drawing.Point(4, 6);
            this.pictureBoxAddImg.Name = "pictureBoxAddImg";
            this.pictureBoxAddImg.Size = new System.Drawing.Size(77, 72);
            this.pictureBoxAddImg.TabIndex = 45;
            this.pictureBoxAddImg.TabStop = false;
            // 
            // lblSuccesfullyAdded
            // 
            this.lblSuccesfullyAdded.AutoSize = true;
            this.lblSuccesfullyAdded.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccesfullyAdded.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSuccesfullyAdded.ForeColor = System.Drawing.Color.Lime;
            this.lblSuccesfullyAdded.Location = new System.Drawing.Point(194, 81);
            this.lblSuccesfullyAdded.Name = "lblSuccesfullyAdded";
            this.lblSuccesfullyAdded.Size = new System.Drawing.Size(282, 23);
            this.lblSuccesfullyAdded.TabIndex = 44;
            this.lblSuccesfullyAdded.Text = "Вы успешно внесли данные!";
            this.lblSuccesfullyAdded.Visible = false;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.BackColor = System.Drawing.Color.Transparent;
            this.lblLine.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLine.ForeColor = System.Drawing.Color.White;
            this.lblLine.Location = new System.Drawing.Point(87, 31);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(538, 24);
            this.lblLine.TabIndex = 43;
            this.lblLine.Text = "________________________________________________";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(94, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(526, 24);
            this.lblTitle.TabIndex = 42;
            this.lblTitle.Text = "Добавление информации о новом рецепте № ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(142, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(188, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 40;
            // 
            // label_List_Medicaments
            // 
            this.label_List_Medicaments.AutoSize = true;
            this.label_List_Medicaments.BackColor = System.Drawing.Color.Transparent;
            this.label_List_Medicaments.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_List_Medicaments.ForeColor = System.Drawing.Color.White;
            this.label_List_Medicaments.Location = new System.Drawing.Point(334, 137);
            this.label_List_Medicaments.Name = "label_List_Medicaments";
            this.label_List_Medicaments.Size = new System.Drawing.Size(318, 22);
            this.label_List_Medicaments.TabIndex = 50;
            this.label_List_Medicaments.Text = "Список добавленных лекарств : \r\n";
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.Transparent;
            this.button_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Clear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Clear.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.button_Clear.ForeColor = System.Drawing.Color.White;
            this.button_Clear.Location = new System.Drawing.Point(191, 390);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(130, 43);
            this.button_Clear.TabIndex = 57;
            this.button_Clear.Text = "Очистить";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Transparent;
            this.button_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Save.Enabled = false;
            this.button_Save.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Save.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(22, 390);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(126, 43);
            this.button_Save.TabIndex = 56;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
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
            this.button_Return.Location = new System.Drawing.Point(482, 390);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(130, 43);
            this.button_Return.TabIndex = 58;
            this.button_Return.Text = "Вернуться";
            this.button_Return.UseVisualStyleBackColor = false;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // AddRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 444);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label_List_Medicaments);
            this.Controls.Add(this.pictureBoxAddImg);
            this.Controls.Add(this.lblSuccesfullyAdded);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_Medicament);
            this.Controls.Add(this.comboBox_Medicament);
            this.Controls.Add(this.listBox_Medicaments);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddRecipeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRecipeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddRecipeForm_FormClosing);
            this.Load += new System.EventHandler(this.AddRecipeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox_Medicaments;
        private System.Windows.Forms.ComboBox comboBox_Medicament;
        private System.Windows.Forms.Label lbl_Medicament;
        private System.Windows.Forms.PictureBox pictureBoxAddImg;
        private System.Windows.Forms.Label lblSuccesfullyAdded;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_List_Medicaments;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Return;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
    }
}
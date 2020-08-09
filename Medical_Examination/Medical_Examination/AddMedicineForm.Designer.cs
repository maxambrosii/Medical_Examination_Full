namespace Medical_Examination
{
    partial class AddMedicineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedicineForm));
            this.label5 = new System.Windows.Forms.Label();
            this.lblType_Package = new System.Windows.Forms.Label();
            this.lblDozirovka = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGruppa = new System.Windows.Forms.Label();
            this.comboBoxTypePackage = new System.Windows.Forms.ComboBox();
            this.comboBoxGruppa = new System.Windows.Forms.ComboBox();
            this.comboBoxTypeDoz = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblSuccesfullAdded = new System.Windows.Forms.Label();
            this.pictureBoxAddImg = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.docDiagnozTableAdapter = new Medical_Examination.DispanserizatsiaDataSetTableAdapters.DocDiagnozTableAdapter();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNumberDoz = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(331, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 17;
            // 
            // lblType_Package
            // 
            this.lblType_Package.AutoSize = true;
            this.lblType_Package.BackColor = System.Drawing.Color.Transparent;
            this.lblType_Package.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType_Package.ForeColor = System.Drawing.Color.White;
            this.lblType_Package.Location = new System.Drawing.Point(97, 220);
            this.lblType_Package.Name = "lblType_Package";
            this.lblType_Package.Size = new System.Drawing.Size(249, 22);
            this.lblType_Package.TabIndex = 13;
            this.lblType_Package.Text = "Выберите \"Тип упаковки\":";
            this.lblType_Package.Visible = false;
            // 
            // lblDozirovka
            // 
            this.lblDozirovka.AutoSize = true;
            this.lblDozirovka.BackColor = System.Drawing.Color.Transparent;
            this.lblDozirovka.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDozirovka.ForeColor = System.Drawing.Color.White;
            this.lblDozirovka.Location = new System.Drawing.Point(136, 183);
            this.lblDozirovka.Name = "lblDozirovka";
            this.lblDozirovka.Size = new System.Drawing.Size(208, 22);
            this.lblDozirovka.TabIndex = 11;
            this.lblDozirovka.Text = "Введите \"Дозировку\":";
            this.lblDozirovka.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(146, 146);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(198, 22);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Введите \"Название\":";
            // 
            // lblGruppa
            // 
            this.lblGruppa.AutoSize = true;
            this.lblGruppa.BackColor = System.Drawing.Color.Transparent;
            this.lblGruppa.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGruppa.ForeColor = System.Drawing.Color.White;
            this.lblGruppa.Location = new System.Drawing.Point(155, 257);
            this.lblGruppa.Name = "lblGruppa";
            this.lblGruppa.Size = new System.Drawing.Size(191, 22);
            this.lblGruppa.TabIndex = 18;
            this.lblGruppa.Text = "Выберите \"Группу\":";
            this.lblGruppa.Visible = false;
            // 
            // comboBoxTypePackage
            // 
            this.comboBoxTypePackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.comboBoxTypePackage.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.comboBoxTypePackage.FormattingEnabled = true;
            this.comboBoxTypePackage.Items.AddRange(new object[] {
            "Банки",
            "Пробирки",
            "Флаконы",
            "Ампулы",
            "Коробка",
            "Пачка",
            "Шприц-тюбики",
            "Пакеты",
            "Бумажные"});
            this.comboBoxTypePackage.Location = new System.Drawing.Point(366, 222);
            this.comboBoxTypePackage.Name = "comboBoxTypePackage";
            this.comboBoxTypePackage.Size = new System.Drawing.Size(226, 21);
            this.comboBoxTypePackage.TabIndex = 33;
            this.comboBoxTypePackage.Visible = false;
            this.comboBoxTypePackage.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypePackage_SelectedIndexChanged);
            this.comboBoxTypePackage.TextChanged += new System.EventHandler(this.comboBoxTypePackage_TextChanged);
            this.comboBoxTypePackage.Click += new System.EventHandler(this.comboBoxTypePackage_Click);
            this.comboBoxTypePackage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxTypePackage_KeyDown);
            // 
            // comboBoxGruppa
            // 
            this.comboBoxGruppa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.comboBoxGruppa.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.comboBoxGruppa.FormattingEnabled = true;
            this.comboBoxGruppa.Items.AddRange(new object[] {
            "Антиаллергические",
            "Антимикробные",
            "Антисептики",
            "Вакцина",
            "Витамины",
            "Гормальные",
            "Диагностические",
            "Противовирусные",
            "Противогрипковые",
            "Противоопухолевые",
            "Противопоразитарные",
            "Противопротозойные",
            "Анальгезирующие",
            "Жаропонижающие",
            "Сердечно-сосудистые",
            "Респираторные",
            "Метаболистические",
            "Бронхо-Легочные",
            "ЦНС_средства",
            "Отоларингологические",
            "Инстоксикационные",
            "Гинекологические",
            "Дерматологические",
            "Венерологические"});
            this.comboBoxGruppa.Location = new System.Drawing.Point(366, 260);
            this.comboBoxGruppa.Name = "comboBoxGruppa";
            this.comboBoxGruppa.Size = new System.Drawing.Size(226, 21);
            this.comboBoxGruppa.TabIndex = 34;
            this.comboBoxGruppa.Visible = false;
            this.comboBoxGruppa.SelectedIndexChanged += new System.EventHandler(this.comboBoxGruppa_SelectedIndexChanged);
            this.comboBoxGruppa.Click += new System.EventHandler(this.comboBoxGruppa_Click);
            this.comboBoxGruppa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxGruppa_KeyDown);
            this.comboBoxGruppa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxGruppa_KeyPress);
            // 
            // comboBoxTypeDoz
            // 
            this.comboBoxTypeDoz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.comboBoxTypeDoz.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.comboBoxTypeDoz.FormattingEnabled = true;
            this.comboBoxTypeDoz.Items.AddRange(new object[] {
            "Грамм(а)",
            "Милли-Грамм(а)",
            "Милли-Литр(а)",
            "Капли(ель)",
            "Штук(а)"});
            this.comboBoxTypeDoz.Location = new System.Drawing.Point(485, 184);
            this.comboBoxTypeDoz.Name = "comboBoxTypeDoz";
            this.comboBoxTypeDoz.Size = new System.Drawing.Size(108, 21);
            this.comboBoxTypeDoz.TabIndex = 37;
            this.comboBoxTypeDoz.Visible = false;
            this.comboBoxTypeDoz.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeDoz_SelectedIndexChanged);
            this.comboBoxTypeDoz.Click += new System.EventHandler(this.comboBoxTypeDoz_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(199, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(153, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 28;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(106, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(511, 24);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Добавление информации о новом лекарстве";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.BackColor = System.Drawing.Color.Transparent;
            this.lblLine.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLine.ForeColor = System.Drawing.Color.White;
            this.lblLine.Location = new System.Drawing.Point(106, 33);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(516, 24);
            this.lblLine.TabIndex = 30;
            this.lblLine.Text = "______________________________________________";
            // 
            // lblSuccesfullAdded
            // 
            this.lblSuccesfullAdded.AutoSize = true;
            this.lblSuccesfullAdded.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccesfullAdded.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSuccesfullAdded.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSuccesfullAdded.Location = new System.Drawing.Point(226, 69);
            this.lblSuccesfullAdded.Name = "lblSuccesfullAdded";
            this.lblSuccesfullAdded.Size = new System.Drawing.Size(282, 23);
            this.lblSuccesfullAdded.TabIndex = 31;
            this.lblSuccesfullAdded.Text = "Вы успешно внесли данные!";
            this.lblSuccesfullAdded.Visible = false;
            // 
            // pictureBoxAddImg
            // 
            this.pictureBoxAddImg.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAddImg.BackgroundImage = global::Medical_Examination.Properties.Resources.add_1_icon;
            this.pictureBoxAddImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAddImg.Location = new System.Drawing.Point(15, 8);
            this.pictureBoxAddImg.Name = "pictureBoxAddImg";
            this.pictureBoxAddImg.Size = new System.Drawing.Size(77, 72);
            this.pictureBoxAddImg.TabIndex = 32;
            this.pictureBoxAddImg.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(438, 324);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(130, 43);
            this.btnReturn.TabIndex = 53;
            this.btnReturn.Text = "Вернуться";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(180, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 43);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // docDiagnozTableAdapter
            // 
            this.docDiagnozTableAdapter.ClearBeforeFill = true;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxName.Location = new System.Drawing.Point(366, 147);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(226, 20);
            this.textBoxName.TabIndex = 56;
            this.textBoxName.Click += new System.EventHandler(this.textBoxName_Click);
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyDown);
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxNumberDoz
            // 
            this.textBoxNumberDoz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.textBoxNumberDoz.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxNumberDoz.Location = new System.Drawing.Point(366, 184);
            this.textBoxNumberDoz.Name = "textBoxNumberDoz";
            this.textBoxNumberDoz.Size = new System.Drawing.Size(111, 20);
            this.textBoxNumberDoz.TabIndex = 57;
            this.textBoxNumberDoz.Visible = false;
            this.textBoxNumberDoz.Click += new System.EventHandler(this.textBoxNumberDoz_Click);
            this.textBoxNumberDoz.TextChanged += new System.EventHandler(this.textBoxNumberDoz_TextChanged);
            this.textBoxNumberDoz.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNumberDoz_KeyDown);
            this.textBoxNumberDoz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberDoz_KeyPress);
            // 
            // AddMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 393);
            this.Controls.Add(this.textBoxNumberDoz);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBoxTypeDoz);
            this.Controls.Add(this.comboBoxGruppa);
            this.Controls.Add(this.comboBoxTypePackage);
            this.Controls.Add(this.pictureBoxAddImg);
            this.Controls.Add(this.lblSuccesfullAdded);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblGruppa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblType_Package);
            this.Controls.Add(this.lblDozirovka);
            this.Controls.Add(this.lblName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMedicineForm";
            this.Load += new System.EventHandler(this.AddMedicineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblType_Package;
        private System.Windows.Forms.Label lblDozirovka;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGruppa;
        private System.Windows.Forms.ComboBox comboBoxTypePackage;
        private System.Windows.Forms.ComboBox comboBoxGruppa;
        private System.Windows.Forms.ComboBox comboBoxTypeDoz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblSuccesfullAdded;
        private System.Windows.Forms.PictureBox pictureBoxAddImg;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAdd;
        private DispanserizatsiaDataSetTableAdapters.DocDiagnozTableAdapter docDiagnozTableAdapter;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNumberDoz;
    }
}
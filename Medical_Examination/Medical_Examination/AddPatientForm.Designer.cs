namespace Medical_Examination
{
    partial class AddPatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatientForm));
            this.lblFIO = new System.Windows.Forms.Label();
            this.lblIDNP = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lbl_N_Strahovka = new System.Windows.Forms.Label();
            this.lbl_N_Ucastka = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Pol = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.radioButton_Masculin = new System.Windows.Forms.RadioButton();
            this.radioButtonFemenin = new System.Windows.Forms.RadioButton();
            this.dTP_Date_R = new System.Windows.Forms.DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.LblAddSuccesfull = new System.Windows.Forms.Label();
            this.pictureBoxAddImg = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.Textbox_FIO = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Textbox_IDNP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Textbox_Adress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Textbox_N_strahovki = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_N_Region = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFIO
            // 
            this.lblFIO.AutoSize = true;
            this.lblFIO.BackColor = System.Drawing.Color.Transparent;
            this.lblFIO.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFIO.ForeColor = System.Drawing.Color.White;
            this.lblFIO.Location = new System.Drawing.Point(221, 120);
            this.lblFIO.Name = "lblFIO";
            this.lblFIO.Size = new System.Drawing.Size(155, 22);
            this.lblFIO.TabIndex = 1;
            this.lblFIO.Text = "Введите \"ФИО\":";
            // 
            // lblIDNP
            // 
            this.lblIDNP.AutoSize = true;
            this.lblIDNP.BackColor = System.Drawing.Color.Transparent;
            this.lblIDNP.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIDNP.ForeColor = System.Drawing.Color.White;
            this.lblIDNP.Location = new System.Drawing.Point(223, 162);
            this.lblIDNP.Name = "lblIDNP";
            this.lblIDNP.Size = new System.Drawing.Size(151, 22);
            this.lblIDNP.TabIndex = 3;
            this.lblIDNP.Text = "Введите \"IDNP\":";
            this.lblIDNP.Visible = false;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.BackColor = System.Drawing.Color.Transparent;
            this.lblAdres.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdres.ForeColor = System.Drawing.Color.White;
            this.lblAdres.Location = new System.Drawing.Point(205, 205);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(171, 22);
            this.lblAdres.TabIndex = 5;
            this.lblAdres.Text = "Введите \"Адрес\":";
            this.lblAdres.Visible = false;
            // 
            // lbl_N_Strahovka
            // 
            this.lbl_N_Strahovka.AutoSize = true;
            this.lbl_N_Strahovka.BackColor = System.Drawing.Color.Transparent;
            this.lbl_N_Strahovka.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_N_Strahovka.ForeColor = System.Drawing.Color.White;
            this.lbl_N_Strahovka.Location = new System.Drawing.Point(104, 247);
            this.lbl_N_Strahovka.Name = "lbl_N_Strahovka";
            this.lbl_N_Strahovka.Size = new System.Drawing.Size(276, 22);
            this.lbl_N_Strahovka.TabIndex = 7;
            this.lbl_N_Strahovka.Text = "Введите \"Номер страховки\":";
            this.lbl_N_Strahovka.Visible = false;
            // 
            // lbl_N_Ucastka
            // 
            this.lbl_N_Ucastka.AutoSize = true;
            this.lbl_N_Ucastka.BackColor = System.Drawing.Color.Transparent;
            this.lbl_N_Ucastka.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_N_Ucastka.ForeColor = System.Drawing.Color.White;
            this.lbl_N_Ucastka.Location = new System.Drawing.Point(171, 289);
            this.lbl_N_Ucastka.Name = "lbl_N_Ucastka";
            this.lbl_N_Ucastka.Size = new System.Drawing.Size(208, 22);
            this.lbl_N_Ucastka.TabIndex = 9;
            this.lbl_N_Ucastka.Text = "Введите \"№ участка\":";
            this.lbl_N_Ucastka.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(146, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 10;
            // 
            // lbl_Pol
            // 
            this.lbl_Pol.AutoSize = true;
            this.lbl_Pol.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pol.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Pol.ForeColor = System.Drawing.Color.White;
            this.lbl_Pol.Location = new System.Drawing.Point(230, 331);
            this.lbl_Pol.Name = "lbl_Pol";
            this.lbl_Pol.Size = new System.Drawing.Size(147, 22);
            this.lbl_Pol.TabIndex = 13;
            this.lbl_Pol.Text = "Введите \"Пол\": ";
            this.lbl_Pol.Visible = false;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Date.Location = new System.Drawing.Point(123, 373);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(252, 22);
            this.lbl_Date.TabIndex = 14;
            this.lbl_Date.Text = "Введите \"Дату рождения\":";
            this.lbl_Date.Visible = false;
            // 
            // radioButton_Masculin
            // 
            this.radioButton_Masculin.AutoSize = true;
            this.radioButton_Masculin.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Masculin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Masculin.ForeColor = System.Drawing.Color.White;
            this.radioButton_Masculin.Location = new System.Drawing.Point(397, 331);
            this.radioButton_Masculin.Name = "radioButton_Masculin";
            this.radioButton_Masculin.Size = new System.Drawing.Size(43, 25);
            this.radioButton_Masculin.TabIndex = 15;
            this.radioButton_Masculin.TabStop = true;
            this.radioButton_Masculin.Text = "М";
            this.radioButton_Masculin.UseVisualStyleBackColor = false;
            this.radioButton_Masculin.Visible = false;
            this.radioButton_Masculin.Click += new System.EventHandler(this.radioButton_Masculin_Click);
            // 
            // radioButtonFemenin
            // 
            this.radioButtonFemenin.AutoSize = true;
            this.radioButtonFemenin.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonFemenin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonFemenin.ForeColor = System.Drawing.Color.White;
            this.radioButtonFemenin.Location = new System.Drawing.Point(446, 331);
            this.radioButtonFemenin.Name = "radioButtonFemenin";
            this.radioButtonFemenin.Size = new System.Drawing.Size(36, 25);
            this.radioButtonFemenin.TabIndex = 16;
            this.radioButtonFemenin.TabStop = true;
            this.radioButtonFemenin.Text = "F";
            this.radioButtonFemenin.UseVisualStyleBackColor = false;
            this.radioButtonFemenin.Visible = false;
            // 
            // dTP_Date_R
            // 
            this.dTP_Date_R.Location = new System.Drawing.Point(397, 375);
            this.dTP_Date_R.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dTP_Date_R.Name = "dTP_Date_R";
            this.dTP_Date_R.Size = new System.Drawing.Size(226, 20);
            this.dTP_Date_R.TabIndex = 17;
            this.dTP_Date_R.Visible = false;
            this.dTP_Date_R.ValueChanged += new System.EventHandler(this.dTP_Date_R_ValueChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(99, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(503, 24);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Добавление информации о новом пациенте";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.BackColor = System.Drawing.Color.Transparent;
            this.lblLine.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLine.ForeColor = System.Drawing.Color.White;
            this.lblLine.Location = new System.Drawing.Point(92, 34);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(593, 24);
            this.lblLine.TabIndex = 19;
            this.lblLine.Text = "_____________________________________________________\r\n";
            // 
            // LblAddSuccesfull
            // 
            this.LblAddSuccesfull.AutoSize = true;
            this.LblAddSuccesfull.BackColor = System.Drawing.Color.Transparent;
            this.LblAddSuccesfull.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblAddSuccesfull.ForeColor = System.Drawing.Color.LimeGreen;
            this.LblAddSuccesfull.Location = new System.Drawing.Point(212, 72);
            this.LblAddSuccesfull.Name = "LblAddSuccesfull";
            this.LblAddSuccesfull.Size = new System.Drawing.Size(282, 23);
            this.LblAddSuccesfull.TabIndex = 20;
            this.LblAddSuccesfull.Text = "Вы успешно внесли данные!";
            this.LblAddSuccesfull.Visible = false;
            // 
            // pictureBoxAddImg
            // 
            this.pictureBoxAddImg.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAddImg.BackgroundImage = global::Medical_Examination.Properties.Resources.add_1_icon;
            this.pictureBoxAddImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAddImg.Location = new System.Drawing.Point(8, 8);
            this.pictureBoxAddImg.Name = "pictureBoxAddImg";
            this.pictureBoxAddImg.Size = new System.Drawing.Size(77, 72);
            this.pictureBoxAddImg.TabIndex = 21;
            this.pictureBoxAddImg.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
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
            this.buttonReturn.Location = new System.Drawing.Point(456, 440);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(130, 43);
            this.buttonReturn.TabIndex = 55;
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
            this.buttonAdd.Location = new System.Drawing.Point(190, 440);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 43);
            this.buttonAdd.TabIndex = 54;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Textbox_FIO
            // 
            this.Textbox_FIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.Textbox_FIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Textbox_FIO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_FIO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Textbox_FIO.ForeColor = System.Drawing.Color.White;
            this.Textbox_FIO.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_FIO.HintText = "";
            this.Textbox_FIO.isPassword = false;
            this.Textbox_FIO.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox_FIO.LineIdleColor = System.Drawing.Color.Black;
            this.Textbox_FIO.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox_FIO.LineThickness = 3;
            this.Textbox_FIO.Location = new System.Drawing.Point(394, 110);
            this.Textbox_FIO.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Textbox_FIO.Name = "Textbox_FIO";
            this.Textbox_FIO.Size = new System.Drawing.Size(225, 32);
            this.Textbox_FIO.TabIndex = 56;
            this.Textbox_FIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_FIO.Enter += new System.EventHandler(this.Textbox_FIO_Enter);
            this.Textbox_FIO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_FIO_KeyDown);
            this.Textbox_FIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_FIO_KeyPress);
            this.Textbox_FIO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Textbox_FIO_MouseDown);
            // 
            // Textbox_IDNP
            // 
            this.Textbox_IDNP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.Textbox_IDNP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Textbox_IDNP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_IDNP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Textbox_IDNP.ForeColor = System.Drawing.Color.White;
            this.Textbox_IDNP.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_IDNP.HintText = "";
            this.Textbox_IDNP.isPassword = false;
            this.Textbox_IDNP.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox_IDNP.LineIdleColor = System.Drawing.Color.Black;
            this.Textbox_IDNP.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox_IDNP.LineThickness = 3;
            this.Textbox_IDNP.Location = new System.Drawing.Point(394, 157);
            this.Textbox_IDNP.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Textbox_IDNP.Name = "Textbox_IDNP";
            this.Textbox_IDNP.Size = new System.Drawing.Size(225, 32);
            this.Textbox_IDNP.TabIndex = 57;
            this.Textbox_IDNP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_IDNP.Visible = false;
            this.Textbox_IDNP.OnValueChanged += new System.EventHandler(this.Textbox_IDNP_OnValueChanged);
            this.Textbox_IDNP.Click += new System.EventHandler(this.Textbox_IDNP_Click);
            this.Textbox_IDNP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_IDNP_KeyDown);
            this.Textbox_IDNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_IDNP_KeyPress);
            // 
            // Textbox_Adress
            // 
            this.Textbox_Adress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.Textbox_Adress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Textbox_Adress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_Adress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Textbox_Adress.ForeColor = System.Drawing.Color.White;
            this.Textbox_Adress.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_Adress.HintText = "";
            this.Textbox_Adress.isPassword = false;
            this.Textbox_Adress.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox_Adress.LineIdleColor = System.Drawing.Color.Black;
            this.Textbox_Adress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox_Adress.LineThickness = 3;
            this.Textbox_Adress.Location = new System.Drawing.Point(394, 195);
            this.Textbox_Adress.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Textbox_Adress.Name = "Textbox_Adress";
            this.Textbox_Adress.Size = new System.Drawing.Size(225, 32);
            this.Textbox_Adress.TabIndex = 58;
            this.Textbox_Adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_Adress.Visible = false;
            this.Textbox_Adress.Click += new System.EventHandler(this.Textbox_Adress_Click);
            this.Textbox_Adress.Enter += new System.EventHandler(this.Textbox_Adress_Enter);
            this.Textbox_Adress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_Adress_KeyDown);
            // 
            // Textbox_N_strahovki
            // 
            this.Textbox_N_strahovki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.Textbox_N_strahovki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Textbox_N_strahovki.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_N_strahovki.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Textbox_N_strahovki.ForeColor = System.Drawing.Color.White;
            this.Textbox_N_strahovki.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_N_strahovki.HintText = "";
            this.Textbox_N_strahovki.isPassword = false;
            this.Textbox_N_strahovki.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox_N_strahovki.LineIdleColor = System.Drawing.Color.Black;
            this.Textbox_N_strahovki.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox_N_strahovki.LineThickness = 3;
            this.Textbox_N_strahovki.Location = new System.Drawing.Point(397, 237);
            this.Textbox_N_strahovki.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Textbox_N_strahovki.Name = "Textbox_N_strahovki";
            this.Textbox_N_strahovki.Size = new System.Drawing.Size(225, 32);
            this.Textbox_N_strahovki.TabIndex = 59;
            this.Textbox_N_strahovki.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_N_strahovki.Visible = false;
            this.Textbox_N_strahovki.OnValueChanged += new System.EventHandler(this.Textbox_N_strahovki_OnValueChanged);
            this.Textbox_N_strahovki.Click += new System.EventHandler(this.Textbox_N_strahovki_Click);
            this.Textbox_N_strahovki.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_N_strahovki_KeyDown);
            this.Textbox_N_strahovki.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_N_strahovki_KeyPress);
            // 
            // TextBox_N_Region
            // 
            this.TextBox_N_Region.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.TextBox_N_Region.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TextBox_N_Region.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_N_Region.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_N_Region.ForeColor = System.Drawing.Color.White;
            this.TextBox_N_Region.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_N_Region.HintText = "";
            this.TextBox_N_Region.isPassword = false;
            this.TextBox_N_Region.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextBox_N_Region.LineIdleColor = System.Drawing.Color.Black;
            this.TextBox_N_Region.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextBox_N_Region.LineThickness = 3;
            this.TextBox_N_Region.Location = new System.Drawing.Point(397, 279);
            this.TextBox_N_Region.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TextBox_N_Region.Name = "TextBox_N_Region";
            this.TextBox_N_Region.Size = new System.Drawing.Size(225, 32);
            this.TextBox_N_Region.TabIndex = 60;
            this.TextBox_N_Region.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_N_Region.Visible = false;
            this.TextBox_N_Region.OnValueChanged += new System.EventHandler(this.TextBox_N_Region_OnValueChanged);
            this.TextBox_N_Region.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_N_Region_KeyDown);
            this.TextBox_N_Region.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_N_Region_KeyPress);
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 512);
            this.Controls.Add(this.TextBox_N_Region);
            this.Controls.Add(this.Textbox_N_strahovki);
            this.Controls.Add(this.Textbox_Adress);
            this.Controls.Add(this.Textbox_IDNP);
            this.Controls.Add(this.Textbox_FIO);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.pictureBoxAddImg);
            this.Controls.Add(this.LblAddSuccesfull);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dTP_Date_R);
            this.Controls.Add(this.radioButtonFemenin);
            this.Controls.Add(this.radioButton_Masculin);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Pol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_N_Ucastka);
            this.Controls.Add(this.lbl_N_Strahovka);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblIDNP);
            this.Controls.Add(this.lblFIO);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPatient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPatientForm_FormClosing);
            this.Load += new System.EventHandler(this.AddPatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFIO;
        private System.Windows.Forms.Label lblIDNP;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lbl_N_Strahovka;
        private System.Windows.Forms.Label lbl_N_Ucastka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Pol;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.RadioButton radioButton_Masculin;
        private System.Windows.Forms.RadioButton radioButtonFemenin;
        private System.Windows.Forms.DateTimePicker dTP_Date_R;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label LblAddSuccesfull;
        private System.Windows.Forms.PictureBox pictureBoxAddImg;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_FIO;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_IDNP;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_Adress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_N_strahovki;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_N_Region;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
    }
}
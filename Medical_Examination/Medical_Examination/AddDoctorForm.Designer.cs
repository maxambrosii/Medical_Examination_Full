namespace Medical_Examination
{
    partial class AddDoctorForm
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDoctorForm));
            this.lblFIO = new System.Windows.Forms.Label();
            this.lblN_Region = new System.Windows.Forms.Label();
            this.lbl_n_Cabinet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxAddImg = new System.Windows.Forms.PictureBox();
            this.lblSuccesfullAdded = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Textbox_FIO = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Textbox_N_Region = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Textbox_n_Cabinet = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.docDiagnozTableAdapter1 = new Medical_Examination.DispanserizatsiaDataSetTableAdapters.DocDiagnozTableAdapter();
            this.Transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFIO
            // 
            this.lblFIO.AutoSize = true;
            this.lblFIO.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.lblFIO, BunifuAnimatorNS.DecorationType.None);
            this.lblFIO.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFIO.ForeColor = System.Drawing.Color.White;
            this.lblFIO.Location = new System.Drawing.Point(160, 139);
            this.lblFIO.Name = "lblFIO";
            this.lblFIO.Size = new System.Drawing.Size(155, 22);
            this.lblFIO.TabIndex = 0;
            this.lblFIO.Text = "Введите \"ФИО\":";
            // 
            // lblN_Region
            // 
            this.lblN_Region.AutoSize = true;
            this.lblN_Region.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.lblN_Region, BunifuAnimatorNS.DecorationType.None);
            this.lblN_Region.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblN_Region.ForeColor = System.Drawing.Color.White;
            this.lblN_Region.Location = new System.Drawing.Point(110, 185);
            this.lblN_Region.Name = "lblN_Region";
            this.lblN_Region.Size = new System.Drawing.Size(208, 22);
            this.lblN_Region.TabIndex = 2;
            this.lblN_Region.Text = "Введите \"№ участка\":";
            this.lblN_Region.Visible = false;
            // 
            // lbl_n_Cabinet
            // 
            this.lbl_n_Cabinet.AutoSize = true;
            this.lbl_n_Cabinet.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.lbl_n_Cabinet, BunifuAnimatorNS.DecorationType.None);
            this.lbl_n_Cabinet.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_n_Cabinet.ForeColor = System.Drawing.Color.White;
            this.lbl_n_Cabinet.Location = new System.Drawing.Point(94, 228);
            this.lbl_n_Cabinet.Name = "lbl_n_Cabinet";
            this.lbl_n_Cabinet.Size = new System.Drawing.Size(224, 22);
            this.lbl_n_Cabinet.TabIndex = 4;
            this.lbl_n_Cabinet.Text = "Введите \"№ кабинета\":";
            this.lbl_n_Cabinet.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.Transition.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(196, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 8;
            // 
            // pictureBoxAddImg
            // 
            this.pictureBoxAddImg.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAddImg.BackgroundImage = global::Medical_Examination.Properties.Resources.add_1_icon;
            this.pictureBoxAddImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Transition.SetDecoration(this.pictureBoxAddImg, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxAddImg.Location = new System.Drawing.Point(12, 3);
            this.pictureBoxAddImg.Name = "pictureBoxAddImg";
            this.pictureBoxAddImg.Size = new System.Drawing.Size(77, 72);
            this.pictureBoxAddImg.TabIndex = 26;
            this.pictureBoxAddImg.TabStop = false;
            // 
            // lblSuccesfullAdded
            // 
            this.lblSuccesfullAdded.AutoSize = true;
            this.lblSuccesfullAdded.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.lblSuccesfullAdded, BunifuAnimatorNS.DecorationType.None);
            this.lblSuccesfullAdded.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSuccesfullAdded.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSuccesfullAdded.Location = new System.Drawing.Point(212, 84);
            this.lblSuccesfullAdded.Name = "lblSuccesfullAdded";
            this.lblSuccesfullAdded.Size = new System.Drawing.Size(282, 23);
            this.lblSuccesfullAdded.TabIndex = 25;
            this.lblSuccesfullAdded.Text = "Вы успешно внесли данные!";
            this.lblSuccesfullAdded.Visible = false;
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.labelLine, BunifuAnimatorNS.DecorationType.None);
            this.labelLine.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLine.ForeColor = System.Drawing.Color.White;
            this.labelLine.Location = new System.Drawing.Point(95, 28);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(516, 24);
            this.labelLine.TabIndex = 24;
            this.labelLine.Text = "______________________________________________";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.lblTitle, BunifuAnimatorNS.DecorationType.None);
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(103, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(462, 24);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Добавление информации о новом враче";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(150, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 22;
            // 
            // Textbox_FIO
            // 
            this.Textbox_FIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.Textbox_FIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Textbox_FIO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Transition.SetDecoration(this.Textbox_FIO, BunifuAnimatorNS.DecorationType.None);
            this.Textbox_FIO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Textbox_FIO.ForeColor = System.Drawing.Color.White;
            this.Textbox_FIO.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_FIO.HintText = "";
            this.Textbox_FIO.isPassword = false;
            this.Textbox_FIO.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox_FIO.LineIdleColor = System.Drawing.Color.Black;
            this.Textbox_FIO.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox_FIO.LineThickness = 3;
            this.Textbox_FIO.Location = new System.Drawing.Point(331, 129);
            this.Textbox_FIO.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Textbox_FIO.Name = "Textbox_FIO";
            this.Textbox_FIO.Size = new System.Drawing.Size(225, 32);
            this.Textbox_FIO.TabIndex = 47;
            this.Textbox_FIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_FIO.Click += new System.EventHandler(this.Textbox_FIO_Click);
            this.Textbox_FIO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_FIO_KeyDown);
            this.Textbox_FIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_FIO_KeyPress);
            // 
            // Textbox_N_Region
            // 
            this.Textbox_N_Region.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.Textbox_N_Region.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Textbox_N_Region.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Transition.SetDecoration(this.Textbox_N_Region, BunifuAnimatorNS.DecorationType.None);
            this.Textbox_N_Region.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Textbox_N_Region.ForeColor = System.Drawing.Color.White;
            this.Textbox_N_Region.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_N_Region.HintText = "";
            this.Textbox_N_Region.isPassword = false;
            this.Textbox_N_Region.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox_N_Region.LineIdleColor = System.Drawing.Color.Black;
            this.Textbox_N_Region.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox_N_Region.LineThickness = 3;
            this.Textbox_N_Region.Location = new System.Drawing.Point(331, 175);
            this.Textbox_N_Region.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Textbox_N_Region.Name = "Textbox_N_Region";
            this.Textbox_N_Region.Size = new System.Drawing.Size(225, 32);
            this.Textbox_N_Region.TabIndex = 48;
            this.Textbox_N_Region.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_N_Region.Visible = false;
            this.Textbox_N_Region.OnValueChanged += new System.EventHandler(this.Textbox_N_Region_OnValueChanged);
            this.Textbox_N_Region.Click += new System.EventHandler(this.Textbox_N_Region_Click);
            this.Textbox_N_Region.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_N_Region_KeyDown);
            this.Textbox_N_Region.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_N_Region_KeyPress);
            // 
            // Textbox_n_Cabinet
            // 
            this.Textbox_n_Cabinet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.Textbox_n_Cabinet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Textbox_n_Cabinet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Transition.SetDecoration(this.Textbox_n_Cabinet, BunifuAnimatorNS.DecorationType.None);
            this.Textbox_n_Cabinet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Textbox_n_Cabinet.ForeColor = System.Drawing.Color.White;
            this.Textbox_n_Cabinet.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_n_Cabinet.HintText = "";
            this.Textbox_n_Cabinet.isPassword = false;
            this.Textbox_n_Cabinet.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox_n_Cabinet.LineIdleColor = System.Drawing.Color.Black;
            this.Textbox_n_Cabinet.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox_n_Cabinet.LineThickness = 3;
            this.Textbox_n_Cabinet.Location = new System.Drawing.Point(331, 218);
            this.Textbox_n_Cabinet.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Textbox_n_Cabinet.Name = "Textbox_n_Cabinet";
            this.Textbox_n_Cabinet.Size = new System.Drawing.Size(225, 32);
            this.Textbox_n_Cabinet.TabIndex = 49;
            this.Textbox_n_Cabinet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_n_Cabinet.Visible = false;
            this.Textbox_n_Cabinet.OnValueChanged += new System.EventHandler(this.Textbox_n_Cabinet_OnValueChanged);
            this.Textbox_n_Cabinet.Click += new System.EventHandler(this.Textbox_n_Cabinet_Click);
            this.Textbox_n_Cabinet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_n_Cabinet_KeyDown);
            this.Textbox_n_Cabinet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_n_Cabinet_KeyPress);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Transparent;
            this.buttonReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Transition.SetDecoration(this.buttonReturn, BunifuAnimatorNS.DecorationType.None);
            this.buttonReturn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReturn.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.buttonReturn.ForeColor = System.Drawing.Color.White;
            this.buttonReturn.Location = new System.Drawing.Point(400, 297);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(126, 43);
            this.buttonReturn.TabIndex = 51;
            this.buttonReturn.Text = "Вернуться";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Transition.SetDecoration(this.buttonAdd, BunifuAnimatorNS.DecorationType.None);
            this.buttonAdd.Enabled = false;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(153, 297);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 43);
            this.buttonAdd.TabIndex = 50;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // docDiagnozTableAdapter1
            // 
            this.docDiagnozTableAdapter1.ClearBeforeFill = true;
            // 
            // Transition
            // 
            this.Transition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Transition.DefaultAnimation = animation1;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // AddDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 362);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.Textbox_n_Cabinet);
            this.Controls.Add(this.Textbox_N_Region);
            this.Controls.Add(this.Textbox_FIO);
            this.Controls.Add(this.pictureBoxAddImg);
            this.Controls.Add(this.lblSuccesfullAdded);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_n_Cabinet);
            this.Controls.Add(this.lblN_Region);
            this.Controls.Add(this.lblFIO);
            this.Transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDoctorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDoctorForm_FormClosing);
            this.Load += new System.EventHandler(this.AddDoctorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFIO;
        private System.Windows.Forms.Label lblN_Region;
        private System.Windows.Forms.Label lbl_n_Cabinet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxAddImg;
        private System.Windows.Forms.Label lblSuccesfullAdded;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_FIO;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_N_Region;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_n_Cabinet;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonAdd;
        private DispanserizatsiaDataSetTableAdapters.DocDiagnozTableAdapter docDiagnozTableAdapter1;
        private BunifuAnimatorNS.BunifuTransition Transition;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
    }
}
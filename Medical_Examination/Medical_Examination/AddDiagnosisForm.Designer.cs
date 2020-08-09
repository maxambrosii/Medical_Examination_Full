namespace Medical_Examination
{
    partial class AddDiagnosisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDiagnosisForm));
            this.label2 = new System.Windows.Forms.Label();
            this.labelTitleDiagnoz = new System.Windows.Forms.Label();
            this.pictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.labelLine = new System.Windows.Forms.Label();
            this.TextboxDiagnoz = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(116, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 13;
            // 
            // labelTitleDiagnoz
            // 
            this.labelTitleDiagnoz.AutoSize = true;
            this.labelTitleDiagnoz.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.labelTitleDiagnoz, BunifuAnimatorNS.DecorationType.None);
            this.labelTitleDiagnoz.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleDiagnoz.ForeColor = System.Drawing.Color.White;
            this.labelTitleDiagnoz.Location = new System.Drawing.Point(82, 135);
            this.labelTitleDiagnoz.Name = "labelTitleDiagnoz";
            this.labelTitleDiagnoz.Size = new System.Drawing.Size(184, 22);
            this.labelTitleDiagnoz.TabIndex = 12;
            this.labelTitleDiagnoz.Text = "Введите \"Диагноз\":";
            // 
            // pictureBoxTitle
            // 
            this.pictureBoxTitle.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTitle.BackgroundImage = global::Medical_Examination.Properties.Resources.add_1_icon;
            this.pictureBoxTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Transition.SetDecoration(this.pictureBoxTitle, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxTitle.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxTitle.Name = "pictureBoxTitle";
            this.pictureBoxTitle.Size = new System.Drawing.Size(77, 76);
            this.pictureBoxTitle.TabIndex = 44;
            this.pictureBoxTitle.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.lblInfo, BunifuAnimatorNS.DecorationType.None);
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblInfo.Location = new System.Drawing.Point(170, 84);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(282, 23);
            this.lblInfo.TabIndex = 43;
            this.lblInfo.Text = "Вы успешно внесли данные!";
            this.lblInfo.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.lblTitle, BunifuAnimatorNS.DecorationType.None);
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(94, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(498, 24);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "Добавление информации о новом диагнозе";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(141, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.Transition.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(187, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 39;
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
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.labelLine, BunifuAnimatorNS.DecorationType.None);
            this.labelLine.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLine.ForeColor = System.Drawing.Color.White;
            this.labelLine.Location = new System.Drawing.Point(88, 34);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(494, 24);
            this.labelLine.TabIndex = 45;
            this.labelLine.Text = "____________________________________________";
            // 
            // TextboxDiagnoz
            // 
            this.TextboxDiagnoz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.TextboxDiagnoz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TextboxDiagnoz.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Transition.SetDecoration(this.TextboxDiagnoz, BunifuAnimatorNS.DecorationType.None);
            this.TextboxDiagnoz.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextboxDiagnoz.ForeColor = System.Drawing.Color.White;
            this.TextboxDiagnoz.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxDiagnoz.HintText = "";
            this.TextboxDiagnoz.isPassword = false;
            this.TextboxDiagnoz.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxDiagnoz.LineIdleColor = System.Drawing.Color.Black;
            this.TextboxDiagnoz.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxDiagnoz.LineThickness = 3;
            this.TextboxDiagnoz.Location = new System.Drawing.Point(285, 125);
            this.TextboxDiagnoz.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TextboxDiagnoz.Name = "TextboxDiagnoz";
            this.TextboxDiagnoz.Size = new System.Drawing.Size(225, 32);
            this.TextboxDiagnoz.TabIndex = 46;
            this.TextboxDiagnoz.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxDiagnoz.Click += new System.EventHandler(this.TextboxDiagnoz_Click);
            this.TextboxDiagnoz.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuMaterialTextbox1_KeyDown);
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
            this.buttonAdd.Location = new System.Drawing.Point(144, 209);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 43);
            this.buttonAdd.TabIndex = 47;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Transition.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(192, 257);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 53);
            this.button4.TabIndex = 47;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = false;
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
            this.buttonReturn.Location = new System.Drawing.Point(356, 209);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(126, 43);
            this.buttonReturn.TabIndex = 48;
            this.buttonReturn.Text = "Вернуться";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // AddDiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 275);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.TextboxDiagnoz);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.pictureBoxTitle);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitleDiagnoz);
            this.Transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDiagnosisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDiagnosisForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDiagnosisForm_FormClosing);
            this.Load += new System.EventHandler(this.AddDiagnosisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTitleDiagnoz;
        private System.Windows.Forms.PictureBox pictureBoxTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private BunifuAnimatorNS.BunifuTransition Transition;
        private System.Windows.Forms.Label labelLine;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxDiagnoz;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonReturn;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
    }
}
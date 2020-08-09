namespace Medical_Examination
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lbl_Authorization = new System.Windows.Forms.Button();
            this.docDiagnozTableAdapter1 = new Medical_Examination.DispanserizatsiaDataSetTableAdapters.DocDiagnozTableAdapter();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.button_Authorization = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Textbox_Login = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Textbox_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox_Line = new System.Windows.Forms.PictureBox();
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition3 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Line)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition3.SetDecoration(this.lbl_Login, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lbl_Login, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lbl_Login, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Login.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Login.ForeColor = System.Drawing.Color.White;
            this.lbl_Login.Location = new System.Drawing.Point(44, 136);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(102, 33);
            this.lbl_Login.TabIndex = 3;
            this.lbl_Login.Text = "Логин:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition3.SetDecoration(this.lblPassword, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lblPassword, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lblPassword, BunifuAnimatorNS.DecorationType.None);
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(24, 211);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(122, 33);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Пароль:";
            // 
            // lbl_Authorization
            // 
            this.lbl_Authorization.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition3.SetDecoration(this.lbl_Authorization, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lbl_Authorization, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lbl_Authorization, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Authorization.FlatAppearance.BorderSize = 0;
            this.lbl_Authorization.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lbl_Authorization.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lbl_Authorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Authorization.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Authorization.ForeColor = System.Drawing.Color.White;
            this.lbl_Authorization.Location = new System.Drawing.Point(113, 11);
            this.lbl_Authorization.Name = "lbl_Authorization";
            this.lbl_Authorization.Size = new System.Drawing.Size(198, 46);
            this.lbl_Authorization.TabIndex = 7;
            this.lbl_Authorization.Text = "Авторизация";
            this.lbl_Authorization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Authorization.UseVisualStyleBackColor = false;
            // 
            // docDiagnozTableAdapter1
            // 
            this.docDiagnozTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.BackgroundImage = global::Medical_Examination.Properties.Resources.no_translate_detected_1270_84;
            this.pictureBox_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition3.SetDecoration(this.pictureBox_Image, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox_Image, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pictureBox_Image, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox_Image.Location = new System.Drawing.Point(388, -1);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(390, 433);
            this.pictureBox_Image.TabIndex = 8;
            this.pictureBox_Image.TabStop = false;
            this.pictureBox_Image.Visible = false;
            // 
            // button_Authorization
            // 
            this.button_Authorization.BackColor = System.Drawing.Color.Transparent;
            this.button_Authorization.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuTransition3.SetDecoration(this.button_Authorization, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button_Authorization, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.button_Authorization, BunifuAnimatorNS.DecorationType.None);
            this.button_Authorization.Enabled = false;
            this.button_Authorization.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_Authorization.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Authorization.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Authorization.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Authorization.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.button_Authorization.ForeColor = System.Drawing.Color.White;
            this.button_Authorization.Location = new System.Drawing.Point(29, 336);
            this.button_Authorization.Name = "button_Authorization";
            this.button_Authorization.Size = new System.Drawing.Size(149, 43);
            this.button_Authorization.TabIndex = 11;
            this.button_Authorization.Text = "Войти";
            this.button_Authorization.UseVisualStyleBackColor = false;
            this.button_Authorization.Click += new System.EventHandler(this.buttonLoginGroup_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.Transparent;
            this.button_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuTransition3.SetDecoration(this.button_Exit, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button_Exit, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.button_Exit, BunifuAnimatorNS.DecorationType.None);
            this.button_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Exit.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.button_Exit.ForeColor = System.Drawing.Color.White;
            this.button_Exit.Location = new System.Drawing.Point(223, 336);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(149, 43);
            this.button_Exit.TabIndex = 12;
            this.button_Exit.Text = "Выйти";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation3;
            this.bunifuTransition1.TimeStep = 0.009F;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition3.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(68, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 13;
            // 
            // Textbox_Login
            // 
            this.Textbox_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.Textbox_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Textbox_Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.Textbox_Login, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.Textbox_Login, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.Textbox_Login, BunifuAnimatorNS.DecorationType.None);
            this.Textbox_Login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Textbox_Login.ForeColor = System.Drawing.Color.White;
            this.Textbox_Login.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_Login.HintText = "";
            this.Textbox_Login.isPassword = false;
            this.Textbox_Login.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox_Login.LineIdleColor = System.Drawing.Color.Black;
            this.Textbox_Login.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox_Login.LineThickness = 3;
            this.Textbox_Login.Location = new System.Drawing.Point(145, 136);
            this.Textbox_Login.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Textbox_Login.Name = "Textbox_Login";
            this.Textbox_Login.Size = new System.Drawing.Size(225, 32);
            this.Textbox_Login.TabIndex = 14;
            this.Textbox_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_Login.OnValueChanged += new System.EventHandler(this.Textbox_Login_OnValueChanged);
            this.Textbox_Login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_Login_KeyPress);
            // 
            // Textbox_Password
            // 
            this.Textbox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.Textbox_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Textbox_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.Textbox_Password, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.Textbox_Password, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.Textbox_Password, BunifuAnimatorNS.DecorationType.None);
            this.Textbox_Password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Textbox_Password.ForeColor = System.Drawing.Color.White;
            this.Textbox_Password.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_Password.HintText = "";
            this.Textbox_Password.isPassword = true;
            this.Textbox_Password.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox_Password.LineIdleColor = System.Drawing.Color.Black;
            this.Textbox_Password.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox_Password.LineThickness = 3;
            this.Textbox_Password.Location = new System.Drawing.Point(145, 212);
            this.Textbox_Password.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Textbox_Password.Name = "Textbox_Password";
            this.Textbox_Password.Size = new System.Drawing.Size(225, 32);
            this.Textbox_Password.TabIndex = 15;
            this.Textbox_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_Password.OnValueChanged += new System.EventHandler(this.Textbox_Password_OnValueChanged);
            this.Textbox_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_Password_KeyPress);
            // 
            // pictureBox_Line
            // 
            this.pictureBox_Line.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Line.BackgroundImage = global::Medical_Examination.Properties.Resources.ЛИНИЯ;
            this.bunifuTransition3.SetDecoration(this.pictureBox_Line, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox_Line, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pictureBox_Line, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox_Line.Location = new System.Drawing.Point(377, -1);
            this.pictureBox_Line.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Line.Name = "pictureBox_Line";
            this.pictureBox_Line.Size = new System.Drawing.Size(11, 440);
            this.pictureBox_Line.TabIndex = 16;
            this.pictureBox_Line.TabStop = false;
            this.pictureBox_Line.Visible = false;
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.Color.DarkRed;
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.Red;
            this.bunifuColorTransition1.ProgessValue = 0;
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation2;
            this.bunifuTransition2.Interval = 15;
            this.bunifuTransition2.MaxAnimationTime = 1900;
            this.bunifuTransition2.TimeStep = 0.009F;
            // 
            // bunifuTransition3
            // 
            this.bunifuTransition3.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.bunifuTransition3.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 1F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuTransition3.DefaultAnimation = animation1;
            this.bunifuTransition3.Interval = 15;
            this.bunifuTransition3.TimeStep = 0.009F;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 435);
            this.Controls.Add(this.pictureBox_Line);
            this.Controls.Add(this.Textbox_Password);
            this.Controls.Add(this.Textbox_Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Authorization);
            this.Controls.Add(this.pictureBox_Image);
            this.Controls.Add(this.lbl_Authorization);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lbl_Login);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthorizationForm_FormClosing);
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Line)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button lbl_Authorization;
        private DispanserizatsiaDataSetTableAdapters.DocDiagnozTableAdapter docDiagnozTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.Button button_Authorization;
        private System.Windows.Forms.Button button_Exit;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_Login;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_Password;
        private System.Windows.Forms.PictureBox pictureBox_Line;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}


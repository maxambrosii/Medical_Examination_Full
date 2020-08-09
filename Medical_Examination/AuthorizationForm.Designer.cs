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
            BunifuAnimatorNS.Animation animation13 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            BunifuAnimatorNS.Animation animation14 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation15 = new BunifuAnimatorNS.Animation();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.docDiagnozTableAdapter1 = new Medical_Examination.DispanserizatsiaDataSetTableAdapters.DocDiagnozTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition3 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition3.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition3.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition3.SetDecoration(this.buttonLogin, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.buttonLogin, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.buttonLogin, BunifuAnimatorNS.DecorationType.None);
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(151, 14);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(264, 57);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Авторизация";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // docDiagnozTableAdapter1
            // 
            this.docDiagnozTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Medical_Examination.Properties.Resources.no_translate_detected_1270_84;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition3.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(517, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 533);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuTransition3.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(39, 414);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 53);
            this.button1.TabIndex = 11;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonLoginGroup_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuTransition3.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(297, 414);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 53);
            this.button2.TabIndex = 12;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button3_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation13.AnimateOnlyDifferences = true;
            animation13.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.BlindCoeff")));
            animation13.LeafCoeff = 0F;
            animation13.MaxTime = 1F;
            animation13.MinTime = 0F;
            animation13.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.MosaicCoeff")));
            animation13.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation13.MosaicShift")));
            animation13.MosaicSize = 0;
            animation13.Padding = new System.Windows.Forms.Padding(0);
            animation13.RotateCoeff = 0F;
            animation13.RotateLimit = 0F;
            animation13.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.ScaleCoeff")));
            animation13.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.SlideCoeff")));
            animation13.TimeCoeff = 0F;
            animation13.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation13;
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
            this.label3.Location = new System.Drawing.Point(91, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 22);
            this.label3.TabIndex = 13;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(216)))));
            this.bunifuMaterialTextbox1.BackgroundImage = global::Medical_Examination.Properties.Resources.Screenshot_1;
            this.bunifuMaterialTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuMaterialTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuMaterialTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuMaterialTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(193, 168);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(300, 39);
            this.bunifuMaterialTextbox1.TabIndex = 14;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox1.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            this.bunifuMaterialTextbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMaterialTextbox1_KeyPress);
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(216)))));
            this.bunifuMaterialTextbox2.BackgroundImage = global::Medical_Examination.Properties.Resources.Screenshot_2;
            this.bunifuMaterialTextbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuMaterialTextbox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuMaterialTextbox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuMaterialTextbox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = true;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(193, 261);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(300, 39);
            this.bunifuMaterialTextbox2.TabIndex = 15;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox2.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged_1);
            this.bunifuMaterialTextbox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMaterialTextbox2_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Medical_Examination.Properties.Resources.ЛИНИЯ;
            this.bunifuTransition3.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Location = new System.Drawing.Point(503, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 542);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
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
            animation14.AnimateOnlyDifferences = true;
            animation14.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.BlindCoeff")));
            animation14.LeafCoeff = 0F;
            animation14.MaxTime = 1F;
            animation14.MinTime = 0F;
            animation14.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.MosaicCoeff")));
            animation14.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation14.MosaicShift")));
            animation14.MosaicSize = 0;
            animation14.Padding = new System.Windows.Forms.Padding(0);
            animation14.RotateCoeff = 0F;
            animation14.RotateLimit = 0F;
            animation14.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.ScaleCoeff")));
            animation14.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.SlideCoeff")));
            animation14.TimeCoeff = 0F;
            animation14.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation14;
            this.bunifuTransition2.Interval = 15;
            this.bunifuTransition2.MaxAnimationTime = 1900;
            this.bunifuTransition2.TimeStep = 0.009F;
            // 
            // bunifuTransition3
            // 
            this.bunifuTransition3.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.bunifuTransition3.Cursor = null;
            animation15.AnimateOnlyDifferences = true;
            animation15.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation15.BlindCoeff")));
            animation15.LeafCoeff = 0F;
            animation15.MaxTime = 1F;
            animation15.MinTime = 0F;
            animation15.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation15.MosaicCoeff")));
            animation15.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation15.MosaicShift")));
            animation15.MosaicSize = 0;
            animation15.Padding = new System.Windows.Forms.Padding(50);
            animation15.RotateCoeff = 1F;
            animation15.RotateLimit = 0F;
            animation15.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation15.ScaleCoeff")));
            animation15.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation15.SlideCoeff")));
            animation15.TimeCoeff = 0F;
            animation15.TransparencyCoeff = 1F;
            this.bunifuTransition3.DefaultAnimation = animation15;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Medical_Examination.Properties.Resources.fuzzy_1800136_19203;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 535);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bunifuMaterialTextbox2);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthorizationForm_FormClosing);
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogin;
        private DispanserizatsiaDataSetTableAdapters.DocDiagnozTableAdapter docDiagnozTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}


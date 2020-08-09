namespace Medical_Examination
{
    partial class SupportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupportForm));
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblTitle = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.textBoxMessage.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxMessage.Location = new System.Drawing.Point(10, 204);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(350, 210);
            this.textBoxMessage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 19;
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
            this.buttonReturn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonReturn.Location = new System.Drawing.Point(209, 439);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(149, 43);
            this.buttonReturn.TabIndex = 29;
            this.buttonReturn.Text = "Вернуться";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.Transparent;
            this.buttonSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSend.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSend.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.buttonSend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSend.Location = new System.Drawing.Point(10, 439);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(149, 43);
            this.buttonSend.TabIndex = 28;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(10, 128);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(57, 20);
            this.lblMail.TabIndex = 30;
            this.lblMail.Text = "E-mail*";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(7, 184);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(110, 20);
            this.lblMessage.TabIndex = 31;
            this.lblMessage.Text = "Сообщение*";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxEmail.Location = new System.Drawing.Point(10, 146);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(350, 23);
            this.textBoxEmail.TabIndex = 32;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatAppearance.BorderSize = 0;
            this.lblTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(44, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(322, 46);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Свяжитесь с нами";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.UseVisualStyleBackColor = false;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxName.Location = new System.Drawing.Point(10, 89);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(350, 23);
            this.textBoxName.TabIndex = 35;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(10, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 20);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "Имя*";
            // 
            // SupportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(371, 509);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Служба поддержки";
            this.Load += new System.EventHandler(this.SupportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox textBoxEmail;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button lblTitle;
    }
}
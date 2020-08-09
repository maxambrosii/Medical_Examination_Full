namespace Medical_Examination
{
    partial class LoaderForm
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
            this.progressBarBackUp = new System.Windows.Forms.ProgressBar();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProcent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBarBackUp
            // 
            this.progressBarBackUp.Location = new System.Drawing.Point(17, 59);
            this.progressBarBackUp.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarBackUp.Name = "progressBarBackUp";
            this.progressBarBackUp.Size = new System.Drawing.Size(414, 44);
            this.progressBarBackUp.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(118, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 22);
            this.lblTitle.TabIndex = 37;
            this.lblTitle.Text = "Идет создание BackUP...";
            // 
            // lblProcent
            // 
            this.lblProcent.AutoSize = true;
            this.lblProcent.BackColor = System.Drawing.Color.Transparent;
            this.lblProcent.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProcent.ForeColor = System.Drawing.Color.White;
            this.lblProcent.Location = new System.Drawing.Point(212, 118);
            this.lblProcent.Name = "lblProcent";
            this.lblProcent.Size = new System.Drawing.Size(36, 22);
            this.lblProcent.TabIndex = 38;
            this.lblProcent.Text = "0%";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(449, 162);
            this.Controls.Add(this.lblProcent);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.progressBarBackUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoaderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarBackUp;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProcent;
        private System.Windows.Forms.Timer timer1;
    }
}
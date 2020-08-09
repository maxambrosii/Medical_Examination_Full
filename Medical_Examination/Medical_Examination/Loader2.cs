﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Examination
{
    public partial class Loader2 : Form
    {
        public Loader2()
        {
            InitializeComponent();
        }

        private void Loader2_Load(object sender, EventArgs e)
        {
            progressBarBackUp.Value = 0;
            int i = 0;

            timer1.Interval = 100;
            timer1.Tick += (s, a) =>
            {
                progressBarBackUp.Value += 2;
                i += 2;
                lblProcent.Text = i + "%";
                if (progressBarBackUp.Value == progressBarBackUp.Maximum)
                {
                    timer1.Stop();
                    this.Close();
                }
            };
            timer1.Start();
        }
    }
}

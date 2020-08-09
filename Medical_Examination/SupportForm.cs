using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Threading;

namespace Medical_Examination
{
    public partial class SupportForm : Form
    {
        public SupportForm()
        {
            InitializeComponent();
        }
        private static void SendMail(MailMessage mail, SmtpClient client)
        {
            client.Send(mail);
        }
        

        
      
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("ProgramIvanov@mail.ru");
                mail.To.Add(new MailAddress("ProgramIvanov@mail.ru"));
                mail.Subject = "Yokoyama Studio";
                mail.Body = textBox1.Text;
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.mail.ru";
                client.Port = 25;
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("ProgramIvanov@mail.ru", "Password123");
                client.Send(mail);
                label1.ForeColor = Color.Green;
                label1.Text = "Message sent successfully";
                textBox1.Text = "";
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }
    }
}

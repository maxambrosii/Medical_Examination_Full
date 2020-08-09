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
        

        private void buttonReturn_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {

            try
            {
                MailAddress fromMailAdress = new MailAddress("ProgramIvanov@mail.ru");
                MailAddress toMailAdress = new MailAddress("ProgramIvanov@mail.ru");
                using (MailMessage mailMessage = new MailMessage(fromMailAdress, toMailAdress))
                using (SmtpClient client = new SmtpClient())
                {
                    mailMessage.Subject = "User " + textBoxEmail.Text + " need Help";
                    mailMessage.Body = textBoxMessage.Text;
                    client.Credentials = new NetworkCredential("ProgramIvanov@mail.ru", "Password123");
                    client.Host = "smtp.mail.ru";
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(fromMailAdress.Address, "Password123");
                    client.Send(mailMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DialogResult dialogResult = MessageBox.Show("SUCCESSFULLY!");

                this.Close();

            }
        }

        private void SupportForm_Load(object sender, EventArgs e)
        {

        }
    }
}

using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Email
{
    public partial class FrmEmail : DevExpress.XtraEditors.XtraForm
    {
        public FrmEmail()
        {
            InitializeComponent();
        }
        private void BtnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mm = new MailMessage();
                string frommail = "T.cakiroglu07@gmail.com";
                string appPassword = "voaxjcghtayqzljj";
                string receiver = TxtAlici.Text;
                string subject = TxtKonu.Text;
                string content = richTextBox1.Text;

                mm.From = new MailAddress(frommail);
                mm.To.Add(receiver);
                mm.Subject = subject;
                mm.Body = content;
                mm.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(frommail, appPassword);

                smtp.Send(mm);
                MessageBox.Show("Mail Başarıyla Gönderildi.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail gönderilirken bir hata oluştu: " + ex.Message);
            }
        }


        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
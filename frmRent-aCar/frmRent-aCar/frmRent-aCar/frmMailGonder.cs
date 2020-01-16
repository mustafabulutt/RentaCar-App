using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net.Mail;

namespace frmRent_aCar
{
    public partial class frmMailGonder : DevExpress.XtraEditors.XtraForm
    {
        public frmMailGonder()
        {
            InitializeComponent();
        }

        private void frmMailGonder_Load(object sender, EventArgs e)
        {
           
          
        }

        private void btnGönder_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("rentacarproje@hotmail.com", "DataHouse16");
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesaj.To.Add(txtHedefMail.Text.ToString());
            mesaj.From = new MailAddress("rentacarproje@hotmail.com");
            mesaj.Subject = txtBaslik.Text.ToString();
            mesaj.Body = txtMesaj.Text.ToString();
            istemci.Send(mesaj);
            MessageBox.Show("Teslim Edildi");
        }
    }
}
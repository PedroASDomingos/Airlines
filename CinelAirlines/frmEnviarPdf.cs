using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinelAirlines
{
    public partial class frmEnviarPdf : Form
    {
        string GuardaPdf;
        public frmEnviarPdf(string pdf)
        {
            InitializeComponent();
            GuardaPdf = pdf;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            //verifica se o campo email está preenchido 
            if (string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Introduza o email para enviar o bilhete", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //caso esteja tudo correcto, envia informação para enviar email
            EnviaMensagemEmail(txt_email.Text, GuardaPdf);
            this.Close();
        }

        public static void EnviaMensagemEmail(string Email, string pdf)
        {
            // valida o email
            bool bValidaEmail = ValidaEnderecoEmail(Email);

            // Se o email não é validao retorna uma mensagem
            if (bValidaEmail == false)
            {
                MessageBox.Show("Email do destinatário inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.office365.com");

                mail.From = new MailAddress("##EMAIL##");
                mail.To.Add(Email);
                mail.Subject = "Cinel Airlines - Boarding pass";
                mail.Body = "Caro cliente, é com prazer que anexamos o seu bilhete de embarque";

                Attachment att = new Attachment(pdf);
                mail.Attachments.Add(att);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("##EMAIL##", "##PASS##");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Email enviado às " + DateTime.Now.ToString() + ".", "Email enviado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public static bool ValidaEnderecoEmail(string enderecoEmail)
        {
            try
            {
                //define a expressão regulara para validar o email
                string texto_Validar = enderecoEmail;
                Regex expressaoRegex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");

                // testa o email com a expressão
                if (expressaoRegex.IsMatch(texto_Validar))
                {
                    // o email é valido
                    return true;
                }
                else
                {
                    // o email é inválido
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

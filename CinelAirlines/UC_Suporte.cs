using LibraryCinelAirlines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinelAirlines
{
    public partial class UC_Suporte : UserControl
    {
        int idUtilizador;
        string utilizador;
        string email;
        public UC_Suporte( int id)
        {
            InitializeComponent();
            idUtilizador = id;
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_assunto.Text))
            {
                MessageBox.Show("Introduza o assunto do seu email", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txt_texto.Text))
            {
                MessageBox.Show("Introduza a sua questão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (Users user in Users.ListaUtilizadores)
            {
                if (idUtilizador == user.IdUser)
                {
                    utilizador = user.User;
                    email = user.Email;
                }
            }
                EnviaMensagemEmail(txt_assunto.Text, txt_texto.Text, utilizador, email);
            txt_assunto.Text = "";
            txt_texto.Text = "";
        }
        public static void EnviaMensagemEmail(string assunto, string texto, string utilizador, string email)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.office365.com");

                mail.From = new MailAddress("##EMAIL##");
                mail.To.Add("##EMAIL##");
                mail.Subject = "CINEL Airlines - Solicitação de suporte";
                mail.Body = "O Utilizador: " + utilizador + " com o Email: " + email + " solicitou apoio com o assunto: " + assunto + " Seguido do texto com o texto: " + texto;

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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_assunto.Text = "";
            txt_texto.Text = "";
        }
    }
}

using FluentEmail.Smtp;
using LibraryCinelAirlines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinelAirlines
{
    public partial class frmForgotPass : Form
    {
        //Varivavis para drag
        bool mouseDown;
        private Point offset;
        public frmForgotPass()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {   
            foreach (Users user in Users.ListaUtilizadores)
            {
                if (user.User == txt_user.Text && user.Email == txt_email.Text)
                {
                    EnviaMensagemEmail(txt_user.Text, txt_email.Text, user.Password);
                    this.Dispose();
                    return;
                }
            }
            if (true)
            {
                    MessageBox.Show("User Name ou Email errado(s)!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }
            
        }

        public static void EnviaMensagemEmail(string User, string Email , string Pass)
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
                mail.Subject = "CINEL Airlines - Envio de Password";
                mail.Body = "O Utilizador: " + User + " com o Email: " + Email + " solicitou reenvio da sua password: " + Pass;

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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}

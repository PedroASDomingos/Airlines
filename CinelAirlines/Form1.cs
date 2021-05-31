using LibraryCinelAirlines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinelAirlines
{
    public partial class Form1 : Form
    {
        //Varivavis para drag
        bool mouseDown;
        private Point offset;
        public Form1()
        {
            InitializeComponent();

            //esconde caracteres da plavra-pass
            txt_pass.UseSystemPasswordChar = true;

            //Carrega lista de utilizadores
            Users.ConstroiListaUsers();
        }

        private void btn_software_Click(object sender, EventArgs e)
        {
            //Mostra form Créditos
            frmSoftware frmsoft = new frmSoftware();
            frmsoft.ShowDialog();
        }

        //Função para fazer drag do modulo login
        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panelMove_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //Pergunta se pretende sair da aplicação
            if (MessageBox.Show("Deseja sair da aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            //Botão fecha a aplicação
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //Validações Login
            if (string.IsNullOrEmpty(txt_user.Text))
            {
                MessageBox.Show("Introduza o User Name", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txt_pass.Text))
            {
                MessageBox.Show("Introduza a Password", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (Users user in Users.ListaUtilizadores)
            {
                if (txt_user.Text == user.User && txt_pass.Text == user.Password)
                {
                    FormMenu fm = new FormMenu(user.IdUser, user.User, user.UltimoLogin, user.NivelAcesso);
                    fm.ShowDialog();
                    this.Close();
                }
            }
            if (true)
            {
                MessageBox.Show("User Name ou Password errado(s)!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void cb_escondePass_CheckedChanged(object sender, EventArgs e)
        {
            //esconde ou mostra password
            if (cb_escondePass.Checked)
            {
                txt_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void btn_fp_Click(object sender, EventArgs e)
        {
            //Chama form para recuperar pass
                frmForgotPass ffp = new frmForgotPass();
                ffp.Show();
        }
    }
}

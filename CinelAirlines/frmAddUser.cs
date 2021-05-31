using LibraryCinelAirlines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinelAirlines
{
    public partial class frmAddUser : Form
    {
        UC_Users _form;
        int idnovoregisto;

        //Varivavis para drag
        bool mouseDown;
        private Point offset;

        public frmAddUser(UC_Users form, int id)
        {
            InitializeComponent();
            _form = form;
            if (id != 0)
            {
                idnovoregisto = id + 1;
            }
            else
            {
                idnovoregisto = 0;
            }
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_user.Text))
            {
                MessageBox.Show("Insira o nome de Utilizador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txt_pass.Text))
            {
                MessageBox.Show("Insira a palavra-pass", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txt_confirmaPass.Text))
            {
                MessageBox.Show("Confirme a palavra-pass", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_pass.Text != txt_confirmaPass.Text)
            {
                MessageBox.Show("Palavra-pass não coincidem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Insira o email", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (Users user in Users.ListaUtilizadores)
            {
                if (user.User == txt_user.Text && user.Email == txt_email.Text)
                {
                    MessageBox.Show("Esse registo já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            int premissao;
            if (cb_admin.Checked)
            {
                premissao = 0;
            }
            else
            {
                premissao = 1;
            }

            //gravar novo registo
            Users.GravarNovoRegisto(idnovoregisto, txt_user.Text, txt_pass.Text, txt_email.Text, " ", premissao);

            _form.ConstroiLista();
            idnovoregisto = idnovoregisto + 1;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

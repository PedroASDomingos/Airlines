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
    public partial class frmEditarUser : Form
    {
        Users _editado;
        UC_Users _form;

        //Varivavis para drag
        bool mouseDown;
        private Point offset;

        public frmEditarUser(UC_Users form, Users editado)
        {
            InitializeComponent();

            _editado = editado;
            _form = form;
            txt_id.Text = editado.IdUser.ToString();
            txt_user.Text = editado.User;
            txt_pass.Text = editado.Password;
            txt_email.Text = editado.Email;

            if (editado.NivelAcesso == 0)
            {
                cb_admin.Checked = true;
            }
            else
            {
                cb_admin.Checked = false;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_user.Text))
            {
                MessageBox.Show("Insira o nome de Utilizador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txt_pass.Text))
            {
                MessageBox.Show("Insira a password", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txt_confirmaPass.Text))
            {
                MessageBox.Show("Confirme a password", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_pass.Text != txt_confirmaPass.Text)
            {
                MessageBox.Show("Palavra-pass e confirmação são diferentes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Insira o email", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            _editado.User = txt_user.Text;
            _editado.Password = txt_pass.Text;
            _editado.Email = txt_email.Text;

            if (cb_admin.Checked)
            {
                _editado.NivelAcesso = 0;
            }
            else
            {
                _editado.NivelAcesso = 1;
            }

            Users.GravarFicheiro();
            _form.ConstroiLista();
            this.Close();
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

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
    public partial class frmEditarAeroporto : Form
    {
        Aeroporto _editado;
        UC_Paises _form;

        //Varivavis para drag
        bool mouseDown;
        private Point offset;
        public frmEditarAeroporto(UC_Paises form, Aeroporto editado)
        {
            InitializeComponent();
            _editado = editado;
            _form = form;
            txt_id.Text = editado.IdAeroporto.ToString();
            txt_nomeAeroporto.Text = editado.NomeAeroporto;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nomeAeroporto.Text))
            {
                MessageBox.Show("Insira o nome do Aeroporto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            _editado.NomeAeroporto = txt_nomeAeroporto.Text;

            Aeroportos.GravarFicheiro();
            _form.ConstroiLista();
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
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

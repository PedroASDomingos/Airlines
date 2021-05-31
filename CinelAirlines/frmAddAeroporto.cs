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
    public partial class frmAddAeroporto : Form
    {
        //variveis de utilização
        UC_Paises _form;
        int IdPais;
        int IdAeroporto;

        //Varivavis para drag
        bool mouseDown;
        private Point offset;
        public frmAddAeroporto(UC_Paises form, int id, int idpais)
        {
            InitializeComponent();
            _form = form;
            if (id != 0)
            {
                IdAeroporto = id + 1;
            }
            else
            {
                IdAeroporto = 0;
            }
            IdPais = idpais;
        }
        //função para drag do form
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

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nomeAeroporto.Text))
            {
                MessageBox.Show("Introduza o nome do Aeroporto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (Aeroporto aeroporto in Aeroportos.ListaAeroportos)
            {
                if (aeroporto.NomeAeroporto == txt_nomeAeroporto.Text)
                {
                    MessageBox.Show("Esse registo já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            //gravar novo registo
            Aeroportos.GravarNovoRegisto(IdAeroporto, IdPais, txt_nomeAeroporto.Text);

            _form.ConstroiLista();
            IdAeroporto = IdAeroporto + 1;

            txt_nomeAeroporto.Text = "";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

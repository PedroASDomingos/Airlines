using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryCinelAirlines;

namespace CinelAirlines
{
    public partial class UC_Voos : UserControl
    {
        int indice;
        public UC_Voos()
        {
            InitializeComponent();
            ConstroiLista();
        }

        private void UC_Voos_Load(object sender, EventArgs e)
        {

        }

        public void ConstroiLista()
        {
            //Limpa Lista
            VoosListBox.DataSource = null;

            //carrega Lista
            VoosListBox.DataSource = Voo.ListaVoos;
            VoosListBox.DisplayMember = "ApresentacaoDadosVoo";
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            //Mostra Form Home 
            foreach (Voo voo in Voo.ListaVoos)
            {
                indice = voo.IdVoo;
            }
            frmAddVoos fav = new frmAddVoos(this, indice);
            fav.Show();

        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            if (VoosListBox.SelectedItem == null)
            {
                MessageBox.Show("Não selecionou nenhum Voo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Voo vooAApagar = (Voo)VoosListBox.SelectedItem;
            Voo apagado = null;
            foreach (Voo voo in Voo.ListaVoos)
            {
                if (vooAApagar.IdVoo == voo.IdVoo)
                {
                    apagado = voo;
                }
            }
            if (apagado != null)
            {
                DialogResult resposta;
                resposta = MessageBox.Show($"Tem a certeza que pretende apagar o {apagado.NomeVoo}", "Apagar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == resposta)
                {
                    Voo.ListaVoos.Remove(apagado);
                    Voo.GravarFicheiro();
                    ConstroiLista();
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (VoosListBox.SelectedItem == null)
            {
                MessageBox.Show("Não selecionou nenhum Voo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Voo vooAEditar = (Voo)VoosListBox.SelectedItem;
            Voo editado = null;
            foreach (Voo voo in Voo.ListaVoos)
            {
                if (vooAEditar.IdVoo == voo.IdVoo)
                {
                    editado = voo;
                }
            }
            //abrir a form nova para editar 
            frmEditarVoo editarVooForm = new frmEditarVoo(this, editado);
            editarVooForm.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //Limpa Lista
            VoosListBox.DataSource = null;

            //carrega Lista
            VoosListBox.DataSource = Voo.ListaVoos;
            VoosListBox.DisplayMember = "ApresentacaoDadosVoo";
        }

        private void VoosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Voo novovoo in Voo.ListaVoos)
            {
                if (novovoo.IdVoo == VoosListBox.SelectedIndex)
                {
                    lbl_nomevoo.Text = novovoo.NomeVoo;
                    lbl_data.Text = novovoo.DataVoo;
                    lbl_hora.Text = novovoo.HoraVoo;
                    lbl_paisorigem.Text = novovoo.PaisOrigem;
                    lbl_aeroportoorigem.Text = novovoo.AeroportoOrigem;
                    lbl_paisdestino.Text = novovoo.PaisDestino;
                    lbl_aeroportodestino.Text = novovoo.AeroportoDestino;
                    lbl_aviao.Text = novovoo.NumAparelho;
                }
            }
        }
    }
}

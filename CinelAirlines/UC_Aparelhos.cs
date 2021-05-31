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
    public partial class UC_Aparelhos : UserControl
    {
        //Variavel capta indice
        int indiceAparelhos;
        //Variaveis pasta das imagens
        string Pasta = Directory.GetCurrentDirectory();
        string PastaImagens = @"\Imagens\";

        public UC_Aparelhos()
        {
            InitializeComponent();
            ConstroiLista();
        }

        public void ConstroiLista()
        {
            //Limpa Lista
            AparelhosListBox.DataSource = null;

            //carrega Lista
            AparelhosListBox.DataSource = Aparelhos.ListaAparelhos;
            AparelhosListBox.DisplayMember = "ApresentacaoDadosAparelhos";

            Paises.GravarFicheiro();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            foreach (Aparelhos aparelho in Aparelhos.ListaAparelhos)
            {
                indiceAparelhos = aparelho.IdAparelho;
            }
            frmAddAparelho faa = new frmAddAparelho(this, indiceAparelhos);
            faa.Show();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            if (AparelhosListBox.SelectedItem == null)
            {
                MessageBox.Show("Não selecionou nenhum Aparelho!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Aparelhos aparelhoAApagar = (Aparelhos)AparelhosListBox.SelectedItem;
            Aparelhos apagado = null;
            foreach (Aparelhos aparelho in Aparelhos.ListaAparelhos)
            {
                if (aparelhoAApagar.IdAparelho == aparelho.IdAparelho)
                {
                    apagado = aparelho;
                }
            }
            if (apagado != null)
            {
                DialogResult resposta;
                resposta = MessageBox.Show($"Tem a certeza que pretende apagar o {apagado.NomeAparelho}", "Apagar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == resposta)
                {
                    Aparelhos.ListaAparelhos.Remove(apagado);
                    Aparelhos.GravarFicheiro();
                    ConstroiLista();
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (AparelhosListBox.SelectedItem == null)
            {
                MessageBox.Show("Não selecionou nenhum Aparelho!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Aparelhos aparelhoAEditar = (Aparelhos)AparelhosListBox.SelectedItem;
            Aparelhos editado = null;
            foreach (Aparelhos aparelho in Aparelhos.ListaAparelhos)
            {
                if (aparelhoAEditar.IdAparelho == aparelho.IdAparelho)
                {
                    editado = aparelho;
                }
            }
            //abrir a form nova para editar 
            frmEditarAparelho editarAparelhoForm = new frmEditarAparelho(this, editado);
            editarAparelhoForm.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //Limpa Lista
            AparelhosListBox.DataSource = null;

            //carrega Lista
            AparelhosListBox.DataSource = Aparelhos.ListaAparelhos;
            AparelhosListBox.DisplayMember = "ApresentacaoDadosAparelhos";
        }

        private void AparelhosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Aparelhos aparelho in Aparelhos.ListaAparelhos)
            {
                if (aparelho.IdAparelho == AparelhosListBox.SelectedIndex)
                {
                    lbl_nomeAviao.Text = aparelho.NomeAparelho;
                    lbl_lotacaoeco.Text = "Lotação em Económica: " + aparelho.LotacaoEconomica;
                    lbl_lotacaoexe.Text = "Lotação em executiva: " + aparelho.LotacaoExecutiva;
                    if (aparelho.Imagem != "null")
                    {
                        pictureBox1.Load(Pasta + PastaImagens + aparelho.Imagem);
                    }
                    else
                    {
                        pictureBox1.Load(Pasta + PastaImagens + "Avioes.png");
                    }
                }

            }
        }
    }
}

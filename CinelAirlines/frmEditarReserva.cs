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
    public partial class frmEditarReserva : Form
    {
        int guardaIdVoo;
        string guardaAparelho;

        //Variaveis pasta das imagens
        string Pasta = Directory.GetCurrentDirectory();
        string PastaImagens = @"\Imagens\";
        public frmEditarReserva(int id)
        {
            InitializeComponent();
            guardaIdVoo = id;
            foreach (Voo voo in Voo.ListaVoos)
            {
                if (voo.IdVoo == guardaIdVoo)
                {
                    lbl_data.Text = voo.DataVoo;
                    lbl_hora.Text = voo.HoraVoo;
                    lbl_aviao.Text = voo.NumAparelho;
                    guardaAparelho = voo.NumAparelho;
                }
            }
            ReservasListBox.DataSource = null;
            ReservasListBox.DataSource = Reservas.ListaReservas.Where(x => x.IdVoo == guardaIdVoo).ToList();
            ReservasListBox.DisplayMember = "ApresentacaoDadosReserva";
            foreach (Aparelhos aparelho in Aparelhos.ListaAparelhos)
            {
                if (aparelho.NomeAparelho == guardaAparelho)
                {
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_AnularReserva_Click(object sender, EventArgs e)
        {
            if (ReservasListBox.SelectedItem == null)
            {
                MessageBox.Show("Não selecionou nenhuma reserva!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Reservas reservaAApagar = (Reservas)ReservasListBox.SelectedItem;
            Reservas apagado = null;
            foreach (Reservas reserva in Reservas.ListaReservas)
            {
                if (reservaAApagar.IdPassageiro == reserva.IdPassageiro)
                {
                    apagado = reserva;
                }
            }
            if (apagado != null)
            {
                DialogResult resposta;
                resposta = MessageBox.Show($"Tem a certeza que pretende apagar a reserva em nome de: {apagado.NomePassageiro} com o lugar: {apagado.Assento} ", "Apagar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == resposta)
                {
                    Reservas.ListaReservas.Remove(apagado);
                    Reservas.GravarFicheiro();
                    ConstroiLista();
                }
            }
        }

        private void ConstroiLista()
        {
            ReservasListBox.DataSource = null;
            ReservasListBox.DataSource = Reservas.ListaReservas.Where(x => x.IdVoo == guardaIdVoo).ToList();
            ReservasListBox.DisplayMember = "ApresentacaoDadosReserva";
        }

        private void ReservasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //lbl_aviao.Text = ReservasListBox.SelectedItem.ToString(); 
        }
    }
}

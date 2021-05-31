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
    public partial class UC_Reservas : UserControl
    {
        //Variaveis outras tabelas
        string guardaAparelho;
        int guardaIdVoo;
        string guardaVoo;
        string newFile;
        int contador;
        int Eco = 0;
        int Exe = 0;
        int checkPesquisa = 1;

        public UC_Reservas()
        {
            InitializeComponent();
            dtp_dataPartida.Format = DateTimePickerFormat.Custom;
            dtp_dataPartida.CustomFormat = "dd/MM/yyyy";
            lbl_aviao.Text = "";
            lbl_data.Text = "";
            lbl_hora.Text = "";


            //foreach (Voo voo in Voo.ListaVoos)
            //{
            //    VoosListBox.Items.Add(voo.NomeVoo + " // Origem: " + voo.PaisOrigem + " // Destino: " + voo.PaisDestino);
            //}
            VoosListBox.DataSource = Voo.ListaVoos;
            VoosListBox.DisplayMember = "ApresentacaoDadosVooLista";
        }
private void ColocaLugares()
        {
            for (int i = 1; i <= Eco; i++)
            {
                Label label = addlabelEco(i);
                flowLayoutPanel1.Controls.Add(label);
                label.Click += new System.EventHandler(this.labelClick);
            }

            for (int i = 1; i <= Exe; i++)
            {
                Label label = addlabelExe(i);
                flowLayoutPanel2.Controls.Add(label);
                label.Click += new System.EventHandler(this.labelClick);
            }
        }
        private void labelClick(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.BackColor == Color.Red)
            {
                foreach (Reservas reserva in Reservas.ListaReservas)
                {
                    if (reserva.IdVoo == guardaIdVoo && reserva.Assento == label.Name)
                    {
                        newFile = reserva.FicheiroPdf;
                    }
                }
                frmMostraPdf fmp = new frmMostraPdf(newFile);
                fmp.Show();
            }
            else
            {
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel2.Controls.Clear();
                frmAddInfoReserva fair = new frmAddInfoReserva(this, Reservas.ListaReservas.Count, guardaVoo, guardaAparelho, label.Name);
                fair.Show();
            }
        }

        Label addlabelEco(int i)
        {
             Label label = new Label();
             label.Name = "Eco" + i.ToString();
             label.Text = i.ToString();
             label.BackColor = Color.Blue;
             label.ForeColor = Color.White;
             label.Width = 45;
             label.Height = 45;
             label.TextAlign = ContentAlignment.MiddleCenter;
             label.Margin = new Padding(5);

            foreach (Reservas reserva in Reservas.ListaReservas)
            {
                if (reserva.IdVoo == guardaIdVoo && reserva.Assento == label.Name)
                {
                    label.BackColor = Color.Red;
                    //label.Enabled = false;
                }
            }
            return label;
        }

        Label addlabelExe(int i)
        {
            Label label = new Label();
            label.Name = "Exe" + i.ToString();
            label.Text = i.ToString();
            label.ForeColor = Color.White;
            label.BackColor = Color.Blue;
            label.Width = 45;
            label.Height = 45;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Margin = new Padding(5);
            foreach (Reservas reserva in Reservas.ListaReservas)
            {
                if (reserva.IdVoo == guardaIdVoo && reserva.Assento == label.Name)
                {
                    label.BackColor = Color.Red;
                }
            }
            return label;
        }

        private void btn_porVoo_Click(object sender, EventArgs e)
        {
            VoosListBox.DataSource = null;
            VoosListBox.DataSource = Voo.ListaVoos;
            VoosListBox.DisplayMember = "ApresentacaoDadosVooLista";
        }

        private void VoosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            foreach (Voo voo in Voo.ListaVoos)
            {
                if (VoosListBox.SelectedIndex == voo.IdVoo)
                {
                    guardaIdVoo = voo.IdVoo;
                    guardaVoo = voo.NomeVoo;
                    lbl_data.Text = voo.DataVoo;
                    lbl_hora.Text = voo.HoraVoo;
                    lbl_aviao.Text = voo.NumAparelho;
                    guardaAparelho = voo.NumAparelho;
                }
            }
            foreach (Aparelhos aparelhos in Aparelhos.ListaAparelhos)
            {
                if (aparelhos.NomeAparelho == guardaAparelho)
                {
                    Eco = aparelhos.LotacaoEconomica;
                    Exe = aparelhos.LotacaoExecutiva;
                }
            }
            ColocaLugares();

            contador = 0;
            foreach (Reservas reserva in Reservas.ListaReservas)
            {
                if (reserva.IdVoo == guardaIdVoo)
                {
                    contador++;
                }
                if (contador > 0)
                {
                    btn_cancelarReserva.Visible = true;
                }
                else
                {
                    btn_cancelarReserva.Visible = false;
                }
            }
        }

        private void btn_cancelarReserva_Click(object sender, EventArgs e)
        {
            //chama form gestão de reserva e envia Id voo
            frmEditarReserva fer = new frmEditarReserva(guardaIdVoo);
            fer.Show();
        }

        private void btn_alteraPesquisa_Click(object sender, EventArgs e)
        {
            if (checkPesquisa == 1)
            {
                panelPesquisaPais.Visible = false;
                panelPesquisaData.Visible = true;
                btn_alteraPesquisa.Text = "Pesquisa por pais";
                checkPesquisa = 0;
                return;
            }
            if (checkPesquisa == 0)
            {
                panelPesquisaPais.Visible = true;
                panelPesquisaData.Visible = false;
                btn_alteraPesquisa.Text = "Pesquisa por data";
                checkPesquisa = 1;
                return;
            }
        }

        private void btn_pesquisaDestino_Click(object sender, EventArgs e)
        {
            if (txt_pesquisaOrigem.Text == string.Empty && txt_pesquisaDestino.Text == string.Empty)
            {
                MessageBox.Show("Introduza o país de origem e/ou país de destino", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_pesquisaOrigem.Text != string.Empty && txt_pesquisaDestino.Text == string.Empty)
            {
                VoosListBox.DataSource = null;
                VoosListBox.DataSource = Voo.ListaVoos.Where(x => x.PaisOrigem == txt_pesquisaOrigem.Text).ToList();
                VoosListBox.DisplayMember = "ApresentacaoDadosVooLista";
                if (VoosListBox.Items.Count == 0)
                {
                    MessageBox.Show("Não existe voos com esse pais de origem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (txt_pesquisaOrigem.Text == string.Empty && txt_pesquisaDestino.Text != string.Empty)
            {
                VoosListBox.DataSource = null;
                VoosListBox.DataSource = Voo.ListaVoos.Where(x => x.PaisDestino == txt_pesquisaDestino.Text).ToList();
                VoosListBox.DisplayMember = "ApresentacaoDadosVooLista";
                if (VoosListBox.Items.Count == 0)
                {
                    MessageBox.Show("Não existe voos com esse destino!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (txt_pesquisaOrigem.Text != string.Empty && txt_pesquisaDestino.Text != string.Empty)
            {
                VoosListBox.DataSource = null;
                VoosListBox.DataSource = Voo.ListaVoos.Where(x => x.PaisOrigem == txt_pesquisaOrigem.Text && x.PaisDestino == txt_pesquisaDestino.Text).ToList();
                VoosListBox.DisplayMember = "ApresentacaoDadosVooLista";
                if (VoosListBox.Items.Count == 0)
                {
                    MessageBox.Show("Não existe voos com esse destino!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void btn_pesquisaData_Click(object sender, EventArgs e)
        {
            lbl_data.Text = string.Empty;
            lbl_hora.Text = string.Empty;
            lbl_aviao.Text = string.Empty;
            if (dtp_dataPartida.Text == string.Empty)
            {
                MessageBox.Show("Introduza a data de partida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dtp_dataPartida.Text != string.Empty)
            {
                VoosListBox.DataSource = null;
                VoosListBox.DataSource = Voo.ListaVoos.Where(x => x.DataVoo == dtp_dataPartida.Text).ToList();
                VoosListBox.DisplayMember = "ApresentacaoDadosVooLista";
                if (VoosListBox.Items.Count == 0)
                {
                    MessageBox.Show("Não existe voos com essa data de partida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }
    }
}



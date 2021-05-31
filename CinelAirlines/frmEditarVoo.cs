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
    public partial class frmEditarVoo : Form
    {
        Voo _editado;
        UC_Voos _form;

        //Varivavis para drag
        bool mouseDown;
        private Point offset;

        //Variaveis para guardar ID´s dos paies 
        int GuardaIdPaisOrigem;
        int GuardaIdPaisDestino;

        public frmEditarVoo(UC_Voos form, Voo editado)
        {
            InitializeComponent();
            _editado = editado;
            _form = form;
            txt_idvoo.Text = editado.IdVoo.ToString();
            txt_nomeVoo.Text = editado.NomeVoo;
            dateTimePicker1.Text = editado.DataVoo;
            txt_hora.Text = editado.HoraVoo;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.MinDate = DateTime.Now;

            foreach (Paises pais in Paises.ListaPaises)
            {
                listboxPaisOrigem.Items.Add(pais.NomePais);
                listboxPaisDestino.Items.Add(pais.NomePais);
            }
            listboxPaisOrigem.Text = editado.PaisOrigem;
            listboxAeroportoOrigem.Text = editado.AeroportoOrigem;
            listboxPaisDestino.Text = editado.PaisDestino;
            listboxAeroportoDestino.Text = editado.AeroportoDestino;
            foreach (Aparelhos aparelho in Aparelhos.ListaAparelhos)
            {
                listboxAparelhos.Items.Add(aparelho.NomeAparelho);
            }
            listboxAparelhos.Text = editado.NumAparelho;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nomeVoo.Text))
            {
                MessageBox.Show("Introduza o nome do Voo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show("Introduza a data do Voo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txt_hora.Text))
            {
                MessageBox.Show("Introduza a hora do Voo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(listboxPaisOrigem.Text))
            {
                MessageBox.Show("Selecione o Pais de Origem do Voo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(listboxAeroportoOrigem.Text))
            {
                MessageBox.Show("Selecione o Aeroporto de Origem do Voo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(listboxPaisDestino.Text))
            {
                MessageBox.Show("Selecione o Pais de Destino do Voo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(listboxAeroportoDestino.Text))
            {
                MessageBox.Show("Selecione o Aeroporto de Destino do Voo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(listboxAparelhos.Text))
            {
                MessageBox.Show("Selecione o Aparelho que irá realizar o Voo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _editado.NomeVoo = txt_nomeVoo.Text;
            _editado.DataVoo = dateTimePicker1.Text;
            _editado.HoraVoo = txt_hora.Text;
            _editado.PaisOrigem = listboxPaisOrigem.Text;
            _editado.AeroportoOrigem = listboxAeroportoOrigem.Text;
            _editado.PaisDestino = listboxPaisDestino.Text;
            _editado.AeroportoDestino = listboxAeroportoDestino.Text;
            _editado.NumAparelho = listboxAparelhos.Text;

            Voo.GravarFicheiro();
            _form.ConstroiLista();
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void listboxPaisDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxAeroportoDestino.Enabled = true;
            listboxAeroportoDestino.Text = "";
            listboxAeroportoDestino.Items.Clear();
            foreach (Paises pais in Paises.ListaPaises)
            {
                if (pais.NomePais == listboxPaisDestino.Text)
                {
                    GuardaIdPaisDestino = pais.Id;
                }
            }
            foreach (Aeroporto aeroporto in Aeroportos.ListaAeroportos)
            {
                if (GuardaIdPaisDestino == aeroporto.IdPais)
                {
                    listboxAeroportoDestino.Items.Add(aeroporto.NomeAeroporto);
                }
            }
        }

        private void listboxPaisOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxAeroportoOrigem.Enabled = true;
            listboxAeroportoOrigem.Text = "";
            listboxAeroportoOrigem.Items.Clear();
            foreach (Paises pais in Paises.ListaPaises)
            {
                if (pais.NomePais == listboxPaisOrigem.Text)
                {
                    GuardaIdPaisOrigem = pais.Id;
                }
            }
            foreach (Aeroporto aeroporto in Aeroportos.ListaAeroportos)
            {
                if (GuardaIdPaisOrigem == aeroporto.IdPais)
                {
                    listboxAeroportoOrigem.Items.Add(aeroporto.NomeAeroporto);
                }
            }
        }

        private void frmEditarVoo_Load(object sender, EventArgs e)
        {

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

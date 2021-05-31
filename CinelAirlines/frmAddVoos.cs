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
    public partial class frmAddVoos : Form
    {
        UC_Voos _form;
        int idnovoregisto;
        int GuardaIdPaisOrigem;
        int GuardaIdPaisDestino;

        //Varivavis para drag
        bool mouseDown;
        private Point offset;

        public frmAddVoos(UC_Voos form, int id)
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.MinDate = DateTime.Now;

            txt_hora.MaxLength = 2;
            txt_minutos.MaxLength = 2;
            _form = form;
            if (id != 0)
            {
                idnovoregisto = id + 1;
            }
            else
            {
                idnovoregisto = 0;
            }

            foreach (Paises pais in Paises.ListaPaises)
            {
                listboxPaisOrigem.Items.Add(pais.NomePais);
                listboxPaisDestino.Items.Add(pais.NomePais);
            }

            foreach (Aparelhos aparelho in Aparelhos.ListaAparelhos)
            {
                listboxAparelhos.Items.Add(aparelho.NomeAparelho);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
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
            if (string.IsNullOrEmpty(txt_minutos.Text))
            {
                MessageBox.Show("Introduza os minutos do Voo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            int hora = Convert.ToInt32(txt_hora.Text);
            if (hora <1 || hora > 24)
            {
                MessageBox.Show("Hora inserida está incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int minutos = Convert.ToInt32(txt_minutos.Text);
            if (minutos < 0 || hora > 59)
            {
                MessageBox.Show("Minutos inseridos está incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (Voo voo in Voo.ListaVoos)
            {
                if (voo.NomeVoo == txt_nomeVoo.Text)
                {
                    MessageBox.Show("Esse registo já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            string hem = txt_hora.Text + ":" + txt_minutos.Text;
            Voo.GravarNovoRegisto(idnovoregisto, txt_nomeVoo.Text, dateTimePicker1.Text, hem, listboxPaisOrigem.Text, listboxAeroportoOrigem.Text, listboxPaisDestino.Text, listboxAeroportoDestino.Text, listboxAparelhos.Text);
            _form.ConstroiLista();
            idnovoregisto = idnovoregisto + 1;
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

        private void txt_hora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_minutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

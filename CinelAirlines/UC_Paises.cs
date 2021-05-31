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
using LibraryCinelAirlines;

namespace CinelAirlines
{
    public partial class UC_Paises : UserControl
    {
        //variavel para captar indice do ultimo registo da lista
        int indice;

        int GuardaIdPais;

        //Variaveis pasta das imagens
        string Pasta = Directory.GetCurrentDirectory();
        string PastaImagens = @"\Imagens\";

        public UC_Paises()
        {
            InitializeComponent();
            ConstroiLista();
        }

        private void UC_Paises_Load(object sender, EventArgs e)
        {

        }

        public void ConstroiLista()
        {
            //Limpa Lista
            PaisesListBox.DataSource = null;

            //carrega Lista
            PaisesListBox.DataSource = Paises.ListaPaises;
            PaisesListBox.DisplayMember = "ApresentacaoDadosPais";

            Paises.GravarFicheiro();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            foreach (Paises pais in Paises.ListaPaises)
            {
                indice = pais.Id;
            }
            frmAddPais fap = new frmAddPais(this, indice);
            fap.Show();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            if (PaisesListBox.SelectedItem == null)
            {
                MessageBox.Show("Não selecionou nenhum Pais!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Paises paisAApagar = (Paises)PaisesListBox.SelectedItem;
            Paises apagado = null;
            foreach (Paises pais in Paises.ListaPaises)
            {
                if (paisAApagar.Id == pais.Id)
                {
                    apagado = pais;
                }
            }
            if (apagado != null)
            {
                DialogResult resposta;
                resposta = MessageBox.Show($"Tem a certeza que pretende apagar o {apagado.NomePais}", "Apagar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == resposta)
                {
                    Paises.ListaPaises.Remove(apagado);
                    Paises.GravarFicheiro();
                    ConstroiLista();
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            PaisesListBox.DataSource = null;
            PaisesListBox.DataSource = Paises.ListaPaises;
            PaisesListBox.DisplayMember = "ApresentacaoDadosPais";
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (PaisesListBox.SelectedItem == null)
            {
                MessageBox.Show("Não selecionou nenhum Pais!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Paises paisAEditar = (Paises)PaisesListBox.SelectedItem;
            Paises editado = null;
                foreach (Paises pais in Paises.ListaPaises)
                {
                    if (paisAEditar.Id == pais.Id)
                    {
                        editado = pais;
                    }
                }
                //abrir a form nova para editar 
                frmEditarPais editarPaisForm = new frmEditarPais(this, editado);
                editarPaisForm.Show();
        }

        private void PaisesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AeroportoslistBox.Items.Clear();
            foreach (Paises pais in Paises.ListaPaises)
            {
                if (pais.Id == PaisesListBox.SelectedIndex)
                {
                    GuardaIdPais = pais.Id;
                    lbl_nomePais.Text = pais.NomePais;
                    //txt_nomeAeroporto.Text = pais.NomeAeroporto;
                    if (pais.Imagem != "null")
                    {
                        pictureBox1.Load(Pasta + PastaImagens + pais.Imagem); 
                    }
                    else
                    {
                        pictureBox1.Load(Pasta + PastaImagens + "BandeiraBranca.jpg");
                    }
                    
                }
            }
            foreach (Aeroporto aeroporto in Aeroportos.ListaAeroportos)
            {
                if (GuardaIdPais == aeroporto.IdPais)
                {
                    AeroportoslistBox.Items.Add(aeroporto.NomeAeroporto);
                }
            }
        }

        private void btn_addAeroporto_Click(object sender, EventArgs e)
        {
            foreach (Aeroporto aeroporto in Aeroportos.ListaAeroportos)
            {
                indice = aeroporto.IdAeroporto;
            }
            frmAddAeroporto fap = new frmAddAeroporto(this, indice, GuardaIdPais);
            fap.Show();
        }

        private void btn_apagarAeroporto_Click(object sender, EventArgs e)
        {
            if (AeroportoslistBox.SelectedItem == null)
            {
                MessageBox.Show("Não selecionou nenhum Aeroporto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Aeroporto apagado = null;
            foreach (Aeroporto aeroporto in Aeroportos.ListaAeroportos)
            {
                if (AeroportoslistBox.SelectedItem == aeroporto.NomeAeroporto)
                {
                    apagado = aeroporto;
                }
            }
            if (apagado != null)
            {
                DialogResult resposta;
                resposta = MessageBox.Show($"Tem a certeza que pretende apagar o {apagado.NomeAeroporto}", "Apagar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == resposta)
                {
                    Aeroportos.ListaAeroportos.Remove(apagado);
                    Aeroportos.GravarFicheiro();
                }
                AeroportoslistBox.Items.Clear();
                foreach (Aeroporto aeroporto in Aeroportos.ListaAeroportos)
                {
                    if (GuardaIdPais == aeroporto.IdPais)
                    {
                        AeroportoslistBox.Items.Add(aeroporto.NomeAeroporto);
                    }
                }
            }
        }
            private void btn_editarAeroporto_Click(object sender, EventArgs e)
        {
            if (AeroportoslistBox.SelectedItem == null)
            {
                MessageBox.Show("Não selecionou nenhum Aeroporto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Paises paisAEditar = (Paises)AeroportoslistBox.SelectedItem
            Aeroporto editado = null;
            foreach (Aeroporto aeroporto in Aeroportos.ListaAeroportos)
            {
                if (AeroportoslistBox.SelectedItem == aeroporto.NomeAeroporto)
                {
                    editado = aeroporto;
                }
            }
            //abrir a form nova para editar 
            frmEditarAeroporto editarAeroportoForm = new frmEditarAeroporto(this, editado);
            editarAeroportoForm.Show();
        }
    }
}

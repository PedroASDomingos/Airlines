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
    public partial class frmEditarPais : Form
    {
        Paises _editado;
        UC_Paises _form;
        string guardaCaminho = "null";
        string nomeFicheiro;

        //Varivavis para drag
        bool mouseDown;
        private Point offset;

        //Variaveis pasta das imagens
        string Pasta = Directory.GetCurrentDirectory();
        string PastaImagens = @"\Imagens\";
        
        public frmEditarPais(UC_Paises form, Paises editado)
        {
            InitializeComponent();
            _editado = editado;
            _form = form;
            txt_idPais.Text = editado.Id.ToString();
            comboBox1.Text = editado.NomePais;
            if (editado.Imagem == "null")
            {
                txt_imagem.Text = "";
            }
            else
            {
                txt_imagem.Text = editado.Imagem;
            }
            guardaCaminho = editado.Imagem;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Insira o nome do Pais", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            _editado.NomePais = comboBox1.Text;
            _editado.NomeAeroporto = "null";
            _editado.Imagem = guardaCaminho;

            Paises.GravarFicheiro();
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

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txt_imagem.Text = open.FileName;
            }
            SalvaImagem();
        }

        private void SalvaImagem()
        {
            File.Copy(txt_imagem.Text, Path.Combine(Pasta + PastaImagens, Path.GetFileName(txt_imagem.Text)), true);
            MessageBox.Show("Upload da imagem feito com sucesso!");
            nomeFicheiro = Path.GetFileName(txt_imagem.Text);
            guardaCaminho = nomeFicheiro;
        }
    }
}

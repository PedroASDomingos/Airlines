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
    public partial class frmEditarNoticia : Form
    {
        Noticias _editado;
        UC_Info _form;

        string guardaCaminho;
        string nomeFicheiro;

        //Varivavis para drag
        bool mouseDown;
        private Point offset;

        //Variaveis pasta das imagens
        string Pasta = Directory.GetCurrentDirectory();
        string PastaImagens = @"\Imagens\";

        public frmEditarNoticia(UC_Info form, Noticias editado)
        {
            InitializeComponent();
            _editado = editado;
            _form = form;
            txt_idNoticia.Text = editado.IdNoticia.ToString();
            txt_titulo.Text = editado.TituloNoticia;
            txt_texto.Text = editado.TextoNoticia;
            dateTimePicker1.Text = editado.DataNoticia;
            txt_imagem.Text = editado.Imagem;
            guardaCaminho = editado.Imagem;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_titulo.Text))
            {
                MessageBox.Show("Introduza o titulo da notícia", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txt_texto.Text))
            {
                MessageBox.Show("Introduza o texto da notícia", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show("Introduza a data da notícia", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            _editado.TituloNoticia = txt_titulo.Text;
            _editado.TextoNoticia = txt_texto.Text;
            _editado.DataNoticia = dateTimePicker1.Text;

            Noticias.GravarFicheiro();
            _form.ConstroiListaNoticias();
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
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp;*.png;";
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

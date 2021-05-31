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
    public partial class frmEditarAparelho : Form
    {
        Aparelhos _editado;
        UC_Aparelhos _form;
        string guardaCaminho = null;
        string nomeFicheiro;

        //Varivavis para drag
        bool mouseDown;
        private Point offset;

        //Variaveis pasta das imagens
        string Pasta = Directory.GetCurrentDirectory();
        string PastaImagens = @"\Imagens\";

        public frmEditarAparelho(UC_Aparelhos form, Aparelhos editado)
        {
            InitializeComponent();
            _editado = editado;
            _form = form;
            txt_idAparelho.Text = editado.IdAparelho.ToString();
            txt_nomeAparelho.Text = editado.NomeAparelho;
            txt_lotEco.Text = editado.LotacaoEconomica.ToString();
            txt_lotExe.Text = editado.LotacaoExecutiva.ToString();
            if (editado.Imagem != "null")
            {
                txt_imagem.Text = Path.GetFileName(editado.Imagem);
            }
            else
            {
                txt_imagem.Text = "";
            }
            guardaCaminho = editado.Imagem;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nomeAparelho.Text))
            {
                MessageBox.Show("Introduza  o Nome do Aparelho", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txt_lotEco.Text))
            {
                MessageBox.Show("Introduza o número de lugares em Económica", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txt_lotExe.Text))
            {
                MessageBox.Show("Introduza o número de lugares em Executiva", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            _editado.NomeAparelho = txt_nomeAparelho.Text;
            _editado.LotacaoEconomica = Convert.ToInt32(txt_lotEco.Text);
            _editado.LotacaoExecutiva = Convert.ToInt32(txt_lotExe.Text);
            _editado.Imagem = guardaCaminho;

            Aparelhos.GravarFicheiro();
            _form.ConstroiLista();
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_lotEco_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solução para utilizador apenas introduzir numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_lotExe_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solução para utilizador apenas introduzir numeros
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

        private void txt_lotEco_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //Solução para utilizador apenas introduzir numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_lotExe_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //Solução para utilizador apenas introduzir numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

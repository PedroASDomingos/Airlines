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
    public partial class frmAddAparelho : Form
    {
        UC_Aparelhos _form;
        int idnovoregisto;
        string guardaCaminho = "null";
        string nomeFicheiro;

        //Varivavis para drag
        bool mouseDown;
        private Point offset;

        //Variaveis pasta das imagens
        string Pasta = Directory.GetCurrentDirectory();
        string PastaImagens = @"\Imagens\";

        public frmAddAparelho(UC_Aparelhos form, int id)
        {
            InitializeComponent();
            _form = form;
            if (id != 0)
            {
                idnovoregisto = id + 1;
            }
            else
            {
                idnovoregisto = 0;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
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
            foreach (Aparelhos aparelho in Aparelhos.ListaAparelhos)
            {
                if (aparelho.NomeAparelho == txt_nomeAparelho.Text && aparelho.LotacaoEconomica == Convert.ToInt32(txt_lotEco.Text) && aparelho.LotacaoExecutiva == Convert.ToInt32(txt_lotExe.Text))
                {
                    MessageBox.Show("Esse registo já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            //gravar novo registo
            Aparelhos.GravarNovoRegisto(idnovoregisto, txt_nomeAparelho.Text, Convert.ToInt32(txt_lotEco.Text), Convert.ToInt32(txt_lotExe.Text), guardaCaminho);
            _form.ConstroiLista();
            idnovoregisto = idnovoregisto + 1;

            txt_nomeAparelho.Text = "";
            txt_lotEco.Text = "";
            txt_lotExe.Text = "";
            txt_imagem.Text = "";
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

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
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

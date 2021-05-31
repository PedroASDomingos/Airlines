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
    public partial class frmAddFuncionario : Form
    {
        UC_Info _form;
        int idnovoregisto;
        string guardaCaminho = "null";
        string nomeFicheiro;

        //Varivavis para drag
        bool mouseDown;
        private Point offset;

        //Variaveis pasta das imagens
        string Pasta = Directory.GetCurrentDirectory();
        string PastaImagens = @"\Imagens\";

        public frmAddFuncionario(UC_Info form, int id)
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

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nome.Text))
            {
                MessageBox.Show("Introduza  o Nome do funcionário ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txt_cargo.Text))
            {
                MessageBox.Show("Introduza o cargo do funcionário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Introduza o email do funcionário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txt_extensao.Text))
            {
                MessageBox.Show("Introduza a extensão do funcionário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            
            foreach (Funcionarios funcionario in Funcionarios.ListaFuncionarios)
            {
                if (funcionario.Nome == txt_nome.Text && funcionario.Cargo == txt_cargo.Text && funcionario.Email == txt_email.Text)
                {
                    MessageBox.Show("Esse registo já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            //gravar novo registo
            Funcionarios.GravarNovoRegisto(idnovoregisto, txt_nome.Text, txt_cargo.Text, txt_email.Text, txt_extensao.Text, guardaCaminho);
            _form.ConstroiListaFuncionarios();
            idnovoregisto = idnovoregisto + 1;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

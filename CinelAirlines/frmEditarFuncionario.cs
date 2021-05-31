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
    public partial class frmEditarFuncionario : Form
    {
        Funcionarios _editado;
        UC_Info _form;
        string guardaCaminho = "null";
        string nomeFicheiro;

        //Varivavis para drag
        bool mouseDown;
        private Point offset;

        public frmEditarFuncionario(UC_Info form, Funcionarios editado)
        {
            InitializeComponent();
            _editado = editado;
            _form = form;
            txt_id.Text = editado.IdFuncionario.ToString();
            txt_nome.Text = editado.Nome;
            txt_cargo.Text = editado.Cargo;
            txt_email.Text = editado.Email;
            txt_extensao.Text = editado.Extencao;
            txt_imagem.Text = editado.Imagem;
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
            File.Copy(txt_imagem.Text, Path.Combine(@"C:\Users\pedro\source\repos\CinelAirlines\CinelAirlines\Resources\", Path.GetFileName(txt_imagem.Text)), true);
            MessageBox.Show("Upload da imagem feito com sucesso!");
            nomeFicheiro = Path.GetFileName(txt_imagem.Text);
            guardaCaminho = @"C:\Users\pedro\source\repos\CinelAirlines\CinelAirlines\Resources\" + nomeFicheiro;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nome.Text))
            {
                MessageBox.Show("Insira o nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txt_cargo.Text))
            {
                MessageBox.Show("Insira o Cargo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Insira o email", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txt_extensao.Text))
            {
                MessageBox.Show("Insira o Extensão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _editado.Nome = txt_nome.Text;
            _editado.Cargo = txt_cargo.Text;
            _editado.Email = txt_email.Text;
            _editado.Extencao = txt_extensao.Text;
            _editado.Imagem = guardaCaminho;

            Funcionarios.GravarFicheiro();
            _form.ConstroiListaFuncionarios();
            this.Close();
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

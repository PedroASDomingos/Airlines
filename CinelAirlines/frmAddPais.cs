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
    
    public partial class frmAddPais : Form
    {
        string guardaCaminho = "null";
        string nomeFicheiro;
        UC_Paises _form;
        int idnovoregisto;

        //Varivavis para drag
        bool mouseDown;
        private Point offset;

        //Variaveis pasta das imagens
        string Pasta = Directory.GetCurrentDirectory();
        string PastaImagens = @"\Imagens\";
        
        public frmAddPais(UC_Paises form, int id)
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
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Selecione o Pais", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (Paises pais in Paises.ListaPaises)
            {
                if(pais.NomePais == comboBox1.Text)
                {
                    MessageBox.Show("Esse registo já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            this.Alert("Sucesso", frmAlerta.enmType.Sucesso);

            //gravar novo registo
            Paises.GravarNovoRegisto(idnovoregisto, comboBox1.Text, "null", guardaCaminho);
            
            _form.ConstroiLista();
            idnovoregisto = idnovoregisto + 1;

            comboBox1.Text = "";
            txt_imagem.Text = "";
        }
        public void Alert (string msg, frmAlerta.enmType type)
        {
            frmAlerta frmA = new frmAlerta();
            frmA.showAlert(msg, type);
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

        private void SalvaImagem()
        {
            File.Copy(txt_imagem.Text, Path.Combine(Pasta + PastaImagens, Path.GetFileName(txt_imagem.Text)), true);
            MessageBox.Show("Upload da imagem feito com sucesso!");
            nomeFicheiro = Path.GetFileName(txt_imagem.Text);
            guardaCaminho = nomeFicheiro;
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txt_imagem.Text = open.FileName;
            }
            if (guardaCaminho != "null")
            {
                SalvaImagem();
            }
            
        }
    }
}

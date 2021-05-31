using iTextSharp.text.pdf;
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
    public partial class frmAddInfoReserva : Form
    {
        UC_Reservas _form;
        int idnovoregisto;
        int guardaIdVoo;
        public frmAddInfoReserva(UC_Reservas form, int id, string nvoo, string aparelho, string assento)
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
            txt_voo.Text = nvoo;
            txt_aparelho.Text = aparelho;
            txt_assento.Text = assento;
            foreach (Voo voo in Voo.ListaVoos)
            {
                if (voo.NomeVoo == nvoo)
                {
                    guardaIdVoo = voo.IdVoo;
                    txt_data.Text = voo.DataVoo;
                    txt_hora.Text = voo.HoraVoo;
                    txt_de.Text = voo.PaisOrigem;
                    txt_deAeroporto.Text = voo.AeroportoOrigem;
                    txt_para.Text = voo.PaisDestino;
                    txt_paraAeroporto.Text = voo.AeroportoDestino;
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nome.Text))
            {
                MessageBox.Show("Introduza  o Nome do Passageiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           
            Random rnd = new Random();
            int rndnumb = rnd.Next(1, 22);

            string Pasta = Directory.GetCurrentDirectory();
            string caminhoPDFS = Pasta + @"\PDFS\";
            string pdfTemplate = caminhoPDFS + "template\\template.pdf";

            Guid id = Guid.NewGuid();
            string nomePDF = id + ".pdf";
            string newFile = caminhoPDFS + nomePDF;

            PdfReader pdfreader = new PdfReader(pdfTemplate);
            PdfStamper pdfStamper = new PdfStamper(pdfreader, new FileStream(newFile, FileMode.Create));

            AcroFields camposPDF = pdfStamper.AcroFields;
            camposPDF.SetField("nome", txt_nome.Text);
            camposPDF.SetField("de", txt_de.Text);
            camposPDF.SetField("para", txt_para.Text);
            camposPDF.SetField("carrier", "Cinel Airlines");
            camposPDF.SetField("data", txt_data.Text);
            camposPDF.SetField("hora", txt_hora.Text);
            camposPDF.SetField("voo", txt_voo.Text);
            camposPDF.SetField("lugar", txt_assento.Text);
            camposPDF.SetField("porta", rndnumb.ToString());
            camposPDF.SetField("horaate", txt_hora.Text);
            camposPDF.SetField("nome2", txt_nome.Text);
            camposPDF.SetField("de2", txt_de.Text);
            camposPDF.SetField("para2", txt_para.Text);
            camposPDF.SetField("data2", txt_data.Text);
            camposPDF.SetField("hora2", txt_hora.Text);
            camposPDF.SetField("voo2", txt_voo.Text);
            camposPDF.SetField("lugar2", txt_assento.Text);
            camposPDF.SetField("porta2", rndnumb.ToString());
            camposPDF.SetField("horaate2", txt_hora.Text);

            pdfStamper.Close();

            //gravar novo registo
            Reservas.GravarNovoRegisto(idnovoregisto, txt_nome.Text, guardaIdVoo, txt_assento.Text, newFile);
            //_form.ConstroiLista();
            idnovoregisto = idnovoregisto + 1;

            frmMostraPdf fmp = new frmMostraPdf(newFile);
            fmp.Show();

            this.Close();
            
        }
    }
}

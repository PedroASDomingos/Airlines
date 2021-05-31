using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinelAirlines
{
    public partial class frmMostraPdf : Form
    {
        //Varivavis para drag
        bool mouseDown;
        private Point offset;

        //variavel para guardar caminho do pdf
        string GuardaPdf;
        public frmMostraPdf(string caminho)
        {
            InitializeComponent();
            GuardaPdf = caminho;
            axAcroPDF1.src = caminho;
            axAcroPDF1.setZoom(135);
        }

        private void btn_fechar_Click(object sender, EventArgs e)
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

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            frmEnviarPdf fep = new frmEnviarPdf(GuardaPdf);
            fep.Show();
        }
    }
}

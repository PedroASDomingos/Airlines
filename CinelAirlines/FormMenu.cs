using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryCinelAirlines;

namespace CinelAirlines
{
    public partial class FormMenu : Form
    {
        //variaveis de utilização
        int IDuser;
        string User;
        string DataULogin;

        //Varivavis para drag
        bool mouseDown;
        private Point offset;
        public FormMenu(int iduser, string user , string ulogin , int na)
        {
            InitializeComponent();
            //mostra dados utilizador
            IDuser = iduser;
            User = user;
            DataULogin = ulogin;
            //ve se o utilizador é administrador ou não
            if (na == 0)
            {
                btn_info.Visible = true; 
                btn_users.Visible = true;
            }

            //Inicia o relogio do form principal
            timer1.Start();

            //Carrega lista de aparelhos
            Aparelhos.ConstroiListaAparelhos();

            //carrega lista de voos
            Voo.ConstroiListaVoos();

            //Carrega lista de paises
            Paises.ConstroiListaPaises();

            //Carrega Aeroportos
            Aeroportos.ConstroiListaAeroportos();

            //Carrega lista de noticias
            Noticias.ConstroiListaNoticias();

            //Carrega Funcionarios
            Funcionarios.ConstroiListaFuncionarios();

            //Carrega Reservas
            Reservas.ConstroiListaReservas();

            //Carrega Tempo
            Tempo.ConstroiListaTempo();

            //Mostra Form Home 
            UC_Home ucHome = new UC_Home(IDuser, User, DataULogin);
            AdicionarControladorAoPainel(ucHome);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //Pergunta se pretende sair da aplicação
            if (MessageBox.Show("Deseja sair da aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            DataULogin = DateTime.Now.ToString("dd/MM/yyyy");

            foreach (Users users in Users.ListaUtilizadores)
            {
                if (IDuser == users.IdUser)
                {
                    users.UltimoLogin = DataULogin;
                }
            }

            //Grava data do ultimo login
            Users.GravarFicheiro();
            //Botão fecha a aplicação
            Application.Exit();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            btn_home.BackColor = Color.FromArgb(255, 193, 0);

            //Mostra Form Home 
            UC_Home ucHome = new UC_Home(IDuser, User, DataULogin);
            AdicionarControladorAoPainel(ucHome);

            //Limpa click dos outros botões
            btn_voos.BackColor = Color.FromArgb(53, 45, 125);
            btn_paises.BackColor = Color.FromArgb(53, 45, 125);
            btn_reservas.BackColor = Color.FromArgb(53, 45, 125);
            btn_aparelhos.BackColor = Color.FromArgb(53, 45, 125);
            btn_info.BackColor = Color.FromArgb(53, 45, 125);
            btn_users.BackColor = Color.FromArgb(53, 45, 125);
            btn_suporte.BackColor = Color.FromArgb(53, 45, 125);
            btn_sobre.BackColor = Color.FromArgb(53, 45, 125);
        }

        private void btn_voos_Click(object sender, EventArgs e)
        {
            btn_voos.BackColor = Color.FromArgb(255, 193, 0);

            //Mostra Form Home 
            UC_Voos ucVoos = new UC_Voos();
            AdicionarControladorAoPainel(ucVoos);

            //Limpa click dos outros botões
            btn_home.BackColor = Color.FromArgb(53, 45, 125);
            btn_paises.BackColor = Color.FromArgb(53, 45, 125);
            btn_reservas.BackColor = Color.FromArgb(53, 45, 125);
            btn_aparelhos.BackColor = Color.FromArgb(53, 45, 125);
            btn_info.BackColor = Color.FromArgb(53, 45, 125);
            btn_users.BackColor = Color.FromArgb(53, 45, 125);
            btn_suporte.BackColor = Color.FromArgb(53, 45, 125);
            btn_sobre.BackColor = Color.FromArgb(53, 45, 125);
        }

        private void btn_reservas_Click(object sender, EventArgs e)
        {
            //Muda a cor do botão que foi clickado
            btn_reservas.BackColor = Color.FromArgb(255, 193, 0);

            //Mostra Form Reservas 
            UC_Reservas ucReservas = new UC_Reservas();
            AdicionarControladorAoPainel(ucReservas);

            //Limpa click dos outros botões
            btn_home.BackColor = Color.FromArgb(53, 45, 125);
            btn_voos.BackColor = Color.FromArgb(53, 45, 125);
            btn_paises.BackColor = Color.FromArgb(53, 45, 125);
            btn_aparelhos.BackColor = Color.FromArgb(53, 45, 125);
            btn_info.BackColor = Color.FromArgb(53, 45, 125);
            btn_users.BackColor = Color.FromArgb(53, 45, 125);
            btn_suporte.BackColor = Color.FromArgb(53, 45, 125);
            btn_sobre.BackColor = Color.FromArgb(53, 45, 125);
        }

        private void btn_paises_Click(object sender, EventArgs e)
        {
            //Muda a cor do botão que foi clickado
            btn_paises.BackColor = Color.FromArgb(255, 193, 0);

            //Mostra UCForm paises 
            UC_Paises ucPaises = new UC_Paises();
            AdicionarControladorAoPainel(ucPaises);

            //Limpa click dos outros botões
            btn_home.BackColor = Color.FromArgb(53, 45, 125);
            btn_voos.BackColor = Color.FromArgb(53, 45, 125);
            btn_reservas.BackColor = Color.FromArgb(53, 45, 125);
            btn_aparelhos.BackColor = Color.FromArgb(53, 45, 125);
            btn_info.BackColor = Color.FromArgb(53, 45, 125);
            btn_users.BackColor = Color.FromArgb(53, 45, 125);
            btn_suporte.BackColor = Color.FromArgb(53, 45, 125);
            btn_sobre.BackColor = Color.FromArgb(53, 45, 125);
        }

        private void btn_aparelhos_Click(object sender, EventArgs e)
        {
            //Muda a cor do botão que foi clickado
            btn_aparelhos.BackColor = Color.FromArgb(255, 193, 0);

            //Mostra UCForm Aparelhos 
            UC_Aparelhos ucAparelhos = new UC_Aparelhos();
            AdicionarControladorAoPainel(ucAparelhos);

            //Limpa click dos outros botões
            btn_home.BackColor = Color.FromArgb(53, 45, 125);
            btn_voos.BackColor = Color.FromArgb(53, 45, 125);
            btn_paises.BackColor = Color.FromArgb(53, 45, 125);
            btn_reservas.BackColor = Color.FromArgb(53, 45, 125);
            btn_info.BackColor = Color.FromArgb(53, 45, 125);
            btn_users.BackColor = Color.FromArgb(53, 45, 125);
            btn_suporte.BackColor = Color.FromArgb(53, 45, 125);
            btn_sobre.BackColor = Color.FromArgb(53, 45, 125);
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            //Muda a cor do botão que foi clickado
            btn_info.BackColor = Color.FromArgb(255, 193, 0);

            //Mostra UCForm Info 
            UC_Info ucInfo = new UC_Info();
            AdicionarControladorAoPainel(ucInfo);

            //Limpa click dos outros botões
            btn_home.BackColor = Color.FromArgb(53, 45, 125);
            btn_voos.BackColor = Color.FromArgb(53, 45, 125);
            btn_paises.BackColor = Color.FromArgb(53, 45, 125);
            btn_aparelhos.BackColor = Color.FromArgb(53, 45, 125);
            btn_reservas.BackColor = Color.FromArgb(53, 45, 125);
            btn_users.BackColor = Color.FromArgb(53, 45, 125);
            btn_suporte.BackColor = Color.FromArgb(53, 45, 125);
            btn_sobre.BackColor = Color.FromArgb(53, 45, 125);
        }
        private void btn_users_Click(object sender, EventArgs e)
        {
            //Muda a cor do botão que foi clickado
            btn_users.BackColor = Color.FromArgb(255, 193, 0);

            //Mostra UC Form Utilizadores
            UC_Users ucUsers = new UC_Users();
            AdicionarControladorAoPainel(ucUsers);

            //Limpa click dos outros botões
            btn_home.BackColor = Color.FromArgb(53, 45, 125);
            btn_voos.BackColor = Color.FromArgb(53, 45, 125);
            btn_paises.BackColor = Color.FromArgb(53, 45, 125);
            btn_aparelhos.BackColor = Color.FromArgb(53, 45, 125);
            btn_reservas.BackColor = Color.FromArgb(53, 45, 125);
            btn_info.BackColor = Color.FromArgb(53, 45, 125);
            btn_suporte.BackColor = Color.FromArgb(53, 45, 125);
            btn_sobre.BackColor = Color.FromArgb(53, 45, 125);
        }

        private void AdicionarControladorAoPainel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Relogio do Form Principal 
            DateTime dt = DateTime.Now;
            lbl_tempo.Text = dt.ToString();
        }
        //função para fazer drag da aplicação
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btn_suporte_Click(object sender, EventArgs e)
        {
            //Muda a cor do botão que foi clickado
            btn_suporte.BackColor = Color.FromArgb(255, 193, 0);

            //Mostra UC Form Suporte
            UC_Suporte ucSuporte = new UC_Suporte(IDuser);
            AdicionarControladorAoPainel(ucSuporte);

            //Limpa click dos outros botões
            btn_home.BackColor = Color.FromArgb(53, 45, 125);
            btn_voos.BackColor = Color.FromArgb(53, 45, 125);
            btn_paises.BackColor = Color.FromArgb(53, 45, 125);
            btn_aparelhos.BackColor = Color.FromArgb(53, 45, 125);
            btn_reservas.BackColor = Color.FromArgb(53, 45, 125);
            btn_info.BackColor = Color.FromArgb(53, 45, 125);
            btn_users.BackColor = Color.FromArgb(53, 45, 125); 
            btn_sobre.BackColor = Color.FromArgb(53, 45, 125);
        }

        private void btn_sobre_Click(object sender, EventArgs e)
        {
            //Muda a cor do botão que foi clickado
            btn_sobre.BackColor = Color.FromArgb(255, 193, 0);

            //Mostra UC Form sobre
            UC_Sobre ucSobre = new UC_Sobre();
            AdicionarControladorAoPainel(ucSobre);

            //Limpa click dos outros botões
            btn_home.BackColor = Color.FromArgb(53, 45, 125);
            btn_voos.BackColor = Color.FromArgb(53, 45, 125);
            btn_paises.BackColor = Color.FromArgb(53, 45, 125);
            btn_aparelhos.BackColor = Color.FromArgb(53, 45, 125);
            btn_reservas.BackColor = Color.FromArgb(53, 45, 125);
            btn_info.BackColor = Color.FromArgb(53, 45, 125);
            btn_users.BackColor = Color.FromArgb(53, 45, 125);
            btn_suporte.BackColor = Color.FromArgb(53, 45, 125);
        }
    }
}

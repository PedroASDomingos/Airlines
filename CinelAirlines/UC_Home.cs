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

    public partial class UC_Home : UserControl
    {
        //Variaveis para controlar painel de noticias
        int numNoticias = 0;
        int indexNoticias = 0;

        //Variaveis pasta das imagens
        string Pasta = Directory.GetCurrentDirectory();
        string PastaImagens = @"\Imagens\";

        //Variaveis para controlar painel de funcionarios
        int numFuncionarios = 0;
        int indexFuncionarios = 0;

        public UC_Home(int id, string user, string ulogin)
        {
            InitializeComponent();

            //Mostra mensagem de boas vindas
            lbl_benvido.Text = "Bem-vindo, " + user;
            lbl_ulogin.Text = "Data do último login: " + ulogin;

            //Mostra o tempo em pais sorteado
            foreach (Paises pais in Paises.ListaPaises)
            {
                cb_paises.Items.Add(pais.NomePais);
            }

            Random randomTempo = new Random();
            int rand = randomTempo.Next(0, Paises.ListaPaises.Count);
            cb_paises.Text = Paises.ListaPaises[rand].NomePais;

            //Mostra quantos paises estão gravadas no sistema
            if (Paises.ListaPaises.Count == 0)
            {
                lbl_numDestinos.Text = "X Destinos";
            }
            else
            {
                lbl_numDestinos.Text = Paises.ListaPaises.Count + " Destinos";
            }

            //Mostra quantas reservas estão gravadas no sistema
            if (Reservas.ListaReservas.Count == 0)
            {
                lbl_numReservas.Text = "X Passageiros";
            }
            else
            {
                lbl_numReservas.Text = Reservas.ListaReservas.Count + " Passageiros";
            }

            //Mostra quantas reservas estão gravadas no sistema
            if (Aparelhos.ListaAparelhos.Count == 0)
            {
                lbl_numAparelhos.Text = "X Aeronaves";
            }
            else
            {
                lbl_numAparelhos.Text = Aparelhos.ListaAparelhos.Count + " Aeronaves";
            }

            //chama funcao para converter 
            numNoticias = Noticias.ListaNoticias.Count;
            if (numNoticias == 0)
            {
                btn_antNoticia.Visible = false;
                btn_proxNoticia.Visible = false;
            }
            if (numNoticias > 0)
            {
                btn_antNoticia.Visible = false;
                btn_proxNoticia.Visible = true;
                lbl_tituloNoticia.Text = Noticias.ListaNoticias[0].TituloNoticia;
                lbl_textoNoticia.Text = Noticias.ListaNoticias[0].TextoNoticia;
                lbl_dataNoticia.Text = Noticias.ListaNoticias[0].DataNoticia;
                if (Noticias.ListaNoticias[0].Imagem != "null")
                {
                    pictureBox2.Load(Pasta + PastaImagens + Noticias.ListaNoticias[0].Imagem);
                }
                else
                {
                    pictureBox2.Load(Pasta + PastaImagens + "aviaoNoticia.jpg");
                }
            }
            numFuncionarios = Funcionarios.ListaFuncionarios.Count;
            if (numFuncionarios == 0)
            {
                btn_antFun.Visible = false;
                btn_proxFun.Visible = false;
            }
            if (numFuncionarios > 0)
            {
                btn_antFun.Visible = false;
                btn_proxFun.Visible = true;
                txt_funNome.Text = Funcionarios.ListaFuncionarios[0].Nome;
                txt_funCargo.Text = Funcionarios.ListaFuncionarios[0].Cargo;
                lbl_email.Text = Funcionarios.ListaFuncionarios[0].Email;
                lbl_extensao.Text = Funcionarios.ListaFuncionarios[0].Extencao;
                if (Funcionarios.ListaFuncionarios[0].Imagem != "null")
                {
                    pc_fotoFun.Load(Pasta + PastaImagens + Funcionarios.ListaFuncionarios[0].Imagem);
                }
                else
                {
                    pc_fotoFun.Load(Pasta + PastaImagens + "icons8_male_user_50px.png");
                }
            }
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_proxNoticia_Click(object sender, EventArgs e)
        {
            btn_antNoticia.Visible = true;
            indexNoticias = indexNoticias + 1;
            if (indexNoticias == Noticias.ListaNoticias.Count - 1)
            {
                btn_proxNoticia.Visible = false;
            }
            if (indexNoticias < Noticias.ListaNoticias.Count)
            {
                lbl_tituloNoticia.Text = Noticias.ListaNoticias[indexNoticias].TituloNoticia;
                lbl_textoNoticia.Text = Noticias.ListaNoticias[indexNoticias].TextoNoticia;
                lbl_dataNoticia.Text = Noticias.ListaNoticias[indexNoticias].DataNoticia;
                if (Noticias.ListaNoticias[indexNoticias].Imagem != "null")
                {
                    pictureBox2.Load(Pasta + PastaImagens + Noticias.ListaNoticias[indexNoticias].Imagem);
                }
                else
                {
                    pictureBox2.Load(Pasta + PastaImagens + "aviaoNoticia.jpg");
                }
            }
        }

        private void btn_antNoticia_Click(object sender, EventArgs e)
        {
            btn_proxNoticia.Visible = true;
            indexNoticias = indexNoticias - 1;
            if (indexNoticias == 0)
            {
                btn_antNoticia.Visible = false; 
            }
            lbl_tituloNoticia.Text = Noticias.ListaNoticias[indexNoticias].TituloNoticia;
            lbl_textoNoticia.Text = Noticias.ListaNoticias[indexNoticias].TextoNoticia;
            lbl_dataNoticia.Text = Noticias.ListaNoticias[indexNoticias].DataNoticia;
            if (Noticias.ListaNoticias[indexNoticias].Imagem != "null")
            {
                pictureBox2.Load(Pasta + PastaImagens + Noticias.ListaNoticias[indexNoticias].Imagem);
            }
            else
            {
                pictureBox2.Load(Pasta + PastaImagens + "aviaoNoticia.jpg");
            }
        }


        private void btn_antFun_Click(object sender, EventArgs e)
        {
            btn_proxFun.Visible = true;
            indexFuncionarios = indexFuncionarios - 1;
            if (indexFuncionarios == 0)
            {
                btn_antFun.Visible = false;
            }
            txt_funNome.Text = Funcionarios.ListaFuncionarios[indexFuncionarios].Nome;
            txt_funCargo.Text = Funcionarios.ListaFuncionarios[indexFuncionarios].Cargo;
            lbl_email.Text = Funcionarios.ListaFuncionarios[indexFuncionarios].Email;
            lbl_extensao.Text = Funcionarios.ListaFuncionarios[indexFuncionarios].Extencao;
            if (Funcionarios.ListaFuncionarios[indexFuncionarios].Imagem != "null")
            {
                pc_fotoFun.Load(Pasta + PastaImagens + Funcionarios.ListaFuncionarios[indexFuncionarios].Imagem);
            }
            else
            {
                pc_fotoFun.Load(Pasta + PastaImagens + "icons8_male_user_50px.png");
            }
        }

        private void btn_proxFun_Click(object sender, EventArgs e)
        {
            btn_antFun.Visible = true;
            indexFuncionarios = indexFuncionarios + 1;
            if (indexFuncionarios == Funcionarios.ListaFuncionarios.Count - 1)
            {
                btn_proxFun.Visible = false;
            }
            if (indexFuncionarios < Funcionarios.ListaFuncionarios.Count)
            {
                txt_funNome.Text = Funcionarios.ListaFuncionarios[indexFuncionarios].Nome;
                txt_funCargo.Text = Funcionarios.ListaFuncionarios[indexFuncionarios].Cargo;
                lbl_email.Text = Funcionarios.ListaFuncionarios[indexFuncionarios].Email;
                lbl_extensao.Text = Funcionarios.ListaFuncionarios[indexFuncionarios].Extencao;
                if (Funcionarios.ListaFuncionarios[indexFuncionarios].Imagem != "null")
                {
                    pc_fotoFun.Load(Pasta + PastaImagens + Funcionarios.ListaFuncionarios[indexFuncionarios].Imagem);
                }
                else
                {
                    pc_fotoFun.Load(Pasta + PastaImagens + "icons8_male_user_50px.png");
                }
            }
        }

        private void cb_paises_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_numAeroportos.Text = "Nº Aeroportos: " + Aeroportos.ListaAeroportos.Where(x => x.IdPais == cb_paises.SelectedIndex).Count();
            foreach (Tempo item in Tempo.ListaTempo)
            {
                if (item.IdPais == cb_paises.SelectedIndex)
                {
                    lbl_pre.Text = "Precipitação: " + item.Precipitacao + " %";
                    lbl_hum.Text = "Humidade: " + item.Humidade + " %";
                    lbl_vento.Text = "Vento: " + item.Vento + " %";
                    lbl_temperatura.Text = item.Temperatura.ToString();
                    pictureBox6.Load(Pasta + item.Imagem);
                }
                
            }
            foreach (Paises pais in Paises.ListaPaises)
            {
                if (pais.NomePais == cb_paises.SelectedItem.ToString())
                {
                    if (pais.Imagem != "null")
                    {
                        pictureBox8.Load(Pasta + PastaImagens + pais.Imagem);
                    }
                    else
                    {
                        pictureBox8.Load(Pasta + PastaImagens + "BandeiraBranca.jpg");
                    }
                }
            }
        }
    }
}



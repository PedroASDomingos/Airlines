using LibraryCinelAirlines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinelAirlines
{
    public partial class UC_Info : UserControl
    {
        //variavel para captar indice do ultimo registo da lista
        int indice;
        int indiceFuncionario;
        public UC_Info()
        {
            InitializeComponent();
            ConstroiListaNoticias();
            ConstroiListaFuncionarios();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            foreach (Noticias noticia in Noticias.ListaNoticias)
            {
                indice = noticia.IdNoticia;
            }
            frmAddNoticia fan = new frmAddNoticia(this, indice);
            fan.Show();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            if (NoticiasListBox.SelectedItem == null)
            {
                MessageBox.Show("Não selecionou nenhuma Notícia!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Noticias noticiaAApagar = (Noticias)NoticiasListBox.SelectedItem;
            Noticias apagado = null;
            foreach (Noticias noticia in Noticias.ListaNoticias)
            {
                if (noticiaAApagar.IdNoticia == noticia.IdNoticia)
                {
                    apagado = noticia;
                }
            }
            if (apagado != null)
            {
                DialogResult resposta;
                resposta = MessageBox.Show($"Tem a certeza que pretende apagar a notícia com o título: {apagado.TituloNoticia} ", "Apagar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == resposta)
                {
                    Noticias.ListaNoticias.Remove(apagado);
                    Noticias.GravarFicheiro();
                    ConstroiListaNoticias();
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (NoticiasListBox.SelectedItem == null)
            {
                MessageBox.Show("Não selecionou nenhuma notícia!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Noticias noticiaAEditar = (Noticias)NoticiasListBox.SelectedItem;
            Noticias editado = null;
            foreach (Noticias noticia in Noticias.ListaNoticias)
            {
                if (noticiaAEditar.IdNoticia == noticia.IdNoticia)
                {
                    editado = noticia;
                }
            }
            //abrir a form nova para editar 
            frmEditarNoticia editarNoticiaForm = new frmEditarNoticia(this, editado);
            editarNoticiaForm.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //Limpa Lista
            NoticiasListBox.DataSource = null;

            //carrega Lista
            NoticiasListBox.DataSource = Noticias.ListaNoticias;
            NoticiasListBox.DisplayMember = "ApresentacaoDadosNoticias";
        }

        public void ConstroiListaNoticias()
        {
            //Limpa Lista
            NoticiasListBox.DataSource = null;

            //carrega Lista
            NoticiasListBox.DataSource = Noticias.ListaNoticias;
            NoticiasListBox.DisplayMember = "ApresentacaoDadosNoticias";
        }

        private void btn_addFuncionarios_Click(object sender, EventArgs e)
        {
            foreach (Funcionarios funcionario in Funcionarios.ListaFuncionarios)
            {
                indiceFuncionario = funcionario.IdFuncionario;
            }
            frmAddFuncionario faf = new frmAddFuncionario(this, indiceFuncionario);
            faf.Show();
        }

        private void btn_apagaFuncionarios_Click(object sender, EventArgs e)
        {
            if (FuncionarioslistBox.SelectedItem == null)
            {
                MessageBox.Show("Não selecionou nenhum funcionário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Funcionarios funcionarioAApagar = (Funcionarios)FuncionarioslistBox.SelectedItem;
            Funcionarios apagado = null;
            foreach (Funcionarios funcionario in Funcionarios.ListaFuncionarios)
            {
                if (funcionarioAApagar.IdFuncionario == funcionario.IdFuncionario)
                {
                    apagado = funcionario;
                }
            }
            if (apagado != null)
            {
                DialogResult resposta;
                resposta = MessageBox.Show($"Tem a certeza que pretende apagar o funcionário com o nome: {apagado.Nome} ", "Apagar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == resposta)
                {
                    Funcionarios.ListaFuncionarios.Remove(apagado);
                    Funcionarios.GravarFicheiro();
                    ConstroiListaFuncionarios();
                }
            }
        }

        private void btn_editarFuncionario_Click(object sender, EventArgs e)
        {
            if (FuncionarioslistBox.SelectedItem == null)
            {
                MessageBox.Show("Não selecionou nenhuma funcionário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Funcionarios funcionarioAEditar = (Funcionarios)FuncionarioslistBox.SelectedItem;
            Funcionarios editado = null;
            foreach (Funcionarios funcionario in Funcionarios.ListaFuncionarios)
            {
                if (funcionarioAEditar.IdFuncionario == funcionario.IdFuncionario)
                {
                    editado = funcionario;
                }
            }
            //abrir a form nova para editar 
            frmEditarFuncionario editarFuncionarioForm = new frmEditarFuncionario(this, editado);
            editarFuncionarioForm.Show();
        }

        private void btn_refreshFuncionario_Click(object sender, EventArgs e)
        {
            //Limpa Lista
            FuncionarioslistBox.DataSource = null;

            //carrega Lista
            FuncionarioslistBox.DataSource = Funcionarios.ListaFuncionarios;
            FuncionarioslistBox.DisplayMember = "ApresentacaoDadosFuncionario";
        }
        public void ConstroiListaFuncionarios()
        {
            //Limpa Lista
            FuncionarioslistBox.DataSource = null;

            //carrega Lista
            FuncionarioslistBox.DataSource = Funcionarios.ListaFuncionarios;
            FuncionarioslistBox.DisplayMember = "ApresentacaoDadosFuncionario";
        }

    }
}

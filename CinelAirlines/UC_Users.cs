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
    public partial class UC_Users : UserControl
    {
        //variavel para captar indice do ultimo registo da lista
        int indice;
        public UC_Users()
        {
            InitializeComponent();
            ConstroiLista();
        }

        public void ConstroiLista()
        {
            //Limpa Lista
            UsersListBox.DataSource = null;

            //carrega Lista
            UsersListBox.DataSource = Users.ListaUtilizadores;
            UsersListBox.DisplayMember = "ApresentacaoDadosUser";

            Users.GravarFicheiro();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            foreach (Users user in Users.ListaUtilizadores)
            {
                indice = user.IdUser;
            }
            frmAddUser fau = new frmAddUser(this, indice);
            fau.Show();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            if (UsersListBox.SelectedItem == null)
            {
                MessageBox.Show("Não selecionou nenhum Utilizador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (UsersListBox.SelectedIndex == 0)
            {
                MessageBox.Show("Não pode apagar o utilizador Administrador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Users userAApagar = (Users)UsersListBox.SelectedItem;
            Users apagado = null;
            foreach (Users user in Users.ListaUtilizadores)
            {
                if (userAApagar.IdUser == user.IdUser)
                {
                    apagado = user;
                }
            }
            if (apagado != null)
            {
                DialogResult resposta;
                resposta = MessageBox.Show($"Tem a certeza que pretende apagar o Utilizador: {apagado.User}", "Apagar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == resposta)
                {
                    Users.ListaUtilizadores.Remove(apagado);
                    Users.GravarFicheiro();
                    ConstroiLista();
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (UsersListBox.SelectedItem == null)
            {
                MessageBox.Show("Não selecionou nenhum Utilizador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Users userAEditar = (Users)UsersListBox.SelectedItem;
            Users editado = null;
            foreach (Users user in Users.ListaUtilizadores)
            {
                if (userAEditar.IdUser == user.IdUser)
                {
                    editado = user;
                }
            }
            //abrir a form nova para editar 
            frmEditarUser editarUserForm = new frmEditarUser(this, editado);
            editarUserForm.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            UsersListBox.DataSource = null;
            UsersListBox.DataSource = Users.ListaUtilizadores;
            UsersListBox.DisplayMember = "ApresentacaoDadosUser";
        }
    }
}

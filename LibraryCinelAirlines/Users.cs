using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCinelAirlines
{

    public class Users
    {
    #region Propusers
        public int IdUser { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string UltimoLogin { get; set; }
        public int NivelAcesso { get; set; }
    #endregion

        // Cria Lista de Utilizadores
        public static List<Users> ListaUtilizadores;

        //carrega lista de Utilizadores
        public static void ConstroiListaUsers()
        {
            //Variaveis para receber o caminho onde esta os ficheiros
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"\Documentos\ficheiro_users.txt";

            //Cria  Lista de paises
            ListaUtilizadores = new List<Users>();

            //Veridica se o ficheiro dos paises existe
            if (File.Exists(NomeFicheiro))
            {
                //Abrir ficheio
                StreamReader ficheiro = new StreamReader(NomeFicheiro, Encoding.UTF8);

                //Corre ficheiro e guarda em variavel pais e capital
                while (!ficheiro.EndOfStream)
                {
                    //carrega id
                    int iduser = Convert.ToInt32(ficheiro.ReadLine());
                    //Carrega user
                    string user = ficheiro.ReadLine();

                    //Carrega pass
                    string pass = ficheiro.ReadLine();

                    //carrega Email
                    string email = ficheiro.ReadLine();

                    //carrega Ultimo Login
                    string ultimologin = ficheiro.ReadLine();

                    //Carrega nivel acesso
                    int nivelacesso = Convert.ToInt32(ficheiro.ReadLine());

                    //adiciona a lista de paises o pais e o nome do aeroporto
                    Users novouser = new Users();
                    novouser.IdUser = iduser;
                    novouser.User = user;
                    novouser.Password = pass;
                    novouser.Email = email;
                    novouser.UltimoLogin = ultimologin;
                    novouser.NivelAcesso = nivelacesso;

                    ListaUtilizadores.Add(novouser);
                }
                ficheiro.Dispose();
            }
        }

        public static void GravarNovoRegisto(int iduser, string user, string pass, string email, string ultimologin, int nivelacesso)
        {
            //Gravar na Lista
            Users novouser = new Users();
            novouser.IdUser = iduser;
            novouser.User = user;
            novouser.Password = pass;
            novouser.Email = email;
            novouser.UltimoLogin = ultimologin;
            novouser.NivelAcesso = nivelacesso;
            ListaUtilizadores.Add(novouser);

            //Manda gravar no ficheiro
            GravarFicheiro();
        }

        public static void GravarFicheiro()
        {
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"\Documentos\ficheiro_users.txt";

            StreamWriter ficheiro = new StreamWriter(NomeFicheiro, false, Encoding.UTF8);
            foreach (Users users in ListaUtilizadores)
            {
                ficheiro.WriteLine(users.IdUser);
                ficheiro.WriteLine(users.User);
                ficheiro.WriteLine(users.Password);
                ficheiro.WriteLine(users.Email);
                ficheiro.WriteLine(users.UltimoLogin);
                ficheiro.WriteLine(users.NivelAcesso);
            }
            ficheiro.Dispose();
        }


        public string ApresentacaoDadosUser
        {
            get
            {
                return $"{User} // {Email}";
            }
        }
    }
}

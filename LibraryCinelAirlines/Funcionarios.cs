using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCinelAirlines
{
    public class Funcionarios
    {
        #region propFuncionario
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        public string Extencao { get; set; }
        public string Imagem { get; set; }
        #endregion

        // Cria Lista de Utilizadores
        public static List<Funcionarios> ListaFuncionarios;

        //carrega lista de Utilizadores
        public static void ConstroiListaFuncionarios()
        {
            //Variaveis para receber o caminho onde esta os ficheiros
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"\Documentos\ficheiro_funcionarios.txt";

            //Cria  Lista de paises
            ListaFuncionarios = new List<Funcionarios>();

            //Veridica se o ficheiro dos paises existe
            if (File.Exists(NomeFicheiro))
            {
                //Abrir ficheio
                StreamReader ficheiro = new StreamReader(NomeFicheiro, Encoding.UTF8);

                //Corre ficheiro e guarda em variavel pais e capital
                while (!ficheiro.EndOfStream)
                {
                    //carrega id
                    int idfuncionario = Convert.ToInt32(ficheiro.ReadLine());
                    //Carrega nome
                    string nome = ficheiro.ReadLine();

                    //Carrega cargo
                    string cargo = ficheiro.ReadLine();

                    //carrega Email
                    string email = ficheiro.ReadLine();

                    //carrega extencao
                    string extencao = ficheiro.ReadLine();

                    //Carrega imagem
                    string imagem = ficheiro.ReadLine();

                    //adiciona a lista de paises o pais e o nome do aeroporto
                    Funcionarios novoFuncionario = new Funcionarios();
                    novoFuncionario.IdFuncionario = idfuncionario;
                    novoFuncionario.Nome = nome;
                    novoFuncionario.Cargo = cargo;
                    novoFuncionario.Email = email;
                    novoFuncionario.Extencao = extencao;
                    novoFuncionario.Imagem = imagem;

                    ListaFuncionarios.Add(novoFuncionario);
                }
                ficheiro.Dispose();
            }
        }

        public static void GravarNovoRegisto(int idfuncionario, string nome, string cargo, string email, string extencao, string imagem)
        {
            //Gravar na Lista
            Funcionarios novoFuncionario = new Funcionarios();
            novoFuncionario.IdFuncionario = idfuncionario;
            novoFuncionario.Nome = nome;
            novoFuncionario.Cargo = cargo;
            novoFuncionario.Email = email;
            novoFuncionario.Extencao = extencao;
            novoFuncionario.Imagem = imagem;

            ListaFuncionarios.Add(novoFuncionario);
            //Manda gravar no ficheiro
            GravarFicheiro();
        }

        public static void GravarFicheiro()
        {
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"\Documentos\ficheiro_funcionarios.txt";

            StreamWriter ficheiro = new StreamWriter(NomeFicheiro, false, Encoding.UTF8);
            foreach (Funcionarios funcionario in ListaFuncionarios)
            {
                ficheiro.WriteLine(funcionario.IdFuncionario);
                ficheiro.WriteLine(funcionario.Nome);
                ficheiro.WriteLine(funcionario.Cargo);
                ficheiro.WriteLine(funcionario.Email);
                ficheiro.WriteLine(funcionario.Extencao);
                ficheiro.WriteLine(funcionario.Imagem);
            }
            ficheiro.Dispose();
        }


        public string ApresentacaoDadosFuncionario
        {
            get
            {
                return $"{Nome} // {Cargo} // {Email}";
            }
        }
    }
}

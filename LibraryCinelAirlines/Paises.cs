using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCinelAirlines
{
    public class Paises
    {
        #region PropPaises
        public int Id { get; set; }
        public string NomePais { get; set; }
        public string NomeAeroporto { get; set; }
        public string Imagem { get; set; }
        #endregion

        //Lista de paises
        public static List<Paises> ListaPaises;

        //carrega lista de paises
        public static void ConstroiListaPaises()
        {
            //Variaveis para receber o caminho onde esta os ficheiros
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"\Documentos\ficheiro_paises.txt";

            //Cria  Lista de paises
            ListaPaises = new List<Paises>();

            //Veridica se o ficheiro dos paises existe
            if (File.Exists(NomeFicheiro))
            {
                //Abrir ficheio
                StreamReader ficheiro = new StreamReader(NomeFicheiro, Encoding.UTF8);
                //Corre ficheiro e guarda em variavel pais e capital
                while (!ficheiro.EndOfStream)
                {
                    //carrega id
                    int idpais = Convert.ToInt32(ficheiro.ReadLine());
                    //Carrega Pais
                    string pais = ficheiro.ReadLine();
                    //Carrega Capital
                    string aeroporto = ficheiro.ReadLine();
                    //Carrega imagens
                    string imagem = ficheiro.ReadLine();
                    //adiciona a lista de paises o pais e o nome do aeroporto
                    Paises novopais = new Paises();
                    novopais.Id = idpais;
                    novopais.NomePais = pais;
                    novopais.NomeAeroporto = aeroporto;
                    novopais.Imagem = imagem;

                    ListaPaises.Add(novopais);
                }
                ficheiro.Dispose();
            }
        }

        public static void GravarNovoRegisto(int idpais, string nomePais, string nomeAeroporto, string imagem)
        {
            //Gravar na Lista
            Paises pais = new Paises();
            pais.Id = idpais;
            pais.NomePais = nomePais;
            pais.NomeAeroporto = nomeAeroporto;
            pais.Imagem = imagem;
            ListaPaises.Add(pais);                              

            //Manda gravar no ficheiro
            GravarFicheiro();
        }

        public static void GravarFicheiro()
        {
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"\Documentos\ficheiro_paises.txt";

            StreamWriter ficheiro = new StreamWriter(NomeFicheiro, false, Encoding.UTF8);
            foreach(Paises pais in ListaPaises)
            {
                ficheiro.WriteLine(pais.Id);
                ficheiro.WriteLine(pais.NomePais);
                ficheiro.WriteLine(pais.NomeAeroporto);
                ficheiro.WriteLine(pais.Imagem);
            }
            ficheiro.Dispose();
        }


        public string ApresentacaoDadosPais
        {
            get
            {
                return $"{NomePais}";
            }
        }

    }
}

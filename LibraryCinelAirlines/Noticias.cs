using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCinelAirlines
{
    public class Noticias
    {
        #region propNoticias
        public int IdNoticia { get; set; }
        public string TituloNoticia { get; set; }
        public string TextoNoticia { get; set; }
        public string DataNoticia { get; set; }
        public string Imagem { get; set; }
        #endregion

        // Cria Lista de Noticias
        public static List<Noticias> ListaNoticias;

        //carrega lista de Noticias
        public static void ConstroiListaNoticias()
        {
            //Variaveis para receber o caminho onde esta os ficheiros
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"\Documentos\ficheiro_noticias.txt";

            //Cria  Lista de paises
            ListaNoticias = new List<Noticias>();

            //Veridica se o ficheiro dos paises existe
            if (File.Exists(NomeFicheiro))
            {
                //Abrir ficheio
                StreamReader ficheiro = new StreamReader(NomeFicheiro, Encoding.UTF8);

                //Corre ficheiro e guarda em variavel pais e capital
                while (!ficheiro.EndOfStream)
                {
                    //carrega id
                    int idnoticia = Convert.ToInt32(ficheiro.ReadLine());

                    //Carrega titulo
                    string titulo = ficheiro.ReadLine();

                    //Carrega texto
                    string texto = ficheiro.ReadLine();

                    //carrega data
                    string data = ficheiro.ReadLine();

                    //carrega data
                    string imagem = ficheiro.ReadLine();

                    //adiciona a lista de paises o pais e o nome do aeroporto
                    Noticias novaNoticia = new Noticias();
                    novaNoticia.IdNoticia = idnoticia;
                    novaNoticia.TituloNoticia = titulo;
                    novaNoticia.TextoNoticia = texto;
                    novaNoticia.DataNoticia = data;
                    novaNoticia.Imagem = imagem;
                    ListaNoticias.Add(novaNoticia);
                }
                ficheiro.Dispose();
            }
        }

        public static void GravarNovoRegisto(int id, string titulo, string texto, string data, string imagem)
        {
            //Gravar na Lista
            Noticias novaNoticia = new Noticias();
            novaNoticia.IdNoticia = id;
            novaNoticia.TituloNoticia = titulo;
            novaNoticia.TextoNoticia = texto;
            novaNoticia.DataNoticia = data;
            novaNoticia.Imagem = imagem;
            ListaNoticias.Add(novaNoticia);

            //Manda gravar no ficheiro
            GravarFicheiro();
        }

        public static void GravarFicheiro()
        {
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"\Documentos\ficheiro_noticias.txt";

            StreamWriter ficheiro = new StreamWriter(NomeFicheiro, false, Encoding.UTF8);
            foreach (Noticias noticia in ListaNoticias)
            {
                ficheiro.WriteLine(noticia.IdNoticia);
                ficheiro.WriteLine(noticia.TituloNoticia);
                ficheiro.WriteLine(noticia.TextoNoticia);
                ficheiro.WriteLine(noticia.DataNoticia);
                ficheiro.WriteLine(noticia.Imagem);
            }
            ficheiro.Dispose();
        }

        public string ApresentacaoDadosNoticias
        {
            get
            {
                return $"{TituloNoticia} // {DataNoticia}";
            }
        }
    }
}

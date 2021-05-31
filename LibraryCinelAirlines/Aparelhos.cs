using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCinelAirlines
{
    public class Aparelhos
    {
        #region propAparelho
        public int IdAparelho { get; set; }
        public string NomeAparelho { get; set; }
        public int LotacaoEconomica { get; set; }
        public int LotacaoExecutiva { get; set; }
        public string Imagem { get; set; }
        #endregion

        //Lista de Aparelhos
        public static List<Aparelhos> ListaAparelhos;

        //Carrega Lista de Aparelhos
        public static void ConstroiListaAparelhos()
        {
            //Variaveis para receber o caminho onde esta os ficheiros
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"\Documentos\ficheiro_aparelhos.txt";

            //Inicia Lista de Aparelhos
            ListaAparelhos = new List<Aparelhos>();

            //verifica se ficeiro dos Aparelhos existe
            if (File.Exists(NomeFicheiro))
            {
                //Abrir ficheiro
                StreamReader ficheiro = new StreamReader(NomeFicheiro, Encoding.UTF8);

                //Corre Ficeiro e guarda em variaveis 
                while (!ficheiro.EndOfStream)
                {
                    //le linha id
                    int id = Convert.ToInt32(ficheiro.ReadLine());
                    // le linha nome
                    string nomeAparelho = ficheiro.ReadLine();
                    // le linha lotação Economica
                    int NumEco = Convert.ToInt32(ficheiro.ReadLine());
                    // le linha lotação Executiva
                    int NumExe = Convert.ToInt32(ficheiro.ReadLine());
                    // le imagens
                    string imagem = ficheiro.ReadLine();

                    //Adiciona a lista de aparelhos o dados de leitura
                    Aparelhos novoAparelho = new Aparelhos();
                    novoAparelho.IdAparelho = id;
                    novoAparelho.NomeAparelho = nomeAparelho;
                    novoAparelho.LotacaoEconomica = NumEco;
                    novoAparelho.LotacaoExecutiva = NumExe;
                    novoAparelho.Imagem = imagem;
                    ListaAparelhos.Add(novoAparelho);
                }
                ficheiro.Dispose();
            }
        }

        public static void GravarNovoRegisto(int id, string nome, int lotEco, int lotExe, string imagem)
        {
            //Gravar na Lista
            Aparelhos aparelho = new Aparelhos();
            aparelho.IdAparelho = id;
            aparelho.NomeAparelho = nome;
            aparelho.LotacaoEconomica = lotEco;
            aparelho.LotacaoExecutiva = lotExe;
            aparelho.Imagem = imagem;
            ListaAparelhos.Add(aparelho);

            //Manda gravar no Ficheiro
            GravarFicheiro();
        }

        public static void GravarFicheiro()
        {
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"\Documentos\ficheiro_aparelhos.txt";

            StreamWriter ficheiro = new StreamWriter(NomeFicheiro, false, Encoding.UTF8);
            foreach (Aparelhos aparelhos in ListaAparelhos)
            {
                ficheiro.WriteLine(aparelhos.IdAparelho);
                ficheiro.WriteLine(aparelhos.NomeAparelho);
                ficheiro.WriteLine(aparelhos.LotacaoEconomica);
                ficheiro.WriteLine(aparelhos.LotacaoExecutiva);
                ficheiro.WriteLine(aparelhos.Imagem);
            }
            ficheiro.Dispose();
        }
        public string ApresentacaoDadosAparelhos
        {
            get
            {
                return $"{NomeAparelho} // Lotação em Economica: {LotacaoEconomica} // Lotação em Executiva: {LotacaoExecutiva}";
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCinelAirlines
{
    public class Aeroportos
    {
        //Lista de Aparelhos
        public static List<Aeroporto> ListaAeroportos;
        //Carrega Lista de Aeroportos
        public static void ConstroiListaAeroportos()
        {
            //Variaveis para receber o caminho onde esta os ficheiros
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"\Documentos\ficheiro_aeroporto.txt";
            //Inicia Lista de Aeroporto
            ListaAeroportos = new List<Aeroporto>();
            //verifica se ficeiro dos Aparelhos existe
            if (File.Exists(NomeFicheiro))
            {
                //Abrir ficheiro
                StreamReader ficheiro = new StreamReader(NomeFicheiro, Encoding.UTF8);
                //Corre Ficeiro e guarda em variaveis 
                while (!ficheiro.EndOfStream)
                {
                    //le linha id aeroporto
                    int id = Convert.ToInt32(ficheiro.ReadLine());
                    // le linha id pais
                    int idpais = Convert.ToInt32(ficheiro.ReadLine());
                    // le nome aeroporto
                    string nomeaeroporto = ficheiro.ReadLine();
                    //Adiciona a lista de aparelhos o dados de leitura
                    Aeroporto novoAeroporto = new Aeroporto();
                    novoAeroporto.IdAeroporto = id;
                    novoAeroporto.IdPais = idpais;
                    novoAeroporto.NomeAeroporto = nomeaeroporto;
                    ListaAeroportos.Add(novoAeroporto);
                }
                ficheiro.Dispose();
            }
        }

        public static void GravarNovoRegisto(int id, int idpais, string nomeaeroporto)
        {
            //Gravar na Lista
            Aeroporto novoAeroporto = new Aeroporto();
            novoAeroporto.IdAeroporto = id;
            novoAeroporto.IdPais = idpais;
            novoAeroporto.NomeAeroporto = nomeaeroporto;
            ListaAeroportos.Add(novoAeroporto);

            //Manda gravar no Ficheiro
            GravarFicheiro();
        }

        public static void GravarFicheiro()
        {
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"\Documentos\ficheiro_aeroporto.txt";

            StreamWriter ficheiro = new StreamWriter(NomeFicheiro, false, Encoding.UTF8);
            foreach (Aeroporto aeroporto in ListaAeroportos)
            {
                ficheiro.WriteLine(aeroporto.IdAeroporto);
                ficheiro.WriteLine(aeroporto.IdPais);
                ficheiro.WriteLine(aeroporto.NomeAeroporto);
            }
            ficheiro.Dispose();
        }
    }
}

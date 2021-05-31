using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCinelAirlines
{
    public class Voo
    {
        
        public int IdVoo { get; set; }
        public string NomeVoo { get; set; }
        public string DataVoo { get; set; }
        public string HoraVoo { get; set; }
        public string PaisOrigem { get; set; }
        public string AeroportoOrigem { get; set; }
        public string PaisDestino { get; set; }
        public string AeroportoDestino { get; set; }
        public string NumAparelho { get; set; }

        //Lista de paises
        public static List<Voo> ListaVoos;

        //carrega lista de paises
        public static void ConstroiListaVoos()
        {
            //Verifica se o ficheiro dos paises existe
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"\Documentos\ficheiro_voos.txt";
            if (File.Exists(NomeFicheiro))
            {
                //Abrir ficheio
                StreamReader ficheiro = new StreamReader(NomeFicheiro, Encoding.UTF8);

                //Iniciar Lista de paises
                ListaVoos = new List<Voo>();

                //Corre ficheiro e guarda em variavel
                while (!ficheiro.EndOfStream)
                {
                    //le o id do voo
                    int id = Convert.ToInt32(ficheiro.ReadLine());
                    //le linha nome voo
                    string nome = ficheiro.ReadLine();
                    //le linha data voo
                    string data = ficheiro.ReadLine();
                    //le linha hora voo
                    string hora = ficheiro.ReadLine();
                    //le linha origem voo
                    string origem = ficheiro.ReadLine();
                    //le linha origem voo
                    string aeroportoorigem = ficheiro.ReadLine();
                    //le linha destino voo
                    string destino = ficheiro.ReadLine();
                    //le linha origem voo
                    string aeroportodestino = ficheiro.ReadLine();
                    //le linha avião voo
                    string aparelho = ficheiro.ReadLine();
                    //cria nova lista
                    Voo novovoo = new Voo();
                    //adiciona a lista de voos
                    novovoo.IdVoo = id;
                    novovoo.NomeVoo = nome;
                    novovoo.DataVoo = data;
                    novovoo.HoraVoo = hora;
                    novovoo.PaisOrigem = origem;
                    novovoo.AeroportoOrigem = aeroportoorigem;
                    novovoo.PaisDestino = destino;
                    novovoo.AeroportoDestino = aeroportodestino;
                    novovoo.NumAparelho = aparelho;
                    ListaVoos.Add(novovoo);
                }

                ficheiro.Dispose();
            }
        }

        public static void GravarNovoRegisto(int id, string nome, string data, string hora, string paisOrigem, string aerOrigem, string paisDestino, string aerDestino, string aparelho)
        { 
            //Gravar na Lista
            Voo novovoo = new Voo();
            novovoo.IdVoo = id;
            novovoo.NomeVoo = nome; 
            novovoo.DataVoo = data;
            novovoo.HoraVoo = hora;
            novovoo.PaisOrigem = paisOrigem;
            novovoo.AeroportoOrigem = aerOrigem;
            novovoo.PaisDestino = paisDestino;
            novovoo.AeroportoDestino = aerDestino;
            novovoo.NumAparelho = aparelho;
            ListaVoos.Add(novovoo);

            //Manda gravar no Ficheiro
            GravarFicheiro();
        }

        public static void GravarFicheiro()
        {
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"\Documentos\ficheiro_voos.txt";

            StreamWriter ficheiro = new StreamWriter(NomeFicheiro, false, Encoding.UTF8);
            foreach (Voo voo in ListaVoos)
            {
                ficheiro.WriteLine(voo.IdVoo);
                ficheiro.WriteLine(voo.NomeVoo);
                ficheiro.WriteLine(voo.DataVoo);
                ficheiro.WriteLine(voo.HoraVoo);
                ficheiro.WriteLine(voo.PaisOrigem);
                ficheiro.WriteLine(voo.AeroportoOrigem);
                ficheiro.WriteLine(voo.PaisDestino);
                ficheiro.WriteLine(voo.AeroportoDestino);
                ficheiro.WriteLine(voo.NumAparelho);
            }
            ficheiro.Dispose();
        }

        public string ApresentacaoDadosVoo
        {
            get
            {
                return $"{NomeVoo} // {DataVoo} // {HoraVoo}";
            }
        }
        public string ApresentacaoDadosVooLista
        {
            get
            {  
                return $"{NomeVoo} // {PaisOrigem} // {PaisDestino}";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCinelAirlines
{
    public class Reservas
    {
        #region PropReservas
        public int IdPassageiro { get; set; }
        public string NomePassageiro { get; set; }
        public int IdVoo { get; set; }
        public string Assento { get; set; }
        public string FicheiroPdf { get; set; }
        #endregion

        //Lista de Reservas
        public static List<Reservas> ListaReservas;

        //carrega lista de Reservas
        public static void ConstroiListaReservas()
        {
            //Verifica se o ficheiro dos Reservas existe
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"\Documentos\ficheiro_reservas.txt";
            if (File.Exists(NomeFicheiro))
            {
                //Abrir ficheio
                StreamReader ficheiro = new StreamReader(NomeFicheiro, Encoding.UTF8);

                //Iniciar Lista de Reservas
                ListaReservas = new List<Reservas>();

                //Corre ficheiro e guarda em variavel
                while (!ficheiro.EndOfStream)
                {
                    //le o Id Passageiro
                    int id = Convert.ToInt32(ficheiro.ReadLine());
                    //le linha NomePassageiro
                    string nome = ficheiro.ReadLine();
                    //le linha IdVoo
                    int idvoo = Convert.ToInt32(ficheiro.ReadLine());
                    //le linha Assento
                    string assento = ficheiro.ReadLine();
                    //le linha ficheiro pdf
                    string ficheiropdf = ficheiro.ReadLine();

                    //cria nova lista
                    Reservas novaReserva = new Reservas();
                    //adiciona a lista de reservas a reserva
                    novaReserva.IdPassageiro = id;
                    novaReserva.NomePassageiro = nome;
                    novaReserva.IdVoo = idvoo;
                    novaReserva.Assento = assento;
                    novaReserva.FicheiroPdf = ficheiropdf;
                    ListaReservas.Add(novaReserva);
                }
                ficheiro.Dispose();
            }
        }

        public static void GravarNovoRegisto(int id, string nome, int idvoo, string assento, string ficheiropdf)
        {
            //Adiciona na lista
            Reservas novaReserva = new Reservas();
            novaReserva.IdPassageiro = id;
            novaReserva.NomePassageiro = nome;
            novaReserva.IdVoo = idvoo;
            novaReserva.Assento = assento;
            novaReserva.FicheiroPdf = ficheiropdf;
            ListaReservas.Add(novaReserva);

            //Manda gravar no Ficheiro
            GravarFicheiro();
        }

        public static void GravarFicheiro()
        {
            //Grava no ficheiro txt
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"\Documentos\ficheiro_reservas.txt";

            StreamWriter ficheiro = new StreamWriter(NomeFicheiro, false, Encoding.UTF8);
            foreach (Reservas reserva in ListaReservas)
            {
                ficheiro.WriteLine(reserva.IdPassageiro);
                ficheiro.WriteLine(reserva.NomePassageiro);
                ficheiro.WriteLine(reserva.IdVoo);
                ficheiro.WriteLine(reserva.Assento);
                ficheiro.WriteLine(reserva.FicheiroPdf);
            }
            ficheiro.Dispose();
        }

        public string ApresentacaoDadosReserva
        {
            get
            {
                return $"{NomePassageiro} // {Assento}";
            }
        }
    }
}

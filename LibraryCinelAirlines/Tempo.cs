using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCinelAirlines
{
    public class Tempo
    {
        public int IdPais { get; set; }
        public int Temperatura { get; set; }
        public int Precipitacao { get; set; }
        public int Humidade { get; set; }
        public int Vento { get; set; }
        public string Imagem { get; set; }

        public static List<Tempo> ListaTempo;

        //carrega lista de paises
        public static void ConstroiListaTempo()
        {
            ListaTempo = new List<Tempo>();
            Random randomTempo = new Random();

            foreach (Paises pais in Paises.ListaPaises)
            {
                var OTempo = new List<string> { "Sol", "Nublado", "Chuva", "Trovoada" };
                int index = randomTempo.Next(OTempo.Count);
                if (OTempo[index] == "Sol")
                {
                    Tempo novoTempo = new Tempo();
                    novoTempo.IdPais = pais.Id;
                    int Temperatura = randomTempo.Next(20,32);
                    novoTempo.Temperatura = Temperatura;
                    novoTempo.Precipitacao = 0;
                    int humudade = randomTempo.Next(30, 42);
                    novoTempo.Humidade = humudade;
                    int vento = randomTempo.Next(10, 30);
                    novoTempo.Vento = vento;
                    novoTempo.Imagem = @"\Imagens\Sol.png";
                    ListaTempo.Add(novoTempo);
                }
                if (OTempo[index] == "Nublado")
                {
                    Tempo novoTempo = new Tempo();
                    novoTempo.IdPais = pais.Id;
                    int Temperatura = randomTempo.Next(10, 20);
                    novoTempo.Temperatura = Temperatura;
                    int precipitacao = randomTempo.Next(20, 30);
                    novoTempo.Precipitacao = precipitacao;
                    int humudade = randomTempo.Next(42, 56);
                    novoTempo.Humidade = humudade;
                    int vento = randomTempo.Next(13, 35);
                    novoTempo.Vento = vento;
                    novoTempo.Imagem = @"\Imagens\Nublado.png";
                    ListaTempo.Add(novoTempo);
                }
                if (OTempo[index] == "Chuva")
                {
                    Tempo novoTempo = new Tempo();
                    novoTempo.IdPais = pais.Id;
                    int Temperatura = randomTempo.Next(5, 20);
                    novoTempo.Temperatura = Temperatura;
                    int precipitacao = randomTempo.Next(30, 50);
                    novoTempo.Precipitacao = precipitacao;
                    int humudade = randomTempo.Next(56, 94);
                    novoTempo.Humidade = humudade;
                    int vento = randomTempo.Next(14, 40);
                    novoTempo.Vento = vento;
                    novoTempo.Imagem = @"\Imagens\Chuva.png";
                    ListaTempo.Add(novoTempo);
                }
                if (OTempo[index] == "Trovoada")
                {
                    Tempo novoTempo = new Tempo();
                    novoTempo.IdPais = pais.Id;
                    int Temperatura = randomTempo.Next(5, 20);
                    novoTempo.Temperatura = Temperatura;
                    int precipitacao = randomTempo.Next(30, 50);
                    novoTempo.Precipitacao = precipitacao;
                    int humudade = randomTempo.Next(70, 94);
                    novoTempo.Humidade = humudade;
                    int vento = randomTempo.Next(50, 80);
                    novoTempo.Vento = vento;
                    novoTempo.Imagem = @"\Imagens\Trovoada.png";
                    ListaTempo.Add(novoTempo);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCinelAirlines
{
    class Noticia
    {
        public int IdNoticia { get; set; }
        public string TituloNoticia { get; set; }
        public string TextoNoticia { get; set; }
        public string DataNoticia { get; set; }
        public string Imagem { get; set; }

        public string ApresentacaoDadosNoticias
        {
            get
            {
                return $"{TituloNoticia} // {DataNoticia}";
            }
        }
    }
}

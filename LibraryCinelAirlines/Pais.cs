using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCinelAirlines
{
    public class Pais
    {
        public int Id { get; set; }
        public string NomePais { get; set; }
        public string Imagem { get; set; }

        public string ApresentacaoDadosPais
        {
            get
            {
                return $"{NomePais}";
            }
        }
    }
}

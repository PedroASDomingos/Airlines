using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCinelAirlines
{
    public class Aeroporto
    {
        public int IdAeroporto { get; set; }
        public int IdPais { get; set; }
        public string NomeAeroporto { get; set; }

        public string ApresentacaoDadosAeroporto
        {
            get
            {
                return $"{NomeAeroporto}";
            }
        }
    }
}

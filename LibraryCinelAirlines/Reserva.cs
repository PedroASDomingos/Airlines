using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCinelAirlines
{
    public class Reserva
    {
        public int IdPassageiro { get; set; }
        public string NomePassageiro { get; set; }
        public int IdVoo { get; set; }
        public string Assento { get; set; }
        public string FicheiroPdf { get; set; }

        public string ApresentacaoDadosVoo
        {
            get
            {
                return $"{NomePassageiro} // {Assento}";
            }
        }
    }
}

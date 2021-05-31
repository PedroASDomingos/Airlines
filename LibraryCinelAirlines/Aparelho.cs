using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCinelAirlines
{
    public class Aparelho
    {
        public int IdAparelho { get; set; }
        public string NomeAparelho { get; set; }
        public int LotacaoEconomica { get; set; }
        public int LotacaoExecutiva { get; set; }
        public string Imagem { get; set; }

        public string ApresentacaoDadosAparelhos
        {
            get
            {
                return $"{NomeAparelho} // Lotação em Economica: {LotacaoEconomica} // Lotação em Executiva: {LotacaoExecutiva}";
            }
        }
    }
}

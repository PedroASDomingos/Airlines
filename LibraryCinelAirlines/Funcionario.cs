using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCinelAirlines
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        public string Extencao { get; set; }
        public string Imagem { get; set; }

        public string ApresentacaoDadosFuncionario
        {
            get
            {
                return $"{Nome} // {Cargo} // {Email}";
            }
        }
    }
}

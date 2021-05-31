using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCinelAirlines
{
    public class User
    {
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string UltimoLogin { get; set; }
        public int NivelAcesso { get; set; }
        public string ApresentacaoDadosUser
        {
            get
            {
                return $"{UserName} // {Email}";
            }
        }

    }
}

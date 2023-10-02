
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp
{
    public class ConfigConection
    {
        private string ConectionString;
        public string GetConectionString()
        {
            ConectionString = "server = localhost; user id=userdb; password=(Suporte) ; database = suportedb";
            return ConectionString;
        } 
       
    }
}

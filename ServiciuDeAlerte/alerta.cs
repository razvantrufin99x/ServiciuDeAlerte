using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciuDeAlerte
{
    public class alerta
    {
        public string idalerta
        {
            get;
            set;
        }
        public DateTime dataexpirarii
        {
            get;
            set;
        }

        public alerta()
        {

        }

        public alerta(string pidalerta, DateTime pdataexpirarii)
        {
            idalerta = pidalerta;
            dataexpirarii = pdataexpirarii;

        }
    }
}

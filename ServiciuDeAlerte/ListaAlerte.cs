using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciuDeAlerte
{
    public class ListaAlerte
    {
        public int urmatoareaalerta = 0;
        public List <alerta> alerte = new List<alerta>();

        public ListaAlerte() { 
        
        }
        public ListaAlerte(alerta a)
        {
            alerte.Add(a);
        }
        public ListaAlerte(string pid, DateTime pdata)
        {
            alerte.Add(new alerta(pid,pdata));
        }
        
        public string verificaalertaurmatoare()
        { 
            DateTime dt = new DateTime();
            dt = DateTime.Now;

            if (dt > alerte[urmatoareaalerta].dataexpirarii)
            {
                return alerteaza(urmatoareaalerta);
            }

            return null;
        }

        public int findFirstAlerte()
        {
            int f = 0;
            int firstdate = 0;
            int seconddate = 0;
            for (int i = 0; i < alerte.Count-1; i++)
            {
                firstdate = alerte[i].dataexpirarii.Year;
                seconddate =  alerte[i+1].dataexpirarii.Year;
                if (firstdate > seconddate) { firstdate = seconddate; f = i + 1; }
                else { f = i; }
            }
            
            
            return f;
        }

        public string alerteaza(int pindexulalertei)
        {
           
            return alerte[urmatoareaalerta].idalerta + " : " + alerte[urmatoareaalerta].dataexpirarii.ToString();


        }
    }
}

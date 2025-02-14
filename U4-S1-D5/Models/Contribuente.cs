using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace U4_S1_D5.Models
{
    public class Contribuente
    {
        private string Nome { get; set; }
        private string Cognome { get; set; }
        private DateTime DataNascita { get; set; }
        private string CodiceFiscale { get; set; }
        private string Sesso { get; set; }
        private string ComuneResidenza { get; set; }
        private int RedditoAnnuale { get; set; }
        private double Imposta { get; set; }


        public double CalcoloImposta(int RedditoAnnuale)
        {

            if (RedditoAnnuale <= 15000)
            {
                return Imposta = RedditoAnnuale * 0.23;
            }
            else if (RedditoAnnuale <= 28000)
            {
                return Imposta = RedditoAnnuale * 0.27 + 3450;
            }
            else if (RedditoAnnuale <= 55000)
            {
                return Imposta = RedditoAnnuale * 0.38 + 6960;
            }
            else if (RedditoAnnuale <= 75000)
            {
                return Imposta = RedditoAnnuale * 0.41 + 17220;
            }
            else
            {
                return Imposta = RedditoAnnuale * 0.43 + 25420;
            }
        }
    }
}
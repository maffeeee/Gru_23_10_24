using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class StazioneDiRadiocomando
    {
        public string NumeroSeriale
        {
            get { return NumeroSeriale; }
            set { NumeroSeriale = value;  }
        }
        private Gru gruAssociata;

        public StazioneDiRadiocomando(string numeroSeriale, Gru gru)
        {
            NumeroSeriale = numeroSeriale;
            gruAssociata = gru;
        }

        public void AlzaGru(int metri)
        {
            gruAssociata.Alza(metri);
        }

        public void AbbassaGru(int metri)
        {
            gruAssociata.Abbassa(metri);
        }

        public void RiportaInPosizioneSicurezza()
        {
            gruAssociata.RiportaInPosizioneSicurezza();
        }

        public double GetAltezzaGru()
        {
            return gruAssociata.GetAltezza();
        }
    }
}

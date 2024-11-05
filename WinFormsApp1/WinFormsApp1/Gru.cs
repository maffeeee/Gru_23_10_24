using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Gru
    {
        private int numSeriale;
        private string produttore;
        private int hMax;
        private int hMin;
        private int hBraccio;
        public Gru(int numSeriale, string produttore, int hMax, int hMin)
        {
            this.numSeriale = numSeriale;
            this.produttore = produttore;
            this.hMax = hMax;
            this.hMin = hMin;
            this.hBraccio = hMin;
        }
        public int HBraccio
        {
            get { return hBraccio; }
            set
            {
                if (value > hMax)
                {
                    hBraccio = hMax;
                    Console.WriteLine("Altezza massima raggiunta.");
                }
                else if (value < hMin)
                {
                    hBraccio = hMin;
                    Console.WriteLine("Altezza minima raggiunta.");
                }
                else
                {
                    hBraccio = value;
                }
            }
        }
        public int HMax
        {
            get { return hMax; }
            set { hMax = value; }
        }
        public int HMin
        {
            get { return hMin; }
            set { hMin = value; }
        }
        public int NumSeriale
        {
            get { return numSeriale; }
        }
        public string Produttore
        {
            get { return produttore; }
        }
        public void Alza(int metri)
        {
            HBraccio += metri;
        }

        public void Abbassa(int metri)
        {
            HBraccio -= metri;
        }
        public void RiportaInPosizioneSicurezza()
        {
            HBraccio = hMin;
        }
        public int GetAltezza()
        {
            return HBraccio;
        }
    }
}

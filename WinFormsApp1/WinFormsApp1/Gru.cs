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
        private int produttore;
        private int hMax;
        private int hMin;
        private int hBraccio;

        public int HBraccio
        {
            get { return hBraccio; }
            set { hBraccio = value; }
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
        public int Produttore
        { 
            get { return produttore; }
        }
    }

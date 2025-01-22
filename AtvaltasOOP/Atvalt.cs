using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AtvaltasOOP
{
    internal class Atvalt
    {
        string eredmeny = string.Empty;

        int decSzam = 0;

        public Atvalt() { }
        public Atvalt(string szam)
        {
            if (isBinaris(szam)) binarisToDecimalis(szam);

            else if (isDecimal(szam)) decimalToBinaris(szam);

            else throw new FormatException("A megadott adat nem szám");

            
        }
        private void decimalToBinaris(string szam)
        {
            while (decSzam > 0)
            {
                eredmeny = decSzam % 2 + eredmeny;

                decSzam /= 2;
            }
        }
        private bool isDecimal(string szam)
        {
            bool eredm = true;
            try
            {
                decSzam = Math.Abs(Convert.ToInt32(szam));
            }
            catch
            {
                eredm = false;
            }
            return eredm;
        }
        private void binarisToDecimalis(string szam)
        {
            int j = 1;
            for (int i = szam.Length - 1; i > 0; i--)
            {
                decSzam += Convert.ToInt32(szam[i]) * j;
                j *= 2;
            }
        }
        private bool isBinaris(string szam)
        {
            bool eredm = true;
            if (szam[0] == '0')
                for (int i = 1; i < szam.Length; i++)
                    if (szam[i] != '0' && szam[i] != '1')
                    {
                        eredm = false;
                        break;
                    }
            return eredm;
        }
    }
}

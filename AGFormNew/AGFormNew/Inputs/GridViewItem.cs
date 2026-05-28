using AGFormNew.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGFormNew.Inputs
{
    public class GridViewItem
    {
        public double Precision { get; set; }
        public double LimiteIzquierdo { get; set; }
        public double LimiteDerecho { get; set; }
        public int NroBits
        {
            get
            {
                return (int)Math.Ceiling(Math.Log((LimiteDerecho - LimiteIzquierdo) * Math.Pow(10, Precision) + 1) / Math.Log(2));
            }
        }
        public string Substring
        {
            get
            {
                return CalculosHelper.GenerarBinarioAleatorio(NroBits);
            }
        }

        public double SubstringDecimal
        {
            get
            {
                return Convert.ToInt64(Substring, 2);
            }
        }

        public double SubstringNroReal
        {
            get
            {
                return Math.Round(LimiteIzquierdo + SubstringDecimal * (LimiteDerecho - LimiteIzquierdo) / (Math.Pow(2, NroBits) - 1), 4);
            }
        }
    }
}

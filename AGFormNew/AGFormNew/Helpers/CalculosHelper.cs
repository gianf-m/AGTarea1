using System;
using System.Collections.Generic;
using System.Text;

namespace AGFormNew.Helpers
{
    public static class CalculosHelper
    {
        private static readonly Random _random = new Random();
        public static string GenerarBinarioAleatorio(int longitud)
        {
            if (longitud <= 0) return string.Empty;

            StringBuilder sb = new StringBuilder(longitud);

            for (int i = 0; i < longitud; i++)
            {
                // _random.Next(2) devuelve 0 o 1 de forma equitativa
                sb.Append(_random.Next(2));
            }

            return sb.ToString();
        }
    }
}

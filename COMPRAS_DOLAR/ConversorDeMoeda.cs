using System;
using System.Collections.Generic;
using System.Text;

namespace COMPRAS_DOLAR
{
    internal class ConversorDeMoeda
    {
        
        public static double ValorReais (double x, double y)
        {
            double total = x * y;
            return total + total * 0.06;
        }

        
    }
}

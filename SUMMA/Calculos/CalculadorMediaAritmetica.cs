using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMMA.Calculos
{
    internal class CalculadorMediaAritmetica : ICalculadorMedia
    {
        public double Calcular(List<double> numeros)
        {
            return numeros.Average();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMMA.Calculos
{
    internal class CalculadorMediaArmonica : ICalculadorMedia
    {
        public double Calcular(List<double> numeros)
        {
            return numeros.Count / numeros.Sum(x => 1 / x);
        }
    }
}

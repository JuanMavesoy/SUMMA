using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMMA.Calculos
{
    internal class CalculadorMediana : ICalculadorMedia
    {
        public double Calcular(List<double> numeros)
        {
            List<double> listaOrdenada = numeros.OrderBy(x => x).ToList();
            int n = listaOrdenada.Count;
            if (n % 2 == 0)
            {
                double medioIzquierdo = listaOrdenada[n / 2 - 1];
                double medioDerecho = listaOrdenada[n / 2];
                return (medioIzquierdo + medioDerecho) / 2;
            }
            else
            {
                return listaOrdenada[n / 2];
            }
        }
    }
}

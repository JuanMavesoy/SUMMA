using SUMMA.Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMMA
{
    internal class ContextoMedia
    {
        private ICalculadorMedia _calculador;

        public void EstablecerCalculador(ICalculadorMedia calculador)
        {
            _calculador = calculador;
        }

        public double CalcularMedia(List<double> numeros)
        {
            if (_calculador == null)
            {
                throw new InvalidOperationException("La estrategia de cálculo no ha sido establecida.");
            }

            return _calculador.Calcular(numeros);
        }
    }
}

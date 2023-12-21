using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMMA
{
    internal class ImpresorEscalera
    {
        public static string ImprimirEscaleraDerechaA(int n)
        {
            string escalera = "";
            for (int i = 1; i <= n; i++)
            {
                escalera += new string(' ', n - i) + new string('*', i) + "\n";
            }
            return escalera.TrimEnd();
        }

        public static string ImprimirEscaleraDerechaB(int n)
        {
            string escalera = "";
            for (int i = n; i >= 1; i--)
            {
                escalera += new string(' ', n - i) + new string('*', i) + "\n";
            }
            return escalera.TrimEnd();
        }


        public static string ImprimirEscaleraCentradaC(int n)
        {
            string escalera = "";

            for (int i = 1; i <= n; i++)
            {
                string espacios = new string(' ', n - i);
                string asteriscos = new string('*', 2 * i+2);
                escalera += espacios + asteriscos + "\n";
            }

            for (int i = n - 1; i >= 1; i--)
            {
                string espacios = new string(' ', n - i);
                string asteriscos = new string('*', 2 * i+2);
                escalera += espacios + asteriscos + "\n";
            }

            return escalera.TrimEnd();
        }



    }
}

    using SUMMA.Calculos;
    using SUMMA;

int terminar = 1; 

   while (terminar != 2){

        Console.Write("Ingrese números separados por espacios: ");
        string entradaNumeros = Console.ReadLine();


        List<double> listaNumeros;
        if (!TryParseNumeros(entradaNumeros, out listaNumeros))
        {
            Console.WriteLine("Entrada no válida para números.");
            return;
        }

        ContextoMedia contextoMedia = new ContextoMedia();

        Console.WriteLine("\nSeleccione el agente para el cálculo de la media:");
        Console.WriteLine("1. Agente A (Aritmética)");
        Console.WriteLine("2. Agente B (Armónica)");
        Console.WriteLine("3. Agente C (Mediana)");
        Console.Write("Ingrese el número del agente: ");

        if (int.TryParse(Console.ReadLine(), out int agenteSeleccionado))
        {
            ICalculadorMedia calculadorSeleccionado = ObtenerCalculadorMedia(agenteSeleccionado);

            if (calculadorSeleccionado != null)
            {
                contextoMedia.EstablecerCalculador(calculadorSeleccionado);

                Console.WriteLine("Resultado del cálculo de la media: " + contextoMedia.CalcularMedia(listaNumeros));


                Console.Write("\nIngrese el tamaño de la escalera: ");

                string entradaTamanioEscalera = Console.ReadLine();

                if (int.TryParse(entradaTamanioEscalera, out int tamanioEscalera) && tamanioEscalera > 0 && tamanioEscalera < 100)
                {
                    // Mostrar las escaleras según el agente seleccionado
                    switch (agenteSeleccionado)
                    {
                        case 1:
                            Console.WriteLine("\nEscalera A (Derecha):\n" + ImpresorEscalera.ImprimirEscaleraDerechaA(tamanioEscalera));
                            break;
                        case 2:
                            Console.WriteLine("\nEscalera B (Derecha):\n" + ImpresorEscalera.ImprimirEscaleraDerechaB(tamanioEscalera));
                            break;
                        case 3:
                            Console.WriteLine("\nEscalera C (Centrada):\n" + ImpresorEscalera.ImprimirEscaleraCentradaC(tamanioEscalera));
                            break;
                        default:
                            Console.WriteLine("Número de agente no válido para escaleras.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida para el tamaño de la escalera.");
                }
            }
            else
            {
                Console.WriteLine("Número de agente no válido para cálculo de media.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida para el número del agente.");
        }


        while (true)
        {
            Console.WriteLine("\nDesea salir del sistema:");
            Console.WriteLine("1. No");
            Console.WriteLine("2. Si");
            Console.Write("Ingrese el número de la opción: ");

            if (int.TryParse(Console.ReadLine(), out terminar))
            {
                if (terminar == 1 || terminar == 2)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, ingrese 1 para continuar o 2 para salir.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
            }
        }

    }

     static ICalculadorMedia ObtenerCalculadorMedia(int agenteSeleccionado)
     {
         switch (agenteSeleccionado)
         {
             case 1:
                 return new CalculadorMediaAritmetica();
             case 2:
                 return new CalculadorMediaArmonica();
             case 3:
                 return new CalculadorMediana();
             default:
                 return null;
         }
     }

    static bool TryParseNumeros(string entrada, out List<double> numeros)
    {
        numeros = new List<double>();
        string[] cadenasNumeros = entrada.Split(' ');

        foreach (string cadenaNumero in cadenasNumeros)
        {
            if (!double.TryParse(cadenaNumero, out double numero))
            {
                return false;
            }
            numeros.Add(numero);
        }

        return true;
    }
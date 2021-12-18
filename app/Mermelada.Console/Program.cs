using System.Collections.Generic;

namespace Mermelada.Console
{
    class Program
    {

        static void Main(string[] args)
        {
            var respuesta = string.Empty;

            List<int> opciones = new List<int>() { 1, 2, 3 };

            do
            {
                System.Console.Clear();
                System.Console.WriteLine("Bienvenido al sistema de Alimentación");
                System.Console.WriteLine("=====================================");
                System.Console.WriteLine();


                System.Console.WriteLine("Que deseas realizar:");
                System.Console.WriteLine();

                System.Console.WriteLine("1. Mermelada");
                System.Console.WriteLine("2. Jalea");
                System.Console.WriteLine("3. Mermelada Light");
                System.Console.WriteLine();

                System.Console.WriteLine("Elige un número...");
                System.Console.WriteLine();

                var cantidadStr = string.Empty;
                int cantidad;
                bool valid = true;

                do
                {
                    if (valid)
                    {
                        System.Console.WriteLine();
                        System.Console.WriteLine("Ingresa una opción correctamente...");
                        System.Console.WriteLine();
                    }

                    cantidadStr = System.Console.ReadLine();

                    valid = !int.TryParse(cantidadStr, out cantidad) || !opciones.Contains(cantidad);

                } while (valid);

                System.Console.WriteLine();
                System.Console.WriteLine("=====================================");
                System.Console.WriteLine();
                System.Console.WriteLine("Elegiste la opción " + cantidadStr);
                System.Console.WriteLine("");
                System.Console.WriteLine("Nuestra recomendación es:");
                System.Console.WriteLine();
                System.Console.WriteLine();

                switch (cantidad)
                {
                    case 1:
                        System.Console.WriteLine(" - Puedes hacer mermelada con un 1 kilo de pulpa y 800 gramos de azúcar.");
                        break;
                    case 2:
                        System.Console.WriteLine(" - Puedes hacer jalea con un 1 kilo de pulpa y 500 gramos de azúcar.");
                        break;
                    case 3:
                        System.Console.WriteLine(" - Puedes hacer mermelada con un 1 kilo de pulpa y 200 gramos de azúcar, añadir agar- agar 10gr por 1 kilo de fruta");
                        System.Console.WriteLine("   La cocción es hasta llegar 65-75 brix.");
                        break;
                    default:
                        break;
                }
                System.Console.WriteLine();
                System.Console.WriteLine("=====================================");
                System.Console.WriteLine();

                do
                {
                    if (!(respuesta == "Y" || respuesta == "N") && respuesta != string.Empty)
                    {
                        System.Console.WriteLine();
                        System.Console.WriteLine("Ingresa una respuesta correctamente...");
                        System.Console.WriteLine();
                    }

                    System.Console.WriteLine("Deseas intentarlo denuevo (y/n)");
                    respuesta = System.Console.ReadLine().Trim().ToUpper();

                } while (!(respuesta == "Y" || respuesta == "N"));


            } while (respuesta == "Y");

        }
    }
}

using System;

namespace Dio
{
    class Xenlongao
    {
        static void Main(string[] args)

        {

            // Quantidade de casos teste
            int numberOfTests = Convert.ToInt32(Console.ReadLine());
            for (int n = 0; n < numberOfTests; n++)

            {
                // Quantidade de esferas
                int numberOfSpheres = int.Parse(Console.ReadLine());
                // Para que um numero possua uma quantidade impar de divisores basta que ele possua uma raiz quadrada exata
                // desta forma
                double numberOfSpheresNeeded = numberOfSpheres - Math.Floor(Math.Sqrt(numberOfSpheres));
                Console.WriteLine(numberOfSpheresNeeded);

            }
        }
    }
}


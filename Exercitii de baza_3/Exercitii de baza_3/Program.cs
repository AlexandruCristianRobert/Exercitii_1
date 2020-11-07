using System;
using System.Linq;

namespace Exercitii_de_baza_3
{
    class Program
    {


        //  ex 1 verifica daca primul sau ultimul nr din vector e numarul ala
        static void PrimUltim(int[] array, int numar)
        {
            if (array[0] == numar || array[array.Length - 1] == numar)
                Console.WriteLine("apare");
            else
                Console.WriteLine("nu apare");
        }

        //  ex 3 verifica daca nr1 = nr ultim
        static bool nr1nrultim(int[] array)
        {
            if (array[0] == array[array.Length - 1])
                return true;
            else
                return false;
        }
        // ca ex 3 doar ca avem doi vectori , e primul sau ultimul nr sunt aceleasi

        static bool verificare2vectori(int[] array1, int[] array2)
        {
            if (array1[0] == array2[0] || array1[array1.Length - 1] == array2[array2.Length - 1])
                return true;
            else
                return false;

        }
        // ex 8

        public static string Invers(string text)
        {
            int lid = text.LastIndexOf('(');
            if (lid == -1)
            {
                return text;
            }
            else
            {
                int rid = text.IndexOf(')', lid);

                return Invers(
                      text.Substring(0, lid)
                    + new string(text.Substring(lid + 1, rid - lid - 1).Reverse().ToArray())
                    + text.Substring(rid + 1)
                );
            }
        }
        static void Main(string[] args)
        {/*
            Console.WriteLine("ex                                 1");
            int numar, n;
            Console.WriteLine("Introdu numarul");
            numar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdu lungimea vectorului:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Introdu elementele vectorului:");
            for (int i = 0; i < n; i++)
                array[i] = Convert.ToInt32(Console.ReadLine());
            PrimUltim(array, numar);
            // ex 2 afiseaza suma elementelor dintr-un vector
            Console.WriteLine("exercitiul                                 2");
            Console.WriteLine(array.Sum());
            Console.WriteLine("exercitiul                                 3");

            Console.WriteLine(nr1nrultim(array));

            int[] array2 = new int[n];// imi e lene sa fac alta lungime

            Console.WriteLine("exercitiul                                 4");
            Console.WriteLine("Introdu nr pentru al 2-lea vector");
            for (int i = 0; i < n; i++)
                array2[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( verificare2vectori(array, array2));
            Console.WriteLine("exercitiul                                 5");
            //inverseaza o matrice
            
               Array.Reverse(array);
            foreach(int x in array)
                Console.WriteLine(x);
                */
            Console.WriteLine("exercitiul                                 6");

            //  verifica daca are vrun element nr impar
            /*
            int n;
            Console.WriteLine("Introdu lungimea vectorului:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            bool verif = false;
            Console.WriteLine("Introdu elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i] % 2 != 0)
                    verif = true;
            }
            Console.WriteLine(verif);

            Console.WriteLine("exercitiul                                 7");
            // suma elementelor matricei DACA nu au 0 deasupra lor
            Console.WriteLine("introdu elementele matricei");
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j=0; j < n; j++)
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int j = 0; j < n; j++)
                sum += matrix[0,j];
            for (int i = 1; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (matrix[i - 1, j] != 0)
                        sum += matrix[i, j];
            Console.WriteLine("Suma lor este: "+sum);
            */
            Console.WriteLine("exercitiul                                 8");
            
            //se da un string, inverseaza substringurile din paranteze si elimina parantezele
            string text = Console.ReadLine();
            Console.WriteLine(Invers(text));


        }
    }
}

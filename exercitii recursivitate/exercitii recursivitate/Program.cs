using System;

namespace exercitii_recursivitate
{
    class Program
    {
        //ex 1 
        //primele n numere naturale

        static void Natural(int numar, int i)
        {
            if (i <= numar)
            {
                Console.WriteLine(i);
                i++;
                Natural(numar, i);
            }
        }
        // ex 2, natural invers
        static void NaturalInvers(int numar)
        {
            if (numar > 0)
            {
                Console.WriteLine(numar);
                numar--;
                NaturalInvers(numar);
            }
        }

        //  ex 3 Suma primelor n nr nat
        static void SumaNatural(int numar, int suma)
        {
            if (numar > 0)
            {
                suma += numar;
                numar--;
                SumaNatural(numar, suma);
            }
            else
                Console.WriteLine(suma);


        }
        // ex 4 afisarea cifrelor unui numar
        static void Cifre(int numar)
        {
            if (numar > 0)
            {
                Console.WriteLine(numar % 10);
                numar /= 10;
                Cifre(numar);
            }
        }
        // ex 5 numara cifrele
        static void NrCifre(int numar, int nr)
        {
            if (numar > 0)
            {
                nr++;
                numar /= 10;
                NrCifre(numar, nr);

            }
            else
                Console.WriteLine(nr);
        }
        // ex 6  afiseaza nr pare sau impare( alege ) dintr-o raza data
        static void Par(int min, int max)
        {
            if (min <= max)
            {
                if (min % 2 == 0)
                    Console.WriteLine(min);
                min++;
                Par(min, max);
            }
        }
        // ex 7 verifica recursiv daca un nr e prim
        static void Prim(int nr, int i)
            {
            if(nr==i)
                Console.WriteLine("numarul "+nr+" este prim");
            if(i<nr && nr%i!=0)
            {
                i++;
                Prim(nr, i);
            }
            
            }
        // ex 8 verifica daca e sau nu palindrom un cuvant
        static void Palindrom(string text,bool  k)
        {
            
                if (text.Length <= 1 && k==true)
                    Console.WriteLine("Este palindrom");
                

            if (text.Length > 1 )
            {
                if (text[0] != text[text.Length - 1])
                {
                    text = text.Substring(1, text.Length - 2);
                    Palindrom(text, k);
                }
                else
                    k = false;
                

            }
            if (k == false)
                Console.WriteLine("Nu e palindrom");
        }
            
            
        // ex 9 factorialul unui numar
        static void factorial(int numar,int suma)
        {
            if (numar == 0)
                Console.WriteLine(suma);
            if (numar>0)
            {
                suma *= numar;
                numar--;
                factorial(numar, suma);
            }
            
            
        }
        // ex 10 fibonnai n numere
        static void fibonacci(int numar,int nr1,int nr2)
        {
            int aux;
            numar--;
            if (nr1==0)
            {
                Console.WriteLine(nr1);
            }
            if(numar>0)
            {
                Console.WriteLine(nr2);
                aux = nr2;
                nr2 += nr1;
                nr1 = aux;
                
                fibonacci(numar, nr1, nr2);
            }
        }
        //  ex 11 toate permutarile unui vector

         static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            a ^= b;
            b ^= a;
            a ^= b;
        }

         static void GetPer(char[] list)
        {
            int x = list.Length - 1;
            GetPer(list, 0, x);
        }

         static void GetPer(char[] list, int k, int m)
        {
            if (k == m)
            {
                Console.Write(list);
                Console.WriteLine();
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Start!");
            int n = Convert.ToInt32(Console.ReadLine());
            //int i = 2;
            //Natural(n, i);
            //NaturalInvers(n);
            int suma = 1;
            //SumaNatural(n,suma);
            //Cifre(n);
            int nr = 0;
            //NrCifre(n, nr);
            //int min = Convert.ToInt32(Console.ReadLine());
            //int max= Convert.ToInt32(Console.ReadLine());
            //Par(min, max);
            //Prim(n, i);
            //Console.WriteLine("text");
            //string text = Console.ReadLine();
            //bool k = true;
            //Palindrom(text,k);
            //factorial(n, suma);
            int nr2 = 1;
            //fibonacci(n,nr,nr2);
            Console.WriteLine("permutari");
            string a = Console.ReadLine();
            char[] lista = a.ToCharArray();

            GetPer(lista);
            
        }
    }

}

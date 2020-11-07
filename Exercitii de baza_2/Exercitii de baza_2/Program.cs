using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercitii_de_baza_2
{


    class Program
    {

        // ex 1 suma cifrelor unui numar
        static int SumaCifre(int myNum)
        {
            int sum = 0;
            while (myNum != 0)
            {
                sum += myNum % 10;
                myNum /= 10;
            }
            return sum;


        }
        // ex 2 despartirea in cuvinte si scrierea inversa

        static string Despartire(string text)
        {
            string despartit = "";
            string[] cuvinte = text.Split(new[] { " " }, StringSplitOptions.None);
            for (int i = cuvinte.Length - 1; i >= 0; i--)
            {
                despartit = despartit + cuvinte[i] + " ";
            }
            return despartit;
        }
        // ex 3 verifica daca e multiplu de 3 sau 7  
        static bool verificare3_7(int x)
        {
            if (x % 3 == 0 || x % 7 == 0)
                return true;
            else
                return false;
        }
        // ex 4 verifica daca textul incepe cu un anumit cuvant
        static bool InceputText(string text, string cuvant)
        {
            string[] cuvinte = text.Split(new[] { " " }, StringSplitOptions.None);
            if (cuvinte[0] == cuvant)
                return true;
            else
                return false;
        }

        // ex 5 verifica daca una din cele 2 numere date se afla intre -10 si 10

        static bool RazaNumar(int x, int y, int minim, int maxim)
        {

            return (Enumerable.Range(minim, maxim).Contains(x) || Enumerable.Range(minim, maxim).Contains(y));

        }
        // ex 6 verifica daca pe pozitia 1 e scris hp  si stergel din text
        static string TextRamas(string text, string cuvant, int poz1, int poz2)
        {
            if (text.Substring(poz1, poz2).Equals(cuvant))
                text = text.Remove(poz1, poz1 + 1);

            return text;

        }

        // ex  7
        static void SubText(string text)
        {
            char[] raspuns = text.ToCharArray();

            for (int i = 0; i <= 1; i++)
                Console.Write(raspuns[i]);
        }

        //  ex 9 Cel mai apropiat nr de 20 sau daca sunt egale afiseaza 0
        static int Comparare(int nr1, int nr2, int target)
            {
            int Anr1=Math.Abs(nr1-target);
            int Anr2=Math.Abs(nr2-target);
            if (Anr1 > Anr2)
                return nr2;
            else
                if (Anr2 > Anr1)
                return nr1;
            else
                return 0;
            }

        // ex 10 
        static bool LiteraXOri(string text,char litera, int nr1,int nr2)
        {
            char[] transpus = text.ToCharArray();
            int nr = 0;
            for(int i=0;i<text.Length; i++)
            {
                if(transpus[i]==litera )
                {
                    nr++;
                }
                
                    
            }
            if (Enumerable.Range(nr1, nr2).Contains(nr))
                return true;
            else
                return false;
        }

        // ex 11
        static void VerificareXlitere(string text, char litera, int x)
        {
            char[] cuvinte = text.ToCharArray();
            int nr = 0;
            for(int i =0;i<x;i++)
            {
                if (cuvinte[i] == litera)
                    nr++;
            }
            
            if(nr==x)
            {
                Console.WriteLine("Textul contine litera "+litera+" de "+x+" ori");
            }
                
        }
        // ex 13
        static void TextImpar(string text)
        {
            char[] cuvinte = text.ToCharArray();
            for(int i=1;i<text.Length;i=i+2)
            {
                Console.Write(cuvinte[i]);
            }
            Console.WriteLine();
        }
        //  ex 14 numara de cate ori apare un numar intr-un vector

        static void NrNumar(int[] vector, int nr)
        {
            int numar = 0;
            for (int i = 0; i < vector.Length; i++)
                if (nr == vector[i])
                    numar++;
            Console.WriteLine("Numarul "+nr+" apare de "+numar+" ori");

        }

         static void Main(string[] args)
        {
            /*
            Console.WriteLine("Introdu numarul");
            int myNum = Convert.ToInt32(Console.ReadLine());
            int sumaCifre = SumaCifre(myNum);
            Console.WriteLine("Sum cifrelor este: "+sumaCifre);

            Console.WriteLine("introdu textul:");
            string text = Console.ReadLine();
            Console.WriteLine(Despartire(text));

            int numar_verificare;
            Console.WriteLine("introdu numarul");
            numar_verificare = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(verificare3_7(numar_verificare));

            Console.WriteLine("Introdu cuvantul");
            string cuvant = Console.ReadLine();
            if(InceputText(text,cuvant))
                Console.WriteLine("Textul incepe cu cuvantul " + cuvant);
            else
                Console.WriteLine("Textul nu incepe cu cuvantul " + cuvant);
                
              int x,  y;
            Console.WriteLine("introdu numerele, nr1= ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nr2=");
            y = Convert.ToInt32(Console.ReadLine());

            if(RazaNumar(x,y,-10,10))
                Console.WriteLine("Cel putin unul din cele doua numere se afla in raza -10,10");
            else
                Console.WriteLine("Numerele nu se afla in raza -10,10");
                */
            /*
        // ex6
        Console.WriteLine("Introdu textul ");
        string text = Console.ReadLine();
        Console.WriteLine("introdu cuvantul pe care vrei sa verifici daca il contine textul");
        string cuvant = Console.ReadLine();
        Console.WriteLine("Introdu pozitia de unde sa inceapa cuvantul:");
        int pozitie = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(TextRamas(text,cuvant,pozitie,cuvant.Length));

        //ex 7
        SubText(text);

        // ex 8 Minimul si maximul dintre 3 nr
        int x, y, z;
        Console.WriteLine("\nIntrodu nr:");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        z = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Maximul este "+Math.Max(Math.Max(x,y),z));
        Console.WriteLine("Minimul este "+Math.Min(z,Math.Min(x,y)));


        // ex 9
        //folosim aceleasi x,y,z de mai sus
        Console.WriteLine(Comparare(x,y,z));

        //  ex 10
        Console.WriteLine("introdu litera");
        char litera= Console.ReadLine()[0];
        Console.WriteLine("introdu limita  mica si dupa cea mare:");
        int min = Convert.ToInt32(Console.ReadLine());
        int max = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(LiteraXOri(text,litera,min,max));
        */

            // ex 11
            Console.WriteLine("                                         ex 11");
            string text;
            Console.WriteLine("introdu Textul:");
            text = Console.ReadLine();
            if(text.Length<4)
                Console.WriteLine(text.ToUpper());
            else
                Console.WriteLine(text.Substring(0,4).ToLower()+text.Substring(4,text.Length-4));

            // ex 12 verifica daca stringul incepe cu x caractere pe primele y pozitii
            Console.WriteLine("                                         ex 12");
            Console.WriteLine("introdu litera, dupa nr de pozitii");
            char litera = Console.ReadLine()[0];
            int nrPoz = Convert.ToInt32(Console.ReadLine());
            VerificareXlitere(text, litera, nrPoz);

            //ex 13 textul doar de pe poziiile impare
            Console.WriteLine("                                         ex 13");
            TextImpar(text);

            // ex 14
            Console.WriteLine("                                         ex 14");

            Console.WriteLine("introdu numarul, lungimea vectorului si elementele din vector");
            int nr, n;
            int[] a = new int[101];
            nr = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());

            NrNumar(a, nr);
        }
    }
}

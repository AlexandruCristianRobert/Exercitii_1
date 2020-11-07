using System;

namespace data_types_exercitii
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // ex 1
            // introdu 3 litere si le afiseaza in rodine inversa
            char[] litere = new char[3];
            Console.WriteLine("introdu 3 litere");
            for (int i = 0; i < 3; i++)
                litere[i]= Console.ReadLine()[0];
            for(int i=2;i>=0;i--)
                Console.WriteLine(litere[i]);
            // dai un numar si o lungime si face o piramida patrata in jos cu ele 
            int numar, lungime;
            Console.WriteLine("exercitiu                 2");
            Console.WriteLine("numar si lungime");
            numar = Convert.ToInt32(Console.ReadLine());
            lungime = Convert.ToInt32(Console.ReadLine());
            while(lungime>0)
            {
                for(int i=0;i<lungime;i++)
                    Console.Write(numar);
                Console.WriteLine();
                lungime--;
            }
            Console.WriteLine("exercitiu                 3");

            string nume = "cristi2091";
            string parola = "regele1.";
            Console.WriteLine("introdu numele si parola");
            string userId, password;
            int nr = 0;
            while(nr<3)
            {
                userId = Console.ReadLine();
                password = Console.ReadLine();
                if (userId == nume && password == parola)
                {
                    Console.WriteLine("Te-ai logat");
                    break;
                }
                Console.WriteLine("Ai introdus o combinatie gresita");
                    nr++;
            }
            if(nr==3)
                Console.WriteLine("Ai incercat deja 3 ori, incearca mai tarziu");

            Console.WriteLine("exercitiu                 4");
            //  doua numere si faci o operatie cu ele
            int x, y;
            Console.WriteLine("introdu 2 numere");
            x = Convert.ToInt32(Console.ReadLine());
            y= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x+" + "+y+" = "+(x+y));

            Console.WriteLine("exercitiu                 5");
            // se da perimetru unui cerc, calculeaza raza si aria cercului
            Console.WriteLine("introdu raza ");
            int raza = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Perimetru este: " + 3.14*raza*2);
            Console.WriteLine("Aria este: "+(3.14*(raza*raza)));

            Console.WriteLine("exercitiu                 6");
            // x=y^2+2y+1 si se da y intre -5 si 5
            Console.WriteLine("introdu un numar intre -5 si 5");
            int numar6 = Convert.ToInt32(Console.ReadLine());
            if(y<0)
                Console.WriteLine("x = (" + numar6 + ") * (" + numar6 + ") +2 * (" + numar6 + ") + 1 = " + (numar6 * numar6 + 2 * numar6 + 1));
            else
            Console.WriteLine("x = "+numar6+" * "+numar6+" +2 * "+numar6+" + 1 = "+ (numar6*numar6+2*numar6+1));

            */
            Console.WriteLine("exercitiu                 7");
            // dintr-un nr decimal(baza 10 ) face unul in binar
            Console.WriteLine("introdu un nr decimal");
            int numar = Convert.ToInt32(Console.ReadLine());
            string binar = Convert.ToString(numar, 2);
            Console.WriteLine("Numarul "+numar+" in binar este: "+binar);


        }
    }
}

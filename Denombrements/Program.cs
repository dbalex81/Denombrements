using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// calcul de la multiplication pour k <= n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static long calculR(int n)
        {
            long r = 1;
            for (int k = 1; k <= n; k++)
                r *= k;
            Console.WriteLine(n + "! = " + r);
            return r;
        }
        /// <summary>
        /// multiplication avec n et t
        /// </summary>
        /// <param name="n"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        static long calculR2(int n, int t)
        {
            long r = 1;
            for (int k = (t - n + 1); k <= t; k++)
                r *= k;
            return r;
        }


        static void Main(string[] args)
        {
            int c = 1;
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());

                if (c == 0) { Environment.Exit(0); }

                if (c == 1)
                {
                    // saisie du nombre d'élément à gerer
                    Console.Write("nombre total d'éléments à gérer = "); 
                    int n = int.Parse(Console.ReadLine()); 
                    // calcul de r
                    calculR(n);
                }
                else
                {
                    if (c == 2)
                    {
                        // saisie du nombre d'élément à gerer
                        Console.Write("nombre total d'éléments à gérer = "); 
                        int t = int.Parse(Console.ReadLine()); 
                        // saisie du nombre d'élément dans le sous ensemble
                        Console.Write("nombre d'éléments dans le sous ensemble = "); 
                        int n = int.Parse(Console.ReadLine()); 
                        // calcul de r
                        long r = calculR2(n, t);
                        // Affichage du résultat de la multipliaction
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                    }
                    else
                    {
                        // saisie du nombre d'élément à gerer
                        Console.Write("nombre total d'éléments à gérer = "); 
                        int t = int.Parse(Console.ReadLine()); 
                        // saisie du nombre d'élément dans le sous ensemble
                        Console.Write("nombre d'éléments dans le sous ensemble = "); 
                        int n = int.Parse(Console.ReadLine()); 
                        // calcul de r1
                        long r1 = calculR2(n, t);
                        // calcul de r2
                        long r2 = calculR(n);
                        
                        // Affichage du résultat de la division des 2 nombres
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace lab4ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti o functie recursiva care va afisa in ordine elementele unui vector de
            intregi. */

            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];

            for(int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            Vector(n, vector);
        }
        static void Vector(int n, int[] vector)
        {
            if(n > 1)
            {
                Vector(n-1 , vector);
            }
            Console.Write( vector[n - 1] + " " );
        }
    }
}

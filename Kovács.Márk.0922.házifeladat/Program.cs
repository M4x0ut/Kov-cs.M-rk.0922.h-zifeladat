using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kovács.Márk._0922.házifeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("3. feladat:");
            int[] tomb3 = new int[20];
            int segedem = 9;
            for (int i = 0; i < tomb3.Length; i++)
            {
                int plusszsegedem = rnd.Next(segedem, 100);
                tomb3[i] = plusszsegedem;
                segedem = plusszsegedem;
                Console.Write(tomb3[i]+",");
            }
            Console.WriteLine();
            Console.WriteLine("5. feladat:");
            bool tizenharom = false;
            int[] tomb = new int[50];
            
            List<int> partalanok = new List<int>();
            for (int i = 10; i < 100; i++)
            {
                if (i%2==1)
                {
                    partalanok.Add(i);
                }
            }

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = partalanok[rnd.Next(0,partalanok.Count)];
                Console.Write(tomb[i]+",");
                if (tomb[i]==13)
                {
                    tizenharom = true;
                }
            }
            Console.WriteLine();
            if (tizenharom==true)
            {
                Console.WriteLine("Volt a tömben 13-as.");
            }
            else
            {
                Console.WriteLine("Nem volt 13-as a tömben.");
            }

            Console.WriteLine("6. feladat:");
            int[] tomb2 = new int[50];
            List<int> ketszamjegyu = new List<int>();
            for (int i = 10; i < 101; i++)
            {
                ketszamjegyu.Add(i);
            }
            for (int i = 0; i < tomb2.Length; i++)
            {
                int seged = ketszamjegyu[rnd.Next(0, ketszamjegyu.Count)];
                tomb2[i] = seged;
                Console.Write(tomb2[i]+",");
                ketszamjegyu.Remove(seged);
            }
            Console.ReadKey();

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheela_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriza = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriza[i, j] = (new Random()).Next(1, 10);
                    System.Threading.Thread.Sleep(600);
                    Console.WriteLine(matriza[i,j]);
                }
            }
            Console.WriteLine("give a number");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (x==matriza[i,j])
                    {
                        Console.WriteLine("the place:");
                        Console.Write(i+"," );
                        Console.WriteLine(j);

                    }
                
                }
            }
        }
    }
}

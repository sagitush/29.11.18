using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheela3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] zolelot = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    zolelot[i, j] = (new Random()).Next(0,2);
                    System.Threading.Thread.Sleep(350);
                    Console.WriteLine(zolelot[i,j]);
                }
            }
            int sum = 0;
            int nisionot = 0;
            while (sum < 9) 
            {
                sum = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (zolelot[i, j] == 0)
                        {
                            sum = sum + 1;
                        }
                    }
                }
                if (sum < 9)
                {
                    Console.WriteLine("mispar shura");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("mispar amuda");
                    int b = Convert.ToInt32(Console.ReadLine());
                    if (zolelot[a, b] == 1)
                    {
                        Console.WriteLine("boom");
                        zolelot[a, b] = 0;
                        nisionot = nisionot + 1;
                    }
                    else
                    {
                        Console.WriteLine("miss");
                        nisionot = nisionot + 1;
                    }
                }
            }
            Console.WriteLine("mispar anisionot:");
            Console.WriteLine(nisionot);
            
        }
    }
}

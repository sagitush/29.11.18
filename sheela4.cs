using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheela_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many classes?");
            int a = Convert.ToInt32(Console.ReadLine());
            int[][] classes = new int[a][];
            for (int i = 0; i < a; i++)
            {
                Console.Write("how many students in class");
                Console.WriteLine(i+1);
                int sizeclasses= Convert.ToInt32(Console.ReadLine());
                classes[i] = new int[sizeclasses];


            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < classes[i].Length; j++)
                {
                    Console.WriteLine("student grade:");
                  
                    classes[i][j]= Convert.ToInt32(Console.ReadLine());
                }
            }
            int sum;
            int[] memuza = new int[a];
            for (int i = 0; i < a; i++)
            {
                sum = 0;
                for (int j = 0; j < classes[i].Length; j++)
                {
                    sum = sum + classes[i][j];
                }
                memuza[i] = sum / classes[i].Length;
            }
            int gadol = 0;
            int index = 0;
            for (int i = 0; i < a; i++)
            {
                if(memuza[i]>gadol)
                {
                    gadol = memuza[i];
                    index = i;
                }
            }
            Console.WriteLine("amemuza agavoa beioter:");
            Console.WriteLine( index+1);
            Console.WriteLine(gadol);
        }
    }
}

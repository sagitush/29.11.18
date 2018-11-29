using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._11._18_siurey_bait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many students?");
            int stud = Convert.ToInt32(Console.ReadLine());
            int[] grades = new int[stud];
            for (int i = 0; i < stud; i++)
            {
                Console.WriteLine("what is the grade?");
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < stud; i++)
            {
                sum = sum + grades[i];
            }
            Console.Write("sum:");
            Console.WriteLine(sum);
            Console.Write("avg:");
            Console.WriteLine(sum/stud);

        }
    }
}

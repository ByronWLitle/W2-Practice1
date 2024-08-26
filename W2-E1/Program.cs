using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2_E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade = 0;
            Console.Write("What is your grade percentage? ");
            grade = Convert.ToInt32(Console.ReadLine());

            if (grade<0 || grade>100)
            {
                Console.WriteLine("Invalid Score");
            }
            else if (grade >= 90)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("D");
            }
            else if (grade >= 50)
            {
                Console.WriteLine("F");
            }

            Console.ReadLine();
        }
    }
}

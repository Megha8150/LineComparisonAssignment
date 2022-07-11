using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonAssignment
{
   public class LineComparison
    {
        public static void lineComparison()
        {
            Console.WriteLine("Enter the values for Line1");
            Console.WriteLine("Enter the value of x1");
            int x1 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter the value of x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double length1 = Math.Sqrt((Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)));
            Console.WriteLine(length1);

            Console.WriteLine("Enter the values for line2");
            Console.WriteLine("Enter the value of x3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x4");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y3");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y4");
            int y4 = Convert.ToInt32(Console.ReadLine());
            double length2 = Math.Sqrt((Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2)));
            Console.WriteLine(length2);

            if(length1==length2)
            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }

        }
    }
}

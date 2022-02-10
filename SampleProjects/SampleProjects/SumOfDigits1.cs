using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjects
{
    class SumOfDigits1
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to find the sum of digits:");
            int Number =int.Parse(Console.ReadLine());
            int Reminder,Sum = 0;
            while (Number > 0)
            {
                Reminder = Number % 10;
                Sum = Sum + Reminder;
                Number = Number/10;
            }
            Console.WriteLine("Sum of digits of given number:"+Sum);
            Console.ReadLine();
        }
    }
}

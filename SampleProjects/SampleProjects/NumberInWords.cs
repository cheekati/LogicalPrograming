using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjects
{
    class NumberInWords
    {
        static void Main()

        {
            Console.Write("Enter a number");
            int Number = int.Parse(Console.ReadLine());
            int Remainder, Reverse = 0;
            while (Number > 0)
            {
                Remainder = Number % 10;
                Reverse = Reverse * 10 + Remainder;
                Number = Number / 10;
            }
            while (Reverse > 0)
            {
                Remainder = Reverse % 10;
                switch (Remainder)
                {  
                    case 1: Console.Write("one"); break;
                    case 2: Console.Write("two"); break;
                    case 3: Console.Write("three"); break;
                    case 4: Console.Write("four"); break;
                    case 5: Console.Write("five"); break;
                    case 6: Console.Write("six"); break;
                    case 7: Console.Write("seven"); break;
                    case 8: Console.Write("eight"); break;
                    case 9: Console.Write("nine"); break;
                    case 10: Console.Write("ten"); break;
                }
                Reverse = Reverse / 10;
            }
            Console.ReadLine();
        }
    }
}

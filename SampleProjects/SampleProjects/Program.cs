// See https://aka.ms/new-console-template for more information
class FibnanocciSeries
{
    static void Main()
    {
        Console.Write("Enter Number of elements in the sequence:");
        int Number =int.Parse(Console.ReadLine());
        int Num1 = 0, Num2 = 1, Num3;
        Console.Write(Num1 + "" + Num2 + "");
        for(int i = 0; i < Number; i++)
        { Num3 = Num1+Num2;
            Console.WriteLine(Num3 + "");
            Num1 = Num2;
            Num2 = Num3;
        }
        Console.ReadLine();
    }
    
}





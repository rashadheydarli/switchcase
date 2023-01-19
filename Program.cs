
using System;
namespace calculator
{
    class Program
    {
        static void Main()
        {
            string op;
            int a, b, result;
            Console.WriteLine("Birinci ədədi daxil edin:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ikinci ədədi daxil edin:");
            b = Convert.ToInt32(Console.ReadLine());

            Initial: Console.WriteLine("Hansı əməliyyatı aparmaq istədiyinizi daxil edin:(+, -, *, /");
            op = Console.ReadLine();

            switch(op)
            {
                case "+":
                    result = a + b;
                    Console.WriteLine("Cavab:"+ result);
                    break;
                case "-":
                    result = a - b;
                    Console.WriteLine("Cavab:"+ result);
                    break;
                case "*":
                    result = a * b;
                    Console.WriteLine("Cavab:" + result);
                    break;
                case "/":
                    result = a / b;
                    Console.WriteLine("Cavab:" + result);
                    break;
                default:
                    Console.WriteLine("Hansı əməliyyatı aparmaq istədiyinizi daxil edin: (+, -, *, / ");
                    break;
            }
                    goto Initial;
        }
    }
}


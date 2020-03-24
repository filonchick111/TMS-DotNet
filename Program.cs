using System;

namespace SimpleCalc1
{
    class Program
    {
        static void Main(string[] args)
          
        
        {
           
            double a;
            double b;
            double total;
            char oper;
            Console.WriteLine("Введите первое число");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите оператор:");
            oper = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("введите второе число");
            b = Convert.ToDouble(Console.ReadLine());
            if (oper == '+')
            {
                total = a + b;
                Console.WriteLine(" Сумма " + a + " и " + b + " равна " + total + ".");

            }
            else if (oper == '-')
            {
                total = a - b;
                Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");

            }
            else if (oper == '*')
            {
                total = a * b;
                Console.WriteLine("Умножение " + a + " и " + b + " равно " + total + ".");
            }
            else if (oper == '/')
            {
                total = a / b;
                Console.WriteLine("Деление " + a + " и " + b + " равно " + total + ".");
            }
            else
            {
                Console.WriteLine("Неизвестный оператор.");

            }

            Console.ReadLine();


        }


    }
}

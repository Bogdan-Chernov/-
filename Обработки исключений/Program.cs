using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetClass;


namespace Обработки_исключений
{
  

        class Programm1
        {
            static void Main()
            {
            ClassSTO cal = new ClassSTO();


            Console.WriteLine("Введите ваше Имя");
            string nme = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Введите ваше Отчество");
            string tname = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - Сложение");
            Console.WriteLine("2 - Вычитание");
            Console.WriteLine("3 - Умножение");
            Console.WriteLine("4 - Деление");
            Console.WriteLine("");
            string o = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Введите Первое число: ");
                string x = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Введите Втрое число: ");
                string y = Console.ReadLine();
            Console.Clear();


            int a = Convert.ToInt32(x);
            int b = Convert.ToInt32(y);

            switch (o)
                {
                    case "1":
                    Console.Clear();
                    Console.WriteLine($"Здраствуйте глубоко увожаемый {nme} {tname}, вот ваши вычисления(+) :");
                    Console.WriteLine($"");
                    cal.addition(a, b);
                        Console.ReadLine();
                        break;

                    case "2":
                    Console.Clear();
                    Console.WriteLine($"Здраствуйте глубоко увожаемый {nme} {tname}, вот ваши вычисления(-) :");
                    Console.WriteLine($"");
                    cal.Subtraction(a, b);
                        Console.ReadLine();
                        break;

                    case "3":
                    Console.Clear();
                    Console.WriteLine($"Здраствуйте глубоко увожаемый {nme} {tname}, вот ваши вычисления(*) :");
                    Console.WriteLine($"");
                    cal.Multiplication(a, b);
                        Console.ReadLine();
                        break;

                    case "4":
                    Console.Clear();
                    Console.WriteLine($"Здраствуйте глубоко увожаемый {nme} {tname} , вот ваши вычисления(/) :");
                    Console.WriteLine($"");
                    cal.Division(a, b);
                    Console.ReadLine();
                    break;
                    default:
                        Console.WriteLine("Будьте Математиком)");
                    Console.ReadLine();
                    break;
                }
            }
        }
    
}
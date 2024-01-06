using System;

namespace Zadanie_9
{
    class Calculator
    {
        static void Main()
        {
            try
            {
                double num1, num2, result;
                char operation;
                Console.Write("Введите первое число: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите операцию (+, -, *, /): ");
                operation = Convert.ToChar(Console.ReadLine());

                Console.Write("Введите второе число: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        Console.WriteLine($"Сумма {num1} и {num2} равна {result}");
                        break;
                    case '-':
                        result = num1 - num2;
                        Console.WriteLine($"Разность {num1} и {num2} равна {result}");
                        break;
                    case '*':
                        result = num1 * num2;
                        Console.WriteLine($"Произведение {num1} и {num2} равно {result}");
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Деление {num1} на {num2} равно {result}");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: нельзя делить на ноль.");
                        }
                        break;
                    default:
                        Console.WriteLine("Ошибка: неверная операция.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}


            

        
    


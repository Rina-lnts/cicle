using System;

class Program
{
    static void Main()
    {
        int number1, number2;

        while (true)
        {
            Console.Write("Введите первое число (от 0 до 10): ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число (от 0 до 10): ");
            number2 = int.Parse(Console.ReadLine());

            if (number1 >= 0 && number1 <= 10 && number2 >= 0 && number2 <= 10)
            {
                int result = number1 * number2;
                Console.WriteLine($"Результат умножения чисел {number1} и {number2}: {result}");
                break;
            }
            else
            {
                Console.WriteLine("Недопустимые числа! Пожалуйста, введите числа от 0 до 10.");
            }
        }

        Console.ReadLine(); // Чтобы консольное окно не закрылось сразу
    }
}


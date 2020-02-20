using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            string inputValue = Console.ReadLine();
            Console.Write("Введите число, которое необходимо удалить: ");
            string number = Console.ReadLine();

            if (ulong.TryParse(inputValue, out ulong parsedInputValue) && ulong.TryParse(number, out ulong parsedNumber) && number.Length <= inputValue.Length)
            {
                string checkInputValue = inputValue;
                inputValue = inputValue.Replace(number, string.Empty);

                if (inputValue != checkInputValue)
                {
                    Console.WriteLine($"\nРезультат: {inputValue}");
                }
                else
                {
                    Console.WriteLine("\nЧисло для удаления не найдено.");
                }                                
            }
            else
            {
                Console.WriteLine("\nОшибка при вводе значений.");
            }
            Console.ReadKey(true);
        }
    }
}

using LibraryPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    /// <summary>
    /// Класс для ввода количества персон через консоль 
    /// </summary>
    internal class GetPersonCount
    {
        /// <summary>
        /// Метод для ввода количества персон через консоль 
        /// </summary>
        /// <returns></returns>
        public static int PersonCount()
        {
            int count;

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите количество персон для добавления в список:");
                    string inputCount = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(inputCount))
                    {
                        throw new FormatException("Поле с количеством персон не может быть пустым. Пожалуйста, введите число.");
                    }

                    if (!int.TryParse(inputCount, out count))
                    {
                        throw new FormatException("Некорректный ввод. Пожалуйста, введите число.");
                    }

                    if (count <= 0)
                    {
                        throw new ArgumentOutOfRangeException("Количество персон не может быть меньше или равно нулю.");
                    }

                    return count;
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                catch (ArgumentOutOfRangeException exception)
                {
                    Console.WriteLine(exception.Message);
                }

                Console.WriteLine("Пожалуйста, попробуйте еще раз.");
            }
        }
    }
}

using LibraryPerson;
namespace LB1
{
    /// <summary>
    /// Основная программа
    /// </summary>
    internal class Program
    {
        //TODO: исправить логику с добавлением в список 
        /// <summary>
        /// Основная программа
        /// </summary>
        public static void Main()
        {
            PersonList personlist = new PersonList();

            while (true)
            {
                Console.WriteLine("МЕНЮ\n" +
                    "\n1  -  Рандомная генерация списка взрослых и детей\t\t" +
                    "2  -  Заполнить поля списка вручную\n" +
                    "\nВыберите цифру\n");

                var number = Console.ReadLine();

                switch (number)
                {
                   //case "1":
                   //    {
                   //        Console.WriteLine("\nВведите количество людей в списке");
                   //        _ = Console.ReadKey();
                   //
                   //        int count;
                   //
                   //        while (true)
                   //        {
                   //            try
                   //            {
                   //                Console.WriteLine("Введите количество персон для добавления в список:");
                   //                string inputCount = Console.ReadLine();
                   //
                   //                if (string.IsNullOrWhiteSpace(inputCount))
                   //                {
                   //                    throw new ArgumentException("Поле с количеством персон не может " +
                   //                        "быть пустым. Введите число.");
                   //                }
                   //
                   //                count = int.Parse(inputCount);
                   //                break;
                   //            }
                   //            catch (ArgumentException exception)
                   //            {
                   //                Console.WriteLine(exception.Message);
                   //            }
                   //        }
                   //
                   //        for (int i = 0; i < count; i++)
                   //        {
                   //            Console.WriteLine($"\nСоздаем персону {i + 1}");
                   //            PersonBase newPerson = AddPersonConsole.PersonConsole();
                   //            firstlist.AddPerson(newPerson);
                   //        }
                   //
                   //        Console.WriteLine($"\nНовый список\n{firstlist.GetPersonsList()}");
                   //
                   //        Console.WriteLine("\nНажмите Enter для выхода из пункта 6");
                   //        _ = Console.ReadKey();
                   //        Console.Clear();
                   //        break;
                   //    }

                    case "2":
                        {
                            Console.WriteLine("\nДля тестирования создания рандомного " +
                                "списка взрослых и детей нажмите Enter");
                            _ = Console.ReadKey();

                            Console.WriteLine("Введите количество детей и взрослых для создания:");
                            int count = int.Parse(Console.ReadLine());
                            Random random = new Random();

                            for (int i = 0; i < count; i++)
                            {
                                int countAdults = random.Next(3, 7);
                                int countChildren = random.Next(3, 7);

                                for (int j = 0; j < countAdults; j++)
                                {
                                    personlist.AddPerson(RandomPerson.GetRandomAdult());
                                }

                                for (int k = 0; k < countChildren; k++)
                                {
                                    personlist.AddPerson(RandomPerson.GetRandomChild());
                                }

                                Console.WriteLine(personlist.GetPersonsList());
                            }
                            Console.WriteLine($"\nСписок 1\n{personlist.GetPersonsList()}");

                            Console.WriteLine("\nНажмите Enter для выхода из пункта меню");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                    default:
                        Console.WriteLine("Некорректный выбор. Пожалуйста, выберите пункт из меню.");
                        break;
                }
            }
        }
    }
}

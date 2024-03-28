using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        private static PersonList _firstPersonList = new PersonList("1 массиве");
        private static PersonList _secondPersonList = new PersonList("2 массиве");

        /// <summary>
        /// Основная программа
        /// </summary>
        private static void Main()
        {
            string number;

            while (true)
            {
                Console.WriteLine("МЕНЮ\n" +
                    "1  -  Создание программно двух списков персон в каждом из которых по три человека+вывести содержимое на экран\n" +
                    "2  -  Добавить нового челока в первый список\n" +
                    "3  -  Копирование второго человека из первого списка в конец второго списка\n" +
                    "4  -  Удаление второго человека из первого списка\n" +
                    "5  -  Очистить список полностью\n" +
                    "6  -  Ввести персону вручную\n" +
                    "7  -  RandomPerson\n");
                number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        {
                            Console.WriteLine("Для тестирования методов программно создано два списка людей.\n" +
                    "В каждом из списков содержатся записи о трех людях.\n" +
                    "Для отображения нажмите Enter");
                            _ = Console.ReadKey();
                            Console.WriteLine("\n3ab. Вывод содержимого списков:\n");
                            _firstPersonList[0] = new Person("Иван", "Иванов", 25, Gender.Male);
                            _firstPersonList[1] = new Person("Анна", "Анновна", 30, Gender.Female);
                            _firstPersonList[2] = new Person("Император", "Великий", 100, Gender.Male);
                            _firstPersonList.PrintPeople();
                            Console.WriteLine();
                            _secondPersonList[0] = new Person("Сидоров", "Сидор", 45, Gender.Male);
                            _secondPersonList[1] = new Person("Анастасия", "Подкорытова", 25, Gender.Female);
                            _secondPersonList[2] = new Person("Валерия", "Ващенко", 30, Gender.Female);
                            _secondPersonList.PrintPeople();
                            Console.WriteLine("\nНажмите Enter для выхода из пункта 1");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("\n3ab. Вывод содержимого списков:\n");
                            _firstPersonList.PrintPeople();
                            Console.WriteLine("\nДля просмотра добавления новой персоны нажмите Enter");
                            _ = Console.ReadKey();
                            Console.WriteLine("\nДобавление новой персоны в список 1\n");
                            _firstPersonList.AddPerson(new Person("Новый", "Человек", 40, Gender.Male));
                            _firstPersonList.PrintPeople();
                            Console.WriteLine("\nНажмите Enter для выхода из пункта 2");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("\n3ab. Вывод содержимого списков:\n");
                            _firstPersonList.PrintPeople();
                            Console.WriteLine("Для просмотра копирования второго человека первого списка в конец второго списка нажмите Enter");
                            _ = Console.ReadKey();
                            Console.WriteLine("\nКопирование второго человека из первого списка в конец второго списка\n");
                            int index = 1;
                            _secondPersonList.AddPerson(_firstPersonList.IndexPerson(index));
                            _secondPersonList.PrintPeople();
                            Console.WriteLine("\nНажмите Enter для выхода из пункта 3");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("\n3ab. Вывод содержимого списков:\n");
                            _firstPersonList.PrintPeople();
                            Console.WriteLine("Для просмотра удаления второго человека из первого списка нажмите Enter");
                            _ = Console.ReadKey();
                            Console.WriteLine("\nУдаление второго человека из первого списка\n");
                            int indexToDelete = 1;
                            _firstPersonList.DeleteIndexPerson(indexToDelete);
                            _firstPersonList.PrintPeople();
                            Console.WriteLine("\nНажмите Enter для выхода из пункта 4");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("\n3ab. Вывод содержимого списков:\n");
                            _secondPersonList.PrintPeople();
                            Console.WriteLine("Для просмотра очистки второго списка нажмите Enter");
                            _ = Console.ReadKey();
                            Console.WriteLine("\nОчистка второго списка\n");
                            _secondPersonList.DeleteArrayPerson();
                            Console.WriteLine("\nСодержимое второго списка");
                            Console.WriteLine("\nСодержимое успешно удалено");
                            _secondPersonList.PrintPeople();
                            Console.WriteLine("\nНажмите Enter для выхода из пункта 5");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("\nДля тестирования метода ввода персоны с клавиатуры нажмите Enter");
                            _ = Console.ReadKey();

                            Console.WriteLine("Введите количество персон для создания:");
                            int count = int.Parse(Console.ReadLine());

                            PersonList personList = new PersonList();

                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine($"\nСоздаем персону {i + 1}");

                                _ = AddPersonConsole.PersonConsole(personList);
                            }

                            Console.WriteLine("\nНажмите Enter для выхода из пункта 6");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                    case "7":
                        {
                            Console.WriteLine();
                            Console.WriteLine("Для тестирования метода RandomPerson нажмите Enter");
                            _ = Console.ReadKey();
                            Console.WriteLine();
                            Person randomPerson = RandomPerson.GetRandomPerson();
                            Console.WriteLine("\nСлучайная персона:");
                            randomPerson.PrintPerson();
                            Console.WriteLine("\nНажмите Enter для выхода из пункта 7");
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

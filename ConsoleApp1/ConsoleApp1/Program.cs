using ClassLibrary1;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                    "1 - Создание программно двух списков персон в каждом из которых по три человека+вывести содержимое на экран\n" +
                    "2 - Добавить нового челока в первый список\n" +
                    "3  -Копирование второго человека из первого списка в конец второго списка\n" +
                    "4 - Удаление второго человека из первого списка\n" +
                    "5 - Очистить список полностью\n" +
                    "6 - Ввести персону вручную\n" +
                    "7 - RandomPerson\n" +
                    "0 - Выход");
                number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        {
                            ProcessOption1();
                            break;
                        }
                    case "2":
                        {
                            ProcessOption2();
                            break;
                        }
                    case "3":
                        {
                            ProcessOption3();
                            break;
                        }
                    case "4":
                        {
                            ProcessOption4();
                            break;
                        }
                    case "5":
                        {
                            ProcessOption5();
                            break;
                        }
                    case "6":
                        {
                            ProcessOption6();
                            break;
                        }
                    case "7":
                        {
                            ProcessOption7();
                            break;
                        }
                    case "0":
                        return;

                    default:
                        Console.WriteLine("Некорректный выбор. Пожалуйста, выберите пункт из меню.");
                        break;
                }
            }

            static void ProcessOption1()
            {
                Console.WriteLine("Для тестирования методов программно создано два списка людей.\n" +
                    "В каждом из списков содержатся записи о трех людях.\n" +
                    "Для отображения нажмите Enter");
                _ = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("3ab. Вывод содержимого списков:");
                Console.WriteLine();
                _firstPersonList[0] = new Person("Иван", "Иванов", 25, Gender.Male);
                _firstPersonList[1] = new Person("Анна", "Анновна", 30, Gender.Female);
                _firstPersonList[2] = new Person("Император", "Великий", 100, Gender.Male);
                _firstPersonList.PrintPeople();
                Console.WriteLine();
                _secondPersonList[0] = new Person("Сидоров", "Сидор", 45, Gender.Male);
                _secondPersonList[1] = new Person("Анастасия", "Подкорытова", 25, Gender.Female);
                _secondPersonList[2] = new Person("Валерия", "Ващенко", 30, Gender.Female);
                _secondPersonList.PrintPeople();
                _ = Console.ReadKey();
                Console.Clear();
            }

            static void ProcessOption2()
            {
                Console.WriteLine("Для просмотра добавления новой персоны нажмите Enter");
                _ = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Добавление новой персоны в список 1");
                Console.WriteLine();
                _firstPersonList.AddPerson(new Person("Новый", "Человек", 40, Gender.Male));
                _firstPersonList.PrintPeople();
                _ = Console.ReadKey();
                Console.Clear();
            }

            static void ProcessOption3()
            {
                Console.WriteLine("Для просмотра копирования второго человека первого списка в конец второго списка нажмите Enter");
                _ = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Копирование второго человека из первого списка в конец второго списка");
                Console.WriteLine();
                int index = 1;
                _secondPersonList.AddPerson(_firstPersonList.IndexPerson(index));
                _secondPersonList.PrintPeople();
                _ = Console.ReadKey();
                Console.Clear();
            }

            static void ProcessOption4()
            {
                Console.WriteLine("Для просмотра удаления второго человека из первого списка нажмите Enter");
                _ = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Удаление второго человека из первого списка");
                Console.WriteLine();
                int indexToDelete = 1;
                _firstPersonList.DeleteIndexPerson(indexToDelete);
                _firstPersonList.PrintPeople();
                _ = Console.ReadKey();
                Console.Clear();
            }

            static void ProcessOption5()
            {
                Console.WriteLine("Для просмотра очистки второго списка нажмите Enter");
                _ = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Очистка второго списка");
                Console.WriteLine();
                _secondPersonList.DeleteArrayPerson();
                Console.WriteLine("Содержимое второго списка");
                _secondPersonList.PrintPeople();
                _ = Console.ReadKey();
                Console.Clear();
            }
            static void ProcessOption6()
            {
                Console.WriteLine();
                Console.WriteLine("Для тестирования метода ввода персоны с клавиатуры нажмите Enter");
                _ = Console.ReadKey();
                Console.WriteLine();
                Person newPerson = Person.AddPersonConsole();
                Console.WriteLine($"Создан новый объект Person:");
                newPerson.PrintPerson();
                _ = Console.ReadKey();
                Console.Clear();
            }
            static void ProcessOption7()
            {
                Console.WriteLine();
                Console.WriteLine("Для тестирования метода RandomPerson нажмите Enter");
                _ = Console.ReadKey();
                Console.WriteLine();
                Person randomPerson = Person.GetRandomPerson();
                Person randomPerson1 = Person.GetRandomPerson();
                Console.WriteLine("Случайная персона:");
                randomPerson.PrintPerson();
                randomPerson1.PrintPerson();
                _ = Console.ReadKey();
                Console.Clear();
            }

        }
    }
}

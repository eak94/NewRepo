using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        /// <summary>
        /// Основная программа
        /// </summary>
        private static void Main()
        {
            //3a
            Console.WriteLine("Для тестирования методов программно создано два списка людей.\n" +
                "В каждом из списков содержатся записи о трех людях.\n" +
                "Для отображения нажмите Enter");
            _ = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("3ab. Вывод содержимого списков:");
            Console.WriteLine();
            PersonList firstPersonList = new PersonList("1 массиве");
            firstPersonList[0] = new Person("Иван", "Иванов", 25, Gender.Male);
            firstPersonList[1] = new Person("Анна", "Анновна", 30, Gender.Female);
            firstPersonList[2] = new Person("Император", "Великий", 100, Gender.Male);
            firstPersonList.PrintPeople();
            Console.WriteLine();
            PersonList secondPersonList = new PersonList("2 массиве");
            secondPersonList[0] = new Person("Сидоров", "Сидор", 45, Gender.Male);
            secondPersonList[1] = new Person("Анастасия", "Подкорытова", 25, Gender.Female);
            secondPersonList[2] = new Person("Валерия", "Ващенко", 30, Gender.Female);
            secondPersonList.PrintPeople();
            _ = Console.ReadKey();

            //3c
            Console.WriteLine();
            Console.WriteLine("Для просмотра добавления новой персоны нажмите Enter");
            _ = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("3с. Добавление новой персоны в список 1");
            Console.WriteLine();
            firstPersonList.AddPerson(new Person("Новый", "Человек", 40, Gender.Male));
            firstPersonList.PrintPeople();
            _ = Console.ReadKey();

            //3d
            Console.WriteLine();
            Console.WriteLine("Для просмотра копирования второго человека первого списка в конец второго списка нажмите Enter");
            _ = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("3d. Копирование второго человека из первого списка в конец второго списка");
            Console.WriteLine();
            int index = 1;
            secondPersonList.AddPerson(firstPersonList.IndexPerson(index));
            secondPersonList.PrintPeople();
            _ = Console.ReadKey();

            //3e
            Console.WriteLine();
            Console.WriteLine("Для просмотра удаления второго человека из первого списка нажмите Enter");
            _ = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("3e. Удаление второго человека из первого списка");
            Console.WriteLine();
            int indexToDelete = 1;
            firstPersonList.DeleteIndexPerson(indexToDelete);
            firstPersonList.PrintPeople();
            _ = Console.ReadKey();

            //3f
            Console.WriteLine();
            Console.WriteLine("Для просмотра очистки второго списка нажмите Enter");
            _ = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("3f. Очистка второго списка");
            Console.WriteLine();
            secondPersonList.DeleteArrayPerson();
            Console.WriteLine("Содержимое второго списка");
            secondPersonList.PrintPeople();
            _ = Console.ReadKey();

            //4
            Console.WriteLine();
            Console.WriteLine("Для тестирования метода ввода персоны с клавиатуры нажмите Enter");
            _ = Console.ReadKey();
            Console.WriteLine();
            Person newPerson = Person.AddPersonConsole();
            Console.WriteLine($"Создан новый объект Person:");
            newPerson.PrintPerson();
            _ = Console.ReadKey();

            //5
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
        }
    }
}

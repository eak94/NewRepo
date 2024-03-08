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
            Console.WriteLine("Для тестирования методов создано два списка людей.\n" +
                "В каждом из списков содержатся записи о трех людях.\n" +
                "Для продолжения нажмите Enter для отображения");
            _ = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("3ab. Вывод содержимого списков:");
            Console.WriteLine();
            PersonList firstPersonList = new PersonList("1 массив");
            firstPersonList[0] = new Person("Иван", "Иванов", 25, Gender.Male);
            firstPersonList[1] = new Person("Анна", "Анновна", 30, Gender.Female);
            firstPersonList[2] = new Person("Император", "Великий", 100, Gender.Undefined);
            firstPersonList.PrintPeople();
            Console.WriteLine();
            PersonList secondPersonList = new PersonList("2 массив");
            secondPersonList[0] = new Person("Сидоров", "Сидор", 45, Gender.Male);
            secondPersonList[1] = new Person("Анастасия", "Подкорытова", 25, Gender.Female);
            secondPersonList[2] = new Person("Валерия", "Ващенко", 30, Gender.Female);
            secondPersonList.PrintPeople();
            _ = Console.ReadKey();

            //3b
            Console.WriteLine();
            Console.WriteLine("3с. Добавление новой персоны в список 1");
            Console.WriteLine();
            firstPersonList.AddPerson(new Person("Новый", "Человек", 40, Gender.Male));
            firstPersonList.PrintPeople();
            _ = Console.ReadKey();

            //3с
            Console.WriteLine();
            Console.WriteLine("3d. Копирование второго человека из первого списка в конец второго списка");
            Console.WriteLine();
            int index = 1;
            secondPersonList.AddPerson(firstPersonList.IndexPerson(index));
            secondPersonList.PrintPeople();
            _ = Console.ReadKey();

            //3d
            Console.WriteLine();
            Console.WriteLine("3e. Удаление второго человека из первого списка");
            Console.WriteLine();
            int indexToDelete = 1;
            firstPersonList.DeleteIndexPerson(indexToDelete);
            firstPersonList.PrintPeople();
            _ = Console.ReadKey();

            //3d
            Console.WriteLine();
            Console.WriteLine("3f. Очистка второго списка");
            Console.WriteLine();
            secondPersonList.DeleteArrayPerson();
            Console.WriteLine("Содержимое второго списка");
            secondPersonList.PrintPeople();
            _ = Console.ReadKey();
        }
    }
}

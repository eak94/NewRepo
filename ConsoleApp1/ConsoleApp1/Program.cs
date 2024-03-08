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
            Console.WriteLine("Для тестирования методов автоматически создано два списка людей.\n" +
                "В каждом из списков содержатся записи о трех людях.\n" +
                "Для продолжения нажмите Enter для отображения");
            _ = Console.ReadKey();
            Console.WriteLine("\nСодержание списков:");
            PersonList firstPersonList = new PersonList("1 массиве");
            Console.WriteLine();
            firstPersonList.AddPerson(new Person("Иван", "Иванов", 25, Gender.Male));
            firstPersonList.AddPerson(new Person("Анна", "Анновна", 30, Gender.Female));
            firstPersonList.AddPerson(new Person("Император", "Великий", 100, Gender.Undefined));
            firstPersonList.PrintPeople();
            PersonList secondPersonList = new PersonList("2 массиве");
            Console.WriteLine();
            secondPersonList.AddPerson(new Person("Петр", "Петров", 2, Gender.Male));
            secondPersonList.AddPerson(new Person("Иван", "Киселев", 45, Gender.Male));
            secondPersonList.AddPerson(new Person("Анастасия", "Левина", 56, Gender.Female));
            secondPersonList.PrintPeople();
            _ = Console.ReadKey();
        }
    }
}

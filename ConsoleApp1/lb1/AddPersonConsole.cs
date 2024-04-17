using LibraryPerson;

namespace Lb1
{
    /// <summary>
    /// 
    /// </summary>
    internal class AddPersonConsole
    {

        /// <summary>
        /// Метод для вывода введеного в консоль персона
        /// </summary>
        /// <param name="personList"></param>
        /// <returns></returns>
        public static Person PersonConsole(PersonList personList)
        {
            //TODO: RSDN
            string name = NameInput("Введите ваше Имя", "Имя не может быть пустым");
            string secondName = NameInput("Введите вашу Фамилию", "Фамилия не может быть пустой");

            int age = AgeInput("Введите ваш Возраст", "Возраст не может быть пустым и должен быть числом");

            Gender gender = GenderInput("Введите ваш Пол (М/Ж) или (M/F)");

            Person newPerson = new Person(name, secondName, age, gender);
            personList.AddPerson(newPerson);

            Console.WriteLine("\nНовый список/");
            personList.PrintPeople();

            return newPerson;
        }

        /// <summary>
        /// Метод для обработки поле имени и фамилии
        /// </summary>
        /// <param name="name">Имя или фамилия</param>
        /// <param name="errorMessage">Ошибка</param>
        /// <returns>Возвращает поле для ввода</returns>
        public static string NameInput(string name, string errorMessage)
        {
            string input;
            do
            {
                Console.WriteLine(name);
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine(errorMessage);
                }
                //if (Person.ExceptionsName(name))
                //{
                //    break;
                //}
            }
            while (string.IsNullOrWhiteSpace(input));

            return input;
        }

        /// <summary>
        /// Метод для обработки возраста
        /// </summary>
        /// <param name="age">Возраст</param>
        /// <returns>Возвращает поле для ввода</returns>
        public static int AgeInput(string age, string errorMessage)
        {
            int input;
            do
            {
                Console.WriteLine(age);
                if (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine(errorMessage);
                }
            }
            while (input == 0);

            return input;
        }

        /// <summary>
        /// Метод для обработки пола
        /// </summary>
        /// <param name="genderInput"> Пол</param>
        /// <returns>Возвращает поля для ввода</returns>
        public static Gender GenderInput(string genderInput)
        {
            while (true)
            {
                Console.WriteLine(genderInput);
                string insertedGender = Console.ReadLine().ToUpper();
                switch (insertedGender)
                {
                    case "M":
                    case "М":
                        return Gender.Male;
                    case "F":
                    case "Ж":
                        return Gender.Female;
                    default:
                        Console.WriteLine("Неправильно указан пол");
                        break;
                }
            }
        }

    }
}


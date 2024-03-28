using ClassLibrary1;

namespace ConsoleApp1
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
            string name = RequestInput("Введите ваше Имя", "Имя не может быть пустым.");
            string secondName = RequestInput("Введите вашу Фамилию", "Фамилия не может быть пустой.");

            int age = RequestIntegerInput("Введите ваш Возраст", "Возраст не может быть пустым и должен быть числом");

            Gender gender = RequestGenderInput("Введите ваш Пол (М/Ж) или (M/F)");

            Person newPerson = new Person(name, secondName, age, gender);
            personList.AddPerson(newPerson);

            personList.PrintPeople();

            return newPerson;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static string RequestInput(string name, string errorMessage)
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
            }
            while (string.IsNullOrWhiteSpace(input));
            return input;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public static int RequestIntegerInput(string prompt, string errorMessage)
        {
            int input;
            do
            {
                Console.WriteLine(prompt);
                if (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine(errorMessage);
                }
            }
            while (input == 0);
            return input;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="genderPrompt"></param>
        /// <returns></returns>
        public static Gender RequestGenderInput(string genderInput)
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


using ClassLibrary1;

namespace ConsoleApp1
{
    /// <summary>
    /// 
    /// </summary>
    internal class AddPersonConsole
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Person PersonConsole(PersonList personList)
        {
            string name = RequestInput("Введите ваше Имя", "Имя не может быть пустым.");
            string secondName = RequestInput("Введите вашу Фамилию", "Фамилия не может быть пустой.");

            int age = RequestIntegerInput("Введите ваш Возраст.");

            Gender gender = RequestGenderInput("Введите ваш Пол (М/Ж)");

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
        private static string RequestInput(string name, string errorMessage)
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
        private static int RequestIntegerInput(string age)
        {
            int input;
            do
            {
                Console.WriteLine(age);
            }
            while (!int.TryParse(Console.ReadLine(), out input));
            return input;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gender"></param>
        /// <returns></returns>
        private static Gender RequestGenderInput(string genderPeople)
        {
            Gender gender;
            do
            {
                Console.WriteLine(genderPeople);
            }
            while (!Enum.TryParse(Console.ReadLine(), out gender) || gender != Gender.Male && gender != Gender.Female);
            return gender;
        }
    }
}


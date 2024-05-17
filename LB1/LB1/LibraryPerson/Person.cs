using System.Text.RegularExpressions;
namespace LibraryPerson
{
    /// <summary>
    /// Класс персон
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        private string _secondName;

        /// <summary>
        /// Возраст пользователя
        /// </summary>
        private int _age;

        /// <summary>
        /// Минимальный возраст
        /// </summary>
        public const int MinAge = 0;

        /// <summary>
        /// Максимальный возраст
        /// </summary>
        public const int MaxAge = 100;

        /// <summary>
        /// Свойства класса имя
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                string validatedName = ExceptionsName(value);
                _name = validatedName;
            }
        }

        /// <summary>
        /// Свойства класса Фамилия
        /// </summary>
        public string SecondName
        {
            get
            {
                return _secondName;
            }
            set
            {
                string validatedName = ExceptionsName(value);
                _secondName = validatedName;
            }
        }

        /// <summary>
        /// Проверка символов, вводимых в поле Имя
        /// </summary>
        /// <param name="value">введенное Имя</param>
        /// <returns>Возвращает строку с Именем или Фамилией с заглавной буквы</returns>
        public static string ExceptionsName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Ничего не введено. Пожалуйста, введите Имя");
            }

            string nameSecondnamePattern = "^[а-яА-Яa-zA-Z]+-?[а-яА-Яa-zA-Z]*$";

            Regex regex = new Regex(nameSecondnamePattern);

            if (!regex.IsMatch(value))
            {
                throw new ArgumentException("Введены недопустимые символы. " +
                    "Пожалуйста, используйте только буквы русского и английского алфавитов");
            }
            string validatedValue = string.Empty;

            foreach (Match match in regex.Matches(value))
            {
                validatedValue += match.Value;
            }

            string[] words = validatedValue.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 1)
                {
                    words[i] = words[i].Substring(0, 1).ToUpper() +
                               words[i].Substring(1).ToLower();
                }
            }
            validatedValue = string.Join(" ", words);
            return validatedValue;
        }


        /// <summary>
        /// Свойства класса Возраст
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                int validatedAge = ExceptionsAge(value);
                _age = validatedAge;
            }
        }

        //TODO: rename
        /// <summary>
        /// Метод для обработки возвраста
        /// </summary>
        /// <param name="age">Возраст</param>
        /// <returns>Возвращает поле для возраста</returns>
        /// <exception cref="ArgumentException"></exception>
        public int ExceptionsAge(int age)
        {
            if (age < MinAge)
            {
                throw new ArgumentException($"Возраст не может быть отрицательным\n");
            }

            if (age > MaxAge)
            {
                throw new ArgumentException($"Возраст не может быть больше {MaxAge}\n");
            }

            return age;
        }

        /// <summary>
        /// Свойства класса Пол
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Конструктор класса Person
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="secondName">Фамилия</param>
        /// <param name="age">Возраст</param>
        /// <param name="gender">Пол</param>
        public Person(string name, string secondName, int age, Gender gender)
        {
            Name = name;
            SecondName = secondName;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Возвращает строковое представление информации о человеке
        /// </summary>
        /// <returns>Строковое представление информации о человеке</returns>
        public string GetInfo()
        {
            return ($"Имя: {Name}, Фамилия: {SecondName}, Возраст: {Age}, Пол: {Gender}\n");
        }

        /// <summary>
        /// Экземляр класса по умолчанию
        /// </summary>
        public Person() : this("Иван", "Иванов", 50, Gender.Male)
        { }
    }
}

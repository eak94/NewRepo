using System.Text.RegularExpressions;

namespace ClassLibrary1
{
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
        private const int _minAge = 0;
        /// <summary>
        /// Максимальный возраст
        /// </summary>
        private const int _maxAge = 100;

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
                bool isValid = false;
                while (!isValid)
                {
                    try
                    {
                        _name = ExceptionsName(value, "Имя должно содержать только русские или английские буквы\n");
                        isValid = true;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"{ex.Message}Пожалуйста, введите имя заново:");
                        value = Console.ReadLine();
                    }
                }
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
                bool isValid = false;
                while (!isValid)
                {
                    try
                    {
                        _secondName = ExceptionsName(value, "Фамилия должна содержать только русские или английские буквы\n");
                        isValid = true;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"{ex.Message}Пожалуйста, введите фамилии заново:");
                        value = Console.ReadLine();
                    }
                }
            }
        }
        /// <summary>
        /// Проверка символов, вводимых в поле Имя и Фамилия
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Возвращает обратную строку</returns>
        private static string ExceptionsName(string value, string errorMessage)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Имеются незаполненные поля\n");
            }

            string nameSecondnamePattern = "^[а-яА-Яa-zA-Z]+-?[а-яА-Яa-zA-Z]*$";

            Regex regex = new Regex(nameSecondnamePattern);
            string validatedValue = string.Empty;

            foreach (Match match in regex.Matches(value))
            {
                validatedValue += match.Value;
            }

            if (string.IsNullOrEmpty(validatedValue))
            {
                throw new ArgumentException(errorMessage);
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
                while (true)
                {
                    try
                    {
                        _ = ExceptionsAge(value);
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"{ex.Message} Пожалуйста, введите возраст заново:");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
        }

        private int ExceptionsAge(int age)
        {
            if ( < _minAge)
            {
                throw new ArgumentException($"Возраст не может быть отрицательным\n");
            }

            if (value > _maxAge)
            {
                throw new ArgumentException($"Возраст не может быть больше {_maxAge}\n");
            }

            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Имеются незаполненные поля\n");
            }
            return value;
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
        /// Вывод данных в консоль
        /// </summary>
        public void PrintPerson()
        {
            Console.WriteLine($"Имя: {Name}" + $" Фамилия: {SecondName}" + $" Возраст: {Age}" + $" Пол: {Gender}");
        }

        /// <summary>
        /// Метод для ввода и чтения персоны с клавиатуры и вывода персоны на экран 
        /// </summary>
        public static Person AddPersonConsole()
        {
            Console.WriteLine("Новые данные");
            Console.WriteLine("Введите ваше Имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите вашу Фамилия");
            string secondName = Console.ReadLine();
            Console.WriteLine("Введите ваш Возраст");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш Пол (М/Ж)");
            Gender gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());
            Person newPerson = new Person(name, secondName, age, gender);
            return newPerson;
        }

        /// <summary>
        /// Экземляр класса по умолчанию
        /// </summary>
        public Person() : this("Иван", "Иванов", 50, Gender.Male)
        { }
    }
}

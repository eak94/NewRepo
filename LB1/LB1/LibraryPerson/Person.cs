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
                _name = ConvertRegistr(value);

                if (_secondName != null)
                {
                    CheckLanguage(_name, _secondName);
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
                _secondName = ConvertRegistr(value);

                if (_name != null)
                {
                    CheckLanguage(_name, _secondName);
                }
            }
        }


        /// <summary>
        /// Метод для преобразования верхнего регистра Имени или Фамилии персоны 
        /// </summary>
        /// <param name="value"> Имя или Фамилия персоны </param>
        /// <returns> Возвращается преобразованное в верхний регистр Имя или Фамилия персоны </returns>
        public string ConvertRegistr(string value)
        {
            if (value == null || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"Поле не может быть пустым." +
                    $" Введите, пожалуйста, еще раз");
            }

            value = value[0].ToString().ToUpper() + value.Substring(1);

            Regex regexNameOrSecondName = new Regex(@"^[a-zA-Zа-яА-Я]+(?:-[a-zA-Zа-яА-Я]+)?$");

            if (regexNameOrSecondName.IsMatch(value))
            {
                string[] words = value.Split(new char[] { '-' });
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i][0].ToString().ToUpper() + words[i].Substring(1);
                }
                value = string.Join("-", words);
            }

            return value;
        }

        /// <summary>
        /// Метод для сравнения языка имени и фамилии
        /// </summary>
        /// <param name="name"> Имя </param>
        /// <param name="secondName"> Фамилия </param>
        private void CheckLanguage(string name, string secondName)
        {
            Language nameLanguage = DefineLanguage(name);
            Language secondNameLanguage = DefineLanguage(secondName);

            if (nameLanguage != Language.Unknown && secondNameLanguage != Language.Unknown)
            {
                if (nameLanguage != secondNameLanguage)
                {
                    throw new ArgumentException("Имя и фамилия должны быть на одном языке." +
                        " Пожалуйста, введите данные заново.");
                }
            }
        }

        /// <summary>
        /// Метод для проверки языка  
        /// </summary>
        /// <param name="word">Слво(Имя или Фамилия)</param>
        /// <returns>Вовзращается язык</returns>
        private Language DefineLanguage(string word)
        {
            if (!Regex.IsMatch(word, @"^[a-zA-Zа-яА-Я]+(?:-[a-zA-Zа-яА-Я]+)?$"))
            {
                throw new ArgumentException("Поле должно содержать символы только" +
                    " русского или только английского алфавита, возможно с дефисом." +
                    "Введите, пожалуйста, еще раз");
            }

            if (Regex.IsMatch(word, @"^[a-zA-Z]+(-[a-zA-Z]+)?$"))
            {
                return Language.English;
            }
            else if (Regex.IsMatch(word, @"^[а-яА-Я]+(-[а-яА-Я]+)?$"))
            {
                return Language.Russian;
            }

            return Language.Unknown;
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
                _age = CheckAge(value);
            }
        }

        //TODO: rename+
        /// <summary>
        /// Метод для обработки возвраста
        /// </summary>
        /// <param name="age"> Возраст </param>
        /// <returns> Возвращает поле для возраста </returns>
        public int CheckAge(int age)
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
        /// <returns> Строковое представление информации о человеке </returns>
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

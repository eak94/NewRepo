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
        /// Пол пользователя
        /// </summary>
        private Gender _gender;

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
                _name = value;
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
                _secondName = value;
            }
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
                _age = value;
            }
        }
        /// <summary>
        /// Свойства класса Пол
        /// </summary>
        public Gender Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }

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
        /// По установлен по умолчанию
        /// </summary>
        public Person() : this("Иван", "Иванов", 50, Gender.Male)
        { }

        /// <summary>
        /// Метод для генерации случайных персон
        /// </summary>
        /// <returns>Возвращает персону, которая сгенерирована случайным образом</returns>
        public static Person GetRandomPerson()
        {
            Person randomPerson = new Person();
            var nameFemale = new string[] {"Катя", "Алина", "Анна", "Екатерина",
        "Алиса", "Наталья", "Валентина"};
            var nameMale = new string[] {"Антон", "Виктор", "Андрей", "Михаил",
        "Борис", "Роман", "Петр"};
            var secondnameMale = new string[] {"Стенов", "Любимов", "Стулов", "Попов",
        "Андреев", "Иванов", "Пушкин"};
            var secondnameFemale = new string[] {"Любимова", "Ващенко", "Подкорытова", "Мешанкина",
        "Сечина", "Ручкина", "Спицина"};

            Random rnd = new Random();

            randomPerson.Gender = (Gender)rnd.Next(2);

            if (randomPerson.Gender == Gender.Female)
            {
                var rndPersonNameFemale = rnd.Next(0, nameFemale.Length);
                var rndPersonSecondnameFemale = rnd.Next(0, secondnameFemale.Length);
                randomPerson.Name = nameFemale[rndPersonNameFemale];
                randomPerson.SecondName = secondnameFemale[rndPersonSecondnameFemale];
            }
            else
            {
                var rndPersonNameMale = rnd.Next(0, nameMale.Length);
                var rndPersonSecondnameMale = rnd.Next(0, secondnameMale.Length);
                randomPerson.Name = nameMale[rndPersonNameMale];
                randomPerson.SecondName = secondnameMale[rndPersonSecondnameMale];
            }

            randomPerson.Age = rnd.Next(0, 150);

            return randomPerson;
        }
    }
}

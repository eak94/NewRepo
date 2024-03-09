
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
            Console.WriteLine("Введите данные");
            Console.WriteLine("Имя");
            string name = Console.ReadLine();
            Console.WriteLine("Фамилия");
            string secondName = Console.ReadLine();
            Console.WriteLine("Возраст");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Пол");
            Gender gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());
            Person newPerson = new Person(name, secondName, age, gender);
            return newPerson;
        }

        /// <summary>
        /// Метод для рандомного создания персон 
        /// </summary>
        public static GetRandomPerson()
        {

        }
    }
}

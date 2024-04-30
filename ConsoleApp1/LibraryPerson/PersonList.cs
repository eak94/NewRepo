
namespace LibraryPerson
{
    /// <summary>
    /// Класс описывает абстракцию списка
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Объект класса Person
        /// </summary>
        private List<Person> _people = new List<Person>();

        /// <summary>
        /// Метод для добавления новых элементов в список
        /// </summary>
        /// <param name="person">объект класса персон</param>
        public void AddPerson(Person person)
        {
            _people.Add(person);
        }

        /// <summary>
        /// Метод для удаления элемента по введенному индексу 
        /// </summary>
        /// <param name="index">Индекс персоны, которую надо удалить</param>
        public void DeleteIndexPerson(int index)
        {
            _people.RemoveAt(index);
        }

        /// <summary>
        /// Метод для поиска персоны по указанному индексу
        /// </summary>
        /// <param name="index">Индекс персоны</param>
        public Person IndexPerson(int index)
        {
            if (index >= 0 && index < _people.Count)
            {
                return _people[index];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Метод для поиска элемента при его наличии в списке
        /// </summary>
        /// <param name="index">объект класса персон</param>
        public Person FindIndexPerson(Person person)
        {
            if (_people.Contains(person))
            {
                return person;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Метод очищает весь список, начиная с 0
        /// </summary>
        public void DeleteArrayPerson()
        {
            _people.Clear();
        }

        /// <summary>
        /// Метод для определения количества персон в списке 
        /// </summary>
        /// <returns>Возвращает количество персон в списке</returns>
        public int CountPerson()
        {
            return _people.Count;
        }

        /// <summary>
        /// Метод для вывода информации об объектах класса
        /// </summary>
        public string GetPersonsList()
        {
            string list = "";
            foreach (Person person in _people)
            {
                list += person.GetPersonInfo();
            }
            return list;
        }
    }
}

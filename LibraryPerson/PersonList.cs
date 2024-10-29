namespace LibraryPerson
{
    /// <summary>
    /// Класс лист персон
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Список персон
        /// </summary>
        private List<Person> _people = new List<Person>();

        /// <summary>
        /// Метод для добавления новых элементов в список 
        /// </summary>
        /// <param name="person">Объект класса персон</param>
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
        /// <returns>Возврашается персона по указанному индексу</returns>
        public Person IndexPerson(int index)
        {
            if ((_people.Count - 1) >= index && index >= 0)
            {
                return _people[index];
            }
            else
            {
                throw new IndexOutOfRangeException($"Персоны" +
                    $"с индексом {index} в списке нет");
            }

        }

        /// <summary>
        /// Метод для поиска индекса персоны
        /// по фамилии и имени при ее наличии в списке
        /// </summary>
        /// <param name="person">Персона для поиска</param>
        /// <returns>Возвращается индекс объекта
        /// класса персоны по его фамилии и имени</returns>
        public int FindIndexPerson(string secondName, string name)
        {
            int index = _people.FindIndex(s => s.SecondName == secondName && s.Name == name);

            if (index != -1)
            {
                return index;
            }
            else
            {
                throw new IndexOutOfRangeException($"Персоны с Фамилией {secondName} и" +
                    $" Именем {name} в списке нет");
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
        /// <returns>Возвращает количество
        /// объектов класса персон в списке</returns>
        public int CountPerson()
        {
            return _people.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetPersonsList()
        {
            string list = string.Join("", _people.Select(person => person.GetInfo()));
            return list;
        }
    }
}

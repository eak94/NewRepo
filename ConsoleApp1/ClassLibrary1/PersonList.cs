using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// Класс описывает абстракцию списка
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Массив, содержащий объекты класса
        /// </summary>
        private Person[] _people = new Person[0];

        /// <summary>
        /// Метод для добавления элементов
        /// </summary>
        /// <param name="person">Данные о персоне</param>
        public void AddPerson(Person person)
        {
            Array.Resize(ref _people, _people.Length + 1);
            int element = 0;
            for (int i = 0; i < _people.Length; i++)
            {
                if (_people[i] == null)
                {
                    element = i;
                    break;
                }
            }
            for (int i = element; i < element + 1; i++)
            {
                _people[i] = person;
            }
        }

        /// <summary>
        /// Метод для удаления всех элементов
        /// </summary>
        /// <param name="person"></param>
        public void DeleteArrayPerson()
        {
            Array.Clear(_people, 0, _people.Length);
        }
        /// <summary>
        /// Метод для удаления всех элементов по индексу
        /// </summary>
        /// <param name="index">Индекс</param>
        public void DeleteIndexPerson(int index)
        {
            _people[index] = null;
        }

    }
}

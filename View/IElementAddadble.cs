using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    /// <summary>
    /// Интерфейс добавления элементов
    /// </summary>
    public interface IElementAddadble
    {
        /// <summary>
        /// Добавляемый элемент
        /// </summary>
        ExerciseBase Element { get; }

        /// <summary>
        /// Метод провери введенных данных
        /// </summary>
        /// <returns>Возвращает true, если данные корректны,
        /// в противном случае возвращает false</returns>
        bool ValidateInput();
    }
}

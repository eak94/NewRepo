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

        bool ValidateInput();
    }
}

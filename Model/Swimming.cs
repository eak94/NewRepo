using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс реализующий вид управжения: плавание 
    /// </summary>
    public class Swimming : ExerciseBase
    {
        /// <summary>
        /// Поле стиль плавания
        /// </summary>
        private string style;

        /// <summary>
        /// Поле дистанция 
        /// </summary>
        private double distance;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Swimming()
        { }
    }
}

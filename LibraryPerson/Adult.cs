using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPerson
{
    /// <summary>
    /// Дочерний класс Adult
    /// </summary>
    public class Adult : PersonBase
    {
        /// <summary>
        /// Поле серии паспорта 
        /// </summary>
        private int _passportSeries;

        /// <summary>
        /// Поле номера паспорта 
        /// </summary>
        private int _passportNumber;

        /// <summary>
        /// Поле партнет
        /// </summary>
        private int _partner;

        /// <summary>
        /// Свойство для серии паспорта
        /// </summary>
        public int PassportSeries;
        {
            get
            {
                return _passportSeries;
            }
            set
            {
                _passportSeries = value;
            }
        }

        /// <summary>
        /// Свойство для номера паспорта
        /// </summary>
        public int PassportNumber;
        {
            get
            {
                return _passportNumber;
            }
            set
            {
            _passportNumber = value;
            }
        }

        public Adult Parther;
        {
            get
            {
                return _partner;
            }
            set
            {
                _partner = value;
            }
        }


    }
}

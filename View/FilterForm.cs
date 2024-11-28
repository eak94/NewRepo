using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Форма фильтрации
    /// </summary>
    public partial class FilterForm : Form
    {
        /// <summary>
        /// Исходный список результатов расчета каллорий
        /// </summary>
        private BindingList<ExerciseBase> _calloriesList;

        /// <summary>
        /// Отфильтрованный список результатов расчета каллорий
        /// </summary>
        private BindingList<ExerciseBase> _filteredСalloriesList;

        /// <summary>
        /// Событие на фильтрацию списка
        /// </summary>
        public EventHandler СalloriesFiltered;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="calloriesList">Исходных список 
        /// результатов расчета каллорий</param>
        public FilterForm(BindingList<ExerciseBase> calloriesList)
        {
            _calloriesList = calloriesList;
        
            InitializeComponent();
       
        }
    }
}

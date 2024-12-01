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
    /// Пользовательский элемент управления для 
    /// типа упражнения жим штанги
    /// </summary>
    public partial class AddWeightLiftingUserControl : UserControl, IElementAddadble
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public AddWeightLiftingUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавляемый элемент тип упражнения - жим штанги
        /// </summary>
        public ExerciseBase Element
        {
            get
            {
                return new WeightLifting()
                {
                    WorkingWeight = Convert.ToDouble(_numBoxWorkingWeight.Text),
                    Repetitions = (int)Convert.ToDouble(_numBoxRepetitions.Text),
                    MaxWeight = Convert.ToDouble(_numBoxMaxWeight.Text),
                };
            }
        }

        private void _labelMaxWeight_Click(object sender, EventArgs e)
        {

        }
    }
}

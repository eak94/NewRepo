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
    /// Пользовательский элемент управления типа упражнения бег
    /// </summary>
    public partial class AddRunningUserControl : UserControl, IElementAddadble
    {
        /// <summary>
        /// Конструктор класса 
        /// </summary>
        public AddRunningUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавляемый элемент тип упражнения - бег
        /// </summary>
        public ExerciseBase Element
        {
            get
            {
                return new Running()
                {
                    Intensity = Convert.ToDouble(_numBoxIntensity.Text),
                    Distance = Convert.ToDouble(_numBoxDistance.Text),
                };
            }
        }

    }
}

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
    public partial class AddRunningUserControl : UserControl
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
                    Intensity = Convert.ToDouble(
                            _textBoxDistance.Text),
                    Distance = Convert.ToDouble(
                           _textBoxIntensity.Text)
                };
            }
        }

        private void _textBoxMetRunning_TextChanged(object sender, EventArgs e)
        {

        }

        private void _textBoxDistance_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddRunningUserControl_Load(object sender, EventArgs e)
        {

        }

        private void AddRunningUserControl_Load_1(object sender, EventArgs e)
        {

        }
    }
}

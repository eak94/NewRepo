using Model;

namespace View
{
    /// <summary>
    /// Форма ввода данных
    /// </summary>
    public partial class DataForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private List<IElementAddadble> _elementAddableControls;

        /// <summary>
		/// Поле для обработки события добавления
		/// </summary>
		public EventHandler CalloriesAdded;

        /// <summary>
		/// Поле для обработки события отмена.
		/// </summary>
		public EventHandler CalloriesCancel;

        /// <summary>
		/// Поле для хранения последнего добавленного объекта
		/// </summary>
		private ExerciseBase _lastCallories;

        /// <summary>
        /// Словарь тип упражнения
        /// </summary>
        private static readonly Dictionary<string, ExerciseType> _typesExersice = new()
        {
            {"Бег", ExerciseType.Running},
            {"Плавание", ExerciseType.Swimming},
            {"Тяжелая атлетика", ExerciseType.WeightLifting},
        };

        /// <summary>
        /// Форма для добавления параметров расчета каллорий
        /// </summary>
        public DataForm()
        {
            InitializeComponent();

            _addRunningUserControl.Visible = false;

            _addSwimmingUserControl.Visible = false;

            _addWeightLiftingUserControl.Visible = false;

            FillComboBox(_typesExersice.Keys.ToArray(), _comboBoxExercise);

            _buttonDataAgree.Click += AgreeButtonClick;

            _comboBoxExercise.SelectedIndexChanged += ChangeExercise;

            _buttonDataCancel.Click += CancelButtonClick;

            _elementAddableControls = new List<IElementAddadble>()
            {
                _addRunningUserControl,
                _addSwimmingUserControl,
                _addWeightLiftingUserControl
            };
        }


        /// <summary>
        /// Заполнение comboBox массивом данных comboBox
        /// </summary>
        /// <param name="dataSource">Массив данных.</param>
        /// <param name="comboBox">ComboBox</param>
        private void FillComboBox<T>(T[] dataSource, ComboBox comboBox)
        {
            comboBox.DataSource = dataSource;
            comboBox.SelectedItem = null;
        }

        /// <summary>
        /// Метод отображает соответствующий элемент управления
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событии</param>
        public void ChangeExercise(object sender, EventArgs e)
        {
            _addRunningUserControl.Visible = 
                _comboBoxExercise.SelectedIndex == 0;
            _addSwimmingUserControl.Visible =
                _comboBoxExercise.SelectedIndex == 1;
            _addWeightLiftingUserControl.Visible = 
                _comboBoxExercise.SelectedIndex == 2;
        }

        /// <summary>
        /// Метод нажатия на кнопку "Рассчитать"
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событии</param>
        private void AgreeButtonClick(object sender, EventArgs e)
        {
            try
            {
                ExerciseBase exerciseElementBase = null;
                foreach (var userControl in _elementAddableControls)
                {
                    if (((UserControl)userControl).Visible)
                    {
                        exerciseElementBase = userControl.Element;
                        exerciseElementBase.Time = Convert.ToDouble(_numBoxTime.Text);
                        exerciseElementBase.WeightPerson = Convert.ToDouble(_numBoxWeightPerson.Text);
                    }
                }

                _lastCallories = exerciseElementBase;

                CalloriesAdded?.Invoke(this, new CalloriesAddedEventArgs(exerciseElementBase));
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}. Введите корректные данные.",
                    "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        /// <summary>
		/// Метод нажатия на кнопку "Отмена"
		/// </summary>
		/// <param name="sender">Событие</param>
		/// <param name="e">Данные о событие</param>
		private void CancelButtonClick(object sender, EventArgs e)
        {
            if (_lastCallories != null)
            {
                CalloriesCancel?.Invoke(this, new CalloriesAddedEventArgs(_lastCallories));
            }
        }
    }
}

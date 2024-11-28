using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private List<IElementAddedble> _elementAddableControls;

        /// <summary>
        /// Событие добавления движения.
        /// </summary>
        public EventHandler ElementAdded;

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
            {"Жим штанги", ExerciseType.WeightLifting},
        };

        /// <summary>
        /// Форма для добавления параметров расчета каллорий
        /// </summary>
        public DataForm()
        {
            InitializeComponent();

            FillComboBox(_typesExersice.Keys.ToArray(), _comboBoxExercise);

            _buttonDataAgree.Click += new EventHandler(AgreeButtonClick);

            _comboBoxExercise.SelectedIndexChanged += new EventHandler(AddGroupBoxData);

            _buttonDataCancel.Click += new EventHandler(CancelButtonClick);

            _textBoxTime.KeyPress += new KeyPressEventHandler(TextBoxKeyPress);

            _textBoxWeightPerson.KeyPress += new KeyPressEventHandler(TextBoxKeyPress);

            _elementAddableControls = new List<IElementAddedble>()
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
        /// Метод нажатия на кнопку "Ок"
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событии</param>
        private void AgreeButtonClick(object sender, EventArgs e)
        {
            try
            {
                ExerciseBase exerciseBase = null;

                foreach (var userControl in _elementAddableControls)
                {
  
                    if (userControl is UserControl control && control.Visible)
                    {
                        if (userControl is IElementAddedble elementControl)
                        {
                            exerciseBase = elementControl.Element;

                            if (exerciseBase == null)
                            {
                                MessageBox.Show("Некорректные данные для выбранного упражнения.",
                                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Выбранный элемент управления не поддерживает добавление данных.",
                                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                ElementAdded?.Invoke(this, new CalloriesAddedEventArgs(exerciseBase));

                MessageBox.Show($"Добавлены данные: {exerciseBase?.GetType().Name}",
                                "Данные добавлены", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}. Введите корректные данные.",
                                 "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Метод добавления пользовательского интерфейса на форму
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событии</param>
        private void AddGroupBoxData(object sender, EventArgs e)
        {
            ExerciseType typeExercise;
            if (!_typesExersice.TryGetValue(_comboBoxExercise.Text, out typeExercise))
            {
                MessageBox.Show("Выберите правильный тип упражнения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            _groupBoxParametrExercise.Controls.Clear();

            Control controlToAdd = null;
            IElementAddedble elementControl = null;

            switch (typeExercise)
            {
                case ExerciseType.Running:
                    controlToAdd = new AddRunningUserControl();
                    elementControl = (IElementAddedble)controlToAdd;
                    break;
                case ExerciseType.Swimming:
                    controlToAdd = new AddSwimmingUserControl();
                    elementControl = (IElementAddedble)controlToAdd;
                    break;
                case ExerciseType.WeightLifting:
                    controlToAdd = new AddWeightLiftingUserControl();
                    elementControl = (IElementAddedble)controlToAdd;
                    break;
                default:
                    MessageBox.Show("Тип упражнения не поддерживается.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            if (controlToAdd != null)
            {
                _groupBoxParametrExercise.SuspendLayout();

                controlToAdd.Visible = true;
                controlToAdd.Location = new Point(
                    (_groupBoxParametrExercise.Width - controlToAdd.Width) / 2,
                    (_groupBoxParametrExercise.Height - controlToAdd.Height) / 2
                );

                _groupBoxParametrExercise.Controls.Add(controlToAdd);

                _groupBoxParametrExercise.ResumeLayout();
                _groupBoxParametrExercise.Visible = true;
            }
            else
            {
                MessageBox.Show("Не удалось создать элемент управления для выбранного типа упражнения.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        /// <summary>
		/// Проверка данных вводимых в textBox
		/// </summary>
		/// <param name="sender">Событие</param>
		/// <param name="e">Данные о событии</param>
		private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && textBox.Text.Contains(","))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '0' &&
                string.IsNullOrEmpty(textBox.Text.Trim('0')))
            {
                e.Handled = true;
            }
        }
    }
}

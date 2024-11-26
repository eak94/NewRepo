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
		/// Поле для обработки события добавления
		/// </summary>
		public EventHandler CalloriesAdded;

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
        /// Словарь тип упражнения
        /// </summary>


        /// <summary>
        /// Форма для добавления параметров расчета каллорий
        /// </summary>
        public DataForm()
        {
            InitializeComponent();

            FillComboBox(_typesExersice.Keys.ToArray(), _comboBoxExercise);

            _buttonDataAgree.Click += new EventHandler(AgreeButtonClick);

            _comboBoxExercise.SelectedIndexChanged += new EventHandler(AddGroupBoxData);
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
            ExerciseType typeExercise =
                    _typesExersice[_comboBoxExercise.Text];
            ExerciseBase exercise = null;

            try
            {
                switch (typeExercise)
                {
                    case ExerciseType.Running:
                        {
                            exercise = new Running();
                            exercise.WeightPerson = Convert.ToDouble(_textBoxWeightPerson.Text);
                            exercise.Time = Convert.ToDouble(_textBoxWeightPerson.Text);
                            break;
                        }

                    case ExerciseType.Swimming:
                        {
                            exercise = new Swimming();
                            exercise.WeightPerson = Convert.ToDouble(_textBoxWeightPerson.Text);
                            exercise.Time = Convert.ToDouble(_textBoxWeightPerson.Text);
                            break;
                        }

                    case ExerciseType.WeightLifting:
                        {
                            exercise = new WeightLifting();
                            exercise.WeightPerson = Convert.ToDouble(_textBoxWeightPerson.Text);
                            exercise.Time = Convert.ToDouble(_textBoxWeightPerson.Text);
                            break;
                        }
                }

                CalloriesAdded?.Invoke(this,
                        new CalloriesAddedEventArgs(exercise));

                _lastCallories = exercise;
            }

            catch
            {
                MessageBox.Show("Введите данные.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Метод добавления GroupBox на форму
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событии</param>
        private void AddGroupBoxData(object sender, EventArgs e)
        {
            ExerciseType typeExercise = _typesExersice[_comboBoxExercise.Text];

            _groupBoxParametrExercise.Controls.Clear();

            Control controlToAdd = null;

            switch (typeExercise)
            {
                case ExerciseType.Running:
                    {
                        AddRunningUserControl runningControl = new AddRunningUserControl();
                        controlToAdd = runningControl;
                        break;
                    }
                case ExerciseType.Swimming:
                    {
                        AddSwimmingUserControl swimmingControl = new AddSwimmingUserControl();
                        controlToAdd = swimmingControl;
                        break;
                    }
                case ExerciseType.WeightLifting:
                    {
                        AddWeightLiftingUserControl weightLiftingControl = new AddWeightLiftingUserControl();
                        controlToAdd = weightLiftingControl;
                        break;
                    }
                default:
                    break;
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
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void _groupBoxDataExercise_Enter(object sender, EventArgs e)
        {

        }

        private void _buttonDataCancel_Click(object sender, EventArgs e)
        {

        }
    }
}

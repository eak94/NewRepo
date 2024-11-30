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

            _buttonAgree.Click += new EventHandler(AgreeButtonClick);

        }
        /// <summary>
        /// Метод нажатия на кнопку "Применить"
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событии</param>
        private void AgreeButtonClick(object sender, EventArgs e)
        {
            bool checkClick = _checkBoxWeightPerson.Checked
                || _checkBoxTime.Checked
                || _checkBoxWeightLifting.Checked
                || _checkBoxSwimming.Checked
                || _checkBoxRunning.Checked;

            if (checkClick)
            {
                _filteredСalloriesList = new BindingList<ExerciseBase>();

                if (_checkBoxWeightLifting.Checked)
                {
                    FilteredTypeExercise(_calloriesList,
                        _filteredСalloriesList,
                        typeof(WeightLifting));
                }

                if (_checkBoxSwimming.Checked)
                {
                    FilteredTypeExercise(_calloriesList,
                        _filteredСalloriesList,
                        typeof(Swimming));
                }

                if (_filteredСalloriesList.Count == 0
                    || _filteredСalloriesList is null)
                {
                    MessageBox.Show("Совпадений не найдено.", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                СalloriesFiltered.Invoke(this,
                new CalloriesFilterEventArgs(_filteredСalloriesList));
            }
            else
            {
                MessageBox.Show("Заполните критерии поиска.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="ExerciseBase"></typeparam>
        /// <param name="exerciseList"></param>
        /// <param name="filteredExerciseList"></param>
        /// <param name="typeExercise"></param>
        private static void FilteredTypeExercise<ExerciseBase>(
          BindingList<ExerciseBase> exerciseList,
           BindingList<ExerciseBase> filteredExerciseList,
           Type typeExercise)
        {
            foreach (var exercise in exerciseList)
            {
                if (typeExercise == exercise.GetType())
                {
                    filteredExerciseList.Add(exercise);
                }
            }
        }
    }
}

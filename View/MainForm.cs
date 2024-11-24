using Model;
using System.ComponentModel;

namespace View
{
    /// <summary>
    /// Главная форма расчета каллорий 
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Лист для заполнения таблицы
        /// результатами расчета каллорий
        /// </summary>
        private BindingList<ExerciseBase> _calloriesList =
            new BindingList<ExerciseBase>();

        /// <summary>
        /// Поле для хранения состояния формы DataForm 
        /// (форма добавления параметров для расчета)
        /// </summary>
        private bool _isDataFormOpen = false;

        /// <summary>
        /// Конструктор Главной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            FillingDataGridView(_calloriesList);

            _buttonAddCallories.Click += AddCalloriesButtonClick;

            DeactivateElements();
        }

        /// <summary>
        /// Метод заполнения таблицы результатов расчета 
        /// </summary>
        /// <param name="calloriesList"></param>
        private void FillingDataGridView(BindingList<ExerciseBase> calloriesList)
        {
            _dataControlCallories.DataSource = calloriesList;
        }

        /// <summary>
        /// Метод нажатия на кнопку "Добавить"
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событии</param>
        private void AddCalloriesButtonClick(object sender, EventArgs e)
        {
            if (!_isDataFormOpen)
            {
                _isDataFormOpen = true;
                DeactivateElements();
                DataForm DataForm = new DataForm();
                DataForm.FormClosed += (s, args) =>
                {
                    _isDataFormOpen = false;
                    DeactivateElements();
                };
                DataForm.CalloriesAdded += AddedCallories;
                DataForm.Show();
            }
        }

        /// <summary>
        /// Обработчик добавления данных в список calloriesList
        /// </summary>
        /// <param name="sender">объект, который вызвал событие</param>
        /// <param name="exerciseBase">аргументы события, которые содержат 
        /// данные, передаваемые при вызове события</param>
        private void AddedCallories(object sender, EventArgs exerciseBase)
        {
            CalloriesAddedEventArgs addedEventArgs =
                 exerciseBase as CalloriesAddedEventArgs;

            if (addedEventArgs?.ExerciseBase != null)
            {
                _calloriesList.Add(addedEventArgs.ExerciseBase);
            }
        }

        /// <summary>
        /// Обработчик для отмены добавления данных в список calloriesList
        /// </summary>
        /// <param name="sender">объект, который вызвал событие</param>
        /// <param name="exerciseBase">аргументы события, которые содержат 
        /// данные, передаваемые при вызове события</param>
        private void CancelCallories(object sender, EventArgs exerciseBase)
        {
            CalloriesAddedEventArgs addedEventArgs =
                exerciseBase as CalloriesAddedEventArgs;
            _calloriesList.Remove(addedEventArgs?.ExerciseBase);
        }

        /// <summary>
        /// Метод деактивации элементов 
        /// </summary>
        private void DeactivateElements()
        {
            _buttonAddCallories.Enabled = !_isDataFormOpen;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _groupBoxResultCalloties_Enter(object sender, EventArgs e)
        {

        }

        private void _buttonResetCallories_Click(object sender, EventArgs e)
        {

        }

        private void _buttonSaveCallories_Click(object sender, EventArgs e)
        {

        }

        private void _buttonOpenCallories_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewResultCalloties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAddCallories_Click(object sender, EventArgs e)
        {

        }
    }
}
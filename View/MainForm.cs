using Model;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Windows.Forms;

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
		/// Отфильтрованный лист для заполнения таблицы.
		/// </summary>
		private BindingList<ExerciseBase> _filteredСalloriesList;

        /// <summary>
        /// Поле для хранения состояния формы
        /// добавления параметров для расчета
        /// </summary>
        private bool _isDataFormOpen = false;

        /// <summary>
		///  Поле для хранения состояния формы для фильтрации
		/// </summary>
		private bool _isFillerFormOpen = false;

        /// <summary>
        /// Поле для хранения состояния фильтра
        /// </summary>
        private bool _isFiltr = false;

        /// <summary>
		/// Поле для сохранения и открытия файла.
		/// </summary>
		private readonly XmlSerializer _serializerXml =
            new XmlSerializer(typeof(BindingList<ExerciseBase>));

        /// <summary>
        /// Конструктор Главной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            FillingDataGridView(_calloriesList);

            _buttonAddCallories.Click += AddCalloriesButtonClick;

            _buttonFindCallories.Click += FilterCallotiesButtonClick;

            _buttonResetCallories.Click += ResetedFilter;

            _buttonDelete.Click += RemoveCalloriesButtonClick;

            _buttonOpenCallories.Click += OpenFile;

            _buttonSaveCallories.Click += SaveFile;

            DeactivateElements();
        }

        /// <summary>
        /// Метод заполнения таблицы результатов расчета 
        /// </summary>
        /// <param name="calloriesList"></param>
        private void FillingDataGridView(BindingList<ExerciseBase> calloriesList)
        {
            _dataControlCallories.DataSource = calloriesList;
            _dataControlCallories.AllowUserToResizeColumns = false;
            _dataControlCallories.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            _dataControlCallories.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            _dataControlCallories.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            _dataControlCallories.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
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
            _calloriesList.Add(addedEventArgs?.ExerciseBase);
        }

        /// <summary>
        /// Метод деактивации элементов 
        /// </summary>
        private void DeactivateElements()
        {
            _buttonAddCallories.Enabled = !_isDataFormOpen 
                && !_isFillerFormOpen && !_isFiltr;

            _buttonDelete.Enabled = !_isDataFormOpen
                && !_isFillerFormOpen && !_isFiltr;

            _buttonFindCallories.Enabled = !_isDataFormOpen &&
                !_isFillerFormOpen;

            _buttonSaveCallories.Enabled = !_isFiltr;

            _buttonOpenCallories.Enabled = !_isFiltr;
        }

        /// <summary>
        /// Метод нажатия на кнопку "Удалить"
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="e">данные о событии</param>
        private void RemoveCalloriesButtonClick(object sender, EventArgs e)
        {
            if (_dataControlCallories.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in
                    _dataControlCallories.SelectedRows)
                {
                    if (row.DataBoundItem is ExerciseBase callories)
                    {
                        _calloriesList.Remove(callories);
                        if (_filteredСalloriesList is not null
                            && _filteredСalloriesList.Count > 0)
                        {
                            _filteredСalloriesList.Remove(callories);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Метод нажатия на кнопку "Настроить фильтр"
        /// </summary>
        /// <param name="sender">Событие.</param>
        /// <param name="e">Данные о событие.</param>
        private void FilterCallotiesButtonClick(object sender, EventArgs e)
        {
            if (!_isFillerFormOpen)
            {
                _isFillerFormOpen = true;
                DeactivateElements();
                FilterForm findForm = new FilterForm(_calloriesList);
                findForm.FormClosed += (s, args) =>
                {
                    _isFillerFormOpen = false;
                    DeactivateElements();
                };
                findForm.СalloriesFiltered += FilteredСallories;
                findForm.Show();
            }
        }

        /// <summary>
		/// Обработчик фильтрации данных
		/// </summary>
		/// <param name="sender">Событие</param>
		/// <param name="calloriesList">Данные о событие</param>
		private void FilteredСallories(object sender, EventArgs calloriesList)
        {
            CalloriesFilterEventArgs filterEventArgs =
                calloriesList as CalloriesFilterEventArgs;

            _filteredСalloriesList = filterEventArgs?.FilteredCalloriesList;
            _isFiltr = true;
            DeactivateElements();
            FillingDataGridView(_filteredСalloriesList);
        }

        /// <summary>
		/// Метод нажатия на кнопку "Сбросить".
		/// </summary>
		/// <param name="sender">Событие.</param>
		/// <param name="e">Данные о событие.</param>
		private void ResetedFilter(object sender, EventArgs e)
        {
            FillingDataGridView(_calloriesList);
            _isFiltr = false;
            DeactivateElements();
        }

        /// <summary>
		/// Метод для открытия данных из файла
		/// </summary>
		/// <param name="sender">Событие</param>
		/// <param name="e">Данные о событие</param>
		private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Файлы (*.tran)|*.tran|Все файлы (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            string filePath = openFileDialog.FileName.ToString();

            try
            {
                using (var file = new StreamReader(filePath))
                {
                    _calloriesList = (BindingList<ExerciseBase>)
                        _serializerXml.Deserialize(file);
                }

                _dataControlCallories.DataSource = _calloriesList;
            }
            catch (Exception ex)
            {
                string errorMessage = $"Не удалось загрузить файл!\nОшибка: {ex.Message}";

                if (ex.InnerException != null)
                {
                    errorMessage += $"\nПодробности: {ex.InnerException.Message}";
                }

                MessageBox.Show(errorMessage, "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
		/// Метод для сохранения данных в файл
		/// </summary>
		/// <param name="sender">Событие</param>
		/// <param name="e">Данные о событие</param>
		private void SaveFile(object sender, EventArgs e)
        {
            if (!_calloriesList.Any() || _calloriesList is null)
            {
                MessageBox.Show("Список пуст!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Файлы (*tran.)|*.tran|Все файлы (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName.ToString();

                using (var file = File.Create(filePath))
                {
                    _serializerXml.Serialize(file, _calloriesList);
                }
            }
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

        private void _buttonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
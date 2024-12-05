using Model;
using System.ComponentModel;
using System.Xml.Serialization;


namespace View
{
    /// <summary>
    /// ������� ����� ������� �������� 
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// ���� ��� ���������� �������
        /// ������������ ������� ��������
        /// </summary>
        private BindingList<ExerciseBase> _calloriesList =
            new BindingList<ExerciseBase>();

        /// <summary>
		/// ��������������� ���� ��� ���������� �������.
		/// </summary>
		private BindingList<ExerciseBase> _filteredExerciseList;

        /// <summary>
		///  ���� ��� �������� ��������� ����� DataForm.
		/// </summary>
		private bool _isDataFormOpen = false;

        /// <summary>
        ///  ���� ��� �������� ��������� ����� FindForm.
        /// </summary>
        private bool _isFindFormOpen = false;

        /// <summary>
        /// ���� ��� �������� ��������� �������.
        /// </summary>
        private bool _isFiltered = false;

        /// <summary>
		/// ���� ��� ���������� � �������� �����.
		/// </summary>
		private readonly XmlSerializer _serializerXml =
            new XmlSerializer(typeof(BindingList<ExerciseBase>));

        /// <summary>
        /// ����������� ������� �����
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            FillingDataGridView(_calloriesList);

            _buttonAddCallories.Click += AddCalloriesButtonClick;

            _buttonDelete.Click += ClickDeleteElementButton;

            _buttonFillterCallories.Click += FillterButtonClick;

            _buttonFillterCallories.Click += ShowIfFiltered;

            _buttonOpenCallories.Click += OpenFile;

            _buttonSaveCallories.Click += SaveFile;

#if DEBUG
            _buttonAddRandom.Click += ClickRandomButton;
            
#endif

            DeactivateElements();
        }

        /// <summary>
        /// ����� ���������� ������� ����������� ������� 
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
        /// ���������� ������ ����������
        /// </summary>
        /// <param name="sender">�������</param>
        /// <param name="exerciseBase">������ � �������</param>
        private void CancelCallories(object sender, EventArgs exerciseBase)
        {
            CalloriesAddedEventArgs addedEventArgs =
               exerciseBase as CalloriesAddedEventArgs;

            _calloriesList.Remove(addedEventArgs?.ExerciseBase);
        }

        /// <summary>
        /// ������ ������� �� ������ "�������� ��������� ������".
        /// </summary>
        /// <param name="sender">�������</param>
        /// <param name="e">������ � �������</param>
        private void ClickRandomButton(object sender, EventArgs e)
        {
            _calloriesList.Add(RandomCallories.GetRandomExercise());
        }

        /// <summary>
        /// ����� ������� �� ������ "��������"
        /// </summary>
        /// <param name="sender">�������</param>
        /// <param name="e">������ � �������</param>
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
                DataForm.CalloriesCancel += CancelCallories;
                DataForm.Show();
            }
        }

        /// <summary>
        /// ���������� ���������� ������ � ������ calloriesList
        /// </summary>
        /// <param name="sender">������, ������� ������ �������</param>
        /// <param name="exerciseBase">��������� �������, ������� �������� 
        /// ������, ������������ ��� ������ �������</param>
        private void AddedCallories(object sender, EventArgs exerciseBase)
        {
            CalloriesAddedEventArgs addedEventArgs = exerciseBase
                as CalloriesAddedEventArgs;
            _calloriesList.Add(addedEventArgs?.ExerciseBase);
        }

        /// <summary>
        /// ����� ����������� ��������� 
        /// </summary>
        private void DeactivateElements()
        {
            _buttonAddCallories.Enabled = !_isFiltered && !_isDataFormOpen;
            _buttonFillterCallories.Enabled = !_isDataFormOpen &&
                !_isFindFormOpen;
            _buttonSaveCallories.Enabled = !_isFiltered;
            _buttonOpenCallories.Enabled = !_isFiltered;
            _buttonDelete.Enabled = !_isFiltered;
#if DEBUG
            _buttonAddRandom.Enabled = !_isFindFormOpen; 
#endif
        }
      

        /// <summary>
        /// ����� ��� ������ "�������"
        /// </summary>
        /// <param name="sender">�������</param>
        /// <param name="e">������ � �������</param>
        private void ClickDeleteElementButton(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in _dataControlCallories.SelectedRows)
            {
                if (row.DataBoundItem is ExerciseBase element)
                {
                    _calloriesList.Remove(element);
                }
            }
        }

        /// <summary>
		/// ����� ������� �� ������ "��������� ������"
		/// </summary>
		/// <param name="sender">�������</param>
		/// <param name="e">������ � �������</param>
		private void FillterButtonClick(object sender, EventArgs e)
        {
            if (!_isFindFormOpen)
            {
                _isFindFormOpen = true;
                FilterForm findForm = new FilterForm(_calloriesList);
                findForm.FormClosed += (s, args) =>
                {
                    _isFindFormOpen = false;
                    _isFiltered = false;
                    DeactivateElements();
                };
                findForm.�alloriesFiltered += FilteredExersice;
                findForm.CalloriesUnfiltered += ResetFilter;
                findForm.Show();
            }
        }

        /// <summary>
        /// �����, �������� ��������� ������ ��� ����������
        /// </summary>
        /// <param name="sender">�������</param>
        /// <param name="e">������ � �������</param>
        private void ShowIfFiltered(object sender, EventArgs e)
        {
            if (_isFiltered == true)
            {
                _buttonDelete.Enabled = false;
            }
            else
            {
                _buttonFillterCallories.Enabled = true;
                _buttonDelete.Enabled = true;
            }
        }

        /// <summary>
		/// ���������� ���������� ������
		/// </summary>
		/// <param name="sender">�������</param>
		/// <param name="transportList">������ � �������</param>
		private void FilteredExersice(object sender, EventArgs exerciseList)
        {
            CalloriesFilterEventArgs filterEventArgs =
                 exerciseList as CalloriesFilterEventArgs;

            _filteredExerciseList = filterEventArgs?.FilteredCalloriesList;
            _isFiltered = true;
            DeactivateElements();
            FillingDataGridView(_filteredExerciseList);
        }

        /// <summary>
        /// ����� ��������� ������� �� ������ "�������� ������" �� ������ �����
        /// </summary>
        /// <param name="sender">�������</param>
        /// <param name="e">������ � �������</param>
        private void ResetFilter(object sender, EventArgs e)
        {
            _isFiltered = false;
            DeactivateElements();
            FillingDataGridView(_calloriesList);
        }

        /// <summary>
		/// ����� ��� �������� ������ �� �����
		/// </summary>
		/// <param name="sender">�������</param>
		/// <param name="e">������ � �������</param>
		private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "����� (*.tran)|*.tran|��� ����� (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            string filePath = openFileDialog.FileName.ToString();

            try
            {
                using (var file = new StreamReader(filePath))
                {
                    _calloriesList = 
                        (BindingList<ExerciseBase>)_serializerXml.Deserialize(file);
                }

                _dataControlCallories.DataSource = _calloriesList;
                MessageBox.Show("���� ������� ��������.",
                    "�������� ���������",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("�� ������� ��������� ����.\n" +
                   "���� �������� ��� �� ������������� �������.",
                   "������",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
		/// ����� ��� ���������� ������ � ����
		/// </summary>
		/// <param name="sender">�������</param>
		/// <param name="e">������ � �������</param>
		private void SaveFile(object sender, EventArgs e)
        {
            if (!_calloriesList.Any() || _calloriesList is null)
            {
                MessageBox.Show("����������� ������ ��� ����������.",
                    "������ �� ���������",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "����� (*tran.)|*.tran|��� ����� (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName.ToString();

                using (var file = File.Create(filePath))
                {
                    _serializerXml.Serialize(file, _calloriesList);
                }

                MessageBox.Show("���� ������� �������.",
                    "���������� ���������",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
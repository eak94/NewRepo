using Model;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Windows.Forms;

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
		private BindingList<ExerciseBase> _filtered�alloriesList;

        /// <summary>
        /// ���� ��� �������� ��������� �����
        /// ���������� ���������� ��� �������
        /// </summary>
        private bool _isDataFormOpen = false;

        /// <summary>
		///  ���� ��� �������� ��������� ����� ��� ����������
		/// </summary>
		private bool _isFillerFormOpen = false;

        /// <summary>
        /// ���� ��� �������� ��������� �������
        /// </summary>
        private bool _isFiltr = false;

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

            _buttonFindCallories.Click += FilterCallotiesButtonClick;

            _buttonResetCallories.Click += ResetedFilter;

            _buttonDelete.Click += RemoveCalloriesButtonClick;

            _buttonOpenCallories.Click += OpenFile;

            _buttonSaveCallories.Click += SaveFile;

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
            CalloriesAddedEventArgs addedEventArgs =
                 exerciseBase as CalloriesAddedEventArgs;
            _calloriesList.Add(addedEventArgs?.ExerciseBase);
        }

        /// <summary>
        /// ����� ����������� ��������� 
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
        /// ����� ������� �� ������ "�������"
        /// </summary>
        /// <param name="sender">�������</param>
        /// <param name="e">������ � �������</param>
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
                        if (_filtered�alloriesList is not null
                            && _filtered�alloriesList.Count > 0)
                        {
                            _filtered�alloriesList.Remove(callories);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// ����� ������� �� ������ "��������� ������"
        /// </summary>
        /// <param name="sender">�������.</param>
        /// <param name="e">������ � �������.</param>
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
                findForm.�alloriesFiltered += Filtered�allories;
                findForm.Show();
            }
        }

        /// <summary>
		/// ���������� ���������� ������
		/// </summary>
		/// <param name="sender">�������</param>
		/// <param name="calloriesList">������ � �������</param>
		private void Filtered�allories(object sender, EventArgs calloriesList)
        {
            CalloriesFilterEventArgs filterEventArgs =
                calloriesList as CalloriesFilterEventArgs;

            _filtered�alloriesList = filterEventArgs?.FilteredCalloriesList;
            _isFiltr = true;
            DeactivateElements();
            FillingDataGridView(_filtered�alloriesList);
        }

        /// <summary>
		/// ����� ������� �� ������ "��������".
		/// </summary>
		/// <param name="sender">�������.</param>
		/// <param name="e">������ � �������.</param>
		private void ResetedFilter(object sender, EventArgs e)
        {
            FillingDataGridView(_calloriesList);
            _isFiltr = false;
            DeactivateElements();
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
                    _calloriesList = (BindingList<ExerciseBase>)
                        _serializerXml.Deserialize(file);
                }

                _dataControlCallories.DataSource = _calloriesList;
            }
            catch (Exception ex)
            {
                string errorMessage = $"�� ������� ��������� ����!\n������: {ex.Message}";

                if (ex.InnerException != null)
                {
                    errorMessage += $"\n�����������: {ex.InnerException.Message}";
                }

                MessageBox.Show(errorMessage, "��������������",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("������ ����!", "��������������",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
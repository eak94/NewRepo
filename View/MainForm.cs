using Model;
using System.ComponentModel;
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
        /// ����������� ������� �����
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            FillingDataGridView(_calloriesList);

            _buttonAddCallories.Click += AddCalloriesButtonClick;

            //_buttonFindCallories.Click += FilterCallotiesButtonClick();

            _buttonDelete.Click += RemoveCalloriesButtonClick;

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
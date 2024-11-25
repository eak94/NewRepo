namespace View
{
    /// <summary>
    /// Главная форма
    /// </summary>
    partial class MainForm
    {
        /// <summary>
        ///  Необходимая переменная дизайнера.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Метод для явного освобождения ресурсов.
        /// </summary>
        /// <param name="disposing">true если ресурсы необходимо
        /// удалить,иначе false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _groupBoxResultCalloties = new GroupBox();
            _dataControlCallories = new DataGridView();
            _buttonOpenCallories = new Button();
            _buttonResetCallories = new Button();
            _buttonAddCallories = new Button();
            _buttonDelete = new Button();
            _buttonSaveCallories = new Button();
            _buttonAddRandom = new Button();
            _buttonFindCallories = new Button();
            _groupBoxResultCalloties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dataControlCallories).BeginInit();
            SuspendLayout();
            // 
            // _groupBoxResultCalloties
            // 
            _groupBoxResultCalloties.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _groupBoxResultCalloties.Controls.Add(_dataControlCallories);
            _groupBoxResultCalloties.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            _groupBoxResultCalloties.ForeColor = Color.Black;
            _groupBoxResultCalloties.Location = new Point(40, 88);
            _groupBoxResultCalloties.Name = "_groupBoxResultCalloties";
            _groupBoxResultCalloties.Size = new Size(824, 335);
            _groupBoxResultCalloties.TabIndex = 0;
            _groupBoxResultCalloties.TabStop = false;
            _groupBoxResultCalloties.Text = "Результаты расчетов каллорий";
            _groupBoxResultCalloties.Enter += _groupBoxResultCalloties_Enter;
            // 
            // _dataControlCallories
            // 
            _dataControlCallories.AllowUserToAddRows = false;
            _dataControlCallories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _dataControlCallories.BackgroundColor = Color.White;
            _dataControlCallories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dataControlCallories.GridColor = Color.White;
            _dataControlCallories.Location = new Point(8, 28);
            _dataControlCallories.Name = "_dataControlCallories";
            _dataControlCallories.ReadOnly = true;
            _dataControlCallories.RowTemplate.Height = 28;
            _dataControlCallories.Size = new Size(810, 301);
            _dataControlCallories.TabIndex = 0;
            _dataControlCallories.CellContentClick += dataGridView1_CellContentClick;
            // 
            // _buttonOpenCallories
            // 
            _buttonOpenCallories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _buttonOpenCallories.Location = new Point(192, 36);
            _buttonOpenCallories.Name = "_buttonOpenCallories";
            _buttonOpenCallories.Size = new Size(130, 31);
            _buttonOpenCallories.TabIndex = 2;
            _buttonOpenCallories.Text = "Открыть";
            _buttonOpenCallories.UseVisualStyleBackColor = true;
            _buttonOpenCallories.Click += _buttonOpenCallories_Click;
            // 
            // _buttonResetCallories
            // 
            _buttonResetCallories.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _buttonResetCallories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _buttonResetCallories.Location = new Point(231, 440);
            _buttonResetCallories.Name = "_buttonResetCallories";
            _buttonResetCallories.Size = new Size(170, 31);
            _buttonResetCallories.TabIndex = 4;
            _buttonResetCallories.Text = "Сбросить фильтр";
            _buttonResetCallories.UseVisualStyleBackColor = true;
            _buttonResetCallories.Click += _buttonResetCallories_Click;
            // 
            // _buttonAddCallories
            // 
            _buttonAddCallories.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _buttonAddCallories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _buttonAddCallories.Location = new Point(734, 440);
            _buttonAddCallories.Name = "_buttonAddCallories";
            _buttonAddCallories.Size = new Size(130, 31);
            _buttonAddCallories.TabIndex = 5;
            _buttonAddCallories.Text = "Добавить";
            _buttonAddCallories.UseVisualStyleBackColor = true;
            _buttonAddCallories.Click += buttonAddCallories_Click;
            // 
            // _buttonDelete
            // 
            _buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _buttonDelete.Location = new Point(586, 440);
            _buttonDelete.Name = "_buttonDelete";
            _buttonDelete.Size = new Size(130, 31);
            _buttonDelete.TabIndex = 6;
            _buttonDelete.Text = "Удалить";
            _buttonDelete.UseVisualStyleBackColor = true;
            _buttonDelete.Click += _buttonDelete_Click;
            // 
            // _buttonSaveCallories
            // 
            _buttonSaveCallories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _buttonSaveCallories.Location = new Point(40, 36);
            _buttonSaveCallories.Name = "_buttonSaveCallories";
            _buttonSaveCallories.Size = new Size(130, 31);
            _buttonSaveCallories.TabIndex = 8;
            _buttonSaveCallories.Text = "Сохранить";
            _buttonSaveCallories.UseVisualStyleBackColor = true;
            _buttonSaveCallories.Click += _buttonSaveCallories_Click;
            // 
            // _buttonAddRandom
            // 
            _buttonAddRandom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _buttonAddRandom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _buttonAddRandom.Location = new Point(610, 36);
            _buttonAddRandom.Name = "_buttonAddRandom";
            _buttonAddRandom.Size = new Size(254, 31);
            _buttonAddRandom.TabIndex = 9;
            _buttonAddRandom.Text = "Добавить рандомный расчет";
            _buttonAddRandom.UseVisualStyleBackColor = true;
            // 
            // _buttonFindCallories
            // 
            _buttonFindCallories.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _buttonFindCallories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _buttonFindCallories.Location = new Point(40, 440);
            _buttonFindCallories.Name = "_buttonFindCallories";
            _buttonFindCallories.Size = new Size(170, 31);
            _buttonFindCallories.TabIndex = 10;
            _buttonFindCallories.Text = "Настроить фильтр";
            _buttonFindCallories.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 497);
            Controls.Add(_buttonFindCallories);
            Controls.Add(_buttonAddRandom);
            Controls.Add(_buttonSaveCallories);
            Controls.Add(_buttonDelete);
            Controls.Add(_buttonAddCallories);
            Controls.Add(_buttonResetCallories);
            Controls.Add(_buttonOpenCallories);
            Controls.Add(_groupBoxResultCalloties);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MainForm";
            Text = "Калькулятор каллорий";
            _groupBoxResultCalloties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dataControlCallories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        /// <summary>
        /// GroupBox для результатов расчета каллорий
        /// </summary>
        private GroupBox _groupBoxResultCalloties;

        /// <summary>
        /// Кнопка "Открыть"
        /// </summary>
        private Button _buttonOpenCallories;

        /// <summary>
        /// Кнопка "Настроить фильтр"
        /// </summary>
        private Button _buttonFindCallories;

        /// <summary>
        /// Кнопка "Сбросить фильтр"
        /// </summary>
        private Button _buttonResetCallories;

        /// <summary>
        /// Кнопка "Добавить"
        /// </summary>
        private Button _buttonAddCallories;

        /// <summary>
        /// Таблица результатов расчета
        /// </summary>
        private DataGridView _dataControlCallories;

        /// <summary>
        /// Кнопка "Удалить"
        /// </summary>
        private Button _buttonDelete;

        /// <summary>
        /// Кнопка "Сохранить"
        /// </summary>
        private Button _buttonSaveCallories;

        /// <summary>
        /// Кнопка "Добавить рандомный расчет"
        /// </summary>
        private Button _buttonAddRandom;
    }
}
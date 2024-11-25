namespace View
{
    partial class AddWeightLiftingUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            _groupBoxWeightLifting = new GroupBox();
            _textBoxWeightLifting = new TextBox();
            _labelMetWeightLifting = new Label();
            _textBoxWorkingWeight = new TextBox();
            _textBoxMaxWeight = new TextBox();
            _labelMaxWeight = new Label();
            _textBoxRepetitions = new TextBox();
            _labelRepetitions = new Label();
            _labelWorkingWeight = new Label();
            _groupBoxWeightLifting.SuspendLayout();
            SuspendLayout();
            // 
            // _groupBoxWeightLifting
            // 
            _groupBoxWeightLifting.Controls.Add(_textBoxWeightLifting);
            _groupBoxWeightLifting.Controls.Add(_labelMetWeightLifting);
            _groupBoxWeightLifting.Controls.Add(_textBoxWorkingWeight);
            _groupBoxWeightLifting.Controls.Add(_textBoxMaxWeight);
            _groupBoxWeightLifting.Controls.Add(_labelMaxWeight);
            _groupBoxWeightLifting.Controls.Add(_textBoxRepetitions);
            _groupBoxWeightLifting.Controls.Add(_labelRepetitions);
            _groupBoxWeightLifting.Controls.Add(_labelWorkingWeight);
            _groupBoxWeightLifting.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _groupBoxWeightLifting.Location = new Point(3, 3);
            _groupBoxWeightLifting.Name = "_groupBoxWeightLifting";
            _groupBoxWeightLifting.Size = new Size(335, 294);
            _groupBoxWeightLifting.TabIndex = 3;
            _groupBoxWeightLifting.TabStop = false;
            _groupBoxWeightLifting.Text = "Параметры жима штанги";
            // 
            // _textBoxWeightLifting
            // 
            _textBoxWeightLifting.Location = new Point(19, 243);
            _textBoxWeightLifting.Name = "_textBoxWeightLifting";
            _textBoxWeightLifting.Size = new Size(292, 29);
            _textBoxWeightLifting.TabIndex = 7;
            // 
            // _labelMetWeightLifting
            // 
            _labelMetWeightLifting.AutoSize = true;
            _labelMetWeightLifting.Location = new Point(21, 219);
            _labelMetWeightLifting.Name = "_labelMetWeightLifting";
            _labelMetWeightLifting.Size = new Size(40, 21);
            _labelMetWeightLifting.TabIndex = 8;
            _labelMetWeightLifting.Text = "MET";
            // 
            // _textBoxWorkingWeight
            // 
            _textBoxWorkingWeight.Location = new Point(18, 123);
            _textBoxWorkingWeight.Name = "_textBoxWorkingWeight";
            _textBoxWorkingWeight.Size = new Size(292, 29);
            _textBoxWorkingWeight.TabIndex = 6;
            // 
            // _textBoxMaxWeight
            // 
            _textBoxMaxWeight.Location = new Point(18, 63);
            _textBoxMaxWeight.Name = "_textBoxMaxWeight";
            _textBoxMaxWeight.Size = new Size(292, 29);
            _textBoxMaxWeight.TabIndex = 5;
            _textBoxMaxWeight.TextChanged += _textBoxMaxWeight_TextChanged;
            // 
            // _labelMaxWeight
            // 
            _labelMaxWeight.AutoSize = true;
            _labelMaxWeight.Location = new Point(21, 39);
            _labelMaxWeight.Name = "_labelMaxWeight";
            _labelMaxWeight.Size = new Size(168, 21);
            _labelMaxWeight.TabIndex = 4;
            _labelMaxWeight.Text = "Максимальный вес, кг";
            // 
            // _textBoxRepetitions
            // 
            _textBoxRepetitions.Location = new Point(18, 183);
            _textBoxRepetitions.Name = "_textBoxRepetitions";
            _textBoxRepetitions.Size = new Size(292, 29);
            _textBoxRepetitions.TabIndex = 2;
            // 
            // _labelRepetitions
            // 
            _labelRepetitions.AutoSize = true;
            _labelRepetitions.Location = new Point(21, 159);
            _labelRepetitions.Name = "_labelRepetitions";
            _labelRepetitions.Size = new Size(183, 21);
            _labelRepetitions.TabIndex = 2;
            _labelRepetitions.Text = "Количество повторений";
            // 
            // _labelWorkingWeight
            // 
            _labelWorkingWeight.AutoSize = true;
            _labelWorkingWeight.Location = new Point(21, 99);
            _labelWorkingWeight.Name = "_labelWorkingWeight";
            _labelWorkingWeight.Size = new Size(120, 21);
            _labelWorkingWeight.TabIndex = 2;
            _labelWorkingWeight.Text = "Рабочий вес, кг";
            // 
            // AddWeightLiftingUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_groupBoxWeightLifting);
            Name = "AddWeightLiftingUserControl";
            Size = new Size(343, 307);
            _groupBoxWeightLifting.ResumeLayout(false);
            _groupBoxWeightLifting.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox _groupBoxWeightLifting;
        private TextBox _textBoxMaxWeight;
        private Label _labelMaxWeight;
        private TextBox _textBoxRepetitions;
        private Label _labelRepetitions;
        private Label _labelWorkingWeight;
        private TextBox _textBoxWorkingWeight;
        private TextBox _textBoxWeightLifting;
        private Label _labelMetWeightLifting;
    }
}

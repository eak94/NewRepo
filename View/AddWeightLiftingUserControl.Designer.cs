using static System.Runtime.InteropServices.JavaScript.JSType;

namespace View
{
    /// <summary>
    /// Пользовательский элемент управления
    /// для типа упражнения жима штанги
    /// </summary>
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
            _numBoxWorkingWeight = new NumBox();
            _numBoxMaxWeight = new NumBox();
            _labelMaxWeight = new Label();
            _numBoxRepetitions = new NumBox();
            _labelRepetitions = new Label();
            _labelWorkingWeight = new Label();
            SuspendLayout();
            // 
            // _numBoxWorkingWeight
            // 
            _numBoxWorkingWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _numBoxWorkingWeight.Location = new Point(208, 77);
            _numBoxWorkingWeight.Name = "_numBoxWorkingWeight";
            _numBoxWorkingWeight.Size = new Size(92, 29);
            _numBoxWorkingWeight.TabIndex = 6;
            // 
            // _numBoxMaxWeight
            // 
            _numBoxMaxWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _numBoxMaxWeight.Location = new Point(208, 24);
            _numBoxMaxWeight.Name = "_numBoxMaxWeight";
            _numBoxMaxWeight.Size = new Size(92, 29);
            _numBoxMaxWeight.TabIndex = 5;
            // 
            // _labelMaxWeight
            // 
            _labelMaxWeight.AutoSize = true;
            _labelMaxWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _labelMaxWeight.Location = new Point(19, 27);
            _labelMaxWeight.Name = "_labelMaxWeight";
            _labelMaxWeight.Size = new Size(168, 21);
            _labelMaxWeight.TabIndex = 4;
            _labelMaxWeight.Text = "Максимальный вес, кг";
            // 
            // _numBoxRepetitions
            // 
            _numBoxRepetitions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _numBoxRepetitions.Location = new Point(208, 131);
            _numBoxRepetitions.Name = "_numBoxRepetitions";
            _numBoxRepetitions.Size = new Size(92, 29);
            _numBoxRepetitions.TabIndex = 2;
            // 
            // _labelRepetitions
            // 
            _labelRepetitions.AutoSize = true;
            _labelRepetitions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _labelRepetitions.Location = new Point(19, 134);
            _labelRepetitions.Name = "_labelRepetitions";
            _labelRepetitions.Size = new Size(183, 21);
            _labelRepetitions.TabIndex = 2;
            _labelRepetitions.Text = "Количество повторений";
            // 
            // _labelWorkingWeight
            // 
            _labelWorkingWeight.AutoSize = true;
            _labelWorkingWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _labelWorkingWeight.Location = new Point(19, 80);
            _labelWorkingWeight.Name = "_labelWorkingWeight";
            _labelWorkingWeight.Size = new Size(120, 21);
            _labelWorkingWeight.TabIndex = 2;
            _labelWorkingWeight.Text = "Рабочий вес, кг";
            // 
            // AddWeightLiftingUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(_numBoxWorkingWeight);
            Controls.Add(_labelWorkingWeight);
            Controls.Add(_numBoxMaxWeight);
            Controls.Add(_labelRepetitions);
            Controls.Add(_labelMaxWeight);
            Controls.Add(_numBoxRepetitions);
            Name = "AddWeightLiftingUserControl";
            Size = new Size(315, 191);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        /// <summary>
        /// NumBox для рабочего веса 
        /// </summary>
        private NumBox _numBoxWorkingWeight;

        /// <summary>
        /// NumBox для максимального веса
        /// </summary>
        private NumBox _numBoxMaxWeight;

        /// <summary>
        /// NumBox для количества повторений
        /// </summary>
        private NumBox _numBoxRepetitions;

        /// <summary>
        /// надпись для максимального веса
        /// </summary>
        private Label _labelMaxWeight;
                
        /// <summary>
        /// надпись для количества повторений
        /// </summary>
        private Label _labelRepetitions;

        /// <summary>
        /// надпись для рабочего веса 
        /// </summary>
        private Label _labelWorkingWeight;
    }
}

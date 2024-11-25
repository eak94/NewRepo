namespace View
{
    /// <summary>
    /// Пользовательский элемент управления 
    /// для типа упражнения бег
    /// </summary>
    partial class AddRunningUserControl
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
            _groupBoxRunning = new GroupBox();
            _textBoxIntensity = new TextBox();
            _labelIntensity = new Label();
            _textBoxMetRunning = new TextBox();
            _labelMetRunning = new Label();
            _textBoxDistance = new TextBox();
            _labelDistance = new Label();
            _groupBoxRunning.SuspendLayout();
            SuspendLayout();
            // 
            // _groupBoxRunning
            // 
            _groupBoxRunning.BackColor = Color.White;
            _groupBoxRunning.Controls.Add(_textBoxIntensity);
            _groupBoxRunning.Controls.Add(_labelIntensity);
            _groupBoxRunning.Controls.Add(_textBoxMetRunning);
            _groupBoxRunning.Controls.Add(_labelMetRunning);
            _groupBoxRunning.Controls.Add(_textBoxDistance);
            _groupBoxRunning.Controls.Add(_labelDistance);
            _groupBoxRunning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _groupBoxRunning.Location = new Point(3, 3);
            _groupBoxRunning.Name = "_groupBoxRunning";
            _groupBoxRunning.Size = new Size(377, 259);
            _groupBoxRunning.TabIndex = 1;
            _groupBoxRunning.TabStop = false;
            _groupBoxRunning.Text = "Параметры бега";
            // 
            // _textBoxIntensity
            // 
            _textBoxIntensity.Location = new Point(21, 133);
            _textBoxIntensity.Name = "_textBoxIntensity";
            _textBoxIntensity.Size = new Size(328, 29);
            _textBoxIntensity.TabIndex = 6;
            // 
            // _labelIntensity
            // 
            _labelIntensity.AutoSize = true;
            _labelIntensity.BackColor = Color.White;
            _labelIntensity.Location = new Point(22, 106);
            _labelIntensity.Name = "_labelIntensity";
            _labelIntensity.Size = new Size(160, 21);
            _labelIntensity.TabIndex = 7;
            _labelIntensity.Text = "Интенсивность, км/ч";
            // 
            // _textBoxMetRunning
            // 
            _textBoxMetRunning.Location = new Point(20, 200);
            _textBoxMetRunning.Name = "_textBoxMetRunning";
            _textBoxMetRunning.Size = new Size(328, 29);
            _textBoxMetRunning.TabIndex = 5;
            _textBoxMetRunning.TextChanged += _textBoxMetRunning_TextChanged;
            // 
            // _labelMetRunning
            // 
            _labelMetRunning.AutoSize = true;
            _labelMetRunning.Location = new Point(24, 174);
            _labelMetRunning.Name = "_labelMetRunning";
            _labelMetRunning.Size = new Size(40, 21);
            _labelMetRunning.TabIndex = 4;
            _labelMetRunning.Text = "MET";
            // 
            // _textBoxDistance
            // 
            _textBoxDistance.Location = new Point(21, 68);
            _textBoxDistance.Name = "_textBoxDistance";
            _textBoxDistance.Size = new Size(328, 29);
            _textBoxDistance.TabIndex = 2;
            // 
            // _labelDistance
            // 
            _labelDistance.AutoSize = true;
            _labelDistance.BackColor = Color.White;
            _labelDistance.Location = new Point(21, 41);
            _labelDistance.Name = "_labelDistance";
            _labelDistance.Size = new Size(114, 21);
            _labelDistance.TabIndex = 2;
            _labelDistance.Text = "Дистанция, км";
            // 
            // AddRunningUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_groupBoxRunning);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AddRunningUserControl";
            Size = new Size(384, 277);
            _groupBoxRunning.ResumeLayout(false);
            _groupBoxRunning.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        /// <summary>
        /// groupBox для типа упражнения бег
        /// </summary>
        private GroupBox _groupBoxRunning;

        /// <summary>
        /// textBox Met для типа упражнения бег
        /// </summary>
        private TextBox _textBoxMetRunning;

        /// <summary>
        /// надпись для Met для типа упражнения бег
        /// </summary>
        private Label _labelMetRunning;

        /// <summary>
        /// textBox дистанция для типа упражнения бег
        /// </summary>
        private TextBox _textBoxDistance;

        /// <summary>
        /// надпись для дистанции для типа упражнения бег
        /// </summary>
        private Label _labelDistance;

        /// <summary>
        /// textBox для интенсивности для типа упражнения бег
        /// </summary>
        private TextBox _textBoxIntensity;

        /// <summary>
        /// надпись для интенсивности для типа упражнения бег
        /// </summary>
        private Label _labelIntensity;
    }
}

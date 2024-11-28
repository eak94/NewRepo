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

        public string Distance
        {
            get { return _textBoxDistance.Text; }
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            _textBoxIntensity = new TextBox();
            _labelIntensity = new Label();
            _textBoxMetRunning = new TextBox();
            _labelMetRunning = new Label();
            _textBoxDistance = new TextBox();
            _labelDistance = new Label();
            SuspendLayout();
            // 
            // _textBoxIntensity
            // 
            _textBoxIntensity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _textBoxIntensity.Location = new Point(51, 155);
            _textBoxIntensity.Name = "_textBoxIntensity";
            _textBoxIntensity.Size = new Size(285, 29);
            _textBoxIntensity.TabIndex = 6;
            // 
            // _labelIntensity
            // 
            _labelIntensity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _labelIntensity.AutoSize = true;
            _labelIntensity.BackColor = Color.White;
            _labelIntensity.Location = new Point(52, 128);
            _labelIntensity.Name = "_labelIntensity";
            _labelIntensity.Size = new Size(160, 21);
            _labelIntensity.TabIndex = 7;
            _labelIntensity.Text = "Интенсивность, км/ч";
            // 
            // _textBoxMetRunning
            // 
            _textBoxMetRunning.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _textBoxMetRunning.Location = new Point(50, 222);
            _textBoxMetRunning.Name = "_textBoxMetRunning";
            _textBoxMetRunning.Size = new Size(286, 29);
            _textBoxMetRunning.TabIndex = 5;
            _textBoxMetRunning.TextChanged += _textBoxMetRunning_TextChanged;
            // 
            // _labelMetRunning
            // 
            _labelMetRunning.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _labelMetRunning.AutoSize = true;
            _labelMetRunning.Location = new Point(54, 196);
            _labelMetRunning.Name = "_labelMetRunning";
            _labelMetRunning.Size = new Size(40, 21);
            _labelMetRunning.TabIndex = 4;
            _labelMetRunning.Text = "MET";
            // 
            // _textBoxDistance
            // 
            _textBoxDistance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _textBoxDistance.Location = new Point(51, 90);
            _textBoxDistance.Name = "_textBoxDistance";
            _textBoxDistance.Size = new Size(285, 29);
            _textBoxDistance.TabIndex = 2;
            _textBoxDistance.TextChanged += _textBoxDistance_TextChanged;
            // 
            // _labelDistance
            // 
            _labelDistance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _labelDistance.AutoSize = true;
            _labelDistance.BackColor = Color.White;
            _labelDistance.Location = new Point(51, 63);
            _labelDistance.Name = "_labelDistance";
            _labelDistance.Size = new Size(114, 21);
            _labelDistance.TabIndex = 2;
            _labelDistance.Text = "Дистанция, км";
            // 
            // AddRunningUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(_textBoxIntensity);
            Controls.Add(_labelIntensity);
            Controls.Add(_labelMetRunning);
            Controls.Add(_textBoxMetRunning);
            Controls.Add(_labelDistance);
            Controls.Add(_textBoxDistance);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AddRunningUserControl";
            Size = new Size(387, 321);
            Load += AddRunningUserControl_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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

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
            _numBoxIntensity = new NumBox();
            _labelIntensity = new Label();
            _numBoxDistance = new NumBox();
            _labelDistance = new Label();
            SuspendLayout();
            // 
            // _numBoxIntensity
            // 
            _numBoxIntensity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _numBoxIntensity.Location = new Point(201, 68);
            _numBoxIntensity.Name = "_numBoxIntensity";
            _numBoxIntensity.Size = new Size(92, 29);
            _numBoxIntensity.TabIndex = 6;
            // 
            // _labelIntensity
            // 
            _labelIntensity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _labelIntensity.AutoSize = true;
            _labelIntensity.BackColor = Color.White;
            _labelIntensity.Location = new Point(13, 71);
            _labelIntensity.Name = "_labelIntensity";
            _labelIntensity.Size = new Size(160, 21);
            _labelIntensity.TabIndex = 7;
            _labelIntensity.Text = "Интенсивность, км/ч";
            // 
            // _numBoxDistance
            // 
            _numBoxDistance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _numBoxDistance.Location = new Point(201, 15);
            _numBoxDistance.Name = "_numBoxDistance";
            _numBoxDistance.Size = new Size(92, 29);
            _numBoxDistance.TabIndex = 2;
            // 
            // _labelDistance
            // 
            _labelDistance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _labelDistance.AutoSize = true;
            _labelDistance.BackColor = Color.White;
            _labelDistance.Location = new Point(13, 17);
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
            Controls.Add(_numBoxIntensity);
            Controls.Add(_labelIntensity);
            Controls.Add(_labelDistance);
            Controls.Add(_numBoxDistance);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AddRunningUserControl";
            Size = new Size(315, 117);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        /// <summary>
        /// NumBox дистанция для типа упражнения бег
        /// </summary>
        private NumBox _numBoxDistance;

        /// <summary>
        /// надпись для дистанции для типа упражнения бег
        /// </summary>
        private Label _labelDistance;

        /// <summary>
        /// NumBox для интенсивности для типа упражнения бег
        /// </summary>
        private NumBox _numBoxIntensity;

        /// <summary>
        /// надпись для интенсивности для типа упражнения бег
        /// </summary>
        private Label _labelIntensity;
    }
}

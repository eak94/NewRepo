namespace View
{
    partial class DataForm
    {
        /// <summary>
        /// Необходимая переменная дизайнера
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Метод для явного освобождения ресурсов
        /// </summary>
        /// <param name="disposing">true если ресурсы необходимо
        /// oудалить,иначе false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _groupBoxDataExercise = new GroupBox();
            _comboBoxExercise = new ComboBox();
            _buttonDataAddRandomParametr = new Button();
            _buttonDataAgree = new Button();
            _buttonDataCancel = new Button();
            _groupBoxDataPerson = new GroupBox();
            label2 = new Label();
            _textBoxWeightPerson = new TextBox();
            _labelWeightPerson = new Label();
            label4 = new Label();
            _groupBoxDataTime = new GroupBox();
            label5 = new Label();
            _textBoxTime = new TextBox();
            _labelTime = new Label();
            _groupBoxParametrExercise = new GroupBox();
            _groupBoxDataExercise.SuspendLayout();
            _groupBoxDataPerson.SuspendLayout();
            _groupBoxDataTime.SuspendLayout();
            SuspendLayout();
            // 
            // _groupBoxDataExercise
            // 
            _groupBoxDataExercise.Controls.Add(_comboBoxExercise);
            _groupBoxDataExercise.Location = new Point(54, 44);
            _groupBoxDataExercise.Name = "_groupBoxDataExercise";
            _groupBoxDataExercise.Size = new Size(254, 85);
            _groupBoxDataExercise.TabIndex = 0;
            _groupBoxDataExercise.TabStop = false;
            _groupBoxDataExercise.Text = "Тип упражнения";
            // 
            // _comboBoxExercise
            // 
            _comboBoxExercise.FormattingEnabled = true;
            _comboBoxExercise.Location = new Point(16, 37);
            _comboBoxExercise.Name = "_comboBoxExercise";
            _comboBoxExercise.Size = new Size(222, 29);
            _comboBoxExercise.TabIndex = 0;
            _comboBoxExercise.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // _buttonDataAddRandomParametr
            // 
            _buttonDataAddRandomParametr.Anchor = AnchorStyles.Left;
            _buttonDataAddRandomParametr.Location = new Point(54, 403);
            _buttonDataAddRandomParametr.Name = "_buttonDataAddRandomParametr";
            _buttonDataAddRandomParametr.Size = new Size(319, 33);
            _buttonDataAddRandomParametr.TabIndex = 1;
            _buttonDataAddRandomParametr.Text = "Заполнить рандомными значениями";
            _buttonDataAddRandomParametr.UseVisualStyleBackColor = true;
            // 
            // _buttonDataAgree
            // 
            _buttonDataAgree.Anchor = AnchorStyles.Bottom;
            _buttonDataAgree.Location = new Point(613, 403);
            _buttonDataAgree.Name = "_buttonDataAgree";
            _buttonDataAgree.Size = new Size(77, 33);
            _buttonDataAgree.TabIndex = 2;
            _buttonDataAgree.Text = "Ок";
            _buttonDataAgree.UseVisualStyleBackColor = true;
            _buttonDataAgree.Click += button2_Click;
            // 
            // _buttonDataCancel
            // 
            _buttonDataCancel.Anchor = AnchorStyles.Bottom;
            _buttonDataCancel.Location = new Point(494, 403);
            _buttonDataCancel.Name = "_buttonDataCancel";
            _buttonDataCancel.Size = new Size(99, 33);
            _buttonDataCancel.TabIndex = 3;
            _buttonDataCancel.Text = "Отмена";
            _buttonDataCancel.UseVisualStyleBackColor = true;
            // 
            // _groupBoxDataPerson
            // 
            _groupBoxDataPerson.Controls.Add(label2);
            _groupBoxDataPerson.Controls.Add(_textBoxWeightPerson);
            _groupBoxDataPerson.Controls.Add(_labelWeightPerson);
            _groupBoxDataPerson.Location = new Point(54, 159);
            _groupBoxDataPerson.Name = "_groupBoxDataPerson";
            _groupBoxDataPerson.Size = new Size(254, 98);
            _groupBoxDataPerson.TabIndex = 4;
            _groupBoxDataPerson.TabStop = false;
            _groupBoxDataPerson.Text = "Данные о человеке";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 66);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 2;
            label2.Click += label2_Click;
            // 
            // _textBoxWeightPerson
            // 
            _textBoxWeightPerson.Location = new Point(15, 58);
            _textBoxWeightPerson.Name = "_textBoxWeightPerson";
            _textBoxWeightPerson.Size = new Size(222, 29);
            _textBoxWeightPerson.TabIndex = 1;
            // 
            // _labelWeightPerson
            // 
            _labelWeightPerson.AutoSize = true;
            _labelWeightPerson.Location = new Point(16, 34);
            _labelWeightPerson.Name = "_labelWeightPerson";
            _labelWeightPerson.Size = new Size(59, 21);
            _labelWeightPerson.TabIndex = 0;
            _labelWeightPerson.Text = "Вес, кг ";
            _labelWeightPerson.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 159);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 3;
            // 
            // _groupBoxDataTime
            // 
            _groupBoxDataTime.Controls.Add(label5);
            _groupBoxDataTime.Controls.Add(_textBoxTime);
            _groupBoxDataTime.Controls.Add(_labelTime);
            _groupBoxDataTime.Location = new Point(54, 274);
            _groupBoxDataTime.Name = "_groupBoxDataTime";
            _groupBoxDataTime.Size = new Size(254, 101);
            _groupBoxDataTime.TabIndex = 5;
            _groupBoxDataTime.TabStop = false;
            _groupBoxDataTime.Text = "Данные о тренировке ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 66);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 2;
            // 
            // _textBoxTime
            // 
            _textBoxTime.Location = new Point(16, 58);
            _textBoxTime.Name = "_textBoxTime";
            _textBoxTime.Size = new Size(221, 29);
            _textBoxTime.TabIndex = 1;
            // 
            // _labelTime
            // 
            _labelTime.AutoSize = true;
            _labelTime.Location = new Point(16, 34);
            _labelTime.Name = "_labelTime";
            _labelTime.Size = new Size(71, 21);
            _labelTime.TabIndex = 0;
            _labelTime.Text = "Время, ч";
            // 
            // _groupBoxParametrExercise
            // 
            _groupBoxParametrExercise.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            _groupBoxParametrExercise.Location = new Point(339, 44);
            _groupBoxParametrExercise.Name = "_groupBoxParametrExercise";
            _groupBoxParametrExercise.Size = new Size(351, 331);
            _groupBoxParametrExercise.TabIndex = 5;
            _groupBoxParametrExercise.TabStop = false;
            _groupBoxParametrExercise.Text = "Данные по типу упражнения";
            // 
            // DataForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(723, 458);
            Controls.Add(_groupBoxParametrExercise);
            Controls.Add(_groupBoxDataTime);
            Controls.Add(_groupBoxDataPerson);
            Controls.Add(label4);
            Controls.Add(_buttonDataCancel);
            Controls.Add(_buttonDataAgree);
            Controls.Add(_buttonDataAddRandomParametr);
            Controls.Add(_groupBoxDataExercise);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "DataForm";
            Text = "Добавить расчет каллорий";
            _groupBoxDataExercise.ResumeLayout(false);
            _groupBoxDataPerson.ResumeLayout(false);
            _groupBoxDataPerson.PerformLayout();
            _groupBoxDataTime.ResumeLayout(false);
            _groupBoxDataTime.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox _groupBoxDataExercise;
        private ComboBox _comboBoxExercise;
        private Button _buttonDataAddRandomParametr;
        private Button _buttonDataAgree;
        private Button _buttonDataCancel;
        private GroupBox _groupBoxDataPerson;
        private TextBox _textBoxWeightPerson;
        private Label _labelWeightPerson;
        private Label label2;
        private Label label4;
        private GroupBox _groupBoxDataTime;
        private Label label5;
        private TextBox _textBoxTime;
        private Label _labelTime;
        private GroupBox _groupBoxParametrExercise;
    }
}
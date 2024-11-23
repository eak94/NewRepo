namespace View
{
    partial class FilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            _groupBoxFilterType = new GroupBox();
            _groupBoxFilterData = new GroupBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            _checkBoxWeightPerson = new CheckBox();
            _buttonAgree = new Button();
            _textBoxWeightPerson = new TextBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            checkBox4 = new CheckBox();
            _groupBoxFilterType.SuspendLayout();
            _groupBoxFilterData.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // _groupBoxFilterType
            // 
            _groupBoxFilterType.Controls.Add(checkBox3);
            _groupBoxFilterType.Controls.Add(checkBox2);
            _groupBoxFilterType.Controls.Add(checkBox1);
            _groupBoxFilterType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _groupBoxFilterType.Location = new Point(35, 30);
            _groupBoxFilterType.Name = "_groupBoxFilterType";
            _groupBoxFilterType.Size = new Size(335, 140);
            _groupBoxFilterType.TabIndex = 0;
            _groupBoxFilterType.TabStop = false;
            _groupBoxFilterType.Text = "По типу упражения ";
            // 
            // _groupBoxFilterData
            // 
            _groupBoxFilterData.Controls.Add(_textBoxWeightPerson);
            _groupBoxFilterData.Controls.Add(_checkBoxWeightPerson);
            _groupBoxFilterData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _groupBoxFilterData.Location = new Point(35, 188);
            _groupBoxFilterData.Name = "_groupBoxFilterData";
            _groupBoxFilterData.Size = new Size(335, 79);
            _groupBoxFilterData.TabIndex = 1;
            _groupBoxFilterData.TabStop = false;
            _groupBoxFilterData.Text = "По данным человека";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(15, 31);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(52, 25);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Бег";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(15, 65);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(98, 25);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Плавание";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(15, 100);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(156, 25);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Тяжелая атлетика";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // _checkBoxWeightPerson
            // 
            _checkBoxWeightPerson.AutoSize = true;
            _checkBoxWeightPerson.Location = new Point(15, 39);
            _checkBoxWeightPerson.Name = "_checkBoxWeightPerson";
            _checkBoxWeightPerson.Size = new Size(74, 25);
            _checkBoxWeightPerson.TabIndex = 3;
            _checkBoxWeightPerson.Text = "Вес, кг";
            _checkBoxWeightPerson.UseVisualStyleBackColor = true;
            // 
            // _buttonAgree
            // 
            _buttonAgree.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _buttonAgree.Location = new Point(230, 379);
            _buttonAgree.Name = "_buttonAgree";
            _buttonAgree.Size = new Size(140, 31);
            _buttonAgree.TabIndex = 2;
            _buttonAgree.Text = "Применить";
            _buttonAgree.UseVisualStyleBackColor = true;
            _buttonAgree.Click += button1_Click;
            // 
            // _textBoxWeightPerson
            // 
            _textBoxWeightPerson.Location = new Point(259, 35);
            _textBoxWeightPerson.Name = "_textBoxWeightPerson";
            _textBoxWeightPerson.Size = new Size(59, 29);
            _textBoxWeightPerson.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(35, 284);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 79);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "По времени тренировки";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(59, 29);
            textBox1.TabIndex = 4;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(15, 39);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(179, 25);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Время тренировки, ч";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(408, 436);
            Controls.Add(groupBox1);
            Controls.Add(_buttonAgree);
            Controls.Add(_groupBoxFilterData);
            Controls.Add(_groupBoxFilterType);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FilterForm";
            Text = "Фильтр";
            _groupBoxFilterType.ResumeLayout(false);
            _groupBoxFilterType.PerformLayout();
            _groupBoxFilterData.ResumeLayout(false);
            _groupBoxFilterData.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox _groupBoxFilterType;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox _groupBoxFilterData;
        private CheckBox _checkBoxWeightPerson;
        private Button _buttonAgree;
        private TextBox _textBoxWeightPerson;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private CheckBox checkBox4;
    }
}
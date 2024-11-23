namespace View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _groupBoxResultCalloties = new GroupBox();
            dataGridView1 = new DataGridView();
            _buttonOpenCallories = new Button();
            _buttonResetCallories = new Button();
            this.buttonAdd = new Button();
            buttonDelete = new Button();
            label1 = new Label();
            _buttonSaveCallories = new Button();
            _buttonAddRandom = new Button();
            _buttonFindCallories = new Button();
            _groupBoxResultCalloties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // _groupBoxResultCalloties
            // 
            _groupBoxResultCalloties.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _groupBoxResultCalloties.Controls.Add(dataGridView1);
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
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(8, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(810, 301);
            dataGridView1.TabIndex = 0;
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
            // buttonAdd
            // 
            this.buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.buttonAdd.Location = new Point(734, 440);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new Size(130, 31);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(598, 440);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(130, 31);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 26);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 7;
            label1.Click += label1_Click;
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
            Controls.Add(label1);
            Controls.Add(buttonDelete);
            Controls.Add(this.buttonAdd);
            Controls.Add(_buttonResetCallories);
            Controls.Add(_buttonOpenCallories);
            Controls.Add(_groupBoxResultCalloties);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MainForm";
            Text = "Калькулятор каллорий";
            _groupBoxResultCalloties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox _groupBoxResultCalloties;
        private Button _buttonOpenCallories;
        private Button _buttonFindCallories;
        private Button _buttonResetCallories;
        private Button buttonAdd;
        private DataGridView dataGridView1;
        private Button button1;
        private Button buttonDelete;
        private Label label1;
        private Button _buttonSaveCallories;
        private Button _buttonAddRandom;
    }
}
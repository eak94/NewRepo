namespace View
{
    partial class Form1
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
            butt1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            domainUpDown1 = new DomainUpDown();
            radioButton1 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // butt1
            // 
            butt1.Location = new Point(31, 53);
            butt1.Name = "butt1";
            butt1.Size = new Size(75, 23);
            butt1.TabIndex = 0;
            butt1.Text = "button1";
            butt1.UseVisualStyleBackColor = true;
            butt1.Click += butt1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(284, 43);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "закрыть";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(butt1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(153, 213);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(511, 111);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(120, 26);
            domainUpDown1.TabIndex = 3;
            domainUpDown1.Text = "domainUpDown1";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(643, 286);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(108, 23);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton1);
            Controls.Add(domainUpDown1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butt1;
        private Button button2;
        private GroupBox groupBox1;
        private DomainUpDown domainUpDown1;
        private RadioButton radioButton1;
    }
}
namespace RPMLevchenko
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ApproxResultOutput = new System.Windows.Forms.TextBox();
            this.ExactResultOutput = new System.Windows.Forms.TextBox();
            this.AbsoluteResultOutput = new System.Windows.Forms.TextBox();
            this.ApproxRsultOutputLabel = new System.Windows.Forms.Label();
            this.ExactResultOutputLabel = new System.Windows.Forms.Label();
            this.ShowAndSaveResultButton = new System.Windows.Forms.Button();
            this.AbsoluteResultOutputLabel = new System.Windows.Forms.Label();
            this.XValueInput = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EpsilonValueInput = new System.Windows.Forms.TextBox();
            this.XValueInputLabel = new System.Windows.Forms.Label();
            this.EpsilonValueInputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ApproxResultOutput
            // 
            this.ApproxResultOutput.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ApproxResultOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApproxResultOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApproxResultOutput.Location = new System.Drawing.Point(35, 151);
            this.ApproxResultOutput.Margin = new System.Windows.Forms.Padding(4);
            this.ApproxResultOutput.Name = "ApproxResultOutput";
            this.ApproxResultOutput.ReadOnly = true;
            this.ApproxResultOutput.Size = new System.Drawing.Size(132, 27);
            this.ApproxResultOutput.TabIndex = 0;
            this.ApproxResultOutput.TextChanged += new System.EventHandler(this.ApproxResultOutput_TextChanged);
            // 
            // ExactResultOutput
            // 
            this.ExactResultOutput.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExactResultOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExactResultOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExactResultOutput.Location = new System.Drawing.Point(35, 233);
            this.ExactResultOutput.Margin = new System.Windows.Forms.Padding(4);
            this.ExactResultOutput.Name = "ExactResultOutput";
            this.ExactResultOutput.ReadOnly = true;
            this.ExactResultOutput.Size = new System.Drawing.Size(132, 27);
            this.ExactResultOutput.TabIndex = 1;
            // 
            // AbsoluteResultOutput
            // 
            this.AbsoluteResultOutput.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AbsoluteResultOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AbsoluteResultOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AbsoluteResultOutput.Location = new System.Drawing.Point(35, 312);
            this.AbsoluteResultOutput.Margin = new System.Windows.Forms.Padding(4);
            this.AbsoluteResultOutput.Name = "AbsoluteResultOutput";
            this.AbsoluteResultOutput.ReadOnly = true;
            this.AbsoluteResultOutput.Size = new System.Drawing.Size(132, 27);
            this.AbsoluteResultOutput.TabIndex = 2;
            // 
            // ApproxRsultOutputLabel
            // 
            this.ApproxRsultOutputLabel.AutoSize = true;
            this.ApproxRsultOutputLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApproxRsultOutputLabel.Location = new System.Drawing.Point(31, 210);
            this.ApproxRsultOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ApproxRsultOutputLabel.Name = "ApproxRsultOutputLabel";
            this.ApproxRsultOutputLabel.Size = new System.Drawing.Size(189, 19);
            this.ApproxRsultOutputLabel.TabIndex = 5;
            this.ApproxRsultOutputLabel.Text = "Точное значение функции";
            // 
            // ExactResultOutputLabel
            // 
            this.ExactResultOutputLabel.AutoSize = true;
            this.ExactResultOutputLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExactResultOutputLabel.Location = new System.Drawing.Point(31, 289);
            this.ExactResultOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExactResultOutputLabel.Name = "ExactResultOutputLabel";
            this.ExactResultOutputLabel.Size = new System.Drawing.Size(333, 19);
            this.ExactResultOutputLabel.TabIndex = 6;
            this.ExactResultOutputLabel.Text = "Абсолютная ошибка приближенного значения";
            // 
            // ShowAndSaveResultButton
            // 
            this.ShowAndSaveResultButton.BackColor = System.Drawing.Color.PaleGreen;
            this.ShowAndSaveResultButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowAndSaveResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAndSaveResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowAndSaveResultButton.Location = new System.Drawing.Point(572, 414);
            this.ShowAndSaveResultButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShowAndSaveResultButton.Name = "ShowAndSaveResultButton";
            this.ShowAndSaveResultButton.Size = new System.Drawing.Size(160, 61);
            this.ShowAndSaveResultButton.TabIndex = 3;
            this.ShowAndSaveResultButton.Text = "Посчитать и записать в файл";
            this.ShowAndSaveResultButton.UseVisualStyleBackColor = false;
            this.ShowAndSaveResultButton.Click += new System.EventHandler(this.ShowAndSaveResultButton_Click);
            // 
            // AbsoluteResultOutputLabel
            // 
            this.AbsoluteResultOutputLabel.AutoSize = true;
            this.AbsoluteResultOutputLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AbsoluteResultOutputLabel.Location = new System.Drawing.Point(31, 128);
            this.AbsoluteResultOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AbsoluteResultOutputLabel.Name = "AbsoluteResultOutputLabel";
            this.AbsoluteResultOutputLabel.Size = new System.Drawing.Size(243, 19);
            this.AbsoluteResultOutputLabel.TabIndex = 4;
            this.AbsoluteResultOutputLabel.Text = "Приближенное значение функции";
            // 
            // XValueInput
            // 
            this.XValueInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.XValueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XValueInput.Location = new System.Drawing.Point(124, 43);
            this.XValueInput.Margin = new System.Windows.Forms.Padding(4);
            this.XValueInput.Name = "XValueInput";
            this.XValueInput.Size = new System.Drawing.Size(132, 27);
            this.XValueInput.TabIndex = 7;
            this.XValueInput.TextChanged += new System.EventHandler(this.XValueInput_TextChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.PaleGreen;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(446, 414);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(104, 61);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EpsilonValueInput
            // 
            this.EpsilonValueInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EpsilonValueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EpsilonValueInput.Location = new System.Drawing.Point(516, 43);
            this.EpsilonValueInput.Margin = new System.Windows.Forms.Padding(4);
            this.EpsilonValueInput.Name = "EpsilonValueInput";
            this.EpsilonValueInput.Size = new System.Drawing.Size(132, 27);
            this.EpsilonValueInput.TabIndex = 9;
            this.EpsilonValueInput.TextChanged += new System.EventHandler(this.EpsilonValueInput_TextChanged);
            // 
            // XValueInputLabel
            // 
            this.XValueInputLabel.AutoSize = true;
            this.XValueInputLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XValueInputLabel.Location = new System.Drawing.Point(31, 46);
            this.XValueInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.XValueInputLabel.Name = "XValueInputLabel";
            this.XValueInputLabel.Size = new System.Drawing.Size(85, 19);
            this.XValueInputLabel.TabIndex = 10;
            this.XValueInputLabel.Text = "Введите x:";
            // 
            // EpsilonValueInputLabel
            // 
            this.EpsilonValueInputLabel.AutoSize = true;
            this.EpsilonValueInputLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EpsilonValueInputLabel.Location = new System.Drawing.Point(375, 46);
            this.EpsilonValueInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EpsilonValueInputLabel.Name = "EpsilonValueInputLabel";
            this.EpsilonValueInputLabel.Size = new System.Drawing.Size(133, 19);
            this.EpsilonValueInputLabel.TabIndex = 11;
            this.EpsilonValueInputLabel.Text = "Введите эпсилон:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 518);
            this.Controls.Add(this.EpsilonValueInputLabel);
            this.Controls.Add(this.XValueInputLabel);
            this.Controls.Add(this.EpsilonValueInput);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.XValueInput);
            this.Controls.Add(this.ExactResultOutputLabel);
            this.Controls.Add(this.ApproxRsultOutputLabel);
            this.Controls.Add(this.AbsoluteResultOutputLabel);
            this.Controls.Add(this.ShowAndSaveResultButton);
            this.Controls.Add(this.AbsoluteResultOutput);
            this.Controls.Add(this.ExactResultOutput);
            this.Controls.Add(this.ApproxResultOutput);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ApproxResultOutput;
        private System.Windows.Forms.TextBox ExactResultOutput;
        private System.Windows.Forms.TextBox AbsoluteResultOutput;
        private System.Windows.Forms.Label ApproxRsultOutputLabel;
        private System.Windows.Forms.Label ExactResultOutputLabel;
        private System.Windows.Forms.Button ShowAndSaveResultButton;
        private System.Windows.Forms.Label AbsoluteResultOutputLabel;
        private System.Windows.Forms.TextBox XValueInput;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox EpsilonValueInput;
        private System.Windows.Forms.Label XValueInputLabel;
        private System.Windows.Forms.Label EpsilonValueInputLabel;
    }
}
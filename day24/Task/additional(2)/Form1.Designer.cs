namespace additional_2_
{
    partial class Form1
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
            this.listBoxArr = new System.Windows.Forms.ListBox();
            this.listBoxArrResult = new System.Windows.Forms.ListBox();
            this.buttonArr = new System.Windows.Forms.Button();
            this.buttonArrResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxArr
            // 
            this.listBoxArr.FormattingEnabled = true;
            this.listBoxArr.ItemHeight = 16;
            this.listBoxArr.Items.AddRange(new object[] {
            " "});
            this.listBoxArr.Location = new System.Drawing.Point(12, 38);
            this.listBoxArr.Name = "listBoxArr";
            this.listBoxArr.Size = new System.Drawing.Size(246, 340);
            this.listBoxArr.TabIndex = 0;
            // 
            // listBoxArrResult
            // 
            this.listBoxArrResult.FormattingEnabled = true;
            this.listBoxArrResult.ItemHeight = 16;
            this.listBoxArrResult.Items.AddRange(new object[] {
            " "});
            this.listBoxArrResult.Location = new System.Drawing.Point(324, 38);
            this.listBoxArrResult.Name = "listBoxArrResult";
            this.listBoxArrResult.Size = new System.Drawing.Size(252, 340);
            this.listBoxArrResult.TabIndex = 1;
            // 
            // buttonArr
            // 
            this.buttonArr.Location = new System.Drawing.Point(12, 394);
            this.buttonArr.Name = "buttonArr";
            this.buttonArr.Size = new System.Drawing.Size(245, 23);
            this.buttonArr.TabIndex = 2;
            this.buttonArr.Text = "Заполнить";
            this.buttonArr.UseVisualStyleBackColor = true;
            this.buttonArr.Click += new System.EventHandler(this.buttonArr_Click);
            // 
            // buttonArrResult
            // 
            this.buttonArrResult.Location = new System.Drawing.Point(324, 394);
            this.buttonArrResult.Name = "buttonArrResult";
            this.buttonArrResult.Size = new System.Drawing.Size(252, 23);
            this.buttonArrResult.TabIndex = 3;
            this.buttonArrResult.Text = "Заменить";
            this.buttonArrResult.UseVisualStyleBackColor = true;
            this.buttonArrResult.Click += new System.EventHandler(this.buttonArrResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Исходный массив";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 440);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonArrResult);
            this.Controls.Add(this.buttonArr);
            this.Controls.Add(this.listBoxArrResult);
            this.Controls.Add(this.listBoxArr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxArr;
        private System.Windows.Forms.ListBox listBoxArrResult;
        private System.Windows.Forms.Button buttonArr;
        private System.Windows.Forms.Button buttonArrResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


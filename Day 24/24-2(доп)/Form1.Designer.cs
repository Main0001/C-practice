namespace _24_2_доп_
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonArrResult = new System.Windows.Forms.Button();
            this.buttonArr = new System.Windows.Forms.Button();
            this.listBoxArrResult = new System.Windows.Forms.ListBox();
            this.listBoxArr = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Результат";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Исходный массив";
            // 
            // buttonArrResult
            // 
            this.buttonArrResult.Location = new System.Drawing.Point(422, 368);
            this.buttonArrResult.Margin = new System.Windows.Forms.Padding(2);
            this.buttonArrResult.Name = "buttonArrResult";
            this.buttonArrResult.Size = new System.Drawing.Size(189, 19);
            this.buttonArrResult.TabIndex = 9;
            this.buttonArrResult.Text = "Заменить";
            this.buttonArrResult.UseVisualStyleBackColor = true;
            this.buttonArrResult.Click += new System.EventHandler(this.buttonArrResult_Click);
            // 
            // buttonArr
            // 
            this.buttonArr.Location = new System.Drawing.Point(188, 368);
            this.buttonArr.Margin = new System.Windows.Forms.Padding(2);
            this.buttonArr.Name = "buttonArr";
            this.buttonArr.Size = new System.Drawing.Size(184, 19);
            this.buttonArr.TabIndex = 8;
            this.buttonArr.Text = "Заполнить";
            this.buttonArr.UseVisualStyleBackColor = true;
            this.buttonArr.Click += new System.EventHandler(this.buttonArr_Click);
            // 
            // listBoxArrResult
            // 
            this.listBoxArrResult.FormattingEnabled = true;
            this.listBoxArrResult.Items.AddRange(new object[] {
            " "});
            this.listBoxArrResult.Location = new System.Drawing.Point(422, 79);
            this.listBoxArrResult.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxArrResult.Name = "listBoxArrResult";
            this.listBoxArrResult.Size = new System.Drawing.Size(190, 277);
            this.listBoxArrResult.TabIndex = 7;
            // 
            // listBoxArr
            // 
            this.listBoxArr.FormattingEnabled = true;
            this.listBoxArr.Items.AddRange(new object[] {
            " "});
            this.listBoxArr.Location = new System.Drawing.Point(188, 79);
            this.listBoxArr.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxArr.Name = "listBoxArr";
            this.listBoxArr.Size = new System.Drawing.Size(186, 277);
            this.listBoxArr.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonArrResult;
        private System.Windows.Forms.Button buttonArr;
        private System.Windows.Forms.ListBox listBoxArrResult;
        private System.Windows.Forms.ListBox listBoxArr;
    }
}



namespace z10
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
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.listBoxArrResult = new System.Windows.Forms.ListBox();
            this.listBoxArr = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Minimal odd element: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Original array:";
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(222, 310);
            this.Button2.Margin = new System.Windows.Forms.Padding(2);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(189, 27);
            this.Button2.TabIndex = 9;
            this.Button2.Text = "Find minimal odd element";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(11, 310);
            this.Button1.Margin = new System.Windows.Forms.Padding(2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(184, 27);
            this.Button1.TabIndex = 8;
            this.Button1.Text = "Fill array";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listBoxArrResult
            // 
            this.listBoxArrResult.FormattingEnabled = true;
            this.listBoxArrResult.Items.AddRange(new object[] {
            " "});
            this.listBoxArrResult.Location = new System.Drawing.Point(222, 21);
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
            this.listBoxArr.Location = new System.Drawing.Point(11, 21);
            this.listBoxArr.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxArr.Name = "listBoxArr";
            this.listBoxArr.Size = new System.Drawing.Size(186, 277);
            this.listBoxArr.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 348);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
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
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.ListBox listBoxArrResult;
        private System.Windows.Forms.ListBox listBoxArr;
    }
}


namespace _30_1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.AddButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.TouristNameTextBox = new System.Windows.Forms.TextBox();
            this.TouristSurnameTextBox = new System.Windows.Forms.TextBox();
            this.TouristPatronymicTextBox = new System.Windows.Forms.TextBox();
            this.TouristNameLabel = new System.Windows.Forms.Label();
            this.TouristSurnameLabel = new System.Windows.Forms.Label();
            this.TouristPatronymicLabel = new System.Windows.Forms.Label();
            this.dBTur_firmDataSet = new _30_1.DBTur_firmDataSet();
            this.туристыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.туристыTableAdapter = new _30_1.DBTur_firmDataSetTableAdapters.ТуристыTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодтуристаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TouristDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dBTur_firmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.туристыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TouristDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(755, 142);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(107, 35);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshButton.Location = new System.Drawing.Point(12, 294);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(469, 36);
            this.RefreshButton.TabIndex = 3;
            this.RefreshButton.Text = "Обновить";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // TouristNameTextBox
            // 
            this.TouristNameTextBox.Location = new System.Drawing.Point(603, 98);
            this.TouristNameTextBox.Name = "TouristNameTextBox";
            this.TouristNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.TouristNameTextBox.TabIndex = 4;
            // 
            // TouristSurnameTextBox
            // 
            this.TouristSurnameTextBox.Location = new System.Drawing.Point(754, 98);
            this.TouristSurnameTextBox.Name = "TouristSurnameTextBox";
            this.TouristSurnameTextBox.Size = new System.Drawing.Size(100, 22);
            this.TouristSurnameTextBox.TabIndex = 5;
            // 
            // TouristPatronymicTextBox
            // 
            this.TouristPatronymicTextBox.Location = new System.Drawing.Point(901, 98);
            this.TouristPatronymicTextBox.Name = "TouristPatronymicTextBox";
            this.TouristPatronymicTextBox.Size = new System.Drawing.Size(100, 22);
            this.TouristPatronymicTextBox.TabIndex = 6;
            // 
            // TouristNameLabel
            // 
            this.TouristNameLabel.AutoSize = true;
            this.TouristNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TouristNameLabel.Location = new System.Drawing.Point(599, 75);
            this.TouristNameLabel.Name = "TouristNameLabel";
            this.TouristNameLabel.Size = new System.Drawing.Size(42, 20);
            this.TouristNameLabel.TabIndex = 7;
            this.TouristNameLabel.Text = "Имя";
            // 
            // TouristSurnameLabel
            // 
            this.TouristSurnameLabel.AutoSize = true;
            this.TouristSurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TouristSurnameLabel.Location = new System.Drawing.Point(751, 75);
            this.TouristSurnameLabel.Name = "TouristSurnameLabel";
            this.TouristSurnameLabel.Size = new System.Drawing.Size(87, 20);
            this.TouristSurnameLabel.TabIndex = 8;
            this.TouristSurnameLabel.Text = "Фамилия";
            // 
            // TouristPatronymicLabel
            // 
            this.TouristPatronymicLabel.AutoSize = true;
            this.TouristPatronymicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TouristPatronymicLabel.Location = new System.Drawing.Point(897, 75);
            this.TouristPatronymicLabel.Name = "TouristPatronymicLabel";
            this.TouristPatronymicLabel.Size = new System.Drawing.Size(91, 20);
            this.TouristPatronymicLabel.TabIndex = 9;
            this.TouristPatronymicLabel.Text = "Отчество";
            // 
            // dBTur_firmDataSet
            // 
            this.dBTur_firmDataSet.DataSetName = "DBTur_firmDataSet";
            this.dBTur_firmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // туристыBindingSource
            // 
            this.туристыBindingSource.DataMember = "Туристы";
            this.туристыBindingSource.DataSource = this.dBTur_firmDataSet;
            // 
            // туристыTableAdapter
            // 
            this.туристыTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(566, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 179);
            this.panel1.TabIndex = 10;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.Width = 125;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодтуристаDataGridViewTextBoxColumn
            // 
            this.кодтуристаDataGridViewTextBoxColumn.DataPropertyName = "Код_туриста";
            this.кодтуристаDataGridViewTextBoxColumn.HeaderText = "Код_туриста";
            this.кодтуристаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодтуристаDataGridViewTextBoxColumn.Name = "кодтуристаDataGridViewTextBoxColumn";
            this.кодтуристаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодтуристаDataGridViewTextBoxColumn.Width = 125;
            // 
            // TouristDataGridView
            // 
            this.TouristDataGridView.AutoGenerateColumns = false;
            this.TouristDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TouristDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодтуристаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn});
            this.TouristDataGridView.DataSource = this.туристыBindingSource;
            this.TouristDataGridView.Location = new System.Drawing.Point(12, 12);
            this.TouristDataGridView.Name = "TouristDataGridView";
            this.TouristDataGridView.RowHeadersWidth = 51;
            this.TouristDataGridView.RowTemplate.Height = 24;
            this.TouristDataGridView.Size = new System.Drawing.Size(469, 275);
            this.TouristDataGridView.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.DeleteButton.Location = new System.Drawing.Point(12, 350);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(469, 33);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TouristPatronymicLabel);
            this.Controls.Add(this.TouristSurnameLabel);
            this.Controls.Add(this.TouristNameLabel);
            this.Controls.Add(this.TouristPatronymicTextBox);
            this.Controls.Add(this.TouristSurnameTextBox);
            this.Controls.Add(this.TouristNameTextBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TouristDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "6";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBTur_firmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.туристыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TouristDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TextBox TouristNameTextBox;
        private System.Windows.Forms.TextBox TouristSurnameTextBox;
        private System.Windows.Forms.TextBox TouristPatronymicTextBox;
        private System.Windows.Forms.Label TouristNameLabel;
        private System.Windows.Forms.Label TouristSurnameLabel;
        private System.Windows.Forms.Label TouristPatronymicLabel;
        private DBTur_firmDataSet dBTur_firmDataSet;
        private System.Windows.Forms.BindingSource туристыBindingSource;
        private DBTur_firmDataSetTableAdapters.ТуристыTableAdapter туристыTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодтуристаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView TouristDataGridView;
        private System.Windows.Forms.Button DeleteButton;
    }
}
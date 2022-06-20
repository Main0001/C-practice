using _30_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_1
{
    public partial class Form1 : Form
    {
        static private string _dbPath = @"D:\Практика по C#\Day34\Task\Data\DBTur_firm.mdf";
        static private string _connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={_dbPath};";
        private DataContext _dB = new DataContext(_connectionString);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBTur_firmDataSet.Туристы". При необходимости она может быть перемещена или удалена.
            this.туристыTableAdapter.Fill(this.dBTur_firmDataSet.Туристы);
        }

        private void Delete()
        {
            try
            {
                var currentCeil = TouristDataGridView.SelectedCells;
                int touristId = (int)TouristDataGridView[0, currentCeil[0].RowIndex].Value;
                var deleteTourists = from tourists in _dB.GetTable<Turist>()
                                     where tourists.Id == touristId
                                     select tourists;

                MessageBox.Show("Запись успешно удалена", "Успех");

                foreach (var tourist in deleteTourists)
                {
                    _dB.GetTable<Turist>().DeleteOnSubmit(tourist);
                }

                _dB.SubmitChanges();
            }
            catch
            {
                MessageBox.Show("Операция удаления не была завершена", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((TouristSurnameTextBox.Text == string.Empty) && (TouristNameTextBox.Text == string.Empty) &&
                    (TouristPatronymicTextBox.Text == string.Empty))
                {
                    MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Turist tourist = new Turist
                {
                    Surname = TouristSurnameTextBox.Text,
                    Name = TouristNameTextBox.Text,
                    Patronymic = TouristPatronymicTextBox.Text
                };

                _dB.GetTable<Turist>().InsertOnSubmit(tourist);
                _dB.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            var values = from tourists in _dB.GetTable<Turist>()
                         select tourists;

            var grid = new DataGrid()
            {
                DataSource = values,
                Width = 400,
                Height = 200,
            };

            panel1.Controls.Add(grid);
        }
    }
}
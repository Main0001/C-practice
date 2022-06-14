using System.Windows;
using System.Xml;

namespace z1
{
    /// <summary>
    /// Логика взаимодействия для xmlAddWindows.xaml
    /// </summary>
    public partial class xmlAddWindows : Window
    {
        public string path = "";
        static XmlDocument xDoc;
        static XmlElement xRoot;

        public xmlAddWindows()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var bookName = BookNameBox.Text;
            var authorName = AuthorNameBox.Text;
            var publishYear = YearBox.Text;


            if (bookName != string.Empty && authorName != string.Empty && publishYear != string.Empty)
            {
                XmlElement userElem = xDoc.CreateElement($"book");

                // создаем атрибут name
                XmlAttribute nameAttr = xDoc.CreateAttribute($"name");


                XmlElement companyElem = xDoc.CreateElement($"author");
                XmlElement ageElem = xDoc.CreateElement("publishingYear");



                // создаем текстовые значения для элементов и атрибута
                XmlText nameText = xDoc.CreateTextNode($"{bookName}");
                XmlText authorText = xDoc.CreateTextNode($"{authorName}");
                XmlText ageText = xDoc.CreateTextNode($"{publishYear}");

                //добавляем узлы
                nameAttr.AppendChild(nameText);
                companyElem.AppendChild(authorText);
                ageElem.AppendChild(ageText);
                userElem.Attributes.Append(nameAttr);
                userElem.AppendChild(companyElem);
                userElem.AppendChild(ageElem);
                xRoot.AppendChild(userElem);
                xDoc.Save(path);

                MessageBox.Show("Запись успено добавлена!");
            }
            else MessageBox.Show("Заполните поля!");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                xDoc = new XmlDocument();
                xDoc.Load(path);
                xRoot = xDoc.DocumentElement;
            }
            catch (System.Exception)
            {
                this.Close();
                MessageBox.Show("Неверный путь к файлу!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

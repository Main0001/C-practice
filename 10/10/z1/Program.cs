using System;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            NoteBook note = new NoteBook("MyNotebook", 10);
            Сommonplacebook general = new Сommonplacebook("MyCPbook", 10, "Leather");
            Console.WriteLine(note.Price());
            Console.WriteLine(general.Price());
        }
    }

    class NoteBook
    {
        private string _name;
        private int _k;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int K
        {
            get { return _k; }
            set { _k = value; }
        }

        public double Price()
        {
            return 15 * _k;
        }

        public NoteBook(string nameData, int kData)
        {
            _name = nameData;
            _k = kData;
        }
    }

    class Сommonplacebook : NoteBook
    {
        private string _material;
        public string Material
        {
            get { return _material; }
            set { _material = value; }
        }
        public Сommonplacebook(string nameData, int kData, string material)
        : base(nameData, kData)
        {
            Material = material;
        }
        public double Price()
        {
            return 15 * K + 50;
        }
    }
}

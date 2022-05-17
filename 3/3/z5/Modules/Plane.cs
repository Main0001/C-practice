using System;

namespace z5.Modules
{
    internal class Plane
    {
        private string _Destination;
        private int _Number;
        private DateTime _Time;
        public Plane(string destitnation, int number, DateTime time)
        {
            _Destination = destitnation;
            _Number = number;
            _Time = time;
        }

        public string destination { get { return _Destination; } set { _Destination = value; } }
        public int number { get { return _Number; } set { _Number = value; } }
        public DateTime time { get { return _Time; } set { _Time = value; } }
    }
}

namespace ScheduleLib
{
    public class Schedule
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private string _name;
        private string _description;
        public Schedule(DateTime startTime, DateTime endTime, string name, string description)
        {
            _startTime = startTime;
            _endTime = endTime;
            _name = name;
            _description = description;
        }

        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        public DateTime EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        public string Name { get { return Name; } set { Name = value; } }

        public string Description { get { return Description; } set { Description = value; } }

        public string Info()
        {
            return $"Start time - {_startTime}, end time - {_endTime}, name - {_name}, description - {_description}";
        }
    }
}
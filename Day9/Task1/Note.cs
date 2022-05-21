using System;

namespace Note
{
    public struct NOTE
    {
        public string Name;
        public string PhoneNumber;
        public int[] BirthdayDate;

        public NOTE(string name, string phoneNumber, int[] birthdayDate)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.BirthdayDate = birthdayDate;
        }

        public void Print()
        {
            if (BirthdayDate[1] < 10)
                Console.WriteLine($"Имя: {Name}, Номер телефона: {PhoneNumber}, День рождения: {BirthdayDate[0]}.0{BirthdayDate[1]}.{BirthdayDate[2]}");
            else
                Console.WriteLine($"Имя: {Name}, Номер телефона: {PhoneNumber}, День рождения: {BirthdayDate[0]}.{BirthdayDate[1]}.{BirthdayDate[2]}");
        }
    }
}

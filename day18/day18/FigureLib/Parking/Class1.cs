namespace Parking
{
    public class ParkingAuto
    {
        public string nameOfAuto;
        public decimal priceOfAuto;
        public string typeOfAuto;

        public ParkingAuto(string nameOfAuto, decimal priceOfAuto, string typeOfAuto)
        {
            this.nameOfAuto = nameOfAuto;
            this.priceOfAuto = priceOfAuto;
            this.typeOfAuto = typeOfAuto;  
        }

        public string BuyAuto(decimal priceOfAuto)
        {
            if (priceOfAuto < this.priceOfAuto)
            {
                return "Недостаточно средств";
            }
            else
            {
                return $"Вы купили машину {nameOfAuto}";
            }
        }
        public string ShowInfo()
        {
            return $"Модель - {nameOfAuto}; Цена - {priceOfAuto}; Тип авто - {typeOfAuto};";
        }

    }
}
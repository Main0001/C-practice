namespace Appliances
{
    public class Appliance
    {
        string name;
        decimal price;

        public Appliance(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public string Info()
        {
            string inf = $"Название: {name}, стоимость: {price}";
            return inf;
        }
    }
}
using Appliances;

Console.WriteLine("Введите характеристики техники: ");

try
{
    Console.Write("Введите название: ");
    string name = Console.ReadLine();

    Console.Write("Введите стоимость: ");
    decimal price = Convert.ToDecimal(Console.ReadLine());

    Appliance app = new Appliance(name, price);

    Console.WriteLine(app.Info());
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
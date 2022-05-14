class Goods
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Status { get; set; }
    public string Owner { get; set; }

    public void GetStatus() { }
    public void Buy() { }
}

class Toy : Goods
{
    public string Type { get; set; }
    public string Material { get; set; }
    public void PlayWithToy() { }
}

class Product : Goods
{
    public string Period { get; set; }
    public string TypeOfProduct { get; set; }

    public void GetTypeOfProduct() { }

}

class MilkProduct : Product
{
    public string TypeOfMilkProduct { get; set; }
    public void GetTypeOfMilkProduct() { }

}
namespace Animals
{
    public class Animal
    {
        string variety;
        string food;
        int weight;
        string color;

        public Animal(string variety, string food, int weight, string color)
        {
            this.variety = variety;
            this.food = food;
            this.weight = weight;
            this.color = color;
        }

        public string AnimalInfo()
        {
            string animalInf = $"Animal variety: {variety}\nthis animal eats: {food}\nweight is {weight}\nwool color: {color}";
            return animalInf;
        }
    }
}
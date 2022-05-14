namespace z2
{
    class Ship
    {
        public string name;
        public string material;
        public string type;
        public void Move() { }
    }

    class Steamer : Ship
    {
        public string typeOfSteamEngine;
        public void RunSteamEngine() { }
    }

    class Sailboat : Ship
    {
        public string typeOfSail;
        public void SpreadTheSail() { }
    }

    class Corvette : Ship
    {
        public int amountOfGuns;
        public void Fire() { }
    }
}

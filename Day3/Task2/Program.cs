class Engine
{
    public int weight;
    public int enginePower;
    public int fuelFlow;

    public void Start()
    {

    }

    public void Stop()
    {

    }
}

class ICE : Engine
{
    public string combustionChamber;
    public string fuelMixture;

    public void PutOil()
    {

    }

    public void FuelInjection()
    {

    }
}

class Diesel : ICE
{
    public string typeOfPiston;

    public void TurningTheCrankshaft()
    {

    }

    public void AirIntake()
    {

    }
}

class JetEngine : ICE
{
    public string typeOfNozzle;
    public string typeOfJetEngine;
    public int engineThrust;

    public void CreateJetThrust()
    {

    }
}
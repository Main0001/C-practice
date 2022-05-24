public class Organization
{
    public string Name;
    public Organization(string name)
    {
        this.Name = name;
    }
}
public class OilCompany : Organization
{
    public int VolumeProduction;
    public OilCompany(string name, int ListClients, int VolumeProduction)
        : base(name)
    {
        this.VolumeProduction = VolumeProduction;
    }
}
public class Plant : Organization
{
    public int NumberWorker;
    public Plant(string name, int ListClients, int VolumeProduction, int NumberWorker)
        : base(name)
    {
        this.NumberWorker = NumberWorker;
    }
}

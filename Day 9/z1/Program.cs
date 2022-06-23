AEROFLOT[] flights = new AEROFLOT[7];
if (flights == null) throw new ArgumentNullException(nameof(flights));
for (int i = 0; i < flights.Length; i++)
{
    Console.WriteLine("Enter data {0}-th flight:", i + 1);
    Console.Write("Station name:");
    flights[i].destination = Console.ReadLine();
    Console.Write("Flight number:");
    flights[i].number = Convert.ToInt32(Console.ReadLine());
    Console.Write("Type of airplane:");
    flights[i].typeOfAircraft = Console.ReadLine();
}
flights = flights.OrderBy(x => x.destination).ToArray();
string tp = "";
bool had = false;
do
{
    Console.WriteLine("\nEnter type of plane, flights, search data");
    tp = Console.ReadLine();
    Console.WriteLine("\nFlights data, airplane: {0}", tp);

    for (int i = 0; i < flights.Length; i++)
    {
        if (tp == flights[i].typeOfAircraft)
        {
            Console.WriteLine("Station end: {0}", flights[i].destination);
            Console.WriteLine("Flight number: {0}", flights[i].number);
            had = true;
        }
    }
    if (!had)
    {
        Console.WriteLine("None for: {0}", tp);
    }
    had = false;
    Console.WriteLine("\nWanna continue? (y/n)");
}
while (Console.ReadLine() != "n");
public struct AEROFLOT
{
    public string destination;
    public int number;
    public string typeOfAircraft;
}

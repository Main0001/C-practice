using System;
using System.Collections.Generic;

Dictionary<string, Dictionary<string, string>> DiscCatalog = new Dictionary<string, Dictionary<string, string>>();
string choice = " ";
while (choice != "Exit")
{
    try
    {
        Console.Write("1 - Create Disc\n2 - Delete Disc\n3 - Add record\n4 - Delete record\n5 - Show catalog\n6 - Show specific disc\n'Exit' - close program\n");
        choice = Console.ReadLine();
        if (choice == "1")
        {
            Dictionary<string, string> KeyDict = new Dictionary<string, string>();
            Console.Write("Enter disc key: ");
            string DiscKey = Console.ReadLine();
            DiscCatalog.Add(DiscKey, KeyDict);
            Console.WriteLine("Disc created!\n");
        }
        else if (choice == "2")
        {
            Console.Write("Delete disc(Enter key to delete): ");
            string DeleteKey = Console.ReadLine();
            DiscCatalog.Remove(DeleteKey);
            Console.WriteLine("Disk deleted!\n");
        }
        else if (choice == "3")
        {
            Console.Write("Add record on disc (Enter disc key): ");
            string DiscKey = Console.ReadLine();
            var record = AddRecord(DiscKey);
        }
        else if (choice == "4")
        {
            Console.Write("Remove record from disc (Enter disc key): ");
            string DiscKey = Console.ReadLine();
            var record = DeleteRecord(DiscKey);
        }
        else if (choice == "5")
        {
            foreach (var catalog in DiscCatalog)
            {
                Console.WriteLine(catalog.Key);
                foreach (var catalogS in DiscCatalog[catalog.Key])
                {
                    Console.Write($"Key: {catalogS.Key} ");
                    Console.WriteLine($"Name: {catalogS.Value}" + "\n");
                }
            }
        }
        else if (choice == "6")
        {
            Console.Write("Show disc(enter disc key): ");
            string DiscKey = Console.ReadLine();
            DiskShow(DiscKey);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Ann error occured - {e.Message}");
    }
}

Dictionary<string, string> AddRecord(string keyOfDisk)
{
    var Record = DiscCatalog[keyOfDisk];
    Console.Write("Record key: ");
    string RecordKey = Console.ReadLine();
    Console.Write("Record name: ");
    string RecordName = Console.ReadLine();
    Record.Add(RecordKey, RecordName);
    Console.WriteLine("Record added!\n");
    return Record;
}
Dictionary<string, string> DeleteRecord(string keyOfDisk)
{
    var Record = DiscCatalog[keyOfDisk];
    Console.Write("Record key: ");
    string RecordKey = Console.ReadLine();
    Record.Remove(RecordKey);
    Console.WriteLine("Record deleted!\n");
    return Record;
}
void DiskShow(string keyOfDisk)
{
    var Dshow = DiscCatalog[keyOfDisk];
    foreach (var rec in Dshow)
    {
        Console.WriteLine($"Key: {rec.Key}");
        Console.WriteLine($"Record name: {rec.Value} \n");
    }
}
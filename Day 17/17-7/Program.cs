using IWshRuntimeLibrary;
using System.Linq;
using File = System.IO.File;

DirectoryInfo di = new DirectoryInfo(@"D:\");
Console.WriteLine("No search pattern returns:");
foreach (var fi in di.GetFiles())
{
    Console.WriteLine(fi.Name);
}

Console.WriteLine();

string path = @"D:\Example_30tp";


try
{
    // Determine whether the directory exists.
    if (Directory.Exists(path))
    {
        Console.WriteLine("That path exists already.");
        var _pathFile = Path.Combine(path, "file1.txt");
        File.Copy(Path.Combine(@"D:\work\Практика\Praktik\Day 17\17-7\bin\Debug\net6.0", "file1.txt"), _pathFile, true);
        var _pathFile2 = Path.Combine(path, "file2.txt");
        File.Copy("file2.txt", _pathFile2, true);
        var _pathFile3 = Path.Combine(path, "file3.txt");
        File.Copy("file3.txt", _pathFile3, true);
        var _file = new FileInfo(_pathFile);
        var _file2 = new FileInfo(_pathFile2);
        var _file3 = new FileInfo(_pathFile3);

        _file.Attributes = FileAttributes.Hidden;
        CreateShortcut("file1", path, _pathFile);
        _file2.Attributes = FileAttributes.Hidden;
        CreateShortcut("file2", path, _pathFile2);
        _file3.Attributes = FileAttributes.Hidden;
        CreateShortcut("file3", path, _pathFile3);
        return;
    }

    // Try to create the directory.
    DirectoryInfo di1 = Directory.CreateDirectory(path);
    Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

    // Delete the directory.
    //di.Delete();
    //Console.WriteLine("The directory was deleted successfully.");



    var pathFile = Path.Combine(path, "file1.txt");
    File.Copy("file1.txt", pathFile, true);
    var pathFile2 = Path.Combine(path, "file2.txt");
    File.Copy("file2.txt", pathFile2, true);
    var pathFile3 = Path.Combine(path, "file3.txt");
    File.Copy("file3.txt", pathFile3, true);
    var file = new FileInfo(pathFile);
    var file2 = new FileInfo(pathFile2);
    var file3 = new FileInfo(pathFile3);

    file.Attributes = FileAttributes.Hidden;
    CreateShortcut("file1", path, pathFile);
    file2.Attributes = FileAttributes.Hidden;
    CreateShortcut("file2", path, pathFile2);
    file3.Attributes = FileAttributes.Hidden;
    CreateShortcut("file3", path, pathFile3);
}
catch (Exception e)
{
    Console.WriteLine("The process failed: {0}", e.ToString());
}
finally { }


static void CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation)
{
    string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");
    WshShell shell = new WshShell();
    IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

    shortcut.Description = "My shortcut description";   // The description of the shortcut
    shortcut.IconLocation = @"c:\myicon.ico";           // The icon of the shortcut
    shortcut.TargetPath = targetFileLocation;                 // The path of the file that will launch when the shortcut is run
    shortcut.Save();                                    // Save the shortcut
}
using System.IO;

DriveInfo[] D = DriveInfo.GetDrives();
foreach (DriveInfo DI in D)
{
    if (DI.DriveType == DriveType.Removable)
    {

        Console.WriteLine("Enter file name: ");
        var fileName = Console.ReadLine();
        //получаем переменную Windows с адресом текущего пользователя
        string PatchProfile = DI.Name+@"\";
        //ищем все вложенные папки 
        string[] S = SearchDirectory(PatchProfile);
        //создаем строку в которой соберем все пути
        string ListPatch = "найденные файлы \n"; //заголовок для строк
        foreach (string folderPatch in S)
        {
            //добавляем новую строку в список
            // ListPatch += folderPatch + "\n";
            try
            {
                //пытаемся найти данные в папке 
                string[] F = SearchFile(folderPatch, fileName);
                foreach (string FF in F)
                {
                    try
                    {
                        Console.WriteLine($"-----{FF}------");
                        string line;
                        //Pass the file path and file name to the StreamReader constructor
                        StreamReader sr = new StreamReader(FF);
                        //Read the first line of text
                        line = sr.ReadLine();
                        //Continue to read until you reach end of file
                        while (line != null)
                        {
                            //write the line to console window
                            Console.WriteLine(line);
                            //Read the next line
                            line = sr.ReadLine();
                        }
                        //close the file
                        sr.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    //добавляем файл в список 
                    ListPatch += FF + "\n";
                }
            }
            catch
            {
            }
        }
        //выводим список на экран 
        Console.WriteLine(ListPatch);

    }
}

static string[] SearchFile(string patch, string pattern)
{
    /*флаг SearchOption.AllDirectories означает искать во всех вложенных папках*/
    string[] ReultSearch = Directory.GetFiles(patch, pattern, SearchOption.AllDirectories);
    //возвращаем список найденных файлов соответствующих условию поиска 
    return ReultSearch;
}

static string[] SearchDirectory(string patch)
{
    //находим все папки в по указанному пути
    string[] ReultSearch = Directory.GetDirectories(patch);
    //возвращаем список директорий
    return ReultSearch;
}
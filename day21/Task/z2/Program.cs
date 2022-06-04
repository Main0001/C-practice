try
{
    Task[] tasks = new Task[2];
    var x = 2;

    for (int i = 0; i < tasks.Length; i++)
    {
        if (i == 0)
        {
            tasks[i] = Task.Factory.StartNew(() =>
            {
                double result = (Math.Sin((Math.PI / 2) + 3 * x)) / (1 - Math.Sin(3 * x - Math.PI));
                Thread.Sleep(2000);
                Console.WriteLine(result);
            });
            tasks[i].Wait();
        }
        else
        {
            tasks[i] = Task.Factory.StartNew(() =>
            {
                double result = 1 / Math.Tan(((5 / 4) * Math.PI) + ((3 / 2) * x));
                Thread.Sleep(2500);
                Console.WriteLine(result);
            });
            tasks[i].Wait();
        }

    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
double a = double.Parse(Console.ReadLine());
double bettiNumber = double.Parse(Console.ReadLine());


double z1 = (Math.Sin(a) + Math.Cos(2 * bettiNumber - a)) / (Math.Cos(a) - Math.Sin(2 * bettiNumber - a));
double z2 = (1 + Math.Sin(2 * bettiNumber)) / Math.Cos(2 * bettiNumber);

class Temp
{
    static void Main(string[] args)
    {
        /// <summary>
        /// Formula value calculation method
        /// </summary>
        /// <param name="n">x power value</param>
        /// <param name="x">new x value</param>
        /// <returns>
        /// Returns the value of the calculated formula
        /// </returns>
        static double Formula(int n, double x)
        {
            return Math.Pow(x, n) / n;
        }

        Console.WriteLine(Formula(2, 4) + Formula(4, 4) + Formula(6, 4));
    }
}

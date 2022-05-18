class Program
{
    public static object BinarySearchDisplay(int[] arr, int key)
    {
        int minNum = 0;
        int maxNum = arr.Length - 1;

        while (minNum <= maxNum)
        {
            int mid = (minNum + maxNum) / 2;
            if (key == arr[mid])
            {
                return ++mid;
            }
            else if (key < arr[mid])
            {
                maxNum = mid - 1;
            }
            else
            {
                minNum = mid + 1;
            }
        }
        return "None";
    }

    static void Main(String[] args)
    {
        int firstNum = 0, secondNum = 99;
        int[] array = new int[100];
        for (firstNum = 1; firstNum < secondNum; firstNum++)
        {
            array[firstNum] = firstNum;
            Console.WriteLine(array[firstNum]);
        }
        
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine(BinarySearchDisplay(array, k));
    }
}
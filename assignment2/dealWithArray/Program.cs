
namespace dwArr;

internal class Dwarr
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please input the length of array");
        int l = Int32.Parse(Console.ReadLine());
        int[] a = new int [l];
        for (int i = 0; i < l; i++)
        {
            Console.WriteLine("Please input num" + i);
            int num = Int32.Parse(Console.ReadLine());
            a[i] = num;
        }
        Console.WriteLine("The max value of a is " + a.Max());
        Console.WriteLine("The min value of a is " + a.Min());
        Console.WriteLine("The sum of a is " + a.Sum());
        Console.WriteLine("The average of a is " + a.Average());
    }
}
        

